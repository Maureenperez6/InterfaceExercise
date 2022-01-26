using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface Icompany
    {
        public string CorpName { get; set; }
        public string Logo { get; set; }

    }
}
//In ICompany

/*Create 2 members that are specific to each every company
 * regardless of vehicle type.
 *
 *
 * Example: public string Logo { get; set; }
 */