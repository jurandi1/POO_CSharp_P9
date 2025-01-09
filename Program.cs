﻿using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace POO_CSharp_P8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Exercício resolvido
            //Fazer um programa para ler um número inteiro N e uma matriz de
            //ordem N contendo números inteiros. Em seguida, mostrar a diagonal
            //principal e a quantidade de valores negativos da matriz

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0;i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0;i < n ; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.Write("Negative numbers = " + count);

            /*double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));*/
        }
    }
}