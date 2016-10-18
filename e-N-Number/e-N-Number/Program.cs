using System;
using System.Globalization;

namespace e_N_Number
{
    internal class Program
    {
        private static void Main()
        {
            ////Se inicia el programa
            Console.WriteLine("Bienvenido al programa de generación del número e");

            var pr = new Program();
            var programa = 0;

            while (programa == 0)
            {
                /* Se ingresa la cantidad de dígitos a los cuales se va a imprimir el numero
                   con un mínimo de 0 y un maximo de la longitud del número capturado
                */
                Console.WriteLine("Por favor ingrese la cantidad de dígitos decimales que quiere observar de 'e', el límite es 15");
                var numDigitos = Console.ReadLine();

                try
                {
                    programa = pr.ManejoPrograma(Convert.ToInt32(numDigitos));
                }
                catch (Exception)
                {
                    Console.WriteLine("El dato ingresado debe ser un número entero");
                    programa = 1;
                }
            }

            Console.WriteLine("El programa ha terminado");
            Console.ReadLine();
        }

        /// <summary>
        /// Método para validar si el programa debe seguir o no
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public int ManejoPrograma(int valor)
        {
            var e = Math.E.ToString(CultureInfo.CurrentCulture);
            var longitud = e.Length - 1;
            //Se convierte el dato ingresado, para verificar que el dato ingresado es un números
            var digitosNum = Convert.ToInt32(valor);

            if (digitosNum > 0)
            {
                if (digitosNum == 1)
                {
                    return ImprimirResultado(e, digitosNum, true);
                }
                if (digitosNum <= longitud)
                {
                    return ImprimirResultado(e, digitosNum, false);
                }

                Console.WriteLine($"El número de dígitos no puede ser mayor a {longitud}");
                return 1;
            }
            Console.WriteLine("El número de dígitos decimales no puede ser menor o igual a cero");
            return 1;
        }

        /// <summary>
        /// Método encapsulado para imprimir resultado normal o sumando 1
        /// </summary>
        /// <param name="e"></param>
        /// <param name="digitosNum"></param>
        /// <param name="normal"></param>
        /// <returns></returns>
        private static int ImprimirResultado(string e, int digitosNum, bool normal)
        {
            e = normal ? e.Substring(0, digitosNum) : e.Substring(0, digitosNum + 1);
            Console.WriteLine($"El valor del número e es {e}");
            return 0;
        }
    }
}
