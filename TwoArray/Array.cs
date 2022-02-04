using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoArray
{
    internal class Array
    {
        private double[,] val;
        public double[,] Val { get => val; set => val = value; }


        public Array(int row, int col)
        {
            Col = col;
            Row = row;

            val = new double[Row, Col];
        }
        public int Col { get; set; }
        public int Row { get; set; }


        public void FillArray()
        {
            for (int i = 0; i < val.GetLength(0); i++)
            {
                for (int j = 0; j < val.GetLength(1); j++)
                {
                    
                    Console.Write($"Val[{i}, {j}] = ");
                    Val[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }


        public void PrintArray()
        {
            for (int i = 0; i < val.GetLength(0); i++)
            {
                for (int j = 0; j < val.GetLength(1); j++)
                {
                    Console.Write($"{val[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public void SumCol()
        {

            Console.Write("\nВведите номер столбца: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < val.GetLength(0); i++)
            {
                for (int j = 0; j < val.GetLength(1); j++)
                {
                    if (num == j)
                    {
                        val[i, 0] += val[i, j];
                        
                    }
                }
               
            }
        }
    }
}