using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm
{
    //Interface para las conversiones
    public interface Iconvertir 
    {
         double Conv(double a, string Unidad);
    } 

    //Clase derivada de Interface
    public class metros : Iconvertir
    {
        public double Conv(double a, string U)
        {
            if (U == "Kilometro")// 1Km = 1000m
            {
                return a / 1000;
            }
            if (U == "Metro")
            {
                return a;
            }
            if (U == "Centrimetro")
            {
                return a * 100;
            }
            if (U == "Milimetro")
            {
                return a * 1000;
            }
            if (U == "Milla") // mts / 1609.34
            {
                return a / 1609.35;
            }
            if (U == "Yarda")
            {
                return a * 1.094;
            }
            if (U == "Pie")
            {
                return a * 3.281;
            }
            if (U == "Pulgada")
            {
                return a * 39.37;
            }
            else
                return 0;

        }
    }

    public class kilometro : Iconvertir
    {
        public double Conv(double a, string U)
        {
            if (U == "Kilometro")
            {
                return a;
            }
            if (U == "Metro")
            {
                return a / 1000;
            }
            if (U == "Centrimetro")
            {
                return a / 100000;
            }
            if (U == "Milimetro")
            {
                return a / 1000000;
            }
            if (U == "Milla") 
            {
                return a / 1.609;
            }
            if (U == "Yarda")
            {
                return a * 1093.613;
            }
            if (U == "Pie")
            {
                return a * 3280.84;
            }
            if (U == "Pulgada")
            {
                return a * 39370.079;
            }
            else
                return 0;

        }
    }

    public class centimetro : Iconvertir
    {
        public double Conv(double a, string U)
        {
            if (U == "Kilometro")
            {
                return a / 100000;
            }
            if (U == "Metro")
            {
                return a / 100;
            }
            if (U == "Centrimetro")
            {
                return a;
            }
            if (U == "Milimetro")
            {
                return a * 10;
            }
            if (U == "Milla")
            {
                return a / 160934.4;
            }
            if (U == "Yarda")
            {
                return a / 91.44
;
            }
            if (U == "Pie")
            {
                return a / 30.48;
            }
            if (U == "Pulgada")
            {
                return a / 2.54;
            }
            else
                return 0;

        }
    }

    public class milimetro : Iconvertir
    {
        public double Conv(double a, string U)
        {
            if (U == "Kilometro")
            {
                return a / 1000000;
            }
            if (U == "Metro")
            {
                return a / 1000;
            }
            if (U == "Centrimetro")
            {
                return a / 10;
            }
            if (U == "Milimetro")
            {
                return a ;
            }
            if (U == "Milla")
            {
                return a / .00000062;
            }
            if (U == "Yarda")
            {
                return a / 914.4;
            }
            if (U == "Pie")
            {
                return a / 304.8;
            }
            if (U == "Pulgada")
            {
                return a / 25.4;
            }
            else
                return 0;

        }
    }

    public class milla : Iconvertir
    {
        public double Conv(double a, string U)
        {
            if (U == "Kilometro")
            {
                return a * 1.609;
            }
            if (U == "Metro")
            {
                return a * 1609.344;
            }
            if (U == "Centrimetro")
            {
                return a * 160934.4;
            }
            if (U == "Milimetro")
            {
                return a * 1609344.0;
            }
            if (U == "Milla")
            {
                return a ;
            }
            if (U == "Yarda")
            {
                return a * 1760;
            }
            if (U == "Pie")
            {
                return a * 5280;
            }
            if (U == "Pulgada")
            {
                return a * 63360;
            }
            else
                return 0;

        }
    }

    public class yarda : Iconvertir
    {
        public double Conv(double a, string U)
        {
            if (U == "Kilometro")
            {
                return a / 1093.613;
            }
            if (U == "Metro")
            {
                return a / 1.094;
            }
            if (U == "Centrimetro")
            {
                return a * 91.44;
            }
            if (U == "Milimetro")
            {
                return a * 914.4;
            }
            if (U == "Milla")
            {
                return a / 1760;
            }
            if (U == "Yarda")
            {
                return a;
            }
            if (U == "Pie")
            {
                return a * 3;
            }
            if (U == "Pulgada")
            {
                return a * 36;
            }
            else
                return 0;

        }
    }

    public class pie : Iconvertir
    {
        public double Conv(double a, string U)
        {
            if (U == "Kilometro")
            {
                return a / 3280.84;
            }
            if (U == "Metro")
            {
                return a / 3.281;
            }
            if (U == "Centrimetro")
            {
                return a * 30.48;
            }
            if (U == "Milimetro")
            {
                return a * 304.8;
            }
            if (U == "Milla")
            {
                return a / 5280;
            }
            if (U == "Yarda")
            {
                return a / 3;
            }
            if (U == "Pie")
            {
                return a ;
            }
            if (U == "Pulgada")
            {
                return a * 12;
            }
            else
                return 0;

        }
    }

    public class pulgada : Iconvertir
    {
        public double Conv(double a, string U)
        {
            if (U == "Kilometro")
            {
                return a / 39370.079;
            }
            if (U == "Metro")
            {
                return a / 39.37;
            }
            if (U == "Centrimetro")
            {
                return a * 2.54;
            }
            if (U == "Milimetro")
            {
                return a * 25.4;
            }
            if (U == "Milla")
            {
                return a / 63360;
            }
            if (U == "Yarda")
            {
                return a / 36;
            }
            if (U == "Pie")
            {
                return a / 12;
            }
            if (U == "Pulgada")
            {
                return a;
            }
            else
                return 0;

        }
    }
}
