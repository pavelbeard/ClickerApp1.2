using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ClickerApp1._2
{
    public partial class ClickerApp : Form
    {
        private const int _delay = 1000;
        private SynchronizationContext _context;
        /// <summary>
        /// 
        /// </summary>
        public ClickerApp()
        {
            InitializeComponent();

            Repeater.MethodsList = new List<string>
            {
                "MouseClick",
                "MouseDoubleClick",
                "MouseRightClick",
                "InsertText",
                "InsertJobs"
            };

            EditButton.Enabled = false;
            StartButton.Enabled = ClicksTable.Rows.Count > 1;
            ResetButton.Enabled = ClicksTable.Rows.Count > 1;
            DeleteButton.Enabled = ClicksTable.Rows.Count > 1;
            EditJobsButton.Enabled = false;
            EditEmployeesButton.Enabled = false;
            button1.Enabled = false;
            button1.Visible = false;
#if DEBUG
            Repeater.PathIn = @"D:\source\repos\ClickerApp1.2\ClickerApp1.2\bin\Debug\debug.txt";
            button1.Enabled = true;
            button1.Visible = true;
#endif

            DelayBox.Text = 2.ToString();
        }

        private void openNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Title = "Open .txt file",
                //InitialDirectory = @"C:\",
                Filter = "txt files|*.txt",
                RestoreDirectory = true
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                open.OpenFile();
                InsertTextComboBox?.Items.Clear();
                Repeater.PathFrom = open.FileName;
                InsertTextComboBox.Items.AddRange(File.ReadAllLines(Repeater.PathFrom));
                Repeater.AmountOfLines = InsertTextComboBox.Items.Count;
                InsertTextComboBox.Text = InsertTextComboBox.Items[0].ToString();
                EditEmployeesButton.Enabled = true;
                StatusBar.Text = "File is opened";
                LinesBar.Text = $"Amount of lines: {Repeater.AmountOfLines}";
            }
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q: AddRow(0); break;
                case Keys.W: AddRow(1); break;
                case Keys.E: AddRow(2); break;
                case Keys.R: if (Repeater.AmountOfLines != 0) AddRow(3); break;
                case Keys.Z: AddRow(4); break;
                case Keys.D: SetDelay_Click(null, null); break;
                case Keys.A: JobsButton_Click(null, null); break;
                case Keys.Oem2: EditButton_Click(null, null); break;
                case Keys.Oemplus: EditEmployeesButton_Click(null, null); break;
                case Keys.OemPipe: EditJobsButton_Click(null, null); break;
                case Keys.Delete: DeleteButton_Click(null, null); break;
                case Keys.Enter: StartButton_Click(null, null); break;
                case Keys.Space: ResetButton_Click(null, null); break;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void StartButton_Click(object sender, EventArgs e)
        {
#if DEBUG
            File.AppendAllText(Repeater.PathIn, $"START PROGRAM\n");
#endif
            try
            {
                ButtonsTurn(false);

                if (ClicksTable.Rows.Count > 1)
                {
                    if (Repeater.AmountOfLines > 0)
                    {
                        for (int lines = 0, str = 0; lines < Repeater.AmountOfLines; lines++, str++)
                        {
#if DEBUG
                            File.AppendAllText(Repeater.PathIn, $"Line {lines + 1} =>\n");                   
#endif
                            ClickProgram(str);
                        }
                        ButtonsTurn(true);
                    }
                    else
                    {
                        ClickProgram();
                        ButtonsTurn(true);
                    }
                }
                else throw new Exception("Fill the rows");
            }
            catch (Exception exception)
            {
                StatusBar.Text = exception.Message;
                SystemSounds.Hand.Play();
                ButtonsTurn(true);
            }
        }

        private void ClickProgram(int str = 0)
        {
            for (int i = 0; i < ClicksTable.RowCount; i++)
            {
#if DEBUG
                File.AppendAllText(Repeater.PathIn,$"\t\tRow {i + 1} =>\n");       
#endif
                KeysEvents.NewPosition(GetXfromRow(i), GetYfromRow(i));

                switch (GetMethodNameFromRow(i))
                {
                    case "MouseClick": KeysEvents.MouseClick(); break;
                    case "MouseDoubleClick": KeysEvents.MouseDoubleClick(); break;
                    case "MouseRightClick": KeysEvents.MouseRightClick(); break;
                    case "InsertText": KeysEvents.InsertText(str, InsertTextComboBox.Items); break;
                    case "InsertJobs": KeysEvents.InsertJobs(JobsComboBox.Items); break;
                }

#if DEBUG
                File.AppendAllText(Repeater.PathIn, $"\t\t\tX = {KeysEvents.GetPosX()}, Y = {KeysEvents.GetPosY()}\n");
#endif
                Thread.Sleep(GetDelayFromRow(i));
            }
        }

        //private void DelayBox_MouseHover(object sender, EventArgs e) => DelayBoxTooltip.SetToolTip(DelayBox, "Press <Enter> to set delay");

        private void AddRow(int methodId, int indexLine = 0)
        {
            try
            {
                ClicksTable.Rows.Add
                (
                    ++Repeater.PointId,
                    KeysEvents.GetPosX(),
                    KeysEvents.GetPosY(),
                    Repeater.Delay,
                    Repeater.MethodsList[methodId]
                );

            }
            catch (Exception e)
            {
                StatusBar.Text = e.Message;
                SystemSounds.Hand.Play();
            }
        }

        private int GetXfromRow(int index) => 
            int.Parse(ClicksTable.Rows[index].Cells[1].Value.ToString());
        private int GetYfromRow(int index) => 
            int.Parse(ClicksTable.Rows[index].Cells[2].Value.ToString());
        private int GetDelayFromRow(int index) => 
            int.Parse(ClicksTable.Rows[index].Cells[3].Value.ToString()) * _delay;
        private string GetMethodNameFromRow(int index) => 
            ClicksTable.Rows[index].Cells[4].Value.ToString();

        private void DelayBox_TextChanged(object sender, EventArgs e)
        {
            var match = Regex.Match(DelayBox.Text, "\\D");
            if (match.Success) DelayBox.Text = DelayBox.Text.Remove(match.Index);
        }
        private void DelayBox_MouseClick(object sender, MouseEventArgs e) => DelayBox.Text = "";

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (ClicksTable.RowCount > 1)
            {
                try
                {
                    Repeater.Reset();
                    ClicksTable.Rows.Clear();
                    StatusBar.Text = "StatusBar";
                    LinesBar.Text = "LinesBar";
                    InsertTextComboBox.Items.Clear();
                    JobsComboBox.Items.Clear();
                    InsertTextComboBox.Text = "";
                    JobsComboBox.Text = "";
                    EditJobsButton.Enabled = false;
                    EditEmployeesButton.Enabled = false;
                }
                catch (Exception exception)
                {
                    StatusBar.Text = exception.Message;
                    SystemSounds.Hand.Play();
                    ButtonsTurn(true);
                }
            }
        }

        private void SetDelay_Click(object sender, EventArgs e)
        {
            try
            {
                Repeater.Delay = int.Parse(DelayBox.Text);
                DelayBox.Text = null;
                StatusBar.Text = $"Delay equals {Repeater.Delay} sec";
            }
            catch (Exception exception)
            {
                StatusBar.Text = exception.Message;
                SystemSounds.Hand.Play();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClicksTable.Rows.Count > 1)
                {
                    int delay = int.Parse(ClicksTable.SelectedRows[0].Cells[3].Value.ToString());
                    string method = ClicksTable.SelectedRows[0].Cells[4].Value.ToString();

                    using (EditRow edit = new EditRow(delay, method /*text*/))
                    {
                        if (edit.ShowDialog() == DialogResult.OK)
                        {
                            if (InsertTextComboBox.Items.Count == 0) 
                                Repeater.AmountOfLines = InsertTextComboBox.Items.Count;
                            //if (JobsComboBox.Items.Count == 0) //Repeater.AmountOfJobs = JobsComboBox.Items.Count

                            ClicksTable.SelectedRows[0].Cells[3].Value = edit.Delay.ToString();
                            ClicksTable.SelectedRows[0].Cells[4].Value = edit.MethodName;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void ClicksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex < ClicksTable.RowCount)
            {
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
            else
            {
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ClicksTable.RowCount > 0)
            {
                try
                {
                    if (ClicksTable.SelectedRows[0].Index == 0)
                    {
                        int next = ClicksTable.Rows.GetNextRow
                        (
                            0,
                            DataGridViewElementStates.None
                        );
                        
                        for (int i = 0; i < ClicksTable.Rows.Count; i++)
                        {
                            ClicksTable.Rows[i].Cells[0].Value = i;
                            Repeater.PointId = i;
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
                            Repeater.PointId = i;
                        }

                        ClicksTable.Rows.RemoveAt(ClicksTable.SelectedRows[0].Index);
                    }
                    else if (ClicksTable.AreAllCellsSelected(false))
                    {
                        ClicksTable.Rows.Clear();
                        Repeater.PointId = 0;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }

        private void ClicksTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (ClicksTable.RowCount > 1 && StartButton.Enabled == false) StartButton.Enabled = true;
            if (ClicksTable.RowCount > 1 && ResetButton.Enabled == false) ResetButton.Enabled = true;
        }

        private void ClicksTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (ClicksTable.RowCount < 1 && StartButton.Enabled) StartButton.Enabled = false;
            if (ClicksTable.RowCount < 1 && ResetButton.Enabled) ResetButton.Enabled = false;
        }

        private void JobsButton_Click(object sender, EventArgs e)
        {
            JobsComboBox.Items.Add(JobsComboBox.Text);
            JobsComboBox.Text = JobsComboBox.Items[0].ToString();
            if (EditJobsButton.Enabled == false) EditJobsButton.Enabled = true;
        }

        private void EditEmployeesButton_Click(object sender, EventArgs e)
        {
            if (InsertTextComboBox.Items.Count >= 1)
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
            if (JobsComboBox.Items.Count >= 1)
            {
                string text = JobsComboBox.SelectedItem?.ToString();

                using (EditText edit = new EditText(text))
                {
                    if (edit.ShowDialog() == DialogResult.OK) 
                        JobsComboBox.Items[JobsComboBox.SelectedIndex] = edit.Text;
                }
            }
        }

        private void ButtonsTurn(bool source)
        {
            StartButton.Enabled =
                ResetButton.Enabled =
                    DeleteButton.Enabled =
                        EditButton.Enabled =
                            EditEmployeesButton.Enabled =
                                EditJobsButton.Enabled =
                                    JobsButton.Enabled =
                                        SetDelayButton.Enabled =
                                            DelayBox.Enabled =
                                                JobsComboBox.Enabled =
                                                    InsertTextComboBox.Enabled = source;
        }

        private void tooltipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (  "Key < Q >\tOne click\n" +
                    "Key < W >\tDouble click\n" +
                    "Key < E >\t\tRight click\n" +
                    "Key < R >\t\tInsert text\n" +
                    "Key < Z >\t\tInsert jobs\n" +
                    "Key < D >\tSet delay\n" +
                    "Key < A >\t\tAdd jobs\n" +
                    "Key < Enter >\tStart program\n" +
                    "Key < Space >\tReset program\n" +
                    "Key < / >\t\tEdit row\n" +
                    "Key < = >\t\tEdit employees\n" +
                    "Key < | >\t\tEdit jobs\n" +
                    "Key < Delete >\tDelete row"
            );
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

                Repeater.PointId = ClicksTable.Rows.GetLastRow(DataGridViewElementStates.None) + 1;
            }
        }

        private void ParseXmlDocument(string pathSource)
        {
            string xmlFile = File.ReadAllText(pathSource);
            string pattern =
                @"<PointID>(.*?)</PointID>(\r\n\s+)<X>(.*?)</X>(\r\n\s+)<Y>(.*?)</Y>(\r\n\s+)<Delay>(.*?)</Delay>(\r\n\s+)<TypeOfEvent>(.*?)</TypeOfEvent>(\r\n\s+)";

            foreach (Match match in Regex.Matches(xmlFile, pattern, RegexOptions.Singleline))
            {
                ClicksTable.Rows.Add
                (
                    match.Groups[1].Value,
                    match.Groups[3].Value,
                    match.Groups[5].Value,
                    match.Groups[7].Value,
                    match.Groups[9].Value
                );
            }

            foreach (Match match in Regex.Matches(xmlFile, @"<Names>(.*?)</Names>"))
                InsertTextComboBox.Items.Add(match.Groups[1].Value);

            foreach (Match match in Regex.Matches(xmlFile, @"<Jobs>(.*?)</Jobs>"))
                JobsComboBox.Items.Add(match.Groups[1].Value);

            InsertTextComboBox.Text = InsertTextComboBox.Items[0].ToString();
            JobsComboBox.Text = JobsComboBox.Items[0].ToString();

            Repeater.AmountOfLines = InsertTextComboBox.Items.Count;

            EditButton.Enabled = EditEmployeesButton.Enabled = EditJobsButton.Enabled = true;
        }

        private DataSet CreateXmlDataSet()
        {
            var dataSet = new DataSet();

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
                    values[i] = row.Cells[i].Value;
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

#if DEBUG
        private void button1_Click(object sender, EventArgs e)
        {
            if (ClicksTable.Rows.Count > 0)
            {
                if (Repeater.AmountOfLines > 0)
                {
                    for (int lines = 0; lines < Repeater.AmountOfLines; lines++)
                    {
                        Test(lines);
                        //Thread.Sleep(100/*Repeater.Delay*/);
                    }
                    MessageBox.Show("Done!");
                }
                else
                {
                    Test();
                    MessageBox.Show("Done!");
                }
            }
        }

        private void Test(int index = 0)
        {
            for (int i = 0; i < ClicksTable.Rows.Count; i++)
            {
                KeysEvents.NewPosition(GetXfromRow(i), GetYfromRow(i));

                switch (GetMethodNameFromRow(i))
                {
                    case "MouseClick":
                        KeysEvents.MouseClick();
                        break;
                    case "MouseDoubleClick":
                        KeysEvents.MouseDoubleClick();
                        break;
                    case "MouseRightClick":
                        KeysEvents.MouseRightClick();
                        break;
                    case "InsertText":
                        KeysEvents.InsertText(index, InsertTextComboBox.Items);
                        break;
                    case "InsertJobs":
                        KeysEvents.InsertJobs(JobsComboBox.Items);
                        break;
                }

                Console.WriteLine($"i = {i}");
                Thread.Sleep(200/*GetDelayFromRow(i)*/);
            }
        }
#endif
    }
}
