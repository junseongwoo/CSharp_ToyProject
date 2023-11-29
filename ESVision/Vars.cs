using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESVision
{
    public class Vars
    {
        
        public static SortedList<string, string> ImagePath { get; set; } = new SortedList<string, string>();

        public static ImgLib imgLib;
        public static int openImgNum = 0;
        
    }
}
