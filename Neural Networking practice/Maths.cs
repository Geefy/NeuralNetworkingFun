using System;
using System.Collections.Generic;
using System.Text;

namespace Neural_Networking_practice
{
    public static class Maths
    {
        public static float Sigmoid(float value)
        {
            return (float)(1 / (1 + Math.Pow(Math.E, -value)));
        }

        public static float[] Sigmoid(float[] arr)
        {
            float[] nArr = new float[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                nArr[i] = Sigmoid(arr[i]);
            }

            return nArr;
        }

        public static float[,] Sigmoid(float[,] arr)
        {
            float[,] nArr = new float[arr.GetLength(0), arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    nArr[i, j] = Sigmoid(arr[i, j]);
                }
            }

            return nArr;
        }

        public static float Scaling(float value, float maxValue)
        {

            float scaledValue = value / maxValue;

            return scaledValue;
        }

        public static float[] Scaling(float[] arr, float maxValue)
        {
            float[] scaledArr = new float[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                scaledArr[i] = arr[i] / maxValue;
            }

            return scaledArr;
        }

        public static float[,] Scaling(float[,] arr, float maxValue)
        {
            float[,] scaledArr = new float[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    scaledArr[i, j] = arr[i, j] / maxValue;
                }
            }
            return scaledArr;
        }
        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public static float[,] Dot(float[,] arr, float[,] weight)
        {
            float[,] nArr = new float[arr.GetLength(0), weight.GetLength(1)];
            if(arr.GetLength(1) == weight.GetLength(0))
            {

                for (int i = 0; i < nArr.GetLength(0); i++)
                {

                    for (int j = 0; j < nArr.GetLength(1); j++)
                    {
                        for (int k = 0; k < arr.GetLength(1); k++)
                        {
                            nArr[i, j] = nArr[i, j] + arr[i, k] * weight[k, j];

                        }
                        
                    }
                }
            }
            else if(arr.GetLength(0) == weight.GetLength(1))
            {
                for (int i = 0; i < nArr.GetLength(0); i++)
                {

                    for (int j = 0; j < nArr.GetLength(1); j++)
                    {

                        for (int k = 0; k < weight.GetLength(0); k++)
                        {
                            nArr[i, j] = nArr[i, j] + arr[i, k] * weight[k, j];

                        }

                    }
                }
            }
            return nArr;
        }

    }
}
