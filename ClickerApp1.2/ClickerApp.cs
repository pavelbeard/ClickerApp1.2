using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Media;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventManager;

namespace EventManager
{
    public partial class ClickerApp : Form
    {
        private string _buffer;

        private int _pointId;

        private int _delay;

        private int _amountOfLines;

        private string _pathFrom;

        //private string _pathIn;

        private List<string> MethodsList;

        private Thread threadPos;


        /// <summary>
        /// 
        /// </summary>
        public ClickerApp()
        {
            InitializeComponent();

            //keys = new KeysEvents.KeyEvents();

            _pointId = 0;
            _delay = 2;
            _amountOfLines = 0;
            _pathFrom = null;
            //_pathIn = null;

            MethodsList = new List<string>
            {
                "MouseClick",
                "MouseDoubleClick",
                "MouseRightClick",
                "InsertText",
                "InsertJobs",
                "ShiftTab",
                "Return"
            };

            threadPos = new Thread(() =>
            {
                while (true)
                {
                    MousePosition.Text = $"X = {Control.MousePosition.X}, Y = {Control.MousePosition.Y}";
                    Thread.Sleep(5);
                }
            });
            threadPos.Start();

            StartButton.Enabled = ClicksTable.Rows.Count > 0;
            ResetButton.Enabled = ClicksTable.Rows.Count > 0;
            DeleteButton.Enabled = ClicksTable.Rows.Count > 0;

            EditJobsButton.Enabled = false;
            EditEmployeesButton.Enabled = false;
            TestButton.Enabled = false;
            CancelButton.Enabled = false;

            #if DEBUG
            TestButton.Enabled = true;
            #endif

            DelayBox.Text = 2.ToString();
        }

