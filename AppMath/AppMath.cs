using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMath
{
    public class AppMath
    {

		// Métodos de verificación

		// Verifica una división y devuelve 0 si es error
		public decimal Dividir(decimal Dividendo, decimal Divisor)
		{

			decimal Retorno;

			Retorno = 0;

			if (Divisor != 0)
				Retorno = (Dividendo / Divisor);
			else
				Retorno = 0;

			return Retorno;

		}

    }
}
