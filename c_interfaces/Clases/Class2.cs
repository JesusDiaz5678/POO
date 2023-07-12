using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_interfaces.Interfaces;

namespace c_interfaces.Clases
{
    internal class Class2 : Class1
    {
        public override void M11()
        {
            throw new NotImplementedException();

        }

        public override void M12()
        {
            throw new NotImplementedException();
        }

        public override void M21()
        {
            throw new NotImplementedException();
        }

        public override void M22()
        {
            throw new NotImplementedException();
        }

        public new string otro_metodo() //AQUI HAY SOBRECARGA, EL PADRE ES VOID, AQUI ES STRING
        {
            return "otro metodo string";
        }

    }
}
