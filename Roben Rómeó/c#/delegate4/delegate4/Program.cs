using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate4
{
    class Szam
    {
        int a;
        public override string ToString()
        {
            return Convert.ToString(a);
        }
        public override bool Equals(object obj)
        {
            Szam sz = obj as Szam;
            if (sz != null)
                if (sz.a == this.a) return true;
            return false;
        }
        public override int GetHashCode()
        {
            return a.GetHashCode();
        }
    }

}
