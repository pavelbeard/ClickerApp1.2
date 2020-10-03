using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    partial class ClickerApp
    {
        private void Clicker_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Modifiers | e.KeyCode)
            {
                case Keys.Q:
                    AddRow(0);
                    break;
                case Keys.Shift | Keys.Q:
                    InsertRow(0);
                    break;
                case Keys.W:
                    AddRow(1);
                    break;
                case Keys.Shift | Keys.W:
                    InsertRow(1);
                    break;
                case Keys.E:
                    AddRow(2);
                    break;
                case Keys.Shift | Keys.E:
                    InsertRow(2);
                    break;
                case Keys.R:
                    if (InsertTextComboBox.Items.Count != 0) AddRow(3);
                    break;
                case Keys.Shift | Keys.R:
                    if (InsertTextComboBox.Items.Count != 0) InsertRow(3);
                    break;
                case Keys.Z:
                    if (JobsComboBox.Items.Count != 0) AddRow(4);
                    break;
                case Keys.Shift | Keys.Z:
                    if (JobsComboBox.Items.Count != 0) InsertRow(4);
                    break;
                case Keys.T:
                    AddRow(5);
                    break;
                case Keys.Shift | Keys.T:
                    InsertRow(5);
                    break;
                case Keys.N:
                    AddRow(6);
                    break;
                case Keys.Shift | Keys.N:
                    InsertRow(6);
                    break;
                case Keys.D:
                    SetDelay_Click(null, null);
                    break;
                case Keys.A:
                    AddTextButton_Click(null, null);
                    break;
                case Keys.Shift | Keys.A:
                    AddJobsButton_Click(null, null);
                    break;
                case Keys.Oemplus:
                    EditEmployeesButton_Click(null, null);
                    break;
                case Keys.OemPipe:
                    EditJobsButton_Click(null, null);
                    break;
                case Keys.Delete:
                    DeleteButton_Click(null, null);
                    break;
                case Keys.S:
                    StartButton_Click(null, null);
                    break;
                case Keys.X:
                    CancelButton_Click(null, null);
                    break;
                case Keys.C:
                    ResetButton_Click(null, null);
                    break;
                case Keys.Escape:
                    Focus();
                    break;
                //Numbers
                case Keys.D0:
                    TestButton_Click(null, null);
                    break;

            }
        }
    }
}
