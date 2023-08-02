namespace GDPIControl
{
    partial class FormAbout
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LL_Control = new LinkLabel();
            label1 = new Label();
            L_Version = new Label();
            LL_Icons = new LinkLabel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(284, 93);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(LL_Control);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(L_Version);
            flowLayoutPanel1.Controls.Add(LL_Icons);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(60, 3);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(220, 87);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // LL_Control
            // 
            LL_Control.AutoSize = true;
            LL_Control.LinkArea = new LinkArea(0, 7);
            LL_Control.Location = new Point(4, 0);
            LL_Control.Margin = new Padding(4, 0, 4, 0);
            LL_Control.Name = "LL_Control";
            LL_Control.Size = new Size(112, 21);
            LL_Control.TabIndex = 3;
            LL_Control.TabStop = true;
            LL_Control.Text = "RRTools от Virenbar";
            LL_Control.UseCompatibleTextRendering = true;
            LL_Control.LinkClicked += LL_Control_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 2;
            label1.Text = "Приложение для конвертации XML файлов росреестра в HTML/PDF";
            // 
            // L_Version
            // 
            L_Version.AutoSize = true;
            L_Version.Location = new Point(4, 51);
            L_Version.Margin = new Padding(4, 0, 4, 0);
            L_Version.Name = "L_Version";
            L_Version.Size = new Size(14, 15);
            L_Version.TabIndex = 3;
            L_Version.Text = "V";
            // 
            // LL_Icons
            // 
            LL_Icons.AutoSize = true;
            LL_Icons.LinkArea = new LinkArea(10, 7);
            LL_Icons.Location = new Point(4, 66);
            LL_Icons.Margin = new Padding(4, 0, 4, 0);
            LL_Icons.Name = "LL_Icons";
            LL_Icons.Size = new Size(102, 21);
            LL_Icons.TabIndex = 4;
            LL_Icons.TabStop = true;
            LL_Icons.Text = "Иконки от Icons8";
            LL_Icons.UseCompatibleTextRendering = true;
            LL_Icons.LinkClicked += LL_Icons_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = RR.WinForms.Properties.Resources.RR_Image;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(284, 162);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(400, 250);
            MinimizeBox = false;
            MinimumSize = new Size(300, 201);
            Name = "FormAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About RRTools";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label L_Version;
        private FlowLayoutPanel flowLayoutPanel1;
        private LinkLabel LL_Control;
        private LinkLabel LL_Icons;
    }
}