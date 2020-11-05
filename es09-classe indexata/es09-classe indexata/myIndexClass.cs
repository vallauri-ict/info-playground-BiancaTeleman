using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es09_classe_indexata
{
    class myIndexClass
    {
        private string[] element;

        public myIndexClass(int elementNumber)
        {
            element = new string[elementNumber];
            for (int i = 0; i < elementNumber; i++)
            {
                element[i] = "empty";
            }
        }

        public string this[int pos]
        {
            get { return element[pos]; }
            set { element[pos] = value; }
        }

        public int length()
        {
            return element.Length;
        }
    }
}
