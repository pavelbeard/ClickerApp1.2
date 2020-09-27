using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerApp1._2
{
    public partial class EditText : Form
    {
        public override string Text { get; set; }
        public EditText(string text)
        {
            InitializeComponent();
            ChangeText.Text = text;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (ChangeText.Text != "") Text = ChangeText.Text;
        }

        private void Decline_Click(object sender, EventArgs e) => Close();
    }
}
