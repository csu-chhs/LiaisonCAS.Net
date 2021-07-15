using System;
using System.Collections.Generic;
using System.Text;

namespace LiaisonCAS.Net.Exceptions
{
    public class LiaisonClientNotAuthorized : Exception
    {
        public LiaisonClientNotAuthorized() : base()
        {

        }

        public LiaisonClientNotAuthorized(string message) : base(message)
        {

        }

        public LiaisonClientNotAuthorized(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
