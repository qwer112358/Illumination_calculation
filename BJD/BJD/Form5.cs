using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJD
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void showListLabel(ListBox listBoxNotHide)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBoxNotHide.Visible = true;
        }

        private void showPictureBox(PictureBox[] pictureBoxes)
        {
            foreach(PictureBox item in pictureBoxes)
            {
                item.Visible = true;
            }
        }

        private void hidePictureBox()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            scheme1.Visible = false;
            scheme2.Visible = false;
            scheme3.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePictureBox();
            header.Visible = true;
            header.Text = linkLabel1.Text;
            hidePictureBox();
            showListLabel(listBox1);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePictureBox();
            header.Visible = true;
            header.Text = "Цель расчета освещения";
            showListLabel(listBox2);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePictureBox();
            header.Visible = true;
            header.Text = "Коэффициент использования светового потока";
            PictureBox[] pictureBoxes = new PictureBox[4] { pictureBox1, pictureBox2, pictureBox3, scheme1};
            showPictureBox(pictureBoxes);
            showListLabel(listBox3);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePictureBox();
            header.Visible = true;
            header.Text = "Удельная мощность светильника";
            scheme2.Visible = true;
            showListLabel(listBox4);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePictureBox();
            header.Visible = true;
            header.Text = "Метод светящихся линий";
            PictureBox[] pictureBoxes = new PictureBox[4] { pictureBox4, pictureBox5, pictureBox6, scheme3};
            showPictureBox(pictureBoxes);
            showListLabel(listBox5);
        }
    }
}
