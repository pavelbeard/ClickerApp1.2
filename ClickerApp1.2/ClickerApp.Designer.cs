using System;

namespace ClickerApp1._2
{
    /// <inheritdoc />
    partial class ClickerApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClickerApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClicksTable = new System.Windows.Forms.DataGridView();
            this.PointID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartButton = new System.Windows.Forms.Button();
            this.DelayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DelayBoxTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LinesBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.SetDelayButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.JobsButton = new System.Windows.Forms.Button();
            this.InsertTextComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JobsComboBox = new System.Windows.Forms.ComboBox();
            this.EditEmployeesButton = new System.Windows.Forms.Button();
            this.EditJobsButton = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClicksTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tooltipsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewFileToolStripMenuItem,
            this.openConfigurationToolStripMenuItem,
            this.saveConfigurationToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openNewFileToolStripMenuItem
            // 
            this.openNewFileToolStripMenuItem.Name = "openNewFileToolStripMenuItem";
            this.openNewFileToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.openNewFileToolStripMenuItem.Text = "Open new file";
            this.openNewFileToolStripMenuItem.Click += new System.EventHandler(this.openNewFileToolStripMenuItem_Click);
            // 
            // openConfigurationToolStripMenuItem
            // 
            this.openConfigurationToolStripMenuItem.Name = "openConfigurationToolStripMenuItem";
            this.openConfigurationToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.openConfigurationToolStripMenuItem.Text = "Open configuration";
            this.openConfigurationToolStripMenuItem.Click += new System.EventHandler(this.openConfigurationToolStripMenuItem_Click);
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.saveConfigurationToolStripMenuItem.Text = "Save configuration";
            this.saveConfigurationToolStripMenuItem.Click += new System.EventHandler(this.saveConfigurationToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // tooltipsToolStripMenuItem
            // 
            this.tooltipsToolStripMenuItem.Name = "tooltipsToolStripMenuItem";
            this.tooltipsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.tooltipsToolStripMenuItem.Text = "Tooltips";
            this.tooltipsToolStripMenuItem.Click += new System.EventHandler(this.tooltipsToolStripMenuItem_Click);
            // 
            // ClicksTable
            // 
            this.ClicksTable.AllowUserToAddRows = false;
            this.ClicksTable.AllowUserToDeleteRows = false;
            this.ClicksTable.AllowUserToResizeColumns = false;
            this.ClicksTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ClicksTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClicksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClicksTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClicksTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ClicksTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ClicksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClicksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PointID,
            this.X,
            this.Y,
            this.Delay,
            this.TypeOfEvent});
            this.ClicksTable.Location = new System.Drawing.Point(12, 59);
            this.ClicksTable.Name = "ClicksTable";
            this.ClicksTable.ReadOnly = true;
            this.ClicksTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClicksTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ClicksTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ClicksTable.RowTemplate.Height = 24;
            this.ClicksTable.Size = new System.Drawing.Size(1004, 264);
            this.ClicksTable.TabIndex = 2;
            this.ClicksTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClicksTable_CellClick);
            this.ClicksTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ClicksTable_RowsAdded);
            this.ClicksTable.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ClicksTable_RowsRemoved);
            this.ClicksTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // PointID
            // 
            this.PointID.HeaderText = "PointID";
            this.PointID.MinimumWidth = 6;
            this.PointID.Name = "PointID";
            this.PointID.ReadOnly = true;
            this.PointID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PointID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delay
            // 
            this.Delay.HeaderText = "Delay";
            this.Delay.MinimumWidth = 6;
            this.Delay.Name = "Delay";
            this.Delay.ReadOnly = true;
            this.Delay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TypeOfEvent
            // 
            this.TypeOfEvent.HeaderText = "Type of event";
            this.TypeOfEvent.MinimumWidth = 6;
            this.TypeOfEvent.Name = "TypeOfEvent";
            this.TypeOfEvent.ReadOnly = true;
            this.TypeOfEvent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeOfEvent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartButton.Location = new System.Drawing.Point(116, 357);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(98, 48);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "[Enter] Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DelayBox
            // 
            this.DelayBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelayBox.Location = new System.Drawing.Point(12, 329);
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.Size = new System.Drawing.Size(98, 22);
            this.DelayBox.TabIndex = 4;
            this.DelayBox.Text = "Set delay";
            this.DelayBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DelayBox_MouseClick);
            this.DelayBox.TextChanged += new System.EventHandler(this.DelayBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(305, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // DelayBoxTooltip
            // 
            this.DelayBoxTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.DelayBoxTooltip.ToolTipTitle = "KeyInfo";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResetButton.Location = new System.Drawing.Point(220, 357);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(110, 48);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "[Space] Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.SystemColors.Control;
            this.StatusBar.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(75, 24);
            this.StatusBar.Text = "StatusBar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar,
            this.LinesBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LinesBar
            // 
            this.LinesBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LinesBar.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.LinesBar.Name = "LinesBar";
            this.LinesBar.Size = new System.Drawing.Size(68, 24);
            this.LinesBar.Text = "LinesBar";
            // 
            // SetDelayButton
            // 
            this.SetDelayButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SetDelayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetDelayButton.Location = new System.Drawing.Point(12, 357);
            this.SetDelayButton.Name = "SetDelayButton";
            this.SetDelayButton.Size = new System.Drawing.Size(98, 48);
            this.SetDelayButton.TabIndex = 11;
            this.SetDelayButton.Text = "[D] Set delay";
            this.SetDelayButton.UseVisualStyleBackColor = false;
            this.SetDelayButton.Click += new System.EventHandler(this.SetDelay_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditButton.Location = new System.Drawing.Point(339, 357);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(110, 48);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "[/] Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(455, 357);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 48);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "[Delete] Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // JobsButton
            // 
            this.JobsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JobsButton.Location = new System.Drawing.Point(452, 469);
            this.JobsButton.Name = "JobsButton";
            this.JobsButton.Size = new System.Drawing.Size(110, 48);
            this.JobsButton.TabIndex = 14;
            this.JobsButton.Text = "[A] Add jobs";
            this.JobsButton.UseVisualStyleBackColor = false;
            this.JobsButton.Click += new System.EventHandler(this.JobsButton_Click);
            // 
            // InsertTextComboBox
            // 
            this.InsertTextComboBox.FormattingEnabled = true;
            this.InsertTextComboBox.Location = new System.Drawing.Point(12, 439);
            this.InsertTextComboBox.Name = "InsertTextComboBox";
            this.InsertTextComboBox.Size = new System.Drawing.Size(318, 24);
            this.InsertTextComboBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Employees";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(336, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Jobs";
            // 
            // JobsComboBox
            // 
            this.JobsComboBox.FormattingEnabled = true;
            this.JobsComboBox.Location = new System.Drawing.Point(336, 439);
            this.JobsComboBox.Name = "JobsComboBox";
            this.JobsComboBox.Size = new System.Drawing.Size(326, 24);
            this.JobsComboBox.TabIndex = 20;
            // 
            // EditEmployeesButton
            // 
            this.EditEmployeesButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditEmployeesButton.Location = new System.Drawing.Point(12, 469);
            this.EditEmployeesButton.Name = "EditEmployeesButton";
            this.EditEmployeesButton.Size = new System.Drawing.Size(110, 48);
            this.EditEmployeesButton.TabIndex = 21;
            this.EditEmployeesButton.Text = "[=] Edit emps";
            this.EditEmployeesButton.UseVisualStyleBackColor = false;
            this.EditEmployeesButton.Click += new System.EventHandler(this.EditEmployeesButton_Click);
            // 
            // EditJobsButton
            // 
            this.EditJobsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditJobsButton.Location = new System.Drawing.Point(336, 469);
            this.EditJobsButton.Name = "EditJobsButton";
            this.EditJobsButton.Size = new System.Drawing.Size(110, 48);
            this.EditJobsButton.TabIndex = 21;
            this.EditJobsButton.Text = "[|] Edit jobs";
            this.EditJobsButton.UseVisualStyleBackColor = false;
            this.EditJobsButton.Click += new System.EventHandler(this.EditJobsButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(906, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Debug";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClickerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1028, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditJobsButton);
            this.Controls.Add(this.EditEmployeesButton);
            this.Controls.Add(this.JobsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertTextComboBox);
            this.Controls.Add(this.JobsButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SetDelayButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelayBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ClicksTable);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1046, 637);
            this.Name = "ClickerApp";
            this.Text = "Clicker App 1.2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClicksTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView ClicksTable;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox DelayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip DelayBoxTooltip;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LinesBar;
        private System.Windows.Forms.Button SetDelayButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button JobsButton;
        private System.Windows.Forms.ComboBox InsertTextComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox JobsComboBox;
        private System.Windows.Forms.Button EditEmployeesButton;
        private System.Windows.Forms.Button EditJobsButton;
        private System.Windows.Forms.ToolStripMenuItem tooltipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointID;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfEvent;
        private System.Windows.Forms.Button button1;
    }
}

