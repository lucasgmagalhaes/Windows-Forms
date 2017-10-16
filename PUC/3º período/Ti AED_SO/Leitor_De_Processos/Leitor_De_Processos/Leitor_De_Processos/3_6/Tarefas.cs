namespace Leitor_De_Processos._3_6
{
    class Tarefas
    {
        int fat = 0, fib = 0;

        public int _fat
        {
            get { return fat; }
            set { fat = value; }
        }

        public int _fib
        {
            get { return fib; }
            set { fib = value; }
        }
        //fatorial iterativo
        public double Fatorial(double numero)
        {
            double aux = 1;
            for (double i = numero; i >= 1; i--)
            {
                aux *= i;
            }
            fat++;
            return aux;
        }
        //fibonacci iterativo
        public double CalcFibonacciIterativo(int pos)
        {
            double[] aux = new double[3];

            aux[0] = 1;
            aux[1] = 1;
            aux[2] = 0;

            for (int i = 0; i <= pos - 1; i++)
            {
                aux[0] = aux[1];
                aux[1] = aux[2];
                aux[2] = aux[0] + aux[1];
            }
            fib++;
            return aux[2];
        }
    }
}
