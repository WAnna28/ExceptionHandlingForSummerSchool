using System;

namespace ExceptionHandlingForSummerSchoolLib
{
    [Serializable]
    public class CalculationException : Exception
    {
        private static readonly string defaultMessage = "An error occurred during calculation in the ExceptionHandlingForSummerSchoolLib.";

        public CalculationException() { }
        public CalculationException(string message) : base(message) { }
        public CalculationException(string message, Exception inner) : base(message, inner) { }
        protected CalculationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public override string Message
        {
            get
            {
                return base.Message + Environment.NewLine + defaultMessage;
            }
        }
    }

    //Exception    


    //[Serializable]
    //public class MyException : Exception
    //{
    //    public MyException() { }
    //    public MyException(string message) : base(message) { }
    //    public MyException(string message, Exception inner) : base(message, inner) { }
    //    protected MyException(
    //      System.Runtime.Serialization.SerializationInfo info,
    //      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    //}
}