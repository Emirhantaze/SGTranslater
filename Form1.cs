using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGTranslater
{
    public partial class Form1 : Form
    {
        String a;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog open = new CommonOpenFileDialog())
            {
                open.IsFolderPicker = false;
                open.Multiselect = true;

                open.DefaultDirectory = "d:\\";
                open.InitialDirectory = "d:\\";
                if (open.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    a = open.FileName;
                }
                MessageBox.Show(a);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Dosyalar dosya = new Dosyalar(".\\save.txt");
            label1.Text = dosya.text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Visible = false;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
