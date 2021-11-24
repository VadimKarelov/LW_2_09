using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_09
{
    public class UravnenieArray
    {
        private static Random rn = new();
        private static int counter = 0;

        private Uravnenie[] array;
        private int size;

        public UravnenieArray()
        {
            array = new Uravnenie[0];
            size = 0;
            counter++;
        }

        public UravnenieArray(int number)
        {
            array = new Uravnenie[number];
            size = number;

            for (int i = 0; i < number; i++)
            {
                array[i] = new Uravnenie(rn.Next(-50, 50), rn.Next(-50, 50), rn.Next(-50, 50));
            }

            counter++;
        }

        public UravnenieArray(double[][] data)
        {
            size = data.Length;
            array = new Uravnenie[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = new Uravnenie(data[i][0], data[i][1], data[i][2]);
            }

            counter++;
        }

        public Uravnenie this[int i]
        {
            get
            {
                if (i >= 0 && i < size)
                    return array[i];
                else
                    return null;
            }
            set
            {
                if (i >= 0 && i < size)
                    array[i] = value;
            }
        }

        public override string ToString()
        {
            string res = "";
            if (array != null && array.Length > 0)
            {
                for (int i = 0; i < size; i++)
                {
                    res += array[i].ToString() + "\n";
                }
            }
            else
            {
                res = "Массив пуст";
            }
            return res;
        }

        public int GetCounter()
        {
            return counter;
        }

        public int GetSize()
        {
            return size;
        }
    }
}