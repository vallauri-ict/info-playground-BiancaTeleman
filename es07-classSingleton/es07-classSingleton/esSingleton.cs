using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es07_classSingleton
{
    class esSingleton
    {
        public int val;
        private static esSingleton instance = null;

        private esSingleton()
        {

        }

        private esSingleton(int val)
        {
            this.val = val;
        }

        public static esSingleton getEsSingleton(int valore)
        {
            if(instance==null)
            {
                instance = new esSingleton(valore);
            }
            else
            {
                instance.val = valore;
            }
            return instance;
        }
    }
}
