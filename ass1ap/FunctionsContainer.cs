using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double func(double val);

    public class FunctionsContainer
    {
        private Dictionary<string, func> funcs = new Dictionary<string, func>();

        public func this[string funcName]
        {
            set { funcs[funcName] = value; }

            get
            {
                if (!funcs.ContainsKey(funcName))
                {
                    funcs[funcName] = Val => Val;
                }
                return funcs[funcName];
            }
        }

        public List<string> getAllMissions()
        {
            return new List<string>(this.funcs.Keys);
        }
    }
}
