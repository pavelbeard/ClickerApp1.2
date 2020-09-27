using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerApp1._2
{
    public partial class EditRow : Form
    {
        public int Delay { get; set; }
        public string MethodName { get; set; }
        //public string TextEdit { get; set; }

        public EditRow(int delay, string method/*, string edit*/)
        {
            InitializeComponent();
            ChangeDelay.Text = delay.ToString();
            ChangeMethod.Text = method;
            //ChangeText.Text = edit;
        }

        private void Deciline_Click(object sender, EventArgs e) => Close();
        private void Accept_Click(object sender, EventArgs e)
        {
            if(ChangeDelay.Text != "") Delay = Int32.Parse(ChangeDelay.Text);
            if(ChangeMethod.Text != "") MethodName = ChangeMethod.Text;
            //if (ChangeText.Text != "") TextEdit = ChangeText.Text;
        }
    }
}
