using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Entities
{
    class CarRental
    {
        public DateTime Start { get; private set; }
        public DateTime Finish { get; private set; }
        public Model model { get; private set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Model model)
        {
            Start = start;
            Finish = finish;
            this.model = model;
            Invoice = null;
        }

    }
}
