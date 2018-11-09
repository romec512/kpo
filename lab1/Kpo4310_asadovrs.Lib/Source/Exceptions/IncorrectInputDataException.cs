using System;
namespace Kpo4310_asadovrs.Lib.Exceptions
{
    public class IncorrectInputDataException : Exception
    {
        private string _message;

        public override string Message 
        { 
            get {
                return _message;
            }
        }

        public IncorrectInputDataException(string message) : base(message)
        {
            _message = message;
        }
    }
}
