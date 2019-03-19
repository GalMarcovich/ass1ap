/****************
 * Gal Marcovich
 * 208715367
 ****************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public func singleFunc;

        public String Name { get; }

        public String Type { get { return "Single"; } }

        public SingleMission(func mission,string nameMission)
        {
            this.singleFunc = mission;

            this.Name = nameMission;
        }

        public event EventHandler<double> OnCalculate;

        /*
         * calculate the value after all the funcs
         */
        public double Calculate(double value) {

            double calc = value;

            if (singleFunc != null)
            {
                calc = singleFunc(value);
            }
            OnCalculate?.Invoke(this, calc);
 
            return calc;
        }

    }
}
