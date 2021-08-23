using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.ResourceModels
{
    public class FileResourceModel
    {
        public byte[] Data { get; set; }
        public string? ContentType { get; set; }
        public string? Url { get; set; }
    }
}
