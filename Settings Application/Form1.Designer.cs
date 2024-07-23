namespace MonitoringService
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.ComboBox comboBoxLogLevel;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Button buttonUpdateInterval;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.buttonUpdateInterval = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.RowHeadersWidth = 51;
            this.dataGridViewLogs.RowTemplate.Height = 24;
            this.dataGridViewLogs.Size = new System.Drawing.Size(776, 350);
            this.dataGridViewLogs.TabIndex = 0;
            // 
            // comboBoxLogLevel
            // 
            this.comboBoxLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogLevel.FormattingEnabled = true;
            this.comboBoxLogLevel.Items.AddRange(new object[] {
            "All",
            "TRACE",
            "DEBUG",
            "INFO",
            "WARN",
            "ERROR",
            "FATAL"});
            this.comboBoxLogLevel.Location = new System.Drawing.Point(12, 379);
            this.comboBoxLogLevel.Name = "comboBoxLogLevel";
            this.comboBoxLogLevel.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLogLevel.TabIndex = 1;
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(150, 380);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(100, 22);
            this.textBoxInterval.TabIndex = 2;
            // 
            // buttonUpdateInterval
            // 
            this.buttonUpdateInterval.Location = new System.Drawing.Point(270, 379);
            this.buttonUpdateInterval.Name = "buttonUpdateInterval";
            this.buttonUpdateInterval.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateInterval.TabIndex = 3;
            this.buttonUpdateInterval.Text = "Update";
            this.buttonUpdateInterval.UseVisualStyleBackColor = true;
            this.buttonUpdateInterval.Click += new System.EventHandler(this.buttonUpdateInterval_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateInterval);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.comboBoxLogLevel);
            this.Controls.Add(this.dataGridViewLogs);
            this.Name = "Form1";
            this.Text = "Log Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
