using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace InsertionSort
{
    class ArraySorting
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }
        }

        public void ArrayInsertionSorting(int[] array)
        {
            try
            {
                int temp;
                var beforeSort = string.Join(" ", array);

                for (int i = 1; i < array.Length; i++)
                {
                    for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }

                var afterSort = string.Join(" ", array);
                var totalBeforeSort = string.Concat("Result before sort:" + " " + beforeSort);
                var totalAfterSort = string.Concat("Result after sort:" + " " + afterSort);
                var str = string.Concat(totalBeforeSort, totalAfterSort);

                logger.Info(str);
            }
            catch (Exception ex)
            {
                logger.Warn(ex.Message);
            }
        }

     
    }
}
