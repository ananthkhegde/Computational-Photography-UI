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

namespace image_stitching
{
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
                //  st.StitchImage("E:\\IIITB\\Sumer Sem\\SE\\Harsha\\testimages\\bed3.jpg","E:\\IIITB\\Sumer Sem\\SE\\Harsha\\testimages\\bed2.jpg");
                if (File.Exists(outputstr))
                {   
                    File.Delete(outputstr);
                }
                st.StitchImage(txtimg2.Text, txtimg1.Text);
                
               
                pictureBoxresult.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBoxresult.Image = LoadUnlocked(outputstr);
                
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
                    Bitmap bit = new Bitmap(open.FileName);
                    pictureBoximg1.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBoximg1.Image = bit;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
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
                    Bitmap bit = new Bitmap(open.FileName);
                    pictureBoximg2.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBoximg2.Image = bit;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void btnsaveas_Click(object sender, EventArgs e)
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
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtimg1tonemap.Text = string.Empty;
            pictureBoximg1.Image = null;
            pictureBoxresult.Image = null;
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
                    Bitmap bit = new Bitmap(open.FileName);
                    pictureBoximg1.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBoximg1.Image = bit;
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
                Tonemapping tm = new Tonemapping();
                tm.Maptone(txtimg1tonemap.Text);
                Bitmap bit = new Bitmap("E:\\IIITB\\Sumer Sem\\SE\\Harsha - Copy\\image_stitching\\image_stitching\\bin\\Debug\\out.jpg");
                pictureBoxresult.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBoxresult.Image = bit;
            }
        }
    }
}
