using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroloji.Bobrek.Moduls
{
    public class tblPostOp
    {
        [Key]
        public int ID { get; set; }

        
        public int? HId { get; set; }
        [ForeignKey("HId")]
        public tblHastaBilgi TblHastaBilgi { get; set; }

        [StringLength(50)]
        public string Pek { get; set; }
        [StringLength(50)]
        public string Dren { get; set; }
        [StringLength(50)]
        public string PstopAna { get; set; }
        [StringLength(50)]
        public string Sonda { get; set; }
        public int? HostSure { get; set; }
        
        public decimal? PreOpKre { get; set; }
        
        public decimal? PstOpKre { get; set; }
        
        public decimal? PreOpHCT { get; set; }
      
        public decimal? PreOpHb { get; set; }
        
        public decimal? PstopHCT { get; set; }
        
        public decimal? PstopHB { get; set; }
        [StringLength(200)]
        public string Takip { get; set; }
        [StringLength(20)]
        public string Tel { get; set; }
        [StringLength(100)]
        public string PstopGecKomp { get; set; }
        [StringLength(5)]
        public string KompClavien { get; set; }
        
    }          
}
