using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm
{
    abstract class FormasStrategy//Clase padre Formas Geometricas con el metodo de calcular area
    {
        public abstract double Area(double _v1, double _v2);
    }

    class AreaTriangulo : FormasStrategy//Strategy para calcular area del triangulo
    {
        public override double Area(double _v1, double _v2)
        {
            return (_v1 * _v2) / 2;
        }
    }

    class AreaCuadrado : FormasStrategy//Strategy para calcular area del Cuadrado
    {
        public override double Area(double _v1, double _v2)
        {
            return _v1 * _v1;
        }
    }

    class AreaRectangulo : FormasStrategy//Strategy para calcular area del Rectangulo
    {
        public override double Area(double _v1, double _v2)
        {
            return _v1 * _v2;
        }
    }

    class AreaCirculo : FormasStrategy//Strategy para calcular area del Circulo
    {
        public override double Area(double _v1, double _v2)
        {
            return 3.1415 * (_v1 * _v1);// _v1 es pi en su valor numerico
        }
    }
}
