﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    public class GradeStatistics
    { 
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
