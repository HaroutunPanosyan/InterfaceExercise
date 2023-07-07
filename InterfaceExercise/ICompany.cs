using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    // Create 2 members that are specific to each every company
    public interface ICompany
    {
        public string Name { get; set; }
        public string ElevatorPitch { get; set; }
        public string ImageURL { get; }
        public virtual void CompanyPitch() { }
    }
}
