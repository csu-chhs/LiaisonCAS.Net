using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels.ApplicationDetails
{
    public class DocumentsResourceModel
    {
        public DocumentsResourceModel()
        {
            Attachments = new List<AttachmentResourceModel>();
        }
        public List<AttachmentResourceModel>? Attachments { get; set; }
        public string? CompletionStatus { get; set; }
    }
}
