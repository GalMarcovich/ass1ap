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
    public class ComposedMission : IMission
    {
        List<func> list = new List<func>();

        public String Name { get; }

        public String Type { get { return "Composed"; } }

        public ComposedMission(string nameMission)
        {
            this.Name = nameMission;
        }

        public event EventHandler<double> OnCalculate;

        /*
         * calculate the value according to the funcs in the list
         */
        public double Calculate(double value)
        {
            foreach (var func in list)
            {
                if (func != null)
                {
                    value = func(value);
                }
            }
            OnCalculate?.Invoke(this, value);

            return value;

        }

        /*
         * add the mission to the list
         */
        public ComposedMission Add(func mission)
        {
            list.Add(mission);
            return this;
        }
        
    }
}
