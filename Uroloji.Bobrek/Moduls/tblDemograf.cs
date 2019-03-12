using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroloji.Bobrek.Moduls
{
    public class tblDemograf
    {
        [Key]
        public int ID { get; set; }

        
        public int? HId { get; set; }
        [ForeignKey("HId")]
        public tblHastaBilgi TblHastaBilgi { get; set; }

        public int? Yas { get; set; }
        public int? Boy { get; set; }
        public int? Kilo { get; set; }
        public int? BMI { get; set; }
        public int? Asa { get; set; }
        [StringLength(150)]
        public string Dr { get; set; }
        [StringLength(2)]
        public string Cinsiyet { get; set; }
        [StringLength(3)]
        public string Taraf { get; set; }
        [StringLength(100)]
        public string Lkz { get; set; }
        [StringLength(10)]
        public string Dur { get; set; }
        [StringLength(50)]
        public string KoMor { get; set; }        
    }
}
