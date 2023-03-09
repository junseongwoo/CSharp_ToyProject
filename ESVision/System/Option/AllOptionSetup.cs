﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESVision
{
    /*
     * XML 파일을 불러오는데 
     * 불러 올 때 파일이 없으면 new class()로 해서 초기화로 생성
     * 있으면 XML 파일 불러오기 
     */
    [Serializable]
    public class AllOptionSetup
    {
        public FileOptionSetup fileOptionSetup { get; set; }
        public PathOptionSetup pathOptionSetup { get; set; }
    }
}
