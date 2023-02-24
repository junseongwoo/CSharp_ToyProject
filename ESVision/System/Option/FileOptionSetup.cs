using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESVision
{
    [Serializable]
    public class FileOptionSetup
    {
        [Category("Test")]
        public int Test1 { get; set; }

        public FileOptionSetup()
        {

        }
    }


}
