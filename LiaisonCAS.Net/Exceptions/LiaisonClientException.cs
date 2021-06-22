using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.Exceptions
{
    public class LiaisonClientException : Exception
    {
        public LiaisonClientException() : base()
        {

        }

        public LiaisonClientException(string message) : base(message)
        {

        }

        public LiaisonClientException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
