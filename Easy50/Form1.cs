using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            GenInfo information = new GenInfo();
            information.awardExcelFile = awardsExcelText.Text;
            information.awardPowerpointTemplateFile = powerpointText.Text;
            information.picturesFolder = picturesText.Text;

            ExcelConfig excelConfig = new ExcelConfig(information);
            Hide();
            excelConfig.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogue = new OpenFileDialog();
            if(dialogue.ShowDialog() == DialogResult.OK)
            {
                awardsExcelText.Text = dialogue.FileName;
            }
        }

        private void powerpointOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogue = new OpenFileDialog();
            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                powerpointText.Text = dialogue.FileName;
            }
        }

        private void picturesOpen_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog dialogue = new FolderBrowserDialog();
            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                picturesText.Text = dialogue.SelectedPath;
            }
        }
    }
}
