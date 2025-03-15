namespace Matriz
{
    public class Operaciones
    {
        private int[,] matriz;
        private int _N;

        public Operaciones(int size)
        {


            _N = ValidateSize(size);
            matriz = new int[_N, _N];
            LlenarMatriz();
        }

       

        private int ValidateSize(int size)
        {
            if(size <= 0)
{
                throw new ArgumentException("El tamaño de la matriz debe ser mayor que 0.");
            }

            return size;
        }

        private void LlenarMatriz()
        {
            for (int i = 0; i < _N; i++)
            {
                for (int j = 0; j < _N; j++)
                {
                    matriz[i, j] = (i + 1) - j;
                }
            }
        }


        public void MostrarMatriz()
        {
            for (int i = 0; i < _N; i++)
            {
                for (int j = 0; j < _N; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int CalcularSumatoria()
        {
            int sumatoria = 0;
            for (int i = 0; i < _N; i++)
            {
                for (int j = 0; j < _N; j++)
                {
                    sumatoria += matriz[i, j];
                }
            }
            return sumatoria;
        }

        public int EncontrarMayor()
        {
            int mayor = matriz[0, 0];
            for (int i = 0; i < _N; i++)
            {
                for (int j = 0; j < _N; j++)
                {
                    if (matriz[i, j] > mayor)
                    {
                        mayor = matriz[i, j];
                    }
                }
            }
            return mayor;
        }

        public int EncontrarMenor()
        {
            int menor = matriz[0, 0];
            for (int i = 0; i < _N; i++)
            {
                for (int j = 0; j < _N; j++)
                {
                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                    }
                }
            }
            return menor;
        }


    }
}
