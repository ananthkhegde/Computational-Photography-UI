namespace image_stitching
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnstitchimg = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbloptions = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnclearall = new System.Windows.Forms.Button();
            this.lblupload = new System.Windows.Forms.Label();
            this.txtimg2 = new System.Windows.Forms.TextBox();
            this.txtimg1 = new System.Windows.Forms.TextBox();
            this.btnimg2 = new System.Windows.Forms.Button();
            this.btnimg1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnclear = new System.Windows.Forms.Button();
            this.btntonemap = new System.Windows.Forms.Button();
            this.txtimg1tonemap = new System.Windows.Forms.TextBox();
            this.btnimgtonemap = new System.Windows.Forms.Button();
            this.lbluploadtonemap = new System.Windows.Forms.Label();
            this.panelresult = new System.Windows.Forms.Panel();
            this.pictureBoxresult = new System.Windows.Forms.PictureBox();
            this.panelimg2 = new System.Windows.Forms.Panel();
            this.pictureBoximg2 = new System.Windows.Forms.PictureBox();
            this.panelimg1 = new System.Windows.Forms.Panel();
            this.pictureBoximg1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfileopen = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnsaveas = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelresult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxresult)).BeginInit();
            this.panelimg2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximg2)).BeginInit();
            this.panelimg1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximg1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstitchimg
            // 
            this.btnstitchimg.Location = new System.Drawing.Point(28, 189);
            this.btnstitchimg.Name = "btnstitchimg";
            this.btnstitchimg.Size = new System.Drawing.Size(72, 23);
            this.btnstitchimg.TabIndex = 0;
            this.btnstitchimg.Text = "Stitch Image";
            this.btnstitchimg.UseVisualStyleBackColor = true;
            this.btnstitchimg.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(22, 72);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbloptions);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelresult);
            this.splitContainer1.Panel2.Controls.Add(this.panelimg2);
            this.splitContainer1.Panel2.Controls.Add(this.panelimg1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1020, 537);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbloptions
            // 
            this.lbloptions.AutoSize = true;
            this.lbloptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbloptions.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbloptions.Location = new System.Drawing.Point(11, 4);
            this.lbloptions.Name = "lbloptions";
            this.lbloptions.Size = new System.Drawing.Size(96, 13);
            this.lbloptions.TabIndex = 2;
            this.lbloptions.Text = "Image Edit Options";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(230, 489);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnclearall);
            this.tabPage1.Controls.Add(this.lblupload);
            this.tabPage1.Controls.Add(this.btnstitchimg);
            this.tabPage1.Controls.Add(this.txtimg2);
            this.tabPage1.Controls.Add(this.txtimg1);
            this.tabPage1.Controls.Add(this.btnimg2);
            this.tabPage1.Controls.Add(this.btnimg1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(222, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Panorama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnclearall
            // 
            this.btnclearall.Location = new System.Drawing.Point(107, 189);
            this.btnclearall.Name = "btnclearall";
            this.btnclearall.Size = new System.Drawing.Size(75, 23);
            this.btnclearall.TabIndex = 13;
            this.btnclearall.Text = "Clear All";
            this.btnclearall.UseVisualStyleBackColor = true;
            this.btnclearall.Click += new System.EventHandler(this.btnclearall_Click);
            // 
            // lblupload
            // 
            this.lblupload.AutoSize = true;
            this.lblupload.Location = new System.Drawing.Point(10, 31);
            this.lblupload.Name = "lblupload";
            this.lblupload.Size = new System.Drawing.Size(113, 13);
            this.lblupload.TabIndex = 12;
            this.lblupload.Text = "Please Upload Images";
            // 
            // txtimg2
            // 
            this.txtimg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtimg2.Location = new System.Drawing.Point(81, 106);
            this.txtimg2.Name = "txtimg2";
            this.txtimg2.Size = new System.Drawing.Size(118, 20);
            this.txtimg2.TabIndex = 5;
            // 
            // txtimg1
            // 
            this.txtimg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtimg1.Location = new System.Drawing.Point(81, 67);
            this.txtimg1.Name = "txtimg1";
            this.txtimg1.Size = new System.Drawing.Size(118, 20);
            this.txtimg1.TabIndex = 4;
            // 
            // btnimg2
            // 
            this.btnimg2.Location = new System.Drawing.Point(6, 103);
            this.btnimg2.Name = "btnimg2";
            this.btnimg2.Size = new System.Drawing.Size(69, 23);
            this.btnimg2.TabIndex = 1;
            this.btnimg2.Text = "Image2";
            this.btnimg2.UseVisualStyleBackColor = true;
            this.btnimg2.Click += new System.EventHandler(this.btnimg2_Click);
            // 
            // btnimg1
            // 
            this.btnimg1.Location = new System.Drawing.Point(7, 67);
            this.btnimg1.Name = "btnimg1";
            this.btnimg1.Size = new System.Drawing.Size(68, 23);
            this.btnimg1.TabIndex = 0;
            this.btnimg1.Text = "Image1";
            this.btnimg1.UseVisualStyleBackColor = true;
            this.btnimg1.Click += new System.EventHandler(this.btnimg1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnclear);
            this.tabPage2.Controls.Add(this.btntonemap);
            this.tabPage2.Controls.Add(this.txtimg1tonemap);
            this.tabPage2.Controls.Add(this.btnimgtonemap);
            this.tabPage2.Controls.Add(this.lbluploadtonemap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(222, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tone Map";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(105, 135);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btntonemap
            // 
            this.btntonemap.Location = new System.Drawing.Point(21, 135);
            this.btntonemap.Name = "btntonemap";
            this.btntonemap.Size = new System.Drawing.Size(75, 23);
            this.btntonemap.TabIndex = 3;
            this.btntonemap.Text = "Tone Map";
            this.btntonemap.UseVisualStyleBackColor = true;
            this.btntonemap.Click += new System.EventHandler(this.btntonemap_Click);
            // 
            // txtimg1tonemap
            // 
            this.txtimg1tonemap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtimg1tonemap.Location = new System.Drawing.Point(95, 74);
            this.txtimg1tonemap.Name = "txtimg1tonemap";
            this.txtimg1tonemap.Size = new System.Drawing.Size(108, 20);
            this.txtimg1tonemap.TabIndex = 2;
            // 
            // btnimgtonemap
            // 
            this.btnimgtonemap.Location = new System.Drawing.Point(10, 72);
            this.btnimgtonemap.Name = "btnimgtonemap";
            this.btnimgtonemap.Size = new System.Drawing.Size(75, 23);
            this.btnimgtonemap.TabIndex = 1;
            this.btnimgtonemap.Text = "Image";
            this.btnimgtonemap.UseVisualStyleBackColor = true;
            this.btnimgtonemap.Click += new System.EventHandler(this.btnimgtonemap_Click);
            // 
            // lbluploadtonemap
            // 
            this.lbluploadtonemap.AutoSize = true;
            this.lbluploadtonemap.Location = new System.Drawing.Point(12, 37);
            this.lbluploadtonemap.Name = "lbluploadtonemap";
            this.lbluploadtonemap.Size = new System.Drawing.Size(84, 13);
            this.lbluploadtonemap.TabIndex = 0;
            this.lbluploadtonemap.Text = "Select an Image";
            // 
            // panelresult
            // 
            this.panelresult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelresult.AutoScroll = true;
            this.panelresult.Controls.Add(this.pictureBoxresult);
            this.panelresult.Location = new System.Drawing.Point(111, 261);
            this.panelresult.Name = "panelresult";
            this.panelresult.Size = new System.Drawing.Size(542, 249);
            this.panelresult.TabIndex = 2;
            // 
            // pictureBoxresult
            // 
            this.pictureBoxresult.Location = new System.Drawing.Point(54, 36);
            this.pictureBoxresult.Name = "pictureBoxresult";
            this.pictureBoxresult.Size = new System.Drawing.Size(435, 168);
            this.pictureBoxresult.TabIndex = 0;
            this.pictureBoxresult.TabStop = false;
            // 
            // panelimg2
            // 
            this.panelimg2.Controls.Add(this.pictureBoximg2);
            this.panelimg2.Location = new System.Drawing.Point(396, 4);
            this.panelimg2.Name = "panelimg2";
            this.panelimg2.Size = new System.Drawing.Size(355, 207);
            this.panelimg2.TabIndex = 1;
            // 
            // pictureBoximg2
            // 
            this.pictureBoximg2.Location = new System.Drawing.Point(18, 5);
            this.pictureBoximg2.Name = "pictureBoximg2";
            this.pictureBoximg2.Size = new System.Drawing.Size(262, 112);
            this.pictureBoximg2.TabIndex = 1;
            this.pictureBoximg2.TabStop = false;
            // 
            // panelimg1
            // 
            this.panelimg1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelimg1.AutoScroll = true;
            this.panelimg1.Controls.Add(this.pictureBoximg1);
            this.panelimg1.Location = new System.Drawing.Point(13, 4);
            this.panelimg1.Name = "panelimg1";
            this.panelimg1.Size = new System.Drawing.Size(338, 207);
            this.panelimg1.TabIndex = 0;
            // 
            // pictureBoximg1
            // 
            this.pictureBoximg1.Location = new System.Drawing.Point(23, 5);
            this.pictureBoximg1.Name = "pictureBoximg1";
            this.pictureBoximg1.Size = new System.Drawing.Size(227, 112);
            this.pictureBoximg1.TabIndex = 0;
            this.pictureBoximg1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnfileopen);
            this.panel1.Controls.Add(this.btnprint);
            this.panel1.Controls.Add(this.btnsaveas);
            this.panel1.Location = new System.Drawing.Point(22, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 39);
            this.panel1.TabIndex = 3;
            // 
            // btnfileopen
            // 
            this.btnfileopen.Image = global::image_stitching.Properties.Resources.open___Copy___Copy;
            this.btnfileopen.Location = new System.Drawing.Point(3, 2);
            this.btnfileopen.Name = "btnfileopen";
            this.btnfileopen.Size = new System.Drawing.Size(55, 32);
            this.btnfileopen.TabIndex = 5;
            this.btnfileopen.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.Image = global::image_stitching.Properties.Resources.print;
            this.btnprint.Location = new System.Drawing.Point(112, 1);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(54, 32);
            this.btnprint.TabIndex = 4;
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnsaveas
            // 
            this.btnsaveas.Image = global::image_stitching.Properties.Resources.saveas;
            this.btnsaveas.Location = new System.Drawing.Point(60, 1);
            this.btnsaveas.Name = "btnsaveas";
            this.btnsaveas.Size = new System.Drawing.Size(45, 33);
            this.btnsaveas.TabIndex = 3;
            this.btnsaveas.UseVisualStyleBackColor = true;
            this.btnsaveas.Click += new System.EventHandler(this.btnsaveas_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelresult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxresult)).EndInit();
            this.panelimg2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximg2)).EndInit();
            this.panelimg1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximg1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstitchimg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbloptions;
        private System.Windows.Forms.Button btnimg2;
        private System.Windows.Forms.Button btnimg1;
        private System.Windows.Forms.TextBox txtimg2;
        private System.Windows.Forms.TextBox txtimg1;
        private System.Windows.Forms.Panel panelimg2;
        private System.Windows.Forms.Panel panelimg1;
        private System.Windows.Forms.PictureBox pictureBoximg2;
        private System.Windows.Forms.PictureBox pictureBoximg1;
        private System.Windows.Forms.Panel panelresult;
        private System.Windows.Forms.PictureBox pictureBoxresult;
        private System.Windows.Forms.Button btnfileopen;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnsaveas;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblupload;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnclearall;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btntonemap;
        private System.Windows.Forms.TextBox txtimg1tonemap;
        private System.Windows.Forms.Button btnimgtonemap;
        private System.Windows.Forms.Label lbluploadtonemap;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

