namespace MainForm
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblControlService = new System.Windows.Forms.Label();
            this.btnStartControlService = new System.Windows.Forms.Button();
            this.btnStopControlService = new System.Windows.Forms.Button();
            this.lblControlServiceStatus = new System.Windows.Forms.Label();
            this.lblMockService = new System.Windows.Forms.Label();
            this.btnStartMockService = new System.Windows.Forms.Button();
            this.btnStopMockService = new System.Windows.Forms.Button();
            this.lblMockServiceStatus = new System.Windows.Forms.Label();
            this.lblAppPoolStatus = new System.Windows.Forms.Label();
            this.btnStartAppPool = new System.Windows.Forms.Button();
            this.btnStopAppPool = new System.Windows.Forms.Button();
            this.lblAppPoolStatusIndicator = new System.Windows.Forms.Label();
            this.cbControlServiceLogLevel = new System.Windows.Forms.ComboBox();
            this.cbMockServiceLogLevel = new System.Windows.Forms.ComboBox();
            this.cbWebApiLogLevel = new System.Windows.Forms.ComboBox();
            this.txtMockServiceFrequency = new System.Windows.Forms.TextBox();
            this.txtWebApiFrequency = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblControlServiceLogLevel = new System.Windows.Forms.Label();
            this.lblMockServiceLogLevel = new System.Windows.Forms.Label();
            this.lblWebApiLogLevel = new System.Windows.Forms.Label();
            this.lblMockServiceFrequency = new System.Windows.Forms.Label();
            this.lblWebApiFrequency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblControlService
            // 
            this.lblControlService.AutoSize = true;
            this.lblControlService.Location = new System.Drawing.Point(16, 18);
            this.lblControlService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlService.Name = "lblControlService";
            this.lblControlService.Size = new System.Drawing.Size(98, 16);
            this.lblControlService.TabIndex = 0;
            this.lblControlService.Text = "Control Service";
            // 
            // btnStartControlService
            // 
            this.btnStartControlService.Location = new System.Drawing.Point(20, 49);
            this.btnStartControlService.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartControlService.Name = "btnStartControlService";
            this.btnStartControlService.Size = new System.Drawing.Size(100, 28);
            this.btnStartControlService.TabIndex = 1;
            this.btnStartControlService.Text = "Başlat";
            this.btnStartControlService.UseVisualStyleBackColor = true;
            this.btnStartControlService.Click += new System.EventHandler(this.btnStartControlService_Click);
            // 
            // btnStopControlService
            // 
            this.btnStopControlService.Location = new System.Drawing.Point(128, 49);
            this.btnStopControlService.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopControlService.Name = "btnStopControlService";
            this.btnStopControlService.Size = new System.Drawing.Size(100, 28);
            this.btnStopControlService.TabIndex = 2;
            this.btnStopControlService.Text = "Durdur";
            this.btnStopControlService.UseVisualStyleBackColor = true;
            this.btnStopControlService.Click += new System.EventHandler(this.btnStopControlService_Click);
            // 
            // lblControlServiceStatus
            // 
            this.lblControlServiceStatus.AutoSize = true;
            this.lblControlServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlServiceStatus.Location = new System.Drawing.Point(236, 55);
            this.lblControlServiceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlServiceStatus.Name = "lblControlServiceStatus";
            this.lblControlServiceStatus.Size = new System.Drawing.Size(46, 18);
            this.lblControlServiceStatus.TabIndex = 3;
            this.lblControlServiceStatus.Text = "Status";
            // 
            // lblMockService
            // 
            this.lblMockService.AutoSize = true;
            this.lblMockService.Location = new System.Drawing.Point(16, 98);
            this.lblMockService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMockService.Name = "lblMockService";
            this.lblMockService.Size = new System.Drawing.Size(89, 16);
            this.lblMockService.TabIndex = 4;
            this.lblMockService.Text = "Mock Service";
            // 
            // btnStartMockService
            // 
            this.btnStartMockService.Location = new System.Drawing.Point(20, 129);
            this.btnStartMockService.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartMockService.Name = "btnStartMockService";
            this.btnStartMockService.Size = new System.Drawing.Size(100, 28);
            this.btnStartMockService.TabIndex = 5;
            this.btnStartMockService.Text = "Başlat";
            this.btnStartMockService.UseVisualStyleBackColor = true;
            this.btnStartMockService.Click += new System.EventHandler(this.btnStartMockService_Click);
            // 
            // btnStopMockService
            // 
            this.btnStopMockService.Location = new System.Drawing.Point(128, 129);
            this.btnStopMockService.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopMockService.Name = "btnStopMockService";
            this.btnStopMockService.Size = new System.Drawing.Size(100, 28);
            this.btnStopMockService.TabIndex = 6;
            this.btnStopMockService.Text = "Durdur";
            this.btnStopMockService.UseVisualStyleBackColor = true;
            this.btnStopMockService.Click += new System.EventHandler(this.btnStopMockService_Click);
            // 
            // lblMockServiceStatus
            // 
            this.lblMockServiceStatus.AutoSize = true;
            this.lblMockServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMockServiceStatus.Location = new System.Drawing.Point(236, 135);
            this.lblMockServiceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMockServiceStatus.Name = "lblMockServiceStatus";
            this.lblMockServiceStatus.Size = new System.Drawing.Size(46, 18);
            this.lblMockServiceStatus.TabIndex = 7;
            this.lblMockServiceStatus.Text = "Status";
            // 
            // lblAppPoolStatus
            // 
            this.lblAppPoolStatus.AutoSize = true;
            this.lblAppPoolStatus.Location = new System.Drawing.Point(16, 178);
            this.lblAppPoolStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppPoolStatus.Name = "lblAppPoolStatus";
            this.lblAppPoolStatus.Size = new System.Drawing.Size(91, 16);
            this.lblAppPoolStatus.TabIndex = 8;
            this.lblAppPoolStatus.Text = "Web API Pool";
            // 
            // btnStartAppPool
            // 
            this.btnStartAppPool.Location = new System.Drawing.Point(20, 209);
            this.btnStartAppPool.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartAppPool.Name = "btnStartAppPool";
            this.btnStartAppPool.Size = new System.Drawing.Size(100, 28);
            this.btnStartAppPool.TabIndex = 9;
            this.btnStartAppPool.Text = "Başlat";
            this.btnStartAppPool.UseVisualStyleBackColor = true;
            this.btnStartAppPool.Click += new System.EventHandler(this.btnStartAppPool_Click);
            // 
            // btnStopAppPool
            // 
            this.btnStopAppPool.Location = new System.Drawing.Point(128, 209);
            this.btnStopAppPool.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopAppPool.Name = "btnStopAppPool";
            this.btnStopAppPool.Size = new System.Drawing.Size(100, 28);
            this.btnStopAppPool.TabIndex = 10;
            this.btnStopAppPool.Text = "Durdur";
            this.btnStopAppPool.UseVisualStyleBackColor = true;
            this.btnStopAppPool.Click += new System.EventHandler(this.btnStopAppPool_Click);
            // 
            // lblAppPoolStatusIndicator
            // 
            this.lblAppPoolStatusIndicator.AutoSize = true;
            this.lblAppPoolStatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAppPoolStatusIndicator.Location = new System.Drawing.Point(236, 215);
            this.lblAppPoolStatusIndicator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppPoolStatusIndicator.Name = "lblAppPoolStatusIndicator";
            this.lblAppPoolStatusIndicator.Size = new System.Drawing.Size(46, 18);
            this.lblAppPoolStatusIndicator.TabIndex = 11;
            this.lblAppPoolStatusIndicator.Text = "Status";
            // 
            // cbControlServiceLogLevel
            // 
            this.cbControlServiceLogLevel.FormattingEnabled = true;
            this.cbControlServiceLogLevel.Location = new System.Drawing.Point(350, 49);
            this.cbControlServiceLogLevel.Name = "cbControlServiceLogLevel";
            this.cbControlServiceLogLevel.Size = new System.Drawing.Size(121, 24);
            this.cbControlServiceLogLevel.TabIndex = 12;
            // 
            // cbMockServiceLogLevel
            // 
            this.cbMockServiceLogLevel.FormattingEnabled = true;
            this.cbMockServiceLogLevel.Location = new System.Drawing.Point(350, 129);
            this.cbMockServiceLogLevel.Name = "cbMockServiceLogLevel";
            this.cbMockServiceLogLevel.Size = new System.Drawing.Size(121, 24);
            this.cbMockServiceLogLevel.TabIndex = 13;
            // 
            // cbWebApiLogLevel
            // 
            this.cbWebApiLogLevel.FormattingEnabled = true;
            this.cbWebApiLogLevel.Location = new System.Drawing.Point(350, 209);
            this.cbWebApiLogLevel.Name = "cbWebApiLogLevel";
            this.cbWebApiLogLevel.Size = new System.Drawing.Size(121, 24);
            this.cbWebApiLogLevel.TabIndex = 14;
            // 
            // txtMockServiceFrequency
            // 
            this.txtMockServiceFrequency.Location = new System.Drawing.Point(500, 130);
            this.txtMockServiceFrequency.Name = "txtMockServiceFrequency";
            this.txtMockServiceFrequency.Size = new System.Drawing.Size(100, 22);
            this.txtMockServiceFrequency.TabIndex = 15;
            // 
            // txtWebApiFrequency
            // 
            this.txtWebApiFrequency.Location = new System.Drawing.Point(500, 210);
            this.txtWebApiFrequency.Name = "txtWebApiFrequency";
            this.txtWebApiFrequency.Size = new System.Drawing.Size(100, 22);
            this.txtWebApiFrequency.TabIndex = 16;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(500, 49);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(100, 28);
            this.btnSaveSettings.TabIndex = 17;
            this.btnSaveSettings.Text = "Ayarları Kaydet";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblControlServiceLogLevel
            // 
            this.lblControlServiceLogLevel.AutoSize = true;
            this.lblControlServiceLogLevel.Location = new System.Drawing.Point(347, 30);
            this.lblControlServiceLogLevel.Name = "lblControlServiceLogLevel";
            this.lblControlServiceLogLevel.Size = new System.Drawing.Size(160, 16);
            this.lblControlServiceLogLevel.TabIndex = 18;
            this.lblControlServiceLogLevel.Text = "Control Service Log Level";
            // 
            // lblMockServiceLogLevel
            // 
            this.lblMockServiceLogLevel.AutoSize = true;
            this.lblMockServiceLogLevel.Location = new System.Drawing.Point(347, 110);
            this.lblMockServiceLogLevel.Name = "lblMockServiceLogLevel";
            this.lblMockServiceLogLevel.Size = new System.Drawing.Size(151, 16);
            this.lblMockServiceLogLevel.TabIndex = 19;
            this.lblMockServiceLogLevel.Text = "Mock Service Log Level";
            // 
            // lblWebApiLogLevel
            // 
            this.lblWebApiLogLevel.AutoSize = true;
            this.lblWebApiLogLevel.Location = new System.Drawing.Point(347, 190);
            this.lblWebApiLogLevel.Name = "lblWebApiLogLevel";
            this.lblWebApiLogLevel.Size = new System.Drawing.Size(122, 16);
            this.lblWebApiLogLevel.TabIndex = 20;
            this.lblWebApiLogLevel.Text = "Web API Log Level";
            // 
            // lblMockServiceFrequency
            // 
            this.lblMockServiceFrequency.AutoSize = true;
            this.lblMockServiceFrequency.Location = new System.Drawing.Point(497, 110);
            this.lblMockServiceFrequency.Name = "lblMockServiceFrequency";
            this.lblMockServiceFrequency.Size = new System.Drawing.Size(156, 16);
            this.lblMockServiceFrequency.TabIndex = 21;
            this.lblMockServiceFrequency.Text = "Mock Service Frequency";
            // 
            // lblWebApiFrequency
            // 
            this.lblWebApiFrequency.AutoSize = true;
            this.lblWebApiFrequency.Location = new System.Drawing.Point(497, 190);
            this.lblWebApiFrequency.Name = "lblWebApiFrequency";
            this.lblWebApiFrequency.Size = new System.Drawing.Size(127, 16);
            this.lblWebApiFrequency.TabIndex = 22;
            this.lblWebApiFrequency.Text = "Web API Frequency";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 260);
            this.Controls.Add(this.lblWebApiFrequency);
            this.Controls.Add(this.lblMockServiceFrequency);
            this.Controls.Add(this.lblWebApiLogLevel);
            this.Controls.Add(this.lblMockServiceLogLevel);
            this.Controls.Add(this.lblControlServiceLogLevel);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.txtWebApiFrequency);
            this.Controls.Add(this.txtMockServiceFrequency);
            this.Controls.Add(this.cbWebApiLogLevel);
            this.Controls.Add(this.cbMockServiceLogLevel);
            this.Controls.Add(this.cbControlServiceLogLevel);
            this.Controls.Add(this.lblAppPoolStatusIndicator);
            this.Controls.Add(this.btnStopAppPool);
            this.Controls.Add(this.btnStartAppPool);
            this.Controls.Add(this.lblAppPoolStatus);
            this.Controls.Add(this.lblMockServiceStatus);
            this.Controls.Add(this.btnStopMockService);
            this.Controls.Add(this.btnStartMockService);
            this.Controls.Add(this.lblMockService);
            this.Controls.Add(this.lblControlServiceStatus);
            this.Controls.Add(this.btnStopControlService);
            this.Controls.Add(this.btnStartControlService);
            this.Controls.Add(this.lblControlService);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Service Controller";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblControlService;
        private System.Windows.Forms.Button btnStartControlService;
        private System.Windows.Forms.Button btnStopControlService;
        private System.Windows.Forms.Label lblControlServiceStatus;
        private System.Windows.Forms.Label lblMockService;
        private System.Windows.Forms.Button btnStartMockService;
        private System.Windows.Forms.Button btnStopMockService;
        private System.Windows.Forms.Label lblMockServiceStatus;
        private System.Windows.Forms.Label lblAppPoolStatus;
        private System.Windows.Forms.Button btnStartAppPool;
        private System.Windows.Forms.Button btnStopAppPool;
        private System.Windows.Forms.Label lblAppPoolStatusIndicator;
        private System.Windows.Forms.ComboBox cbControlServiceLogLevel;
        private System.Windows.Forms.ComboBox cbMockServiceLogLevel;
        private System.Windows.Forms.ComboBox cbWebApiLogLevel;
        private System.Windows.Forms.TextBox txtMockServiceFrequency;
        private System.Windows.Forms.TextBox txtWebApiFrequency;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblControlServiceLogLevel;
        private System.Windows.Forms.Label lblMockServiceLogLevel;
        private System.Windows.Forms.Label lblWebApiLogLevel;
        private System.Windows.Forms.Label lblMockServiceFrequency;
        private System.Windows.Forms.Label lblWebApiFrequency;
    }
}
