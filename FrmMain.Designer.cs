namespace YoutubeTools;

partial class FrmMain
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
        dgvWindows = new DataGridView();
        colHandle = new DataGridViewTextBoxColumn();
        colTitle = new DataGridViewTextBoxColumn();
        colState = new DataGridViewTextBoxColumn();
        colTime = new DataGridViewTextBoxColumn();
        label1 = new Label();
        txtVideoKey = new TextBox();
        label2 = new Label();
        updnInstances = new NumericUpDown();
        btnRun = new Button();
        label3 = new Label();
        updnReplay = new NumericUpDown();
        btnStop = new Button();
        chkDelay = new CheckBox();
        chkHeadless = new CheckBox();
        pictureBox1 = new PictureBox();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        chkPreventDetection = new CheckBox();
        chkMuteAudio = new CheckBox();
        ((System.ComponentModel.ISupportInitialize)dgvWindows).BeginInit();
        ((System.ComponentModel.ISupportInitialize)updnInstances).BeginInit();
        ((System.ComponentModel.ISupportInitialize)updnReplay).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // dgvWindows
        // 
        dgvWindows.AllowUserToAddRows = false;
        dgvWindows.AllowUserToDeleteRows = false;
        dgvWindows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvWindows.BackgroundColor = SystemColors.ControlLight;
        dgvWindows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvWindows.Columns.AddRange(new DataGridViewColumn[] { colHandle, colTitle, colState, colTime });
        dgvWindows.GridColor = SystemColors.InfoText;
        dgvWindows.Location = new Point(17, 193);
        dgvWindows.Margin = new Padding(4, 5, 4, 5);
        dgvWindows.Name = "dgvWindows";
        dgvWindows.ReadOnly = true;
        dgvWindows.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        dgvWindows.RowTemplate.Height = 25;
        dgvWindows.Size = new Size(857, 522);
        dgvWindows.TabIndex = 0;
        // 
        // colHandle
        // 
        colHandle.HeaderText = "Handle";
        colHandle.MinimumWidth = 8;
        colHandle.Name = "colHandle";
        colHandle.ReadOnly = true;
        colHandle.Width = 150;
        // 
        // colTitle
        // 
        colTitle.HeaderText = "Title";
        colTitle.MinimumWidth = 8;
        colTitle.Name = "colTitle";
        colTitle.ReadOnly = true;
        colTitle.Width = 150;
        // 
        // colState
        // 
        colState.HeaderText = "State";
        colState.MinimumWidth = 8;
        colState.Name = "colState";
        colState.ReadOnly = true;
        colState.Width = 150;
        // 
        // colTime
        // 
        colTime.HeaderText = "Total Time";
        colTime.MinimumWidth = 8;
        colTime.Name = "colTime";
        colTime.ReadOnly = true;
        colTime.Width = 150;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(11, 23);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(131, 25);
        label1.TabIndex = 1;
        label1.Text = "Video URL Key:";
        // 
        // txtVideoKey
        // 
        txtVideoKey.Location = new Point(136, 20);
        txtVideoKey.Margin = new Padding(4, 5, 4, 5);
        txtVideoKey.Name = "txtVideoKey";
        txtVideoKey.Size = new Size(142, 31);
        txtVideoKey.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(506, 24);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(89, 25);
        label2.TabIndex = 3;
        label2.Text = "Instances:";
        // 
        // updnInstances
        // 
        updnInstances.Location = new Point(603, 20);
        updnInstances.Margin = new Padding(4, 5, 4, 5);
        updnInstances.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        updnInstances.Name = "updnInstances";
        updnInstances.Size = new Size(86, 31);
        updnInstances.TabIndex = 4;
        updnInstances.TextAlign = HorizontalAlignment.Center;
        updnInstances.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // btnRun
        // 
        btnRun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnRun.BackColor = Color.Maroon;
        btnRun.Location = new Point(753, 20);
        btnRun.Margin = new Padding(4, 5, 4, 5);
        btnRun.Name = "btnRun";
        btnRun.Size = new Size(107, 38);
        btnRun.TabIndex = 5;
        btnRun.Text = "Start";
        btnRun.UseVisualStyleBackColor = false;
        btnRun.Click += btnRun_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(275, 23);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(141, 25);
        label3.TabIndex = 6;
        label3.Text = "Check (minutes):";
        // 
        // updnReplay
        // 
        updnReplay.Location = new Point(412, 20);
        updnReplay.Margin = new Padding(4, 5, 4, 5);
        updnReplay.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
        updnReplay.Name = "updnReplay";
        updnReplay.Size = new Size(86, 31);
        updnReplay.TabIndex = 7;
        updnReplay.TextAlign = HorizontalAlignment.Center;
        updnReplay.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // btnStop
        // 
        btnStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnStop.BackColor = Color.Maroon;
        btnStop.Enabled = false;
        btnStop.Location = new Point(753, 68);
        btnStop.Margin = new Padding(4, 5, 4, 5);
        btnStop.Name = "btnStop";
        btnStop.Size = new Size(107, 38);
        btnStop.TabIndex = 8;
        btnStop.Text = "Stop";
        btnStop.UseVisualStyleBackColor = false;
        btnStop.Click += btnStop_Click;
        // 
        // chkDelay
        // 
        chkDelay.AutoSize = true;
        chkDelay.Checked = true;
        chkDelay.CheckState = CheckState.Checked;
        chkDelay.Location = new Point(17, 68);
        chkDelay.Margin = new Padding(4, 5, 4, 5);
        chkDelay.Name = "chkDelay";
        chkDelay.Size = new Size(351, 29);
        chkDelay.TabIndex = 9;
        chkDelay.Text = "Random delay between starting videos.";
        chkDelay.UseVisualStyleBackColor = true;
        // 
        // chkHeadless
        // 
        chkHeadless.AutoSize = true;
        chkHeadless.Checked = true;
        chkHeadless.CheckState = CheckState.Checked;
        chkHeadless.Location = new Point(403, 68);
        chkHeadless.Margin = new Padding(4, 5, 4, 5);
        chkHeadless.Name = "chkHeadless";
        chkHeadless.Size = new Size(215, 29);
        chkHeadless.TabIndex = 12;
        chkHeadless.Text = "Hide browser window.";
        chkHeadless.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(753, 114);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(107, 75);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 13;
        pictureBox1.TabStop = false;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = Color.DimGray;
        label4.Location = new Point(694, 203);
        label4.Name = "label4";
        label4.Size = new Size(127, 25);
        label4.TabIndex = 20;
        label4.Text = "YT-HOUR 1.01";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(17, 163);
        label5.Name = "label5";
        label5.Size = new Size(304, 25);
        label5.TabIndex = 21;
        label5.Text = "Created by: nushair1232@gmail.com";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(17, 144);
        label6.Name = "label6";
        label6.Size = new Size(239, 25);
        label6.TabIndex = 22;
        label6.Text = "For any addition contact me.";
        // 
        // chkPreventDetection
        // 
        chkPreventDetection.AutoSize = true;
        chkPreventDetection.Checked = true;
        chkPreventDetection.CheckState = CheckState.Checked;
        chkPreventDetection.Location = new Point(17, 110);
        chkPreventDetection.Margin = new Padding(4, 5, 4, 5);
        chkPreventDetection.Name = "chkPreventDetection";
        chkPreventDetection.Size = new Size(180, 29);
        chkPreventDetection.TabIndex = 10;
        chkPreventDetection.Text = "Prevent detection.";
        chkPreventDetection.UseVisualStyleBackColor = true;
        // 
        // chkMuteAudio
        // 
        chkMuteAudio.AutoSize = true;
        chkMuteAudio.Checked = true;
        chkMuteAudio.CheckState = CheckState.Checked;
        chkMuteAudio.Location = new Point(403, 107);
        chkMuteAudio.Margin = new Padding(4, 5, 4, 5);
        chkMuteAudio.Name = "chkMuteAudio";
        chkMuteAudio.Size = new Size(248, 29);
        chkMuteAudio.TabIndex = 11;
        chkMuteAudio.Text = "Do not play video sounds.";
        chkMuteAudio.UseVisualStyleBackColor = true;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Brown;
        ClientSize = new Size(891, 735);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(pictureBox1);
        Controls.Add(label3);
        Controls.Add(chkHeadless);
        Controls.Add(chkMuteAudio);
        Controls.Add(chkPreventDetection);
        Controls.Add(chkDelay);
        Controls.Add(btnStop);
        Controls.Add(updnReplay);
        Controls.Add(btnRun);
        Controls.Add(updnInstances);
        Controls.Add(label2);
        Controls.Add(txtVideoKey);
        Controls.Add(label1);
        Controls.Add(dgvWindows);
        ForeColor = SystemColors.ButtonHighlight;
        Margin = new Padding(4, 5, 4, 5);
        MinimumSize = new Size(905, 763);
        Name = "FrmMain";
        Text = "YouTube Tools";
        FormClosing += FrmMain_FormClosing;
        ((System.ComponentModel.ISupportInitialize)dgvWindows).EndInit();
        ((System.ComponentModel.ISupportInitialize)updnInstances).EndInit();
        ((System.ComponentModel.ISupportInitialize)updnReplay).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgvWindows;
    private Label label1;
    private TextBox txtVideoKey;
    private Label label2;
    private NumericUpDown updnInstances;
    private Button btnRun;
    private Label label3;
    private NumericUpDown updnReplay;
    private Button btnStop;
    private CheckBox chkDelay;
    private CheckBox chkHeadless;
    private DataGridViewTextBoxColumn colHandle;
    private DataGridViewTextBoxColumn colTitle;
    private DataGridViewTextBoxColumn colState;
    private DataGridViewTextBoxColumn colTime;
    private PictureBox pictureBox1;
    private Label label4;
    private Label label5;
    private Label label6;
    private CheckBox chkPreventDetection;
    private CheckBox chkMuteAudio;
}
