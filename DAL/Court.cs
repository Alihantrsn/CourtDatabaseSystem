using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.DAL
{
    public class Court
    {

        public int Id { get; set; }

        public string Court_Name { get; set; }

        //A courthouse may have a more than 1 court but every court must be in a courthouse
        //1-M
        //A lawyer can look more than 1 case but every case needs 1 judge 1-M

        public List<CourtHouse> courtHouses { get; set; } = new();   //m rel with courthose

        public List<Judge> Judges { get; set; } = new();  //1 rel with judge
    }
}
