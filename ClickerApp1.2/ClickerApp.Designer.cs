namespace EventManager
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
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DelayBoxTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LinesBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.WorkerBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.MousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.SetDelayButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.JobsButton = new System.Windows.Forms.Button();
            this.InsertTextComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JobsComboBox = new System.Windows.Forms.ComboBox();
            this.EditEmployeesButton = new System.Windows.Forms.Button();
            this.EditJobsButton = new System.Windows.Forms.Button();
            this.BWorker = new System.ComponentModel.BackgroundWorker();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.DelayBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.AddTextButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClicksTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBox)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1216, 28);
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
            this.openNewFileToolStripMenuItem.Enabled = false;
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
            this.tooltipsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.tooltipsToolStripMenuItem.Text = "HotKeys";
            this.tooltipsToolStripMenuItem.Click += new System.EventHandler(this.tooltipsToolStripMenuItem_Click);
            // 
            // ClicksTable
            // 
            this.ClicksTable.AllowUserToAddRows = false;
            this.ClicksTable.AllowUserToDeleteRows = false;
            this.ClicksTable.AllowUserToResizeColumns = false;
            this.ClicksTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ClicksTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClicksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClicksTable.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.ClicksTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClicksTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClicksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClicksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PointID,
            this.X,
            this.Y,
            this.Interval,
            this.TypeOfEvent,
            this.Description});
            this.ClicksTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClicksTable.GridColor = System.Drawing.Color.Thistle;
            this.ClicksTable.Location = new System.Drawing.Point(0, 28);
            this.ClicksTable.Name = "ClicksTable";
            this.ClicksTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClicksTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ClicksTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClicksTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ClicksTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            this.ClicksTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ClicksTable.RowTemplate.Height = 24;
            this.ClicksTable.Size = new System.Drawing.Size(1216, 309);
            this.ClicksTable.TabIndex = 1;
            this.ClicksTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ClicksTable_CellBeginEdit);
            this.ClicksTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClicksTable_CellClick);
            this.ClicksTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClicksTable_CellValueChanged);
            this.ClicksTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ClicksTable_RowsAdded);
            this.ClicksTable.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ClicksTable_RowsRemoved);
            this.ClicksTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clicker_KeyDown);
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
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Interval
            // 
            this.Interval.HeaderText = "Interval";
            this.Interval.MinimumWidth = 6;
            this.Interval.Name = "Interval";
            this.Interval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TypeOfEvent
            // 
            this.TypeOfEvent.HeaderText = "Type of event";
            this.TypeOfEvent.MinimumWidth = 6;
            this.TypeOfEvent.Name = "TypeOfEvent";
            this.TypeOfEvent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeOfEvent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(12, 357);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(128, 48);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start\r\n[S]";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(1396, 484);
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
            this.ResetButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(12, 519);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(128, 48);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset\r\n[C]";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.Transparent;
            this.StatusBar.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(75, 24);
            this.StatusBar.Text = "StatusBar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar,
            this.LinesBar,
            this.WorkerBar,
            this.MousePosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 603);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1216, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LinesBar
            // 
            this.LinesBar.BackColor = System.Drawing.Color.Transparent;
            this.LinesBar.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.LinesBar.Name = "LinesBar";
            this.LinesBar.Size = new System.Drawing.Size(68, 24);
            this.LinesBar.Text = "LinesBar";
            // 
            // WorkerBar
            // 
            this.WorkerBar.BackColor = System.Drawing.Color.Transparent;
            this.WorkerBar.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.WorkerBar.Name = "WorkerBar";
            this.WorkerBar.Size = new System.Drawing.Size(91, 24);
            this.WorkerBar.Text = "ProgressBar";
            // 
            // MousePosition
            // 
            this.MousePosition.BackColor = System.Drawing.Color.Transparent;
            this.MousePosition.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.MousePosition.Name = "MousePosition";
            this.MousePosition.Size = new System.Drawing.Size(109, 24);
            this.MousePosition.Text = "MousePosition";
            // 
            // SetDelayButton
            // 
            this.SetDelayButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SetDelayButton.FlatAppearance.BorderSize = 0;
            this.SetDelayButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.SetDelayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDelayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetDelayButton.Location = new System.Drawing.Point(636, 357);
            this.SetDelayButton.Name = "SetDelayButton";
            this.SetDelayButton.Size = new System.Drawing.Size(128, 48);
            this.SetDelayButton.TabIndex = 12;
            this.SetDelayButton.Text = "[D] Set delay";
            this.SetDelayButton.UseVisualStyleBackColor = false;
            this.SetDelayButton.Click += new System.EventHandler(this.SetDelay_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(12, 465);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 48);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete\r\n[Delete]";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // JobsButton
            // 
            this.JobsButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.JobsButton.FlatAppearance.BorderSize = 0;
            this.JobsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JobsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobsButton.Location = new System.Drawing.Point(146, 465);
            this.JobsButton.Name = "JobsButton";
            this.JobsButton.Size = new System.Drawing.Size(128, 48);
            this.JobsButton.TabIndex = 9;
            this.JobsButton.Text = "Add ext. text\r\n[Shift+A]";
            this.JobsButton.UseVisualStyleBackColor = false;
            this.JobsButton.Click += new System.EventHandler(this.AddJobsButton_Click);
            // 
            // InsertTextComboBox
            // 
            this.InsertTextComboBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.InsertTextComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertTextComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertTextComboBox.FormattingEnabled = true;
            this.InsertTextComboBox.Location = new System.Drawing.Point(280, 357);
            this.InsertTextComboBox.Name = "InsertTextComboBox";
            this.InsertTextComboBox.Size = new System.Drawing.Size(283, 24);
            this.InsertTextComboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Extended text";
            // 
            // JobsComboBox
            // 
            this.JobsComboBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.JobsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JobsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsComboBox.FormattingEnabled = true;
            this.JobsComboBox.Location = new System.Drawing.Point(280, 465);
            this.JobsComboBox.Name = "JobsComboBox";
            this.JobsComboBox.Size = new System.Drawing.Size(283, 24);
            this.JobsComboBox.TabIndex = 11;
            // 
            // EditEmployeesButton
            // 
            this.EditEmployeesButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EditEmployeesButton.FlatAppearance.BorderSize = 0;
            this.EditEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditEmployeesButton.Location = new System.Drawing.Point(146, 411);
            this.EditEmployeesButton.Name = "EditEmployeesButton";
            this.EditEmployeesButton.Size = new System.Drawing.Size(128, 48);
            this.EditEmployeesButton.TabIndex = 5;
            this.EditEmployeesButton.Text = "Edit text\r\n[=]";
            this.EditEmployeesButton.UseVisualStyleBackColor = false;
            this.EditEmployeesButton.Click += new System.EventHandler(this.EditEmployeesButton_Click);
            // 
            // EditJobsButton
            // 
            this.EditJobsButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EditJobsButton.FlatAppearance.BorderSize = 0;
            this.EditJobsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditJobsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditJobsButton.Location = new System.Drawing.Point(146, 519);
            this.EditJobsButton.Name = "EditJobsButton";
            this.EditJobsButton.Size = new System.Drawing.Size(128, 48);
            this.EditJobsButton.TabIndex = 9;
            this.EditJobsButton.Text = "Edit ext. text\r\n[|]";
            this.EditJobsButton.UseVisualStyleBackColor = false;
            this.EditJobsButton.Click += new System.EventHandler(this.EditJobsButton_Click);
            // 
            // BWorker
            // 
            this.BWorker.WorkerReportsProgress = true;
            this.BWorker.WorkerSupportsCancellation = true;
            this.BWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWorker_DoWork);
            this.BWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWorker_ProgressChanged);
            this.BWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWorker_RunWorkerCompleted);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar.Location = new System.Drawing.Point(0, 580);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1216, 23);
            this.ProgressBar.TabIndex = 23;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(12, 411);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 48);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel\r\n[X]";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TestButton.FlatAppearance.BorderSize = 0;
            this.TestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestButton.Location = new System.Drawing.Point(1076, 353);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(128, 48);
            this.TestButton.TabIndex = 14;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // DelayBox
            // 
            this.DelayBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DelayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelayBox.Location = new System.Drawing.Point(770, 357);
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.Size = new System.Drawing.Size(128, 22);
            this.DelayBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(770, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Delay";
            // 
            // AddTextButton
            // 
            this.AddTextButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddTextButton.FlatAppearance.BorderSize = 0;
            this.AddTextButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AddTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTextButton.Location = new System.Drawing.Point(146, 357);
            this.AddTextButton.Name = "AddTextButton";
            this.AddTextButton.Size = new System.Drawing.Size(128, 48);
            this.AddTextButton.TabIndex = 3;
            this.AddTextButton.Text = "Add text\r\n[A]";
            this.AddTextButton.UseVisualStyleBackColor = false;
            this.AddTextButton.Click += new System.EventHandler(this.AddTextButton_Click);
            // 
            // ClickerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1216, 633);
            this.Controls.Add(this.AddTextButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DelayBox);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.EditJobsButton);
            this.Controls.Add(this.EditEmployeesButton);
            this.Controls.Add(this.JobsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertTextComboBox);
            this.Controls.Add(this.JobsButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SetDelayButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ClicksTable);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1234, 680);
            this.MinimumSize = new System.Drawing.Size(1234, 680);
            this.Name = "ClickerApp";
            this.Text = "Clicker App 1.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClickerApp_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clicker_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClicksTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridView ClicksTable;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip DelayBoxTooltip;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LinesBar;
        private System.Windows.Forms.Button SetDelayButton;
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
        private System.ComponentModel.BackgroundWorker BWorker;
        private new System.Windows.Forms.ToolStripStatusLabel MousePosition;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel WorkerBar;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.NumericUpDown DelayBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointID;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddTextButton;
    }
}

