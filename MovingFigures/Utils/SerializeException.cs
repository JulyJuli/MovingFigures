using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingFigures
{
    [Serializable]
    class DeserializeException : Exception
    {
        private string messageDetails = String.Empty;
        public string CauseOfError { get; set; }
        public DeserializeException() { }
        public DeserializeException(string message) : base(message) { } 
        public DeserializeException(string message,
        System.Exception inner) : base( message, inner ) { }

        public override string Message
        {
            get
            {
                return string.Format(" Something wrong with input data... {0}", messageDetails);
            }
        }
    }
}