        #region Events
        private void ClicksTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (ClicksTable.RowCount > 0 && StartButton.Enabled == false) StartButton.Enabled = true;
            if (ClicksTable.RowCount > 0 && ResetButton.Enabled == false) ResetButton.Enabled = true;
        }
        private void ClicksTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (ClicksTable.RowCount < 0 && StartButton.Enabled) StartButton.Enabled = false;
            if (ClicksTable.RowCount < 0 && ResetButton.Enabled) ResetButton.Enabled = false;
        }
        private void ClicksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex < ClicksTable.RowCount) DeleteButton.Enabled = true;
            else DeleteButton.Enabled = false;

        }
        private void ClicksTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (ClicksTable.CurrentCell.ColumnIndex != 5) _buffer = ClicksTable.CurrentCell.Value.ToString();
        }
        private void ClicksTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void ClickerApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            threadPos.Abort();
            //threadLines.Abort();
        }
        #endregion

        #region Menu
        private void openNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void tooltipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = string.Format($"Key<Q>\t\t=>\tOne click\n\r" +
                                           $"Key<W>\t\t=>\tRight click\n\r" +
                                           $"Key<E>\t\t=>\tDouble click\n\r" +
                                           $"Key<R>\t\t=>\tInsert text\n\r" +
                                           $"Key<Z>\t\t=>\tInsert ext. text\n\r" +
                                           $"Key<T>\t\t=>\tEmulate 'Shift+Tab'\n\r" +
                                           $"Key<N>\t\t=>\tEmulate 'Return'\n\r" +
                                           $"Key<D>\t\t=>\tSet delay\n\r" +
                                           $"Key<A>\t\t=>\tAdd text\n\r" +
                                           $"Key<=>\t\t=>\tEdit text\n\r" +
                                           $"Key<Shift + A>\t=>\tAdd ext. text\n\r" +
                                           $"Key<|>\t\t=>\tEdit ext. text\n\r" +
                                           $"Key<S>\t\t=>\tStart program\n\r" +
                                           $"Key<X>\t\t=>\tCancel program\n\r" +
                                           $"Key<C>\t\t=>\tReset all\n\r" +
                                           $"Key<Delete>\t=>\tDelete selected row\n\r" +
                                           $"Key<Shift+[Q-N]>\t=>\tInsert row\n\r");

            MessageBox.Show(message);
        }
        private void saveConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "xml file|*.xml",
                Title = "Save file",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                var dataSet = CreateXmlDataSet();
                dataSet.WriteXml(save.FileName, XmlWriteMode.WriteSchema);
            }

        }
        private void openConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Title = "Open .xml",
                Filter = ".xml files|*.xml",
                RestoreDirectory = true,
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                ClicksTable.Rows.Clear();
                InsertTextComboBox.Items.Clear();
                JobsComboBox.Items.Clear();

                ParseXmlDocument(open.FileName);

                _pointId = ClicksTable.Rows.GetLastRow(DataGridViewElementStates.None) + 1;
            }
        }
        #endregion

        #region Buttons
        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonsTurn(false);
                StartButton.Enabled = false;
                CancelButton.Enabled = true;
                if (BWorker.IsBusy != true) BWorker.RunWorkerAsync();
            }
            catch (Exception exception)
            {
                StatusBar.Text = exception.Message;
                SystemSounds.Hand.Play();
                ButtonsTurn(true);
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (BWorker.WorkerSupportsCancellation) BWorker.CancelAsync();
            CancelButton.Enabled = false;
            StartButton.Enabled = true;
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (ClicksTable.RowCount > 0)
            {
                try
                {
                    _pointId = 0;

                    ClicksTable.Rows?.Clear();

                    StatusBar.Text = "StatusBar";
                    LinesBar.Text = "LinesBar";
                    WorkerBar.Text = "ProgressBar";

                    InsertTextComboBox.Items?.Clear();
                    JobsComboBox.Items?.Clear();

                    InsertTextComboBox.Text = "";
                    JobsComboBox.Text = "";

                    EditJobsButton.Enabled = false;
                    EditEmployeesButton.Enabled = false;

                    StartButton.Enabled = false;
                    DeleteButton.Enabled = false;
                    CancelButton.Enabled = false;
                    ResetButton.Enabled = false;

                    ProgressBar.Value = 0;

                }
                catch (Exception exception)
                {
                    StatusBar.Text = exception.Message;
                    SystemSounds.Hand.Play();
                    ButtonsTurn(true);
                }
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
        private void SetDelay_Click(object sender, EventArgs e)
        {
            _delay = (int)DelayBox.Value;
            StatusBar.Text = $@"Delay equals {_delay} sec";
        }
        private void AddTextButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Title = "Open .txt file",
                Filter = "txt files|*.txt",
                RestoreDirectory = true
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                open.OpenFile();

                InsertTextComboBox?.Items.Clear();

                _pathFrom = open.FileName;
                InsertTextComboBox.Items.AddRange(File.ReadAllLines(_pathFrom));

                _amountOfLines = InsertTextComboBox.Items.Count;
                InsertTextComboBox.Text = InsertTextComboBox.Items[0].ToString();

                EditEmployeesButton.Enabled = true;

                StatusBar.Text = "File is opened";
                LinesBar.Text = $@"Amount of lines: {_amountOfLines}";
            }
        }
        private void AddJobsButton_Click(object sender, EventArgs e)
        {
            JobsComboBox.Items.Add(JobsComboBox.Text);
            JobsComboBox.Text = JobsComboBox.Items[0].ToString();
            if (EditJobsButton.Enabled == false) EditJobsButton.Enabled = true;
        }
        private void EditEmployeesButton_Click(object sender, EventArgs e)
        {
            if (InsertTextComboBox.Items.Count >= 0)
            {
                string text = InsertTextComboBox.SelectedItem?.ToString();

                using (EditText edit = new EditText(text))
                {
                    if (edit.ShowDialog() == DialogResult.OK)
                        InsertTextComboBox.Items[InsertTextComboBox.SelectedIndex] = edit.Text;
                }
            }
        }
        private void EditJobsButton_Click(object sender, EventArgs e)
        {
            if (JobsComboBox.Items.Count >= 0)
            {
                string text = JobsComboBox.SelectedItem?.ToString();

                using (EditText edit = new EditText(text))
                {
                    if (edit.ShowDialog() == DialogResult.OK)
                        JobsComboBox.Items[JobsComboBox.SelectedIndex] = edit.Text;
                }
            }
        }
        #endregion

        #region Functions
        private int GetXfromRow(int index) =>
            int.Parse(ClicksTable.Rows[index].Cells[1].Value.ToString());
        private int GetYfromRow(int index) =>
            int.Parse(ClicksTable.Rows[index].Cells[2].Value.ToString());
        private int GetDelayFromRow(int index) =>
            int.Parse(ClicksTable.Rows[index].Cells[3].Value.ToString());
        private string GetMethodNameFromRow(int index) =>
            ClicksTable.Rows[index].Cells[4].Value.ToString();
        private void ButtonsTurn(bool source)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                StartButton.Enabled =
                ResetButton.Enabled =
                    DeleteButton.Enabled =
                            EditEmployeesButton.Enabled =
                                EditJobsButton.Enabled =
                                    JobsButton.Enabled =
                                        SetDelayButton.Enabled =
                                            DelayBox.Enabled =
                                                JobsComboBox.Enabled =
                                                    InsertTextComboBox.Enabled = source;
            });
        }
        private void AddRow(int methodId)
        {
            ClicksTable.Rows.Add(++_pointId, GetPosX(), GetPosY(), _delay, MethodsList[methodId]);
            //DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            //cell.Items.AddRange(TypeOfEvent.Items);
            //cell.Value = ;
            StatusBar.Text = $"Row {_pointId} added";
        }
        private void DeleteRow()
        {
            if (ClicksTable.RowCount > 0)
            {
                if (ClicksTable.SelectedRows[0].Index == 0)
                {
                    for (int i = 0; i < ClicksTable.Rows.Count; i++)
                    {
                        ClicksTable.Rows[i].Cells[0].Value = i;
                        _pointId = i;
                    }

                    ClicksTable.Rows.RemoveAt(ClicksTable.SelectedRows[0].Index);
                }
                else if (ClicksTable.SelectedRows[0].Index > 0)
                {
                    int previous = ClicksTable.Rows.GetPreviousRow
                        (
                            ClicksTable.SelectedRows[0].Index,
                            DataGridViewElementStates.None
                        ) + 1;

                    for (int i = previous; i < ClicksTable.Rows.Count; i++)
                    {
                        ClicksTable.Rows[i].Cells[0].Value = i;
                        _pointId = i;
                    }

                    ClicksTable.Rows.RemoveAt(ClicksTable.SelectedRows[0].Index);
                }
                else if (ClicksTable.AreAllCellsSelected(false))
                {
                    ClicksTable.Rows.Clear();
                    _pointId = 0;
                }
            }
        }
        private void InsertRow(int methodId)
        {
            if (ClicksTable.Rows.Count != 0)
            {
                object[] items = { 0, GetPosX(), GetPosY(), _delay, MethodsList[methodId] };

                if (ClicksTable.SelectedRows.Count > 0)
                {
                    int index = ClicksTable.SelectedRows[0].Index;
                    _pointId = 0;

                    ClicksTable.Rows.Insert(index, items);

                    for (int i = 0; i < ClicksTable.Rows.Count; i++)
                        ClicksTable.Rows[i].Cells[0].Value = ++_pointId;
                    StatusBar.Text = @$"Row {index + 1} inserted";
                }
                else StatusBar.Text = "Строка не выбрана!";
            }
            else AddRow(methodId);
        }
        private DataSet CreateXmlDataSet()
        {
            var dataSet = new DataSet("ClickerApp");

            var data = new DataTable("ClickerProgramTable");

            var names = new DataTable
            {
                Columns = { "Names" },
                TableName = "NamesList"
            };

            var jobs = new DataTable
            {
                Columns = { "Jobs" },
                TableName = "JobsList"
            };


            //Операции с таблицей кликов
            foreach (DataGridViewColumn column in ClicksTable.Columns)
                if (column.Visible) data.Columns.Add(column.Name);

            var values = new object[ClicksTable.Columns.Count];

            foreach (DataGridViewRow row in ClicksTable.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Cells[i].Value == null)
                        values[i] = "null";
                    else
                        values[i] = row.Cells[i].Value;
                }
                data.Rows.Add(values);
            }

            //Операции с таблицей имен
            foreach (string name in InsertTextComboBox.Items)
                names.Rows.Add(name);

            //Операции с таблицей работ
            foreach (string job in JobsComboBox.Items)
                jobs.Rows.Add(job);

            dataSet.Tables.Add(data);
            dataSet.Tables.Add(names);
            dataSet.Tables.Add(jobs);

            return dataSet;
        }
        private void ParseXmlDocument(string pathSource)
        {
            string xmlFile = File.ReadAllText(pathSource);
            string pattern =
                @"<PointID>(.*?)</PointID>(\r\n\s+)<X>(.*?)</X>(\r\n\s+)<Y>(.*?)</Y>(\r\n\s+)<Interval>(.*?)</Interval>(\r\n\s+)<TypeOfEvent>(.*?)</TypeOfEvent>(\r\n\s+)<Description>(.*?)</Description>";

            foreach (Match match in Regex.Matches(xmlFile, pattern, RegexOptions.Singleline))
            {
                ClicksTable.Rows.Add
                (
                    match.Groups[1].Value,
                    match.Groups[3].Value,
                    match.Groups[5].Value,
                    match.Groups[7].Value,
                    match.Groups[9].Value,
                    match.Groups[11].Value
                );
            }

            foreach (Match match in Regex.Matches(xmlFile, @" < Names>(.*?)</Names>"))
                InsertTextComboBox.Items.Add(match.Groups[1].Value);

            foreach (Match match in Regex.Matches(xmlFile, @"<Jobs>(.*?)</Jobs>"))
                JobsComboBox.Items.Add(match.Groups[1].Value);

            if ((InsertTextComboBox.Items.Count != 0) || (JobsComboBox.Items.Count != 0))
            {
                InsertTextComboBox.Text = $"{InsertTextComboBox.Items[0]}";
                JobsComboBox.Text = $"{JobsComboBox.Items[0]}";
            }

            _amountOfLines = InsertTextComboBox.Items.Count;

            EditEmployeesButton.Enabled = EditJobsButton.Enabled = true;
        }
        #endregion

        private void TestButton_Click(object sender, EventArgs e)
        {
            //object[] items = { 0, GetPosX(), GetPosY(), _delay, MethodsList[0] };
            //ClicksTable.Rows.Insert(ClicksTable.SelectedRows[0].Index, items);

            //_pointId = 0;

            //for (int i = 0; i < ClicksTable.Rows.Count; i++)
            //    ClicksTable.Rows[i].Cells[0].Value = ++_pointId;

            //int test = 117;

            //int a = 0, b = 0, c = 0;

            //a = test / 100 % 10;
            //b = test / 10 % 10;
            //c = test / 1 % 10;

            //string abc = "Алешаева";

            //SendKeys.Send(abc);
        }
    }
}
