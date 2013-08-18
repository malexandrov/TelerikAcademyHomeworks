using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InvalidRangeExceptionExercise
{
    class InvalidRangeException<T> : ApplicationException
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T start;
        private T end;


        public T Start
        {
            get { return start; }

        }

        public T End
        {
            get { return end; }

        }

        public InvalidRangeException() : base()
        {
        }

        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {
        }

        public InvalidRangeException(string message, Exception innerException) : base (message, innerException)
        {
        }
        public InvalidRangeException(string message, Exception innerException, T start, T end)
            : base(message, innerException)
        {
            this.start = start;
            this.end = end;
        }

        protected InvalidRangeException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }

    }
}
