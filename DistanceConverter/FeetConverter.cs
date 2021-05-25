using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {

    public static class FeetConverter {

        private const double ratio = 0.3048;

        static public double FromMeter(double meter) {
            return meter / ratio;
        }

        static public double ToMeter(double feet) {
            return feet * ratio;
        }
    }
}
