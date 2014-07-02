using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;

namespace image_stitching
{
    #region "Class defination"
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string outputstr =  Application.StartupPath + "\\result.jpg";
            if (validate())
            {
                stitch st = new stitch();
                if (File.Exists(outputstr))
                {   
                    File.Delete(outputstr);
                }
                st.StitchImage(txtimg2.Text, txtimg1.Text);
                pictureBoxresult.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBoxresult.Image = LoadUnlocked(outputstr);
                btnsaveas.Enabled = true;
                trackBar1.Visible = true;
            }
        }
        private Bitmap LoadUnlocked(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                return new Bitmap(bm);
            }
        }
        private bool validate()
        {
            Boolean success = true;
            if (string.IsNullOrEmpty(txtimg1.Text))
            {
                errorProvider1.SetError(txtimg1, "Please upload first image");
                success = false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txtimg2.Text))
            {
                errorProvider2.SetError(txtimg2, "Please upload second image");
                success = false;
            }
            else
            {
                errorProvider2.Clear();
            }
            return success;
        }
        private bool validatetonemap()
        {
            Boolean success = true;
            if (string.IsNullOrEmpty(txtimg1tonemap.Text))
            {
                errorProvider3.SetError(txtimg1tonemap, "Please upload an image");
                success = false;
            }
            else
            {
                errorProvider3.Clear();
            }
            return success;
        }

       

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnimg1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtimg1.Text = open.FileName;
                    pictureBoximg1.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBoximg1.Image = LoadUnlocked(open.FileName);
                    pictureBoximg1.BackgroundImageLayout = ImageLayout.Stretch;
                    trackBar1.Visible = true;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }
        public Image PictureBoxZoom(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics grap = Graphics.FromImage(bm);
            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bm;
        }
        private void btnimg2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtimg2.Text = open.FileName;
                  //  Bitmap bit = new Bitmap(open.FileName);
                    pictureBoximg2.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBoximg2.Image = LoadUnlocked(open.FileName);
                    pictureBoximg2.BackgroundImageLayout = ImageLayout.Stretch;
                    trackBar2.Visible = true;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void btnsaveas_Click(object sender, EventArgs e)
        {
            Saveas();
           
        }
        private void Saveas()
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";

            saveFileDialog1.Title = "Save an Image File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxresult.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void btnclearall_Click(object sender, EventArgs e)
        {
            txtimg1.Text = string.Empty;
                txtimg2.Text = string.Empty;
                //checkBoxtonemap.Checked = false;
                pictureBoximg1.Image = null;
                pictureBoximg2.Image = null;
                pictureBoxresult.Image = null;
                btnsaveas.Enabled = false;
                trackBar1.Visible = false;
                trackBar2.Visible = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtimg1tonemap.Text = string.Empty;
            pictureBoximg1.Image = null;
            pictureBoxresult.Image = null;
            btnsaveas.Enabled = false;
            trackBar1.Visible = false;
        }

        private void btnimgtonemap_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtimg1tonemap.Text = open.FileName;
                    pictureBoximg1.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBoximg1.Image = LoadUnlocked(open.FileName);
                    trackBar1.Visible = true;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void btntonemap_Click(object sender, EventArgs e)
        {
           
            if (validatetonemap())
            {
                string outputstr = Application.StartupPath + "\\out.jpg";
                if (File.Exists(outputstr))
                {
                    File.Delete(outputstr);
                }
                Tonemapping tm = new Tonemapping();
                tm.Maptone(txtimg1tonemap.Text);
                pictureBoxresult.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBoxresult.Image = LoadUnlocked(outputstr);
                btnsaveas.Enabled = true;
            }
        }

        private void btnfileopen_Click(object sender, EventArgs e)
        {
            openfile();
        }

        private void openfile()
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBoximg2.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBoxresult.Image = LoadUnlocked(open.FileName);

                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openfile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saveas();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toneMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void panoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string imagepath = null;
            imagepath = (tabControl1.SelectedIndex == 0)?txtimg1.Text:txtimg1tonemap.Text;
            Image image1 = Image.FromFile(imagepath);
            if (trackBar1.Value >0)
            {
                pictureBoximg1.Image = null;

                pictureBoximg1.Image = PictureBoxZoom(image1, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Image image2 = Image.FromFile(txtimg2.Text);
            if (trackBar2.Value > 0)
            {
                pictureBoximg2.Image = null;

                pictureBoximg2.Image = PictureBoxZoom(image2, new Size(trackBar2.Value, trackBar2.Value));
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }
    }
}
    # endregion