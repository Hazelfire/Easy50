using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Powerpoint = Microsoft.Office.Interop.PowerPoint;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.IO;
using System.Drawing;

namespace Easy50
{
    class Generator
    {
        private static string getValueOfCell(ref Excel.Worksheet sheet, int x, int y)
        {
            Excel.Range cell = sheet.Cells[y, x] as Excel.Range;
            return cell.Value;
        }

        private static string findFileInFolder(string folder, string fileName)
        {
            string[] subFiles = Directory.GetFileSystemEntries(folder);
            foreach(string currentFile in subFiles)
            {
                FileAttributes attributes = File.GetAttributes(currentFile);
                if (attributes.HasFlag(FileAttributes.Directory))
                {
                    string file = findFileInFolder(currentFile, fileName);
                    if (file != "")
                    {
                        return file;
                    }
                }
                else
                {
                    if (Path.GetFileName(currentFile) == fileName)
                    {
                        return currentFile;
                    }
                }
            }
            return "";
        }

        public static void generate(GenInfo genInfo)
        {
            Powerpoint.Application powerApp = new Powerpoint.Application();

            Powerpoint.Presentation awardsPresentation = powerApp.Presentations.Open(genInfo.awardPowerpointTemplateFile, MsoTriState.msoFalse, MsoTriState.msoTrue, MsoTriState.msoFalse);

            int startingNumberOfSlides = awardsPresentation.Slides.Count;
       
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook awardsWorkbook = excelApp.Workbooks.Open(genInfo.awardExcelFile, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "/t", false, false, 0, true, 1, 0);
            Excel.Worksheet awardsWorksheet = awardsWorkbook.Worksheets[1];

            int lastUsedRow = awardsWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Row;

            for (int rowIndex = genInfo.startingRow; rowIndex <= lastUsedRow; rowIndex++)
            {
                if (getValueOfCell(ref awardsWorksheet, genInfo.studentCodeColumn, rowIndex) == "")
                {
                    continue;
                }

                Powerpoint.Slide currentSlide = awardsPresentation.Slides.AddSlide(awardsPresentation.Slides.Count + 1, awardsPresentation.SlideMaster.CustomLayouts[genInfo.awardLayoutIndex]);

                Powerpoint.Shapes slideShapes = currentSlide.Shapes;

                Powerpoint.Placeholders placeholders = slideShapes.Placeholders;

                int placeholderIndex = 1;
                foreach (Powerpoint.Shape shape in placeholders)
                {
                    // Set Student Name
                    if (placeholderIndex == genInfo.awardStudentNamePlaceholderIndex)
                    {
                        shape.TextFrame.TextRange.Text = getValueOfCell(ref awardsWorksheet, genInfo.studentNameColumn, rowIndex);
                    }

                    // Set Student Form
                    if (placeholderIndex == genInfo.awardStudentFormPlaceholderIndex)
                    {
                        Powerpoint.TextFrame frame = shape.TextFrame;
                        
                        Powerpoint.TextRange range = frame.TextRange;
                        range.Text = getValueOfCell(ref awardsWorksheet, genInfo.studentFormColumn, rowIndex);
                        
                    }

                    // Set award
                    if (placeholderIndex == genInfo.awardAwardTitlePlaceholderIndex)
                    {
                        shape.TextFrame.TextRange.Text = getValueOfCell(ref awardsWorksheet, genInfo.studentAwardColumn, rowIndex);
                    }

                    // Set picture
                    if (placeholderIndex == genInfo.awardStudentPicturePlaceholderIndex)
                    {
                        string studentCode = getValueOfCell(ref awardsWorksheet, genInfo.studentCodeColumn, rowIndex);
                        string pictureFile = findFileInFolder(genInfo.picturesFolder, studentCode + genInfo.pictureFileExtension);
                        if (pictureFile != "")
                        {
                            shape.Fill.UserPicture(pictureFile);
                        }
                        else
                        {
                            Console.Out.WriteLine("Picture for " + studentCode + " not found");
                        }

                    }
                    placeholderIndex++;

                }

            }

            for(int i = 0; i < startingNumberOfSlides; i++)
            {
                awardsPresentation.Slides[1].Delete();
            }

            

            awardsPresentation.SaveAs(Path.GetDirectoryName(genInfo.awardPowerpointTemplateFile) + "/Output.pptx");

            
        }
    }
}
