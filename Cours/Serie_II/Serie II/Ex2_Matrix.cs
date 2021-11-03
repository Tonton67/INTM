using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Matrix
    {
        public static int[][] BuildingMatrix(int[] leftVector, int[] rightVector)
        {
            //TODO
            if (leftVector.Length != rightVector.Length)
            {
                return new int[0][];
            }
            int[][] array = new int[leftVector.Length][];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[rightVector.Length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = leftVector[i] * rightVector[j];
                }

            }

            return array;
        }

        public static int[][] Addition(int[][] leftMatrix, int[][] rightMatrix)
        {
            //TODO
            if (leftMatrix.Length != rightMatrix.Length)
            {
                return new int[0][];
            }
            int[][] array = new int[leftMatrix.Length][];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[rightMatrix.Length];
                for (int j = 0; j < array[i].Length; j++)
                {
                 //   array[i][j] = leftMatrix[i][k] + rightMatrix[j][l];
                    for (int k = 0; k < array.Length; k++)
                    {
                        array[k] = new int[rightMatrix.Length];
                        for (int l = 0; l < array[k].Length; l++)
                        {
                            array[i][j] = leftMatrix[i][k] + rightMatrix[j][l];
                            array[k][l] = leftMatrix[i][k] + rightMatrix[j][l];

                        }
                    }
                }
                //for (int i2 = 0; i2 < array.Length; i2++)
                //{
                //    array[i2] = new int[rightMatrix.Length];
                //    for (int j2 = 0; j2 < array[i2].Length; j2++)
                //    {
                //        array[i2][j2] = leftMatrix[i2] + rightMatrix[j2];
                //    }
                //}

            }
                return array;
        }

        public static int[][] Substraction(int[][] leftMatrix, int[][] rightMatrix)
        {
            //TODO
            if (leftMatrix.Length != rightMatrix.Length)
            {
                return new int[0][];
            }
            int[][] array = new int[leftMatrix.Length][];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[rightMatrix.Length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    //   array[i][j] = leftMatrix[i][k] + rightMatrix[j][l];
                    for (int k = 0; k < array.Length; k++)
                    {
                        array[k] = new int[rightMatrix.Length];
                        for (int l = 0; l < array[k].Length; l++)
                        {
                            array[i][j] = leftMatrix[i][k] - rightMatrix[j][l];
                            array[k][l] = leftMatrix[i][k] - rightMatrix[j][l];

                        }
                    }
                }
                //for (int i2 = 0; i2 < array.Length; i2++)
                //{
                //    array[i2] = new int[rightMatrix.Length];
                //    for (int j2 = 0; j2 < array[i2].Length; j2++)
                //    {
                //        array[i2][j2] = leftMatrix[i2] - rightMatrix[j2];
                //    }
                //}

            }
            return array;
        }

        public static int[][] Multiplication(int[][] leftMatrix, int[][] rightMatrix)
        {
            //TODO
            return new int[0][];
        }

        public static void DisplayMatrix(int[][] matrix)
        {
            string s = string.Empty;
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    s += matrix[i][j].ToString().PadLeft(5) + " ";
                }
                s += Environment.NewLine;
            }
            Console.WriteLine(s);
        }
    }
}
