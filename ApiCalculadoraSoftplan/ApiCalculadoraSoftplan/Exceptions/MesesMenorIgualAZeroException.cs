using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Exceptions
{
    [Serializable]
    public class MesesMenorIgualAZeroException : Exception
    {
        public MesesMenorIgualAZeroException() : base("Valor do parâmetro \"meses\" menor ou igual a zero.")  
        {
        }

        public MesesMenorIgualAZeroException(string message) : base(message)
        {
        }

        public MesesMenorIgualAZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MesesMenorIgualAZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
