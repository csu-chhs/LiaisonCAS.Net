using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.AggregateModels
{
    public class ApplicationsSelectedProgram
    {
        public DateTime? deadline { get; set; }
        public long Id { get; set; }
        public string name { get; set; }
        public string submissionStatus { get; set; }
    }
}
