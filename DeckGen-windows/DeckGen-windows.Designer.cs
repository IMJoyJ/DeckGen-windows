namespace DeckGen_windows
{
    partial class formDeckGenWindows
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowseCdb = new System.Windows.Forms.Button();
            this.txtCdb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLfList = new System.Windows.Forms.TextBox();
            this.btnBrowseLfList = new System.Windows.Forms.Button();
            this.numMain = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numEx = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numYdkMain = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numYdkEx = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numYdkNum = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.ofdCdb = new System.Windows.Forms.OpenFileDialog();
            this.ofdLfList = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYdkMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYdkEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYdkNum)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseCdb
            // 
            this.btnBrowseCdb.Location = new System.Drawing.Point(335, 12);
            this.btnBrowseCdb.Name = "btnBrowseCdb";
            this.btnBrowseCdb.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseCdb.TabIndex = 0;
            this.btnBrowseCdb.Text = "浏览...";
            this.btnBrowseCdb.UseVisualStyleBackColor = true;
            // 
            // txtCdb
            // 
            this.txtCdb.AllowDrop = true;
            this.txtCdb.Location = new System.Drawing.Point(89, 14);
            this.txtCdb.Name = "txtCdb";
            this.txtCdb.Size = new System.Drawing.Size(240, 21);
            this.txtCdb.TabIndex = 1;
            this.txtCdb.DragDrop += new System.Windows.Forms.DragEventHandler(this.Global_DragDrop);
            this.txtCdb.DragEnter += new System.Windows.Forms.DragEventHandler(this.Global_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "cards.cdb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "lflist.conf";
            // 
            // txtLfList
            // 
            this.txtLfList.AllowDrop = true;
            this.txtLfList.Location = new System.Drawing.Point(89, 41);
            this.txtLfList.Name = "txtLfList";
            this.txtLfList.Size = new System.Drawing.Size(240, 21);
            this.txtLfList.TabIndex = 4;
            this.txtLfList.DragDrop += new System.Windows.Forms.DragEventHandler(this.Global_DragDrop);
            this.txtLfList.DragEnter += new System.Windows.Forms.DragEventHandler(this.Global_DragEnter);
            // 
            // btnBrowseLfList
            // 
            this.btnBrowseLfList.Location = new System.Drawing.Point(335, 39);
            this.btnBrowseLfList.Name = "btnBrowseLfList";
            this.btnBrowseLfList.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLfList.TabIndex = 3;
            this.btnBrowseLfList.Text = "浏览...";
            this.btnBrowseLfList.UseVisualStyleBackColor = true;
            // 
            // numMain
            // 
            this.numMain.Location = new System.Drawing.Point(203, 68);
            this.numMain.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMain.Name = "numMain";
            this.numMain.Size = new System.Drawing.Size(207, 21);
            this.numMain.TabIndex = 6;
            this.numMain.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "选取可以加入主卡组的卡的数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "选取可以加入额外卡组的卡的数量";
            // 
            // numEx
            // 
            this.numEx.Location = new System.Drawing.Point(203, 95);
            this.numEx.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numEx.Name = "numEx";
            this.numEx.Size = new System.Drawing.Size(207, 21);
            this.numEx.TabIndex = 8;
            this.numEx.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "生成的每个ydk的主卡组数量";
            // 
            // numYdkMain
            // 
            this.numYdkMain.Location = new System.Drawing.Point(203, 122);
            this.numYdkMain.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numYdkMain.Name = "numYdkMain";
            this.numYdkMain.Size = new System.Drawing.Size(207, 21);
            this.numYdkMain.TabIndex = 10;
            this.numYdkMain.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "生成的每个ydk的额外卡组数量";
            // 
            // numYdkEx
            // 
            this.numYdkEx.Location = new System.Drawing.Point(203, 149);
            this.numYdkEx.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numYdkEx.Name = "numYdkEx";
            this.numYdkEx.Size = new System.Drawing.Size(207, 21);
            this.numYdkEx.TabIndex = 12;
            this.numYdkEx.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "生成ydk的数量上限";
            // 
            // numYdkNum
            // 
            this.numYdkNum.Location = new System.Drawing.Point(203, 176);
            this.numYdkNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numYdkNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYdkNum.Name = "numYdkNum";
            this.numYdkNum.Size = new System.Drawing.Size(207, 21);
            this.numYdkNum.TabIndex = 14;
            this.numYdkNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(335, 204);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 42);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip.Location = new System.Drawing.Point(0, 255);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(422, 22);
            this.statusStrip.TabIndex = 17;
            this.statusStrip.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(32, 17);
            this.status.Text = "就绪";
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // ofdCdb
            // 
            this.ofdCdb.FileName = "cards.cdb";
            this.ofdCdb.Filter = "CDB 文件|*.cdb|所有文件|*.*";
            // 
            // ofdLfList
            // 
            this.ofdLfList.FileName = "lflist.conf";
            this.ofdLfList.Filter = "CONF 文件|*.conf|所有文件|*.*";
            // 
            // formDeckGenWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 277);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numYdkNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numYdkEx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numYdkMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLfList);
            this.Controls.Add(this.btnBrowseLfList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCdb);
            this.Controls.Add(this.btnBrowseCdb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formDeckGenWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeckGen-windows by JoyJ v1.0";
            this.Load += new System.EventHandler(this.formDeckGenWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYdkMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYdkEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYdkNum)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseCdb;
        private System.Windows.Forms.TextBox txtCdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLfList;
        private System.Windows.Forms.Button btnBrowseLfList;
        private System.Windows.Forms.NumericUpDown numMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numEx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numYdkMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numYdkEx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numYdkNum;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.OpenFileDialog ofdCdb;
        private System.Windows.Forms.OpenFileDialog ofdLfList;
    }
}

