namespace Convetidor_de_Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBoxDownloadFile = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDownload = new System.Windows.Forms.Button();
            this.LabelDownloadFinished = new System.Windows.Forms.Label();
            this.GroupBoxEditFile = new System.Windows.Forms.GroupBox();
            this.TableLayoutEditFile = new System.Windows.Forms.TableLayoutPanel();
            this.LabelChooseFormat = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RadioButtonMov = new System.Windows.Forms.RadioButton();
            this.RadioButtonAvi = new System.Windows.Forms.RadioButton();
            this.RadioButtonMp4 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCropVideo = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelStart = new System.Windows.Forms.Label();
            this.NumericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelVideoSize = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.RadioButton1080 = new System.Windows.Forms.RadioButton();
            this.RadioButton720 = new System.Windows.Forms.RadioButton();
            this.RadioButton480 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelFps = new System.Windows.Forms.Label();
            this.GroupBoxSelectFile = new System.Windows.Forms.GroupBox();
            this.TableLayoutSelectFile = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonSelectFile = new System.Windows.Forms.Button();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.numericUpDownFps = new System.Windows.Forms.NumericUpDown();
            this.TableLayoutMain.SuspendLayout();
            this.GroupBoxDownloadFile.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.GroupBoxEditFile.SuspendLayout();
            this.TableLayoutEditFile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDuration)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.GroupBoxSelectFile.SuspendLayout();
            this.TableLayoutSelectFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFps)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(1024, 83);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Video File Converter";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableLayoutMain
            // 
            this.TableLayoutMain.ColumnCount = 3;
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutMain.Controls.Add(this.GroupBoxDownloadFile, 2, 0);
            this.TableLayoutMain.Controls.Add(this.GroupBoxEditFile, 1, 0);
            this.TableLayoutMain.Controls.Add(this.GroupBoxSelectFile, 0, 0);
            this.TableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutMain.Location = new System.Drawing.Point(0, 83);
            this.TableLayoutMain.Name = "TableLayoutMain";
            this.TableLayoutMain.RowCount = 1;
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.Size = new System.Drawing.Size(1024, 481);
            this.TableLayoutMain.TabIndex = 1;
            // 
            // GroupBoxDownloadFile
            // 
            this.GroupBoxDownloadFile.Controls.Add(this.tableLayoutPanel8);
            this.GroupBoxDownloadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxDownloadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxDownloadFile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GroupBoxDownloadFile.Location = new System.Drawing.Point(685, 3);
            this.GroupBoxDownloadFile.Name = "GroupBoxDownloadFile";
            this.GroupBoxDownloadFile.Size = new System.Drawing.Size(336, 475);
            this.GroupBoxDownloadFile.TabIndex = 2;
            this.GroupBoxDownloadFile.TabStop = false;
            this.GroupBoxDownloadFile.Text = "Step 3 - Download File";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.ButtonDownload, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.LabelDownloadFinished, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(330, 441);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDownload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonDownload.FlatAppearance.BorderSize = 0;
            this.ButtonDownload.Location = new System.Drawing.Point(30, 82);
            this.ButtonDownload.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(270, 46);
            this.ButtonDownload.TabIndex = 1;
            this.ButtonDownload.Text = "Save File";
            this.ButtonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ButtonDownload.UseVisualStyleBackColor = false;
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // LabelDownloadFinished
            // 
            this.LabelDownloadFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDownloadFinished.AutoSize = true;
            this.LabelDownloadFinished.Location = new System.Drawing.Point(3, 300);
            this.LabelDownloadFinished.Name = "LabelDownloadFinished";
            this.LabelDownloadFinished.Size = new System.Drawing.Size(324, 29);
            this.LabelDownloadFinished.TabIndex = 2;
            this.LabelDownloadFinished.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GroupBoxEditFile
            // 
            this.GroupBoxEditFile.Controls.Add(this.TableLayoutEditFile);
            this.GroupBoxEditFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxEditFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxEditFile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GroupBoxEditFile.Location = new System.Drawing.Point(344, 3);
            this.GroupBoxEditFile.Name = "GroupBoxEditFile";
            this.GroupBoxEditFile.Size = new System.Drawing.Size(335, 475);
            this.GroupBoxEditFile.TabIndex = 1;
            this.GroupBoxEditFile.TabStop = false;
            this.GroupBoxEditFile.Text = "Step 2 - Edit File";
            // 
            // TableLayoutEditFile
            // 
            this.TableLayoutEditFile.ColumnCount = 1;
            this.TableLayoutEditFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutEditFile.Controls.Add(this.LabelChooseFormat, 0, 0);
            this.TableLayoutEditFile.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.TableLayoutEditFile.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.TableLayoutEditFile.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.TableLayoutEditFile.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.TableLayoutEditFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutEditFile.Location = new System.Drawing.Point(3, 31);
            this.TableLayoutEditFile.Name = "TableLayoutEditFile";
            this.TableLayoutEditFile.RowCount = 5;
            this.TableLayoutEditFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588F));
            this.TableLayoutEditFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588F));
            this.TableLayoutEditFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.52941F));
            this.TableLayoutEditFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.52941F));
            this.TableLayoutEditFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.52941F));
            this.TableLayoutEditFile.Size = new System.Drawing.Size(329, 441);
            this.TableLayoutEditFile.TabIndex = 0;
            // 
            // LabelChooseFormat
            // 
            this.LabelChooseFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelChooseFormat.AutoSize = true;
            this.LabelChooseFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChooseFormat.Location = new System.Drawing.Point(3, 20);
            this.LabelChooseFormat.Name = "LabelChooseFormat";
            this.LabelChooseFormat.Size = new System.Drawing.Size(323, 24);
            this.LabelChooseFormat.TabIndex = 0;
            this.LabelChooseFormat.Text = "Choose your format";
            this.LabelChooseFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel1.Controls.Add(this.RadioButtonMov, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RadioButtonAvi, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.RadioButtonMp4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 58);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // RadioButtonMov
            // 
            this.RadioButtonMov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButtonMov.AutoSize = true;
            this.RadioButtonMov.Location = new System.Drawing.Point(122, 3);
            this.RadioButtonMov.Name = "RadioButtonMov";
            this.RadioButtonMov.Size = new System.Drawing.Size(76, 33);
            this.RadioButtonMov.TabIndex = 1;
            this.RadioButtonMov.TabStop = true;
            this.RadioButtonMov.Text = "mov";
            this.RadioButtonMov.UseVisualStyleBackColor = true;
            this.RadioButtonMov.CheckedChanged += new System.EventHandler(this.RadioButtonMov_CheckedChanged);
            // 
            // RadioButtonAvi
            // 
            this.RadioButtonAvi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButtonAvi.AutoSize = true;
            this.RadioButtonAvi.Location = new System.Drawing.Point(238, 3);
            this.RadioButtonAvi.Name = "RadioButtonAvi";
            this.RadioButtonAvi.Size = new System.Drawing.Size(61, 33);
            this.RadioButtonAvi.TabIndex = 2;
            this.RadioButtonAvi.TabStop = true;
            this.RadioButtonAvi.Text = "avi";
            this.RadioButtonAvi.UseVisualStyleBackColor = true;
            this.RadioButtonAvi.CheckedChanged += new System.EventHandler(this.RadioButtonAvi_CheckedChanged);
            // 
            // RadioButtonMp4
            // 
            this.RadioButtonMp4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButtonMp4.AutoSize = true;
            this.RadioButtonMp4.Location = new System.Drawing.Point(14, 3);
            this.RadioButtonMp4.Name = "RadioButtonMp4";
            this.RadioButtonMp4.Size = new System.Drawing.Size(78, 33);
            this.RadioButtonMp4.TabIndex = 0;
            this.RadioButtonMp4.TabStop = true;
            this.RadioButtonMp4.Text = "mp4";
            this.RadioButtonMp4.UseVisualStyleBackColor = true;
            this.RadioButtonMp4.CheckedChanged += new System.EventHandler(this.RadioButtonMp4_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LabelCropVideo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.92784F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.07217F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(323, 97);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // LabelCropVideo
            // 
            this.LabelCropVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCropVideo.AutoSize = true;
            this.LabelCropVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCropVideo.Location = new System.Drawing.Point(3, 3);
            this.LabelCropVideo.Name = "LabelCropVideo";
            this.LabelCropVideo.Size = new System.Drawing.Size(317, 24);
            this.LabelCropVideo.TabIndex = 1;
            this.LabelCropVideo.Text = "Crop your video (sec)";
            this.LabelCropVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.LabelStart, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.NumericUpDownStart, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.NumericUpDownDuration, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.LabelDuration, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(317, 61);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // LabelStart
            // 
            this.LabelStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelStart.AutoSize = true;
            this.LabelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStart.Location = new System.Drawing.Point(3, 0);
            this.LabelStart.Name = "LabelStart";
            this.LabelStart.Size = new System.Drawing.Size(152, 24);
            this.LabelStart.TabIndex = 3;
            this.LabelStart.Text = "Start";
            this.LabelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericUpDownStart
            // 
            this.NumericUpDownStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericUpDownStart.Location = new System.Drawing.Point(3, 27);
            this.NumericUpDownStart.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDownStart.Name = "NumericUpDownStart";
            this.NumericUpDownStart.Size = new System.Drawing.Size(152, 35);
            this.NumericUpDownStart.TabIndex = 4;
            this.NumericUpDownStart.ValueChanged += new System.EventHandler(this.NumericUpDownStart_ValueChanged);
            // 
            // NumericUpDownDuration
            // 
            this.NumericUpDownDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericUpDownDuration.Location = new System.Drawing.Point(161, 27);
            this.NumericUpDownDuration.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumericUpDownDuration.Name = "NumericUpDownDuration";
            this.NumericUpDownDuration.Size = new System.Drawing.Size(153, 35);
            this.NumericUpDownDuration.TabIndex = 5;
            this.NumericUpDownDuration.ValueChanged += new System.EventHandler(this.NumericUpDownDuration_ValueChanged);
            // 
            // LabelDuration
            // 
            this.LabelDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDuration.Location = new System.Drawing.Point(161, 0);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(153, 24);
            this.LabelDuration.TabIndex = 2;
            this.LabelDuration.Text = "Duration";
            this.LabelDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.LabelVideoSize, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 234);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(323, 97);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // LabelVideoSize
            // 
            this.LabelVideoSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVideoSize.AutoSize = true;
            this.LabelVideoSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVideoSize.Location = new System.Drawing.Point(3, 12);
            this.LabelVideoSize.Name = "LabelVideoSize";
            this.LabelVideoSize.Size = new System.Drawing.Size(317, 24);
            this.LabelVideoSize.TabIndex = 2;
            this.LabelVideoSize.Text = "Video Size";
            this.LabelVideoSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelVideoSize.UseMnemonic = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.RadioButton1080, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.RadioButton720, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.RadioButton480, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(317, 43);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // RadioButton1080
            // 
            this.RadioButton1080.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButton1080.AutoSize = true;
            this.RadioButton1080.Location = new System.Drawing.Point(222, 3);
            this.RadioButton1080.Name = "RadioButton1080";
            this.RadioButton1080.Size = new System.Drawing.Size(83, 33);
            this.RadioButton1080.TabIndex = 1;
            this.RadioButton1080.TabStop = true;
            this.RadioButton1080.Text = "1080";
            this.RadioButton1080.UseVisualStyleBackColor = true;
            this.RadioButton1080.CheckedChanged += new System.EventHandler(this.RadioButton270_CheckedChanged);
            // 
            // RadioButton720
            // 
            this.RadioButton720.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButton720.AutoSize = true;
            this.RadioButton720.Location = new System.Drawing.Point(122, 3);
            this.RadioButton720.Name = "RadioButton720";
            this.RadioButton720.Size = new System.Drawing.Size(70, 33);
            this.RadioButton720.TabIndex = 2;
            this.RadioButton720.TabStop = true;
            this.RadioButton720.Text = "720";
            this.RadioButton720.UseVisualStyleBackColor = true;
            this.RadioButton720.CheckedChanged += new System.EventHandler(this.RadioButton180_CheckedChanged);
            // 
            // RadioButton480
            // 
            this.RadioButton480.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioButton480.AutoSize = true;
            this.RadioButton480.Location = new System.Drawing.Point(17, 3);
            this.RadioButton480.Name = "RadioButton480";
            this.RadioButton480.Size = new System.Drawing.Size(70, 33);
            this.RadioButton480.TabIndex = 3;
            this.RadioButton480.TabStop = true;
            this.RadioButton480.Text = "480";
            this.RadioButton480.UseVisualStyleBackColor = true;
            this.RadioButton480.CheckedChanged += new System.EventHandler(this.RadioButton480_CheckedChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.numericUpDownFps, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.LabelFps, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(323, 101);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // LabelFps
            // 
            this.LabelFps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFps.AutoSize = true;
            this.LabelFps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFps.Location = new System.Drawing.Point(3, 13);
            this.LabelFps.Name = "LabelFps";
            this.LabelFps.Size = new System.Drawing.Size(317, 24);
            this.LabelFps.TabIndex = 3;
            this.LabelFps.Text = "FPS";
            this.LabelFps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBoxSelectFile
            // 
            this.GroupBoxSelectFile.Controls.Add(this.TableLayoutSelectFile);
            this.GroupBoxSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSelectFile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GroupBoxSelectFile.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxSelectFile.Name = "GroupBoxSelectFile";
            this.GroupBoxSelectFile.Size = new System.Drawing.Size(335, 475);
            this.GroupBoxSelectFile.TabIndex = 0;
            this.GroupBoxSelectFile.TabStop = false;
            this.GroupBoxSelectFile.Text = "Step 1 - Select File";
            // 
            // TableLayoutSelectFile
            // 
            this.TableLayoutSelectFile.ColumnCount = 1;
            this.TableLayoutSelectFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutSelectFile.Controls.Add(this.ButtonSelectFile, 0, 1);
            this.TableLayoutSelectFile.Controls.Add(this.LabelFileName, 0, 0);
            this.TableLayoutSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutSelectFile.Location = new System.Drawing.Point(3, 31);
            this.TableLayoutSelectFile.Name = "TableLayoutSelectFile";
            this.TableLayoutSelectFile.RowCount = 2;
            this.TableLayoutSelectFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutSelectFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutSelectFile.Size = new System.Drawing.Size(329, 441);
            this.TableLayoutSelectFile.TabIndex = 0;
            // 
            // ButtonSelectFile
            // 
            this.ButtonSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSelectFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSelectFile.FlatAppearance.BorderSize = 0;
            this.ButtonSelectFile.Location = new System.Drawing.Point(30, 307);
            this.ButtonSelectFile.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.ButtonSelectFile.Name = "ButtonSelectFile";
            this.ButtonSelectFile.Size = new System.Drawing.Size(269, 46);
            this.ButtonSelectFile.TabIndex = 0;
            this.ButtonSelectFile.Text = "Select File";
            this.ButtonSelectFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ButtonSelectFile.UseVisualStyleBackColor = false;
            this.ButtonSelectFile.Click += new System.EventHandler(this.ButtonSelectFile_Click);
            // 
            // LabelFileName
            // 
            this.LabelFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.Location = new System.Drawing.Point(3, 95);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(323, 29);
            this.LabelFileName.TabIndex = 1;
            this.LabelFileName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numericUpDownFps
            // 
            this.numericUpDownFps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownFps.Location = new System.Drawing.Point(3, 53);
            this.numericUpDownFps.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownFps.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFps.Name = "numericUpDownFps";
            this.numericUpDownFps.Size = new System.Drawing.Size(317, 35);
            this.numericUpDownFps.TabIndex = 6;
            this.numericUpDownFps.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFps.ValueChanged += new System.EventHandler(this.numericUpDownFps_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1024, 564);
            this.Controls.Add(this.TableLayoutMain);
            this.Controls.Add(this.LabelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Video Converter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TableLayoutMain.ResumeLayout(false);
            this.GroupBoxDownloadFile.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.GroupBoxEditFile.ResumeLayout(false);
            this.TableLayoutEditFile.ResumeLayout(false);
            this.TableLayoutEditFile.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDuration)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.GroupBoxSelectFile.ResumeLayout(false);
            this.TableLayoutSelectFile.ResumeLayout(false);
            this.TableLayoutSelectFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.GroupBox GroupBoxDownloadFile;
        private System.Windows.Forms.GroupBox GroupBoxEditFile;
        private System.Windows.Forms.GroupBox GroupBoxSelectFile;
        private System.Windows.Forms.Button ButtonSelectFile;
        private System.Windows.Forms.TableLayoutPanel TableLayoutSelectFile;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.TableLayoutPanel TableLayoutEditFile;
        private System.Windows.Forms.Label LabelChooseFormat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton RadioButtonMp4;
        private System.Windows.Forms.RadioButton RadioButtonAvi;
        private System.Windows.Forms.RadioButton RadioButtonMov;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelCropVideo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LabelDuration;
        private System.Windows.Forms.Label LabelStart;
        private System.Windows.Forms.NumericUpDown NumericUpDownStart;
        private System.Windows.Forms.NumericUpDown NumericUpDownDuration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LabelVideoSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton RadioButton1080;
        private System.Windows.Forms.RadioButton RadioButton720;
        private System.Windows.Forms.RadioButton RadioButton480;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label LabelFps;
        private System.Windows.Forms.Button ButtonDownload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label LabelDownloadFinished;
        private System.Windows.Forms.NumericUpDown numericUpDownFps;
    }
}

