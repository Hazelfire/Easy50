using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Easy50
{
    public partial class ExcelConfig : Form
    {
        GenInfo mCurrentGenerationInfo;

        Excel.Application mxlApp;
        Excel.Worksheet mAwardsSheet;

        bool mHasHeadings = false;
        int mStudentNameColumn = 1;
        int mStudentFormColumn = 1;
        int mStudentCodeColumn = 1;
        int mStudentAwardColumn = 1;

        public ExcelConfig(GenInfo generationInfo)
        {
            mCurrentGenerationInfo = generationInfo;

            mxlApp = new Excel.Application();

            Excel.Workbook awardsWorkbook = mxlApp.Workbooks.Open(generationInfo.awardExcelFile, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "/t", false, false, 0, true, 1, 0);
            mAwardsSheet = (Excel.Worksheet)awardsWorkbook.Worksheets.get_Item(1);

            InitializeComponent();
        }

        public void ExcelConfig_Load(object sender, EventArgs e)
        {
            updateExample();
        }

        private void updateExample()
        {
            int startingRow = 1;
            if (mHasHeadings)
            {
                startingRow++;
            }

            Excel.Range nameCell = mAwardsSheet.Cells[startingRow, mStudentNameColumn] as Excel.Range;
            string exampleName = nameCell.Value;
            exampleStudentNameLabel.Text = "Name: " + exampleName;

            Excel.Range formCell = mAwardsSheet.Cells[startingRow, mStudentFormColumn] as Excel.Range;
            string exampleForm = formCell.Value;
            exampleStudentFormLabel.Text = "Form: " + exampleForm;

            Excel.Range codeCell = mAwardsSheet.Cells[startingRow, mStudentCodeColumn] as Excel.Range;
            string exampleCode = codeCell.Value;
            exampleStudentCodeLabel.Text = "Code: " + exampleCode;

            Excel.Range awardCell = mAwardsSheet.Cells[startingRow, mStudentAwardColumn] as Excel.Range;
            string exampleAward = awardCell.Value;
            exampleStudentAwardLabel.Text = "Award: " + exampleAward;

        }

        private void studentNameSelector_ValueChanged(object sender, EventArgs e)
        {
            mStudentNameColumn =(int) studentNameSelector.Value;
            updateExample();
        }

        private void studentFormSelector_ValueChanged(object sender, EventArgs e)
        {
            mStudentFormColumn = (int)studentFormSelector.Value;
            updateExample();
        }

        private void studentCodeSelector_ValueChanged(object sender, EventArgs e)
        {
            mStudentCodeColumn = (int)studentCodeSelector.Value;
            updateExample();
        }

        private void studentAwardSelector_ValueChanged(object sender, EventArgs e)
        {
            mStudentAwardColumn = (int)studentAwardSelector.Value;
            updateExample();
        }

        private void headingsBox_CheckedChanged(object sender, EventArgs e)
        {
            mHasHeadings = headingsBox.Checked;
            updateExample();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            int startingRow = 1;
            if (mHasHeadings)
            {
                startingRow++;
            }

            mCurrentGenerationInfo.startingRow = startingRow;
            mCurrentGenerationInfo.studentAwardColumn = mStudentAwardColumn;
            mCurrentGenerationInfo.studentCodeColumn = mStudentCodeColumn;
            mCurrentGenerationInfo.studentFormColumn = mStudentFormColumn;
            mCurrentGenerationInfo.studentNameColumn = mStudentNameColumn;

            
            new PicturesFolderConfig(mCurrentGenerationInfo).Show();
            Hide();
        }
    }
}
