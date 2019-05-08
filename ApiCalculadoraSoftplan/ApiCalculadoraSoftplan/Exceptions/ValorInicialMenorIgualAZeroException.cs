using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiCalculadoraSoftplan.Exceptions
{
    [Serializable]
    public class ValorInicialMenorIgualAZeroException : Exception
    {
        public ValorInicialMenorIgualAZeroException() : base("Valor do parâmetro \"valorinicial\" menor ou igual a zero.")  
        {
        }

        public ValorInicialMenorIgualAZeroException(string message) : base(message)
        {
        }

        public ValorInicialMenorIgualAZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValorInicialMenorIgualAZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
