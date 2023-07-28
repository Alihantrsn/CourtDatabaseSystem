using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.DAL
{
    public class CourtHouse
    {

        public int Id { get; set; }
        
        public string? CourtHouse_Name { get; set; }
        public string? CourtHouse_Adress { get; set; }

        public List<Court> Courts { get; set; } = new List<Court>();//parent class agaainst 1-m rel between courts
       // public List<Judge> Judges { get; set; }=new List<Judge>();
        
        //A courthouse may have a more than 1 court but every court must be in a courthouse
        //1-M
    }
}
