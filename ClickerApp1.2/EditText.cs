using System;
using System.Windows.Forms;

namespace EventManager
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
