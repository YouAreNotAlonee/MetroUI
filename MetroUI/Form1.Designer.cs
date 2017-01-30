namespace MetroUI
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTap = new MetroFramework.Controls.MetroTabControl();
            this.PlayList = new MetroFramework.Controls.MetroTabPage();
            this.Setting = new MetroFramework.Controls.MetroTabPage();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.metroTrackBar2 = new MetroFramework.Controls.MetroTrackBar();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.Map = new System.Windows.Forms.TabPage();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTap.SuspendLayout();
            this.PlayList.SuspendLayout();
            this.Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(7, 18);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(800, 400);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(7, 424);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(800, 20);
            this.metroTrackBar1.TabIndex = 1;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Value = 10;
            // 
            // metroTap
            // 
            this.metroTap.Controls.Add(this.PlayList);
            this.metroTap.Controls.Add(this.Map);
            this.metroTap.Controls.Add(this.Setting);
            this.metroTap.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTap.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTap.ItemSize = new System.Drawing.Size(50, 50);
            this.metroTap.Location = new System.Drawing.Point(820, 32);
            this.metroTap.Name = "metroTap";
            this.metroTap.SelectedIndex = 0;
            this.metroTap.Size = new System.Drawing.Size(250, 500);
            this.metroTap.TabIndex = 2;
            this.metroTap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTap.UseSelectable = true;
            // 
            // PlayList
            // 
            this.PlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayList.Controls.Add(this.metroListView1);
            this.PlayList.HorizontalScrollbarBarColor = true;
            this.PlayList.HorizontalScrollbarHighlightOnWheel = false;
            this.PlayList.HorizontalScrollbarSize = 10;
            this.PlayList.Location = new System.Drawing.Point(4, 54);
            this.PlayList.Name = "PlayList";
            this.PlayList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlayList.Size = new System.Drawing.Size(242, 442);
            this.PlayList.TabIndex = 0;
            this.PlayList.Text = "PlayList";
            this.PlayList.VerticalScrollbarBarColor = true;
            this.PlayList.VerticalScrollbarHighlightOnWheel = false;
            this.PlayList.VerticalScrollbarSize = 10;
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.metroCheckBox1);
            this.Setting.Controls.Add(this.metroToggle2);
            this.Setting.Controls.Add(this.metroLabel3);
            this.Setting.Controls.Add(this.metroToggle1);
            this.Setting.Controls.Add(this.metroLabel2);
            this.Setting.Controls.Add(this.metroRadioButton3);
            this.Setting.Controls.Add(this.metroRadioButton2);
            this.Setting.Controls.Add(this.metroRadioButton1);
            this.Setting.Controls.Add(this.metroLabel1);
            this.Setting.HorizontalScrollbarBarColor = true;
            this.Setting.HorizontalScrollbarHighlightOnWheel = false;
            this.Setting.HorizontalScrollbarSize = 10;
            this.Setting.Location = new System.Drawing.Point(4, 54);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(268, 442);
            this.Setting.TabIndex = 1;
            this.Setting.Text = "Setting";
            this.Setting.VerticalScrollbarBarColor = true;
            this.Setting.VerticalScrollbarHighlightOnWheel = false;
            this.Setting.VerticalScrollbarSize = 10;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem29,
            listViewItem30});
            this.metroListView1.Location = new System.Drawing.Point(3, 17);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(240, 400);
            this.metroListView1.TabIndex = 1;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton5.BackgroundImage")));
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton5.Location = new System.Drawing.Point(820, 538);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(40, 40);
            this.metroButton5.TabIndex = 7;
            this.metroButton5.UseSelectable = true;
            // 
            // metroButton6
            // 
            this.metroButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton6.BackgroundImage")));
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton6.Location = new System.Drawing.Point(879, 538);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(40, 40);
            this.metroButton6.TabIndex = 8;
            this.metroButton6.UseSelectable = true;
            // 
            // metroButton7
            // 
            this.metroButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton7.BackgroundImage")));
            this.metroButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton7.Location = new System.Drawing.Point(934, 538);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(40, 40);
            this.metroButton7.TabIndex = 9;
            this.metroButton7.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(3, 45);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton1.TabIndex = 3;
            this.metroRadioButton1.Text = "metroRadioButton1";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(3, 66);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton2.TabIndex = 4;
            this.metroRadioButton2.Text = "metroRadioButton2";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(3, 87);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton3.TabIndex = 5;
            this.metroRadioButton3.Text = "metroRadioButton3";
            this.metroRadioButton3.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "metroLabel2";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(6, 174);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 16);
            this.metroToggle1.TabIndex = 7;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(151, 136);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "metroLabel3";
            // 
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.Location = new System.Drawing.Point(151, 174);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(80, 16);
            this.metroToggle2.TabIndex = 9;
            this.metroToggle2.Text = "Off";
            this.metroToggle2.UseSelectable = true;
            // 
            // metroTrackBar2
            // 
            this.metroTrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar2.Location = new System.Drawing.Point(732, 447);
            this.metroTrackBar2.Name = "metroTrackBar2";
            this.metroTrackBar2.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBar2.TabIndex = 11;
            this.metroTrackBar2.Text = "metroTrackBar2";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(6, 232);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox1.TabIndex = 10;
            this.metroCheckBox1.Text = "metroCheckBox1";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroButton8
            // 
            this.metroButton8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton8.BackgroundImage")));
            this.metroButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton8.Location = new System.Drawing.Point(603, 437);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(40, 40);
            this.metroButton8.TabIndex = 12;
            this.metroButton8.UseSelectable = true;
            // 
            // metroButton9
            // 
            this.metroButton9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton9.BackgroundImage")));
            this.metroButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton9.Location = new System.Drawing.Point(557, 437);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(40, 40);
            this.metroButton9.TabIndex = 13;
            this.metroButton9.UseSelectable = true;
            // 
            // metroButton10
            // 
            this.metroButton10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton10.BackgroundImage")));
            this.metroButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton10.Location = new System.Drawing.Point(649, 437);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(40, 40);
            this.metroButton10.TabIndex = 14;
            this.metroButton10.UseSelectable = true;
            // 
            // Map
            // 
            this.Map.Location = new System.Drawing.Point(4, 54);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(268, 442);
            this.Map.TabIndex = 2;
            this.Map.Text = "Map";
            // 
            // metroButton11
            // 
            this.metroButton11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton11.BackgroundImage")));
            this.metroButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton11.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton11.Location = new System.Drawing.Point(511, 437);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(40, 40);
            this.metroButton11.TabIndex = 15;
            this.metroButton11.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(695, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(985, 538);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(40, 40);
            this.metroButton1.TabIndex = 17;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(1039, 538);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(40, 40);
            this.metroButton2.TabIndex = 18;
            this.metroButton2.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton11);
            this.Controls.Add(this.metroButton10);
            this.Controls.Add(this.metroButton9);
            this.Controls.Add(this.metroButton8);
            this.Controls.Add(this.metroTrackBar2);
            this.Controls.Add(this.metroButton7);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroTap);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.metroTap.ResumeLayout(false);
            this.PlayList.ResumeLayout(false);
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroTabControl metroTap;
        private MetroFramework.Controls.MetroTabPage PlayList;
        private MetroFramework.Controls.MetroTabPage Setting;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar2;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroButton metroButton10;
        private System.Windows.Forms.TabPage Map;
        private MetroFramework.Controls.MetroButton metroButton11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}

