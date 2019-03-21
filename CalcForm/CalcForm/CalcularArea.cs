using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm
{
    class CalcularArea
    {
        private double _v1;
        private double _v2;

        private FormasStrategy _FormasStrategy;

        public void SetFormasStrategy(FormasStrategy formasStrategy)
        {
            this._FormasStrategy = formasStrategy;
        }

        public double CalcularAreas(double a, double b)
        {
            return _FormasStrategy.Area(a, b);
        }

    }
}
