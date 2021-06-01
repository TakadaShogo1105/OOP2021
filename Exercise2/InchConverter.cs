using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {

    public static class InchConverter {

        private const double ratio = 0.0254;

        static public double FromMeter(double meter) {
            return meter * ratio;
        }

        static public double ToMeter(double inch) {
            return inch / ratio;
        }
    }
}
