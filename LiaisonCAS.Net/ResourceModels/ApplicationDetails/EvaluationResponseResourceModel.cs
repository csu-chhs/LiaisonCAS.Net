using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class EvaluationResponseResourceModel
    {
        public string? Comments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? DocType { get; set; }
        public int? EvaluatorId { get; set; }
        public string? FileName { get; set; }
        public string? FileType { get; set; }
        public string? FileUploadedDate { get; set; }
        public int? Id { get; set; }
        public DateTime? ResponseDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
