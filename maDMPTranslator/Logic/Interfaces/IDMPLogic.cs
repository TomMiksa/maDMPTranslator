﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maDMPTranslator.Logic.Interfaces
{
    public interface IDMPLogic
    {
        Dictionary<string, string> InitializeHeaderDict(Models.RDA_DMP.maDMP maDMP);
        Dictionary<string, string> InitializeQuestionsDict();
        Dictionary<string, List<string>> InitializeAnswersDict(Models.RDA_DMP.maDMP maDMP);
    }
}