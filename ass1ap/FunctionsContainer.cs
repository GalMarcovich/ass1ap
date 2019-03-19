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
    public delegate double func(double val);

    public class FunctionsContainer
    {
        private Dictionary<string, func> funcs = new Dictionary<string, func>();

        /*
         * indexer according the funcs
         */
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

        /*
         * return the list of the missions 
         */
        public List<string> getAllMissions()
        {
            return new List<string>(this.funcs.Keys);
        }
    }
}
