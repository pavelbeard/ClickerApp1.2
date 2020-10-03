using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    partial class ClickerApp
    {
        private int _startIndex = 0;
        private void SubProgram(int str = 0, int i = 0)
        {
            NewPosition(GetXfromRow(i), GetYfromRow(i));
            switch (GetMethodNameFromRow(i))
            {
                case "MouseClick":
                    MouseClick();
                    break;
                case "MouseDoubleClick":
                    MouseDoubleClick();
                    break;
                case "MouseRightClick":
                    MouseRightClick();
                    break;
                case "ShiftTab":
                    ShiftTab();
                    break;
                case "Return":
                    Return();
                    break;
                case "InsertText":
                    InsertText(str);
                    break;
                case "InsertJobs":
                    InsertJobs();
                    break;
            }
            Thread.Sleep(TimeSpan.FromSeconds(GetDelayFromRow(i)));
        }

        #region BackgroundWorker

        private void BWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            double progress = 0;

            BackgroundWorker worker = sender as BackgroundWorker;

            if (ClicksTable.Rows.Count > 0)
            {
                if (_amountOfLines > 0)
                {
                    for (int lines = _startIndex, str = 0; lines < _amountOfLines; lines++, str++)
                    {
                        for (int i = 0; i < ClicksTable.RowCount; i++)
                        {
                            if (BWorker.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }
                            progress += 100.0 / (ClicksTable.RowCount * _amountOfLines);
                            worker?.ReportProgress((int)progress);
                            SubProgram(str, i);
                        }
                    }
                    ButtonsTurn(true);
                }
                else
                {
                    for (int i = 0; i < ClicksTable.RowCount; i++)
                    {
                        if (BWorker.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }
                        progress += 100.0 / ClicksTable.RowCount;
                        worker?.ReportProgress((int)progress);
                        SubProgram(0, i);
                        
                    }
                    ButtonsTurn(true);
                }
            }
            else throw new Exception("Fill the rows");
        }

        private void BWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WorkerBar.Text = $@"{e.ProgressPercentage}%";
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void BWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                WorkerBar.Text = "Canceled!";
                ProgressBar.Value = 0;
                CancelButton.Enabled = false;
            }
            else if (e.Error != null) ProgressBar.Text = $@"Error: {e.Error.Message}";
            else
            {
                WorkerBar.Text = "Complete! 100%";
                ProgressBar.Value = 100;
                CancelButton.Enabled = false;
            }
        }
        #endregion
    }
}
