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
    public partial class PicturesFolderConfig : Form
    {
        GenInfo mGenInfo;
        public PicturesFolderConfig(GenInfo generationInfo)
        {
            mGenInfo = generationInfo;
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            mGenInfo.pictureFileExtension = extensionTextBox.Text;

            new Powerpoint_config(mGenInfo).Show();
            Hide();
            // Pass on the chain
        }

        private void PicturesFolderConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
