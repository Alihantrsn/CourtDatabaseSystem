using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.DAL
{
    public class Judge
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Lname { get; set; }


        
        public List<Court> Court { get; set; } = new List<Court> { }; //Many rel with court
        
        //public List<Judge> Judges { get; set; } = new();//1-m rel between case and judges
        public Case Case { get; set; } 
        //public List<Case> CaseCases { get; set; } = new List<Case>();


    }
}
