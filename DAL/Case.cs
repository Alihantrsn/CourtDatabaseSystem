using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.DAL
{
      public class Case
    {
        public int Id { get; set; }
         [ForeignKey("Judges")]
        public int Case_File_Number { get; set; }
        public string Case_Date { get; set; }
        public string Case_Defendent_Name { get; set; }
        public string Case_PlaintiffsName { get; set; }
        public String Case_Type { get; set; }
        public string Case_Court_Name { get; set; }
        public string Case_CourtHouse_Name { get; set; }
        public int JudgeId { get; set; }
        


        //public List<Lawyers> Lawyers { get; set; } = new List<Lawyers>();
        public List<Costumers> Costumers { get; set; } = new(); //M-M rel between case and costumer
        public List<Lawyers> Lawyers { get; set;} = new(); //M-M rel between case and lawyers
        
        
       // public Judge judge { get; set; } = null!; //1-m rel between case and judges
       // public List<Judge> judges { get; set; } = new();
        public Judge Judges { get; set; } 
    }
}
