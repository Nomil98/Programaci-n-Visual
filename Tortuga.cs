class Tortuga : Carrera
    {
        public Tortuga (int numero) : base (numero)
        {
            this._Posicion = 0;
        }

        new public int Correr()
        {
            int avance = base.Correr();

            if(avance <= 8)
            {
                _Posicion += 3; 
            }
            else if(avance <= 12)
            {
                _Posicion += 6;
            }
            else if(avance <= 16)
            {
                _Posicion -= 5;
            }
            else if (avance <=20)
            {
                _Posicion -= 9;
            }
            return 0;
        }
