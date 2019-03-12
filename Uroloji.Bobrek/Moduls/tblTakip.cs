using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroloji.Bobrek.Moduls
{
    public class tblTakip
    {
        [Key]
        public int ID { get; set; }

        
        public int? HId { get; set; }
        [ForeignKey("HId")]
        public tblHastaBilgi TblHastaBilgi { get; set; }

        [StringLength(5)]
        public string Pstop3LNuks { get; set; }
        
        public decimal? Pstop3Kre { get; set; }
        [StringLength(5)]
        public string Pstop6LNuks { get; set; }
        
        public decimal? Pstop6Kre { get; set; }
        [StringLength(5)]
        public string Pstop12LNuks { get; set; }
      
        public decimal? Pstop12Kre { get; set; }
        
    }
}
