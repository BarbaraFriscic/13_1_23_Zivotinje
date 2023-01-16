using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_23_Zivotinje
{
    internal abstract class Zivotinja
    {
        public string Ime { get; set; }
        public char Spol { get; set; }

        public abstract string Glasanje();
    }
    class Macka : Zivotinja
    {
        public override string Glasanje()
        {
            return $"{Ime} kaže: mijau";
        }
    }
    class Pas : Zivotinja
    {
        public override string Glasanje()
        {
            return $"{Ime} kaže: vuf vuf";
        }
        
    }
}
