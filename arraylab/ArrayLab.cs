using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab
{

    class ArrayLab
    {

        private int[] arr = new int[10000];
        System.Random rand = new System.Random();
        public int this[int index]   // indexer declaration
        {
            get
            {
                arr[index] = rand.Next();

                // The arr object will throw IndexOutOfRange exception.
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }
}
