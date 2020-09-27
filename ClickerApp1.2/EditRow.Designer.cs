namespace ClickerApp1._2
{
    partial class EditRow
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
            this.LabelDelay = new System.Windows.Forms.Label();
            this.LabelMethod = new System.Windows.Forms.Label();
            this.ChangeDelay = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.Deciline = new System.Windows.Forms.Button();
            this.ChangeMethod = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelDelay
            // 
            this.LabelDelay.BackColor = System.Drawing.SystemColors.Highlight;
            this.LabelDelay.Location = new System.Drawing.Point(30, 62);
            this.LabelDelay.Name = "LabelDelay";
            this.LabelDelay.Size = new System.Drawing.Size(127, 22);
            this.LabelDelay.TabIndex = 0;
            this.LabelDelay.Text = "Change delay:";
            this.LabelDelay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelMethod
            // 
            this.LabelMethod.BackColor = System.Drawing.SystemColors.Highlight;
            this.LabelMethod.Location = new System.Drawing.Point(30, 102);
            this.LabelMethod.Name = "LabelMethod";
            this.LabelMethod.Size = new System.Drawing.Size(127, 24);
            this.LabelMethod.TabIndex = 1;
            this.LabelMethod.Text = "Change method:";
            this.LabelMethod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ChangeDelay
            // 
            this.ChangeDelay.Location = new System.Drawing.Point(163, 62);
            this.ChangeDelay.Name = "ChangeDelay";
            this.ChangeDelay.Size = new System.Drawing.Size(100, 22);
            this.ChangeDelay.TabIndex = 3;
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Accept.Location = new System.Drawing.Point(57, 138);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(100, 34);
            this.Accept.TabIndex = 6;
            this.Accept.Text = "Ok";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Deciline
            // 
            this.Deciline.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Deciline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Deciline.Location = new System.Drawing.Point(163, 138);
            this.Deciline.Name = "Deciline";
            this.Deciline.Size = new System.Drawing.Size(100, 34);
            this.Deciline.TabIndex = 7;
            this.Deciline.Text = "Cancel";
            this.Deciline.UseVisualStyleBackColor = false;
            this.Deciline.Click += new System.EventHandler(this.Deciline_Click);
            // 
            // ChangeMethod
            // 
            this.ChangeMethod.FormattingEnabled = true;
            this.ChangeMethod.Items.AddRange(new object[] {
            "MouseClick",
            "MouseDoubleClick",
            "MouseRightClick",
            "InsertText",
            "InsertJobs"});
            this.ChangeMethod.Location = new System.Drawing.Point(163, 99);
            this.ChangeMethod.Name = "ChangeMethod";
            this.ChangeMethod.Size = new System.Drawing.Size(100, 24);
            this.ChangeMethod.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(328, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(0, 16);
            // 
            // EditRow
            // 
            this.AcceptButton = this.Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.Deciline;
            this.ClientSize = new System.Drawing.Size(328, 287);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ChangeMethod);
            this.Controls.Add(this.Deciline);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.ChangeDelay);
            this.Controls.Add(this.LabelMethod);
            this.Controls.Add(this.LabelDelay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(346, 334);
            this.Name = "EditRow";
            this.Text = "Edit row";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDelay;
        private System.Windows.Forms.Label LabelMethod;
        private System.Windows.Forms.TextBox ChangeDelay;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Deciline;
        private System.Windows.Forms.ComboBox ChangeMethod;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
    }
}