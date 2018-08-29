namespace hands_viewer.cs
{
    partial class MainForm
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
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Live = new System.Windows.Forms.ToolStripMenuItem();
            this.Playback = new System.Windows.Forms.ToolStripMenuItem();
            this.Record = new System.Windows.Forms.ToolStripMenuItem();
            this.Depth = new System.Windows.Forms.RadioButton();
            this.Labelmap = new System.Windows.Forms.RadioButton();
            this.Status2 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Scale2 = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.PictureBox();
            this.Mirror = new System.Windows.Forms.CheckBox();
            this.cmbGesturesList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFPS = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.ContourCheckBox = new System.Windows.Forms.CheckBox();
            this.ImageGroupBox = new System.Windows.Forms.GroupBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.TrackingModeGroupBox = new System.Windows.Forms.GroupBox();
            this.Extremities = new System.Windows.Forms.CheckBox();
            this.Skeleton = new System.Windows.Forms.CheckBox();
            this.Joints = new System.Windows.Forms.CheckBox();
            this.FullHandMode = new System.Windows.Forms.RadioButton();
            this.MainMenu.SuspendLayout();
            this.Status2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).BeginInit();
            this.ImageGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.TrackingModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.BackColor = System.Drawing.Color.Azure;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.Location = new System.Drawing.Point(440, 417);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(80, 28);
            this.Start.TabIndex = 2;
            this.Start.Text = "启   动";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Stop.Enabled = false;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stop.Location = new System.Drawing.Point(440, 459);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(80, 27);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "停   止";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.sourceToolStripMenuItem.Text = "硬件";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(601, 25);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Live,
            this.Playback,
            this.Record});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.modeToolStripMenuItem.Text = "模式";
            // 
            // Live
            // 
            this.Live.Checked = true;
            this.Live.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Live.Name = "Live";
            this.Live.Size = new System.Drawing.Size(100, 22);
            this.Live.Text = "直播";
            this.Live.Click += new System.EventHandler(this.Live_Click);
            // 
            // Playback
            // 
            this.Playback.Name = "Playback";
            this.Playback.Size = new System.Drawing.Size(100, 22);
            this.Playback.Text = "回放";
            this.Playback.Click += new System.EventHandler(this.Playback_Click);
            // 
            // Record
            // 
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(100, 22);
            this.Record.Text = "录制";
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Depth
            // 
            this.Depth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Depth.AutoSize = true;
            this.Depth.Checked = true;
            this.Depth.Location = new System.Drawing.Point(10, 18);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(71, 16);
            this.Depth.TabIndex = 20;
            this.Depth.TabStop = true;
            this.Depth.Text = "深度图像";
            this.Depth.UseVisualStyleBackColor = true;
            this.Depth.CheckedChanged += new System.EventHandler(this.Depth_CheckedChanged);
            // 
            // Labelmap
            // 
            this.Labelmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Labelmap.AutoSize = true;
            this.Labelmap.Location = new System.Drawing.Point(10, 38);
            this.Labelmap.Name = "Labelmap";
            this.Labelmap.Size = new System.Drawing.Size(71, 16);
            this.Labelmap.TabIndex = 21;
            this.Labelmap.Text = "标注图像";
            this.Labelmap.UseVisualStyleBackColor = true;
            this.Labelmap.CheckedChanged += new System.EventHandler(this.Labelmap_CheckedChanged);
            // 
            // Status2
            // 
            this.Status2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.Status2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Status2.Location = new System.Drawing.Point(0, 538);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(601, 22);
            this.Status2.SizingGrip = false;
            this.Status2.TabIndex = 25;
            this.Status2.Text = "Status2";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(26, 17);
            this.StatusLabel.Text = "OK";
            // 
            // Scale2
            // 
            this.Scale2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Scale2.AutoSize = true;
            this.Scale2.Checked = true;
            this.Scale2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Scale2.Location = new System.Drawing.Point(13, 18);
            this.Scale2.Name = "Scale2";
            this.Scale2.Size = new System.Drawing.Size(60, 16);
            this.Scale2.TabIndex = 26;
            this.Scale2.Text = "比例尺";
            this.Scale2.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.ErrorImage = null;
            this.Panel2.InitialImage = null;
            this.Panel2.Location = new System.Drawing.Point(24, 31);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(400, 304);
            this.Panel2.TabIndex = 27;
            this.Panel2.TabStop = false;
            // 
            // Mirror
            // 
            this.Mirror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mirror.AutoSize = true;
            this.Mirror.Checked = true;
            this.Mirror.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Mirror.Location = new System.Drawing.Point(13, 38);
            this.Mirror.Name = "Mirror";
            this.Mirror.Size = new System.Drawing.Size(72, 16);
            this.Mirror.TabIndex = 30;
            this.Mirror.Text = "镜像画面";
            this.Mirror.UseVisualStyleBackColor = true;
            // 
            // cmbGesturesList
            // 
            this.cmbGesturesList.AllowDrop = true;
            this.cmbGesturesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGesturesList.DropDownHeight = 800;
            this.cmbGesturesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbGesturesList.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGesturesList.FormattingEnabled = true;
            this.cmbGesturesList.IntegralHeight = false;
            this.cmbGesturesList.Location = new System.Drawing.Point(440, 334);
            this.cmbGesturesList.Name = "cmbGesturesList";
            this.cmbGesturesList.Size = new System.Drawing.Size(142, 23);
            this.cmbGesturesList.TabIndex = 35;
            this.cmbGesturesList.SelectedIndexChanged += new System.EventHandler(this.cmbGesturesList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "手势识别:";
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Location = new System.Drawing.Point(440, 491);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(0, 12);
            this.labelFPS.TabIndex = 39;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTextBox.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTextBox.Location = new System.Drawing.Point(24, 345);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(400, 177);
            this.infoTextBox.TabIndex = 40;
            this.infoTextBox.Text = "";
            // 
            // ContourCheckBox
            // 
            this.ContourCheckBox.AutoSize = true;
            this.ContourCheckBox.Checked = true;
            this.ContourCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ContourCheckBox.Enabled = false;
            this.ContourCheckBox.Location = new System.Drawing.Point(10, 58);
            this.ContourCheckBox.Name = "ContourCheckBox";
            this.ContourCheckBox.Size = new System.Drawing.Size(60, 16);
            this.ContourCheckBox.TabIndex = 41;
            this.ContourCheckBox.Text = "手轮廓";
            this.ContourCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImageGroupBox
            // 
            this.ImageGroupBox.Controls.Add(this.Depth);
            this.ImageGroupBox.Controls.Add(this.Labelmap);
            this.ImageGroupBox.Controls.Add(this.ContourCheckBox);
            this.ImageGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ImageGroupBox.Location = new System.Drawing.Point(440, 31);
            this.ImageGroupBox.Name = "ImageGroupBox";
            this.ImageGroupBox.Size = new System.Drawing.Size(142, 88);
            this.ImageGroupBox.TabIndex = 47;
            this.ImageGroupBox.TabStop = false;
            this.ImageGroupBox.Text = "图像显示";
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.Scale2);
            this.OptionsGroupBox.Controls.Add(this.Mirror);
            this.OptionsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OptionsGroupBox.Location = new System.Drawing.Point(440, 125);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(142, 62);
            this.OptionsGroupBox.TabIndex = 48;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "选项";
            // 
            // TrackingModeGroupBox
            // 
            this.TrackingModeGroupBox.Controls.Add(this.Extremities);
            this.TrackingModeGroupBox.Controls.Add(this.Skeleton);
            this.TrackingModeGroupBox.Controls.Add(this.Joints);
            this.TrackingModeGroupBox.Controls.Add(this.FullHandMode);
            this.TrackingModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TrackingModeGroupBox.Location = new System.Drawing.Point(440, 197);
            this.TrackingModeGroupBox.Name = "TrackingModeGroupBox";
            this.TrackingModeGroupBox.Size = new System.Drawing.Size(142, 105);
            this.TrackingModeGroupBox.TabIndex = 49;
            this.TrackingModeGroupBox.TabStop = false;
            this.TrackingModeGroupBox.Text = "追踪选项";
            // 
            // Extremities
            // 
            this.Extremities.AutoSize = true;
            this.Extremities.Location = new System.Drawing.Point(14, 78);
            this.Extremities.Name = "Extremities";
            this.Extremities.Size = new System.Drawing.Size(48, 16);
            this.Extremities.TabIndex = 46;
            this.Extremities.Text = "四肢";
            this.Extremities.UseVisualStyleBackColor = true;
            // 
            // Skeleton
            // 
            this.Skeleton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skeleton.AutoSize = true;
            this.Skeleton.Checked = true;
            this.Skeleton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Skeleton.Location = new System.Drawing.Point(14, 58);
            this.Skeleton.Name = "Skeleton";
            this.Skeleton.Size = new System.Drawing.Size(60, 16);
            this.Skeleton.TabIndex = 23;
            this.Skeleton.Text = "手骨架";
            this.Skeleton.UseVisualStyleBackColor = true;
            // 
            // Joints
            // 
            this.Joints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Joints.AutoSize = true;
            this.Joints.Checked = true;
            this.Joints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Joints.Location = new System.Drawing.Point(14, 38);
            this.Joints.Name = "Joints";
            this.Joints.Size = new System.Drawing.Size(72, 16);
            this.Joints.TabIndex = 19;
            this.Joints.Text = "手关节点";
            this.Joints.UseVisualStyleBackColor = true;
            // 
            // FullHandMode
            // 
            this.FullHandMode.AutoSize = true;
            this.FullHandMode.Checked = true;
            this.FullHandMode.Location = new System.Drawing.Point(14, 18);
            this.FullHandMode.Name = "FullHandMode";
            this.FullHandMode.Size = new System.Drawing.Size(71, 16);
            this.FullHandMode.TabIndex = 51;
            this.FullHandMode.TabStop = true;
            this.FullHandMode.Text = "全手跟踪";
            this.FullHandMode.UseVisualStyleBackColor = true;
            this.FullHandMode.CheckedChanged += new System.EventHandler(this.TrackingModeChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 560);
            this.Controls.Add(this.TrackingModeGroupBox);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.ImageGroupBox);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.labelFPS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGesturesList);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Status2);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "基于Intel RealSense 的手势识别控制器（BY TXY）";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Status2.ResumeLayout(false);
            this.Status2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).EndInit();
            this.ImageGroupBox.ResumeLayout(false);
            this.ImageGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.TrackingModeGroupBox.ResumeLayout(false);
            this.TrackingModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.RadioButton Depth;
        private System.Windows.Forms.RadioButton Labelmap;
        private System.Windows.Forms.StatusStrip Status2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.CheckBox Scale2;
        private System.Windows.Forms.PictureBox Panel2;
        private System.Windows.Forms.CheckBox Mirror;
        private System.Windows.Forms.ComboBox cmbGesturesList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Live;
        private System.Windows.Forms.ToolStripMenuItem Playback;
        private System.Windows.Forms.ToolStripMenuItem Record;
        private System.Windows.Forms.CheckBox ContourCheckBox;
        private System.Windows.Forms.GroupBox ImageGroupBox;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.GroupBox TrackingModeGroupBox;
        private System.Windows.Forms.RadioButton FullHandMode;
        private System.Windows.Forms.CheckBox Extremities;
        private System.Windows.Forms.CheckBox Skeleton;
        private System.Windows.Forms.CheckBox Joints;
    }
}