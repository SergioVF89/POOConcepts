namespace DescFactores
{
    public class Factores
    {
        private int _num;
        private int _n;

        /*public int Num
        {
           get => _num;
           set => _num = ValidateNum( value); 
        }*/
        public Factores(int num)
        {
            _num = ValidateNum(num);
            _n = num;
        }

        private int ValidateNum(int num)
        {
            if (num <= 1)
            {
                throw new ArgumentException("El Numero debe ser mayor a 1.");
            }

            return num;
        }

        public List<int> DescomponerEnFactores()
        {
            List<int> factores = new List<int>();
            int divisor = 2;

            while (_num > 1)
            {
                while (_num % divisor == 0)
                {
                    factores.Add(divisor);
                    _num /= divisor;
                }
                divisor++;
            }

            return factores;
        }


        public void MostrarFactores(List<int> factores)
        {
            Console.Write($"{_n} = ");
            for (int i = 0; i < factores.Count; i++)
            {
                Console.Write(factores[i]);
                if (i < factores.Count - 1)
                {
                    Console.Write(" x ");
                }
            }
            Console.WriteLine();
        }


    }
}
