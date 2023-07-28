using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.DAL
{
    public class Lawyers:BasePerson
    {
        public int Lawyer_D_Number { get; set; }


        public List<Case> Case { get; set; } = new();
       // public List<Costumers> Costumers { get; set; } = new List<Costumers>();






    }
}
