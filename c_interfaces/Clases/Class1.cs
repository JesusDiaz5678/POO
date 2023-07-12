using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_interfaces.Interfaces;

namespace c_interfaces.Clases
{
    internal abstract class Class1 : Interface1
    {
        public abstract void M11();
        


        public abstract void M12();


        public abstract void M21();

        public abstract void M22();

        public void otro_metodo()
        {
            Console.WriteLine("OTRO METODO VOID junior ");
        }
        
    }
}
