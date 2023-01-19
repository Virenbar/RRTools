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
            this.B_Convert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.B_OpenOut = new System.Windows.Forms.Button();
            this.LV_Files = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Convert
            // 
            this.B_Convert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Convert.AutoSize = true;
            this.B_Convert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Convert.Location = new System.Drawing.Point(525, 61);
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.B_Convert, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.B_OpenOut, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 361);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // B_OpenOut
            // 
            this.B_OpenOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_OpenOut.AutoSize = true;
            this.B_OpenOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_OpenOut.Location = new System.Drawing.Point(210, 61);
            this.B_OpenOut.Name = "B_OpenOut";
            this.B_OpenOut.Padding = new System.Windows.Forms.Padding(1);
            this.B_OpenOut.Size = new System.Drawing.Size(101, 27);
            this.B_OpenOut.TabIndex = 0;
            this.B_OpenOut.Text = "Открыть папку";
            this.B_OpenOut.UseVisualStyleBackColor = true;
            this.B_OpenOut.Click += new System.EventHandler(this.B_OpenOut_Click);
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
            this.LV_Files.Location = new System.Drawing.Point(0, 24);
            this.LV_Files.Name = "LV_Files";
            this.LV_Files.Size = new System.Drawing.Size(631, 337);
            this.LV_Files.TabIndex = 3;
            this.LV_Files.UseCompatibleStateImageBehavior = false;
            this.LV_Files.View = System.Windows.Forms.View.Details;
            this.LV_Files.DragDrop += new System.Windows.Forms.DragEventHandler(this.LV_Files_DragDrop);
            this.LV_Files.DragEnter += new System.Windows.Forms.DragEventHandler(this.LV_Files_DragEnter);
            this.LV_Files.DragOver += new System.Windows.Forms.DragEventHandler(this.LV_Files_DragOver);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Файл";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.очиститьСписокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // очиститьСписокToolStripMenuItem
            // 
            this.очиститьСписокToolStripMenuItem.Name = "очиститьСписокToolStripMenuItem";
            this.очиститьСписокToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.очиститьСписокToolStripMenuItem.Text = "Очистить список";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 461);
            this.Controls.Add(this.LV_Files);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem очиститьСписокToolStripMenuItem;
    }
}