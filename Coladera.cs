using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera_Eratostenes
{
    class Coladera_Eratostenes
    {
        private int[] _Vector;

        public Coladera_Eratostenes() //Se le asigna el tamaño al vector.
        {
            _Vector = new int[1000];
        }

        public void Llenar() //Le asignamos a todo el vector el valor de uno.
        {
            for (int i = 1; i < _Vector.Length; i++)
            {
                _Vector[i] = 1;
            }

        }

        public void Coladera()///Aquí se hace la asignación de ceros a los números no primos y 
                              //se quedan sólo los subíndices con valor a 1 que serán los primos. 
        {
            for(int i=2; i<_Vector.Length/2; i++)
            {
                if(_Vector[i]==1)
                {
                    for (int j = i + i; i < _Vector.Length; j += i)
                        if (j % i == 0)
                            _Vector[j] = 0;
                }
            }
        }

        public string Mostrar()//Se van a mostrar sólo los subíndices  con valor de 1.
        {
            string primos= "";
            for(int i =1; i<_Vector.Length; i++ )
            {
                if (_Vector[i] == 1)
                    primos = primos + i.ToString() + Environment.NewLine;

                
            }
            return primos;  
        }




    }
}
