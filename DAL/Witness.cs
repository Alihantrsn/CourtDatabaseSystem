using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.DAL
{
    public class Witness
    {

        public int Id { get; set; }
        public string W_Name { get; set; }
        public string W_Lname { get; set; }

        public virtual List<Session> Sessions { get; set; } = new List<Session>();

    }
}
