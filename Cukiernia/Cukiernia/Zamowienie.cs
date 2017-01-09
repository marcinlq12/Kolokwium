using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Zamowienie
    {
        protected DateTime czasDostawy;


        virtual public bool PoprawnyCzas()
        {
            DateTime czas = DateTime.Now;


            if (czasDostawy > czas)
            {


                return true;
            }
            else
            {
                return false;
            }
        }

        private void UstawCzas(DateTime czasDostawy)
        {
            this.czasDostawy = czasDostawy;
        }

    }
}