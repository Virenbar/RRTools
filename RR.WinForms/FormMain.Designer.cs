namespace RR.WinForms
{
    partial class FormMain
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
            B_Convert = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            B_OpenOut = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            FLP_Orientation = new FlowLayoutPanel();
            RB_Album = new RadioButton();
            RB_Book = new RadioButton();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            RB_HTML = new RadioButton();
            RB_PDF = new RadioButton();
            label2 = new Label();
            LV_Files = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            MI_About = new ToolStripMenuItem();
            сертификатыToolStripMenuItem = new ToolStripMenuItem();
            MI_InstallCertificate = new ToolStripMenuItem();
            MI_RemoveCertificate = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            SB_Add = new ToolStripButton();
            SB_Delete = new ToolStripButton();
            SL_Count = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            SL_Status = new ToolStripStatusLabel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            FLP_Orientation.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // B_Convert
            // 
            B_Convert.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            B_Convert.AutoSize = true;
            B_Convert.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_Convert.Image = icons8.Replace16;
            B_Convert.Location = new Point(3, 36);
            B_Convert.Name = "B_Convert";
            B_Convert.Padding = new Padding(1);
            B_Convert.Size = new Size(124, 27);
            B_Convert.TabIndex = 0;
            B_Convert.Text = "Конвертировать";
            B_Convert.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Convert.UseVisualStyleBackColor = true;
            B_Convert.Click += B_PDFConvert_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 362);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(584, 78);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(B_Convert, 0, 1);
            tableLayoutPanel3.Controls.Add(B_OpenOut, 0, 0);
            tableLayoutPanel3.Location = new Point(451, 9);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(130, 66);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // B_OpenOut
            // 
            B_OpenOut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            B_OpenOut.AutoSize = true;
            B_OpenOut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_OpenOut.Image = icons8.OpenedFolder16;
            B_OpenOut.Location = new Point(3, 3);
            B_OpenOut.Name = "B_OpenOut";
            B_OpenOut.Padding = new Padding(1);
            B_OpenOut.Size = new Size(124, 27);
            B_OpenOut.TabIndex = 0;
            B_OpenOut.Text = "Открыть папку";
            B_OpenOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_OpenOut.UseVisualStyleBackColor = true;
            B_OpenOut.Click += B_OpenOut_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 72);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройки";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(FLP_Orientation, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(271, 50);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // FLP_Orientation
            // 
            FLP_Orientation.Anchor = AnchorStyles.Left;
            FLP_Orientation.AutoSize = true;
            FLP_Orientation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FLP_Orientation.Controls.Add(RB_Album);
            FLP_Orientation.Controls.Add(RB_Book);
            FLP_Orientation.Enabled = false;
            FLP_Orientation.Location = new Point(97, 25);
            FLP_Orientation.Margin = new Padding(0);
            FLP_Orientation.Name = "FLP_Orientation";
            FLP_Orientation.Size = new Size(174, 25);
            FLP_Orientation.TabIndex = 2;
            FLP_Orientation.WrapContents = false;
            // 
            // RB_Album
            // 
            RB_Album.AutoSize = true;
            RB_Album.Checked = true;
            RB_Album.Location = new Point(3, 3);
            RB_Album.Name = "RB_Album";
            RB_Album.Size = new Size(88, 19);
            RB_Album.TabIndex = 0;
            RB_Album.TabStop = true;
            RB_Album.Text = "Альбомная";
            RB_Album.UseVisualStyleBackColor = true;
            // 
            // RB_Book
            // 
            RB_Book.AutoSize = true;
            RB_Book.Location = new Point(97, 3);
            RB_Book.Name = "RB_Book";
            RB_Book.Size = new Size(74, 19);
            RB_Book.TabIndex = 1;
            RB_Book.Text = "Книжная";
            RB_Book.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(44, 5);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Формат";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Left;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(RB_HTML);
            flowLayoutPanel1.Controls.Add(RB_PDF);
            flowLayoutPanel1.Location = new Point(97, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(115, 25);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // RB_HTML
            // 
            RB_HTML.AutoSize = true;
            RB_HTML.Checked = true;
            RB_HTML.Location = new Point(3, 3);
            RB_HTML.Name = "RB_HTML";
            RB_HTML.Size = new Size(57, 19);
            RB_HTML.TabIndex = 0;
            RB_HTML.TabStop = true;
            RB_HTML.Text = "HTML";
            RB_HTML.UseVisualStyleBackColor = true;
            // 
            // RB_PDF
            // 
            RB_PDF.AutoSize = true;
            RB_PDF.Location = new Point(66, 3);
            RB_PDF.Name = "RB_PDF";
            RB_PDF.Size = new Size(46, 19);
            RB_PDF.TabIndex = 1;
            RB_PDF.Text = "PDF";
            RB_PDF.UseVisualStyleBackColor = true;
            RB_PDF.CheckedChanged += RB_PDF_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "Орентация PDF";
            // 
            // LV_Files
            // 
            LV_Files.AllowDrop = true;
            LV_Files.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            LV_Files.Dock = DockStyle.Fill;
            LV_Files.FullRowSelect = true;
            LV_Files.GridLines = true;
            LV_Files.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            LV_Files.Location = new Point(0, 49);
            LV_Files.Name = "LV_Files";
            LV_Files.Size = new Size(584, 313);
            LV_Files.TabIndex = 3;
            LV_Files.UseCompatibleStateImageBehavior = false;
            LV_Files.View = View.Details;
            LV_Files.DragDrop += LV_Files_DragDrop;
            LV_Files.DragEnter += LV_Files_DragEnter;
            LV_Files.DragOver += LV_Files_DragOver;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Имя файла";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Результат";
            columnHeader2.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MI_About, сертификатыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // MI_About
            // 
            MI_About.Alignment = ToolStripItemAlignment.Right;
            MI_About.Image = icons8.Info16;
            MI_About.Name = "MI_About";
            MI_About.Size = new Size(68, 20);
            MI_About.Text = "About";
            MI_About.Click += MI_About_Click;
            // 
            // сертификатыToolStripMenuItem
            // 
            сертификатыToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            сертификатыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MI_InstallCertificate, MI_RemoveCertificate });
            сертификатыToolStripMenuItem.Image = icons8.Passport16;
            сертификатыToolStripMenuItem.Name = "сертификатыToolStripMenuItem";
            сертификатыToolStripMenuItem.Size = new Size(101, 20);
            сертификатыToolStripMenuItem.Text = "Сертификат";
            // 
            // MI_InstallCertificate
            // 
            MI_InstallCertificate.Image = icons8.Ok16;
            MI_InstallCertificate.Name = "MI_InstallCertificate";
            MI_InstallCertificate.Size = new Size(180, 22);
            MI_InstallCertificate.Text = "Установить";
            MI_InstallCertificate.Click += MI_InstallCertificate_Click;
            // 
            // MI_RemoveCertificate
            // 
            MI_RemoveCertificate.Image = icons8.Cancel16;
            MI_RemoveCertificate.Name = "MI_RemoveCertificate";
            MI_RemoveCertificate.Size = new Size(180, 22);
            MI_RemoveCertificate.Text = "Удалить";
            MI_RemoveCertificate.Click += MI_RemoveCertificate_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { SB_Add, SB_Delete, SL_Count });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(584, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // SB_Add
            // 
            SB_Add.Image = icons8.Add16;
            SB_Add.Name = "SB_Add";
            SB_Add.Size = new Size(79, 22);
            SB_Add.Text = "Добавить";
            SB_Add.Click += SB_Add_Click;
            // 
            // SB_Delete
            // 
            SB_Delete.Image = icons8.Minus16;
            SB_Delete.Name = "SB_Delete";
            SB_Delete.Size = new Size(71, 22);
            SB_Delete.Text = "Удалить";
            SB_Delete.Click += SB_Delete_Click;
            // 
            // SL_Count
            // 
            SL_Count.Alignment = ToolStripItemAlignment.Right;
            SL_Count.Name = "SL_Count";
            SL_Count.Size = new Size(61, 22);
            SL_Count.Text = "Файлов: 0";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { SL_Status });
            statusStrip1.Location = new Point(0, 440);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // SL_Status
            // 
            SL_Status.Name = "SL_Status";
            SL_Status.Size = new Size(12, 17);
            SL_Status.Text = "-";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 462);
            Controls.Add(LV_Files);
            Controls.Add(toolStrip1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(600, 500);
            Name = "FormMain";
            Text = "Росреестр - Tools";
            Load += FormMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            FLP_Orientation.ResumeLayout(false);
            FLP_Orientation.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button B_Convert;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView LV_Files;
        private ColumnHeader columnHeader1;
        private Button B_OpenOut;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MI_About;
        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel FLP_Orientation;
        private RadioButton RB_Album;
        private RadioButton RB_Book;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton RB_HTML;
        private RadioButton RB_PDF;
        private Label label2;
        private ToolStripButton SB_Delete;
        private ToolStripButton SB_Add;
        private ToolStripLabel SL_Count;
        private TableLayoutPanel tableLayoutPanel3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel SL_Status;
        private ToolStripMenuItem сертификатыToolStripMenuItem;
        private ToolStripMenuItem MI_InstallCertificate;
        private ToolStripMenuItem MI_RemoveCertificate;
        private ColumnHeader columnHeader2;
    }
}