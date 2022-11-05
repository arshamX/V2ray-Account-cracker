namespace V2ray_Account_cracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBott = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblcheck = new System.Windows.Forms.Label();
            this.lblGoods = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.nudThreads = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblThread = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panelBott.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
            this.panel7.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBott
            // 
            this.panelBott.Controls.Add(this.btnStop);
            this.panelBott.Controls.Add(this.btnStart);
            this.panelBott.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBott.Location = new System.Drawing.Point(0, 192);
            this.panelBott.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBott.Name = "panelBott";
            this.panelBott.Size = new System.Drawing.Size(507, 32);
            this.panelBott.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStop.Location = new System.Drawing.Point(343, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(82, 32);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStart.Location = new System.Drawing.Point(425, 0);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid.Location = new System.Drawing.Point(0, 58);
            this.datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 29;
            this.datagrid.Size = new System.Drawing.Size(507, 134);
            this.datagrid.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblcheck);
            this.panel3.Controls.Add(this.lblGoods);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.lblCount);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(191, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 58);
            this.panel3.TabIndex = 2;
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblcheck.Location = new System.Drawing.Point(164, 14);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(68, 15);
            this.lblcheck.TabIndex = 5;
            this.lblcheck.Text = "Checked : 0";
            // 
            // lblGoods
            // 
            this.lblGoods.AutoSize = true;
            this.lblGoods.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGoods.Location = new System.Drawing.Point(108, 14);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(56, 15);
            this.lblGoods.TabIndex = 4;
            this.lblGoods.Text = "Goods : 0";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(37, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status : IDLE";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCount.Location = new System.Drawing.Point(0, 14);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(37, 15);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "IPs : 0";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 34);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(316, 24);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 14);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.nudThreads);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(71, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 58);
            this.panel6.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 36);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(120, 22);
            this.panel8.TabIndex = 3;
            // 
            // nudThreads
            // 
            this.nudThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudThreads.Location = new System.Drawing.Point(0, 16);
            this.nudThreads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudThreads.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreads.Name = "nudThreads";
            this.nudThreads.Size = new System.Drawing.Size(120, 23);
            this.nudThreads.TabIndex = 2;
            this.nudThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreads.ValueChanged += new System.EventHandler(this.nudThreads_ValueChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblThread);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 16);
            this.panel7.TabIndex = 0;
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.BackColor = System.Drawing.Color.Transparent;
            this.lblThread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThread.Location = new System.Drawing.Point(0, 0);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(77, 15);
            this.lblThread.TabIndex = 0;
            this.lblThread.Text = "Thread count";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnLoad);
            this.panelTop.Controls.Add(this.panel6);
            this.panelTop.Controls.Add(this.panel3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(507, 58);
            this.panelTop.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoad.Location = new System.Drawing.Point(0, 0);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(72, 58);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 224);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBott);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "V2ray Cracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panelBott.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBott;
        private Button btnStop;
        private Button btnStart;
        private DataGridView datagrid;
        private Panel panel3;
        private Label lblcheck;
        private Label lblGoods;
        private Label lblStatus;
        private Label lblCount;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Panel panel8;
        private NumericUpDown nudThreads;
        private Panel panel7;
        private Label lblThread;
        private Panel panelTop;
        private Button btnLoad;
    }
}