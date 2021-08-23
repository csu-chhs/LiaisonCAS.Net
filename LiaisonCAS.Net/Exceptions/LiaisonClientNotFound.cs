using System;

namespace LiaisonCAS.Net.Exceptions
{
    public class LiaisonClientNotFound : Exception
    {
        public LiaisonClientNotFound() : base()
        {

        }

        public LiaisonClientNotFound(string message) : base(message)
        {

        }

        public LiaisonClientNotFound(string message, Exception? inner) : base(message, inner)
        {

        }
    }
}
