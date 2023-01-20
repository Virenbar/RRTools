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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.B_Convert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.B_OpenOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FLP_Orientation = new System.Windows.Forms.FlowLayoutPanel();
            this.RB_Album = new System.Windows.Forms.RadioButton();
            this.RB_Book = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RB_HTML = new System.Windows.Forms.RadioButton();
            this.RB_PDF = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LV_Files = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SB_Add = new System.Windows.Forms.ToolStripButton();
            this.SB_Delete = new System.Windows.Forms.ToolStripButton();
            this.SL_Count = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SL_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.FLP_Orientation.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Convert
            // 
            this.B_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Convert.AutoSize = true;
            this.B_Convert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Convert.Location = new System.Drawing.Point(3, 36);
            this.B_Convert.Name = "B_Convert";
            this.B_Convert.Padding = new System.Windows.Forms.Padding(1);
            this.B_Convert.Size = new System.Drawing.Size(103, 27);
            this.B_Convert.TabIndex = 0;
            this.B_Convert.Text = "Преобразовать";
            this.B_Convert.UseVisualStyleBackColor = true;
            this.B_Convert.Click += new System.EventHandler(this.B_PDFConvert_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 362);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 78);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.B_Convert, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.B_OpenOut, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(472, 9);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(109, 66);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // B_OpenOut
            // 
            this.B_OpenOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.B_OpenOut.AutoSize = true;
            this.B_OpenOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_OpenOut.Location = new System.Drawing.Point(3, 3);
            this.B_OpenOut.Name = "B_OpenOut";
            this.B_OpenOut.Padding = new System.Windows.Forms.Padding(1);
            this.B_OpenOut.Size = new System.Drawing.Size(103, 27);
            this.B_OpenOut.TabIndex = 0;
            this.B_OpenOut.Text = "Открыть папку";
            this.B_OpenOut.UseVisualStyleBackColor = true;
            this.B_OpenOut.Click += new System.EventHandler(this.B_OpenOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.FLP_Orientation, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(271, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // FLP_Orientation
            // 
            this.FLP_Orientation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FLP_Orientation.AutoSize = true;
            this.FLP_Orientation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLP_Orientation.Controls.Add(this.RB_Album);
            this.FLP_Orientation.Controls.Add(this.RB_Book);
            this.FLP_Orientation.Enabled = false;
            this.FLP_Orientation.Location = new System.Drawing.Point(97, 25);
            this.FLP_Orientation.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_Orientation.Name = "FLP_Orientation";
            this.FLP_Orientation.Size = new System.Drawing.Size(174, 25);
            this.FLP_Orientation.TabIndex = 2;
            this.FLP_Orientation.WrapContents = false;
            // 
            // RB_Album
            // 
            this.RB_Album.AutoSize = true;
            this.RB_Album.Checked = true;
            this.RB_Album.Location = new System.Drawing.Point(3, 3);
            this.RB_Album.Name = "RB_Album";
            this.RB_Album.Size = new System.Drawing.Size(88, 19);
            this.RB_Album.TabIndex = 0;
            this.RB_Album.TabStop = true;
            this.RB_Album.Text = "Альбомная";
            this.RB_Album.UseVisualStyleBackColor = true;
            // 
            // RB_Book
            // 
            this.RB_Book.AutoSize = true;
            this.RB_Book.Location = new System.Drawing.Point(97, 3);
            this.RB_Book.Name = "RB_Book";
            this.RB_Book.Size = new System.Drawing.Size(74, 19);
            this.RB_Book.TabIndex = 1;
            this.RB_Book.Text = "Книжная";
            this.RB_Book.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Формат";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.RB_HTML);
            this.flowLayoutPanel1.Controls.Add(this.RB_PDF);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(97, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(116, 25);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // RB_HTML
            // 
            this.RB_HTML.AutoSize = true;
            this.RB_HTML.Checked = true;
            this.RB_HTML.Location = new System.Drawing.Point(3, 3);
            this.RB_HTML.Name = "RB_HTML";
            this.RB_HTML.Size = new System.Drawing.Size(58, 19);
            this.RB_HTML.TabIndex = 0;
            this.RB_HTML.TabStop = true;
            this.RB_HTML.Text = "HTML";
            this.RB_HTML.UseVisualStyleBackColor = true;
            // 
            // RB_PDF
            // 
            this.RB_PDF.AutoSize = true;
            this.RB_PDF.Location = new System.Drawing.Point(67, 3);
            this.RB_PDF.Name = "RB_PDF";
            this.RB_PDF.Size = new System.Drawing.Size(46, 19);
            this.RB_PDF.TabIndex = 1;
            this.RB_PDF.Text = "PDF";
            this.RB_PDF.UseVisualStyleBackColor = true;
            this.RB_PDF.CheckedChanged += new System.EventHandler(this.RB_PDF_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Орентация PDF";
            // 
            // LV_Files
            // 
            this.LV_Files.AllowDrop = true;
            this.LV_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LV_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Files.FullRowSelect = true;
            this.LV_Files.GridLines = true;
            this.LV_Files.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Files.Location = new System.Drawing.Point(0, 49);
            this.LV_Files.Name = "LV_Files";
            this.LV_Files.Size = new System.Drawing.Size(584, 313);
            this.LV_Files.TabIndex = 3;
            this.LV_Files.UseCompatibleStateImageBehavior = false;
            this.LV_Files.View = System.Windows.Forms.View.Details;
            this.LV_Files.DragDrop += new System.Windows.Forms.DragEventHandler(this.LV_Files_DragDrop);
            this.LV_Files.DragEnter += new System.Windows.Forms.DragEventHandler(this.LV_Files_DragEnter);
            this.LV_Files.DragOver += new System.Windows.Forms.DragEventHandler(this.LV_Files_DragOver);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя файла";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MI_About
            // 
            this.MI_About.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MI_About.Name = "MI_About";
            this.MI_About.Size = new System.Drawing.Size(52, 20);
            this.MI_About.Text = "About";
            this.MI_About.Click += new System.EventHandler(this.MI_About_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SB_Add,
            this.SB_Delete,
            this.SL_Count});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SB_Add
            // 
            this.SB_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SB_Add.Image = ((System.Drawing.Image)(resources.GetObject("SB_Add.Image")));
            this.SB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SB_Add.Name = "SB_Add";
            this.SB_Add.Size = new System.Drawing.Size(63, 22);
            this.SB_Add.Text = "Добавить";
            this.SB_Add.Click += new System.EventHandler(this.SB_Add_Click);
            // 
            // SB_Delete
            // 
            this.SB_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SB_Delete.Image = ((System.Drawing.Image)(resources.GetObject("SB_Delete.Image")));
            this.SB_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SB_Delete.Name = "SB_Delete";
            this.SB_Delete.Size = new System.Drawing.Size(55, 22);
            this.SB_Delete.Text = "Удалить";
            this.SB_Delete.Click += new System.EventHandler(this.SB_Delete_Click);
            // 
            // SL_Count
            // 
            this.SL_Count.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SL_Count.Name = "SL_Count";
            this.SL_Count.Size = new System.Drawing.Size(61, 22);
            this.SL_Count.Text = "Файлов: 0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SL_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SL_Status
            // 
            this.SL_Status.Name = "SL_Status";
            this.SL_Status.Size = new System.Drawing.Size(12, 17);
            this.SL_Status.Text = "-";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.LV_Files);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FormMain";
            this.Text = "Росреестр - Tools";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.FLP_Orientation.ResumeLayout(false);
            this.FLP_Orientation.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}