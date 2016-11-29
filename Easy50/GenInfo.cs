using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy50
{
    public struct GenInfo
    {

        public string awardExcelFile;
        public string picturesFolder;
        public string awardPowerpointTemplateFile;

        public int startingRow;
        public int studentNameColumn;
        public int studentFormColumn;
        public int studentCodeColumn;
        public int studentAwardColumn;

        public string pictureFileExtension;

        int awardHeadingLayoutIndex;
        int awardLayoutIndex;
        int awardHeadingAwardTitlePlaceholderIndex;
        int awardAwardTitlePlaceholderIndex;
        int awardStudentNamePlaceholderIndex;
        int awardStudentPicturePlaceholderIndex;
        int awardStudentFormPlaceholderIndex;
    } 
}
