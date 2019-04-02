using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_SegundaParcial
{
    class miVector
    {
        private int [] _vec;

        public miVector(int tamaño)
        {
            _vec = new int[tamaño];

        }

        public int Llenar (int inicial)
        {
            for(int i =0; i<_vec.Length; i++)
            {
            
            _vec[i] = inicial++;
            }
            return inicial;

        public string Mostrar()
        {
            string M = " ";
            for(int i = 0; i<_vec.Length; i ++)
            {
                M += "[" + i + "]=" + _vec[i] + Environment.NewLine;
            }
            return M;
        }

        public void GirarArriba()
        {
            int T = _vec[_vec.Length - 1];
            for (int i =_vec.Length - 1; i >=1; i--)
            {
                _vec[i] = _vec[i - 1];
            }
            _vec[0] = T;
        }
        public void GirarAbajo()
        {
            int T = _vec[0];
            for (int i = 0; i < _vec.Length-1; i++)
            {
                _vec[i] = _vec[i + 1];
            }
            _vec[_vec.Length-1] = T;
    
        }
        public void Invertir()
        {
            int T;
            int medio;
            medio = _vec.Length / 2;
            for (int i = 0; i < medio; i++)
            {
                T = _vec[i];
                _vec[i] = _vec[_vec.Length - 1 - i];
                _vec[_vec.Length - 1 - i] = T;
            }
        }
            
      
       
    }
}
