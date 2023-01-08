using System;

namespace Lab4ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m, respectiv m,n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la tastaura.
             Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I rezultatul*/

            Console.WriteLine("Introduceti lungimea m pentru prima matrice: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti lungimea n pentru prima matrice: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti lungimea p pentru a doua matrice: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti lungimea q pentru a doua matrice: ");
            int q = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[m, n];
            int[,] matrix2 = new int[p, q];

            Console.WriteLine("Citim prima matrice, cu " + m + " randuri si  " + n + " coloane.");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Introduceti elementul de pe pozitia " + i + " " + j);
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Citim a doua matrice, cu " + n + " randuri si  " + m + " coloane.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Introduceti elementul de pe pozitia " + i + " " + j);
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] matrix3 = new int[m, q];

            if (n != p)
            {
                Console.WriteLine("Inmultirea matricilor nu se poate efectua, deoarece n = " + n + " trebuie sa fie egal cu p = " + p );
            }
            else matrix3 = CalculeazaProdusulPentruDouaMatrici(m, q, n, matrix1, matrix2);

            Console.WriteLine("Matricea rezultat este: ");
            AfiseazaMatrice(m, n, matrix3);
        }

        private static int[,] CalculeazaProdusulPentruDouaMatrici(int m, int q, int n, int[,] matrix1, int[,] matrix2)
        {
            int[,] matrix3 = new int[m, q];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    matrix3[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return matrix3;
        }

        static void AfiseazaMatrice(int m, int n, int[,] matrix3) 
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Console.Write(matrix3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        }
}
