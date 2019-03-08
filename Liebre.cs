class Liebre : Carrera
    {
        public Liebre (int numero) : base (numero)
        {
            this._Posicion = 0;
        }
        new public int Correr()
        {
            int avance = base.Correr();
            if (avance <=4)
            {
                _Posicion += 0;
            }
            else if  (avance <= 9 )
            {
                _Posicion += 12;
            }
            else if(avance <= 12)
            {
                _Posicion += 5;
            }
            else if (avance <= 15)
            {
                _Posicion -= 4;
            }
            else if (avance <=20)
            {
                _Posicion -= 8;
            }

            return 0;
        }
