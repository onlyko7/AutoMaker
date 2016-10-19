namespace AutoMaker
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCapture = new System.Windows.Forms.Button();
            this.pnlMonitor = new System.Windows.Forms.Panel();
            this.picMonitor = new System.Windows.Forms.PictureBox();
            this.picSubMonitor = new System.Windows.Forms.PictureBox();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.작업폴더열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로젝트저장CtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHome = new System.Windows.Forms.Label();
            this.프로젝트열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubMonitor)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCapture
            // 
            this.btCapture.Location = new System.Drawing.Point(314, 456);
            this.btCapture.Name = "btCapture";
            this.btCapture.Size = new System.Drawing.Size(94, 23);
            this.btCapture.TabIndex = 0;
            this.btCapture.Text = "Capture(F5)";
            this.btCapture.UseVisualStyleBackColor = true;
            this.btCapture.Click += new System.EventHandler(this.btCapture_Click);
            // 
            // pnlMonitor
            // 
            this.pnlMonitor.AutoScroll = true;
            this.pnlMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMonitor.Controls.Add(this.picMonitor);
            this.pnlMonitor.Location = new System.Drawing.Point(314, 27);
            this.pnlMonitor.Name = "pnlMonitor";
            this.pnlMonitor.Size = new System.Drawing.Size(640, 423);
            this.pnlMonitor.TabIndex = 2;
            // 
            // picMonitor
            // 
            this.picMonitor.Location = new System.Drawing.Point(3, 3);
            this.picMonitor.Name = "picMonitor";
            this.picMonitor.Size = new System.Drawing.Size(360, 184);
            this.picMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMonitor.TabIndex = 1;
            this.picMonitor.TabStop = false;
            this.picMonitor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMonitor_MouseDown);
            this.picMonitor.MouseEnter += new System.EventHandler(this.picMonitor_MouseEnter);
            this.picMonitor.MouseLeave += new System.EventHandler(this.picMonitor_MouseLeave);
            this.picMonitor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMonitor_MouseMove);
            this.picMonitor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picMonitor_MouseUp);
            // 
            // picSubMonitor
            // 
            this.picSubMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSubMonitor.Location = new System.Drawing.Point(854, 467);
            this.picSubMonitor.Name = "picSubMonitor";
            this.picSubMonitor.Size = new System.Drawing.Size(100, 103);
            this.picSubMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSubMonitor.TabIndex = 3;
            this.picSubMonitor.TabStop = false;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(777, 467);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(21, 12);
            this.x.TabIndex = 4;
            this.x.Text = "X :";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(777, 490);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(21, 12);
            this.y.TabIndex = 5;
            this.y.Text = "Y :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.propertyGrid);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 543);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(286, 215);
            this.propertyGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.작업폴더열기ToolStripMenuItem,
            this.프로젝트열기ToolStripMenuItem,
            this.프로젝트저장CtrlSToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // 작업폴더열기ToolStripMenuItem
            // 
            this.작업폴더열기ToolStripMenuItem.Name = "작업폴더열기ToolStripMenuItem";
            this.작업폴더열기ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.작업폴더열기ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.작업폴더열기ToolStripMenuItem.Text = "작업폴더 열기";
            this.작업폴더열기ToolStripMenuItem.Click += new System.EventHandler(this.작업폴더열기ToolStripMenuItem_Click);
            // 
            // 프로젝트저장CtrlSToolStripMenuItem
            // 
            this.프로젝트저장CtrlSToolStripMenuItem.Name = "프로젝트저장CtrlSToolStripMenuItem";
            this.프로젝트저장CtrlSToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            this.프로젝트저장CtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.프로젝트저장CtrlSToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.프로젝트저장CtrlSToolStripMenuItem.Text = "프로젝트 저장";
            this.프로젝트저장CtrlSToolStripMenuItem.Click += new System.EventHandler(this.프로젝트저장CtrlSToolStripMenuItem_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(414, 461);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(77, 12);
            this.lblHome.TabIndex = 8;
            this.lblHome.Text = "작업디렉토리";
            // 
            // 프로젝트열기ToolStripMenuItem
            // 
            this.프로젝트열기ToolStripMenuItem.Name = "프로젝트열기ToolStripMenuItem";
            this.프로젝트열기ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.프로젝트열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.프로젝트열기ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.프로젝트열기ToolStripMenuItem.Text = "프로젝트 열기";
            this.프로젝트열기ToolStripMenuItem.Click += new System.EventHandler(this.프로젝트열기ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 596);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.picSubMonitor);
            this.Controls.Add(this.pnlMonitor);
            this.Controls.Add(this.btCapture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "AutoMaker v0.1b";
            this.pnlMonitor.ResumeLayout(false);
            this.pnlMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubMonitor)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCapture;
        private System.Windows.Forms.Panel pnlMonitor;
        private System.Windows.Forms.PictureBox picMonitor;
        private System.Windows.Forms.PictureBox picSubMonitor;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 작업폴더열기ToolStripMenuItem;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.ToolStripMenuItem 프로젝트저장CtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로젝트열기ToolStripMenuItem;
    }
}

