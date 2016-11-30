using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
using System.IO;

namespace Easy50
{
    public partial class Powerpoint_config : Form
    {

        PowerPoint.Presentation mPresentation;

        GenInfo mGenInfo;
        public Powerpoint_config(GenInfo generationInfo)
        {
            mGenInfo = generationInfo;
            InitializeComponent();
        }

        private void addItemToCombo(string item)
        {
            awardHeadingMasterCombo.Items.Add(item);
            singleAwardMasterCombo.Items.Add(item);
        }

        private void Powerpoint_config_Load(object sender, EventArgs e)
        {
            PowerPoint.Application powerApp = new PowerPoint.Application();
            mPresentation = powerApp.Presentations.Open(mGenInfo.awardPowerpointTemplateFile, MsoTriState.msoFalse, MsoTriState.msoTrue, MsoTriState.msoFalse);

            for (int i = 0; i < mPresentation.SlideMaster.CustomLayouts.Count; i++)
            {
                addItemToCombo(mPresentation.SlideMaster.CustomLayouts[i + 1].Name);
            }
            
        }

        private void awardHeadingMasterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            int comboIndex = awardHeadingMasterCombo.SelectedIndex;

            mGenInfo.awardHeadingLayoutIndex = comboIndex + 1;

            PowerPoint.CustomLayout selectedLayout = mPresentation.SlideMaster.CustomLayouts[comboIndex + 1];
            mPresentation.Slides.AddSlide(mPresentation.Slides.Count + 1, selectedLayout);
            string workingDirectory = Directory.GetCurrentDirectory();

            awardHeadingTextBoxCombo.Items.Clear();

            // Load the placeholder combo boxes and such
            PowerPoint.Shapes shapes = selectedLayout.Shapes;

            foreach(PowerPoint.Shape shape in shapes)
            {
                if(shape.Type == MsoShapeType.msoPlaceholder)
                {
                    awardHeadingTextBoxCombo.Items.Add(shape.Name);
                }
            }

            if (File.Exists(workingDirectory + "/AwardHeadingRender.png"))
            {
                if (headingPictureBox.Image != null)
                    headingPictureBox.Image.Dispose();
                File.Delete(workingDirectory + "/AwardHeadingRender.png");
            }

            mPresentation.Slides[mPresentation.Slides.Count].Export(workingDirectory + "/AwardHeadingRender.png", "png", headingPictureBox.Width, headingPictureBox.Height);

            headingPictureBox.Image = Image.FromFile(workingDirectory + "/AwardHeadingRender.png");


        }

        private void singleAwardMasterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboIndex = singleAwardMasterCombo.SelectedIndex;

            mGenInfo.awardLayoutIndex = comboIndex + 1;

            PowerPoint.CustomLayout selectedLayout = mPresentation.SlideMaster.CustomLayouts[comboIndex + 1];
            mPresentation.Slides.AddSlide(mPresentation.Slides.Count + 1, selectedLayout);
            string workingDirectory = Directory.GetCurrentDirectory();

            imagePlaceholderCombo.Items.Clear();
            awardPlaceholderCombo.Items.Clear();
            formPlaceholderCombo.Items.Clear();
            studentNamePlaceholderCombo.Items.Clear();

            // Load the text boxes and such
            PowerPoint.Shapes shapes = selectedLayout.Shapes;

            foreach (PowerPoint.Shape shape in shapes)
            {
                if (shape.Type == MsoShapeType.msoPlaceholder)
                {
                    imagePlaceholderCombo.Items.Add(shape.Name);
                    awardPlaceholderCombo.Items.Add(shape.Name);
                    formPlaceholderCombo.Items.Add(shape.Name);
                    studentNamePlaceholderCombo.Items.Add(shape.Name);
                }
            }

            if (File.Exists(workingDirectory + "/AwardSlideRender.png"))
            {
                if (awardPictureBox.Image != null)
                    awardPictureBox.Image.Dispose();
                File.Delete(workingDirectory + "/AwardSlideRender.png");
            }

            mPresentation.Slides[mPresentation.Slides.Count].Export(workingDirectory + "/AwardSlideRender.png", "png", headingPictureBox.Width, headingPictureBox.Height);

            awardPictureBox.Image = Image.FromFile(workingDirectory + "/AwardSlideRender.png");



        }

        private void awardHeadingTextBoxCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mGenInfo.awardHeadingAwardTitlePlaceholderIndex = awardHeadingMasterCombo.SelectedIndex + 1;
        }

        private void imagePlaceholderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mGenInfo.awardStudentPicturePlaceholderIndex = imagePlaceholderCombo.SelectedIndex + 1;
        }

        private void formPlaceholderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mGenInfo.awardStudentFormPlaceholderIndex = formPlaceholderCombo.SelectedIndex + 1;
        }

        private void studentNamePlaceholderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mGenInfo.awardStudentNamePlaceholderIndex = studentNamePlaceholderCombo.SelectedIndex + 1;
        }

        private void awardPlaceholderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mGenInfo.awardAwardTitlePlaceholderIndex = awardPlaceholderCombo.SelectedIndex + 1;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Generator.generate(mGenInfo);
            Hide();
        }
    }
}
