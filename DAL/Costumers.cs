using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.DAL
{
    public class Costumers
    {

        [Key]
        public int Case_Number{ get; set; }

        public string? Costumer_Name { get; set; }   
        public string? Case_Type { get; set; }
        public string? Which_C_House { get; set; }
        public string? Which_Court { get; set; }
        //One costumer may have a more than 1 case but every court mus have at least 1 costumer
        //public List<Lawyers> Lawyers { get; set; }=new List<Lawyers>();
        public List<Case> Case { get; set; }=new List<Case>();  //M-M rel between case and costumer





    }
}
