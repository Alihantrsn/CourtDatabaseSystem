using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.DAL
{
    public class Session
    {

        [Key]
        public int Session_Date { get; set; }
        public String Session_C_Room { get; set; }
        public virtual Witness Witness { get; set; } = null!;

        //In Cellses witnneses can be testify



    }
}
