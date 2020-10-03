namespace EventManager
{
    partial class EditText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeText = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.Decline = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 196);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(0, 16);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit:";
            // 
            // ChangeText
            // 
            this.ChangeText.Location = new System.Drawing.Point(107, 71);
            this.ChangeText.Name = "ChangeText";
            this.ChangeText.Size = new System.Drawing.Size(281, 22);
            this.ChangeText.TabIndex = 2;
            // 
            // Accept
            // 
            this.Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Accept.Location = new System.Drawing.Point(107, 99);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(140, 36);
            this.Accept.TabIndex = 3;
            this.Accept.Text = "Ok";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Decline
            // 
            this.Decline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Decline.Location = new System.Drawing.Point(253, 99);
            this.Decline.Name = "Decline";
            this.Decline.Size = new System.Drawing.Size(135, 36);
            this.Decline.TabIndex = 3;
            this.Decline.Text = "Cancel";
            this.Decline.UseVisualStyleBackColor = true;
            this.Decline.Click += new System.EventHandler(this.Decline_Click);
            // 
            // EditText
            // 
            this.AcceptButton = this.Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.Decline;
            this.ClientSize = new System.Drawing.Size(492, 218);
            this.Controls.Add(this.Decline);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.ChangeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "EditText";
            this.Text = "Edit text";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChangeText;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Decline;
    }
}