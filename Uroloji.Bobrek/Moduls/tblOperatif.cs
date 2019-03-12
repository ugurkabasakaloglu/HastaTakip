using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroloji.Bobrek.Moduls
{
    public class tblOperatif
    {
        [Key]
        public int ID { get; set; }

        
        public int? HId { get; set; }
        [ForeignKey("HId")]
        public tblHastaBilgi TblHastaBilgi { get; set; }

        [StringLength(20)]
        public string PksAcil { get; set; }
        [StringLength(50)]
        public string Sk { get; set; }
        [StringLength(150)]
        public string Coop { get; set; }
        public int? Iskm { get; set; }
        public int? ProtS { get; set; }
        [StringLength(50)]
        public string YrdYnt { get; set; }
        [StringLength(2)]
        public string CerSin { get; set; }
        public int? Sure { get; set; }
        [StringLength(20)]
        public string Dren { get; set; }
        public int? Kanam { get; set; }
        public int? Piyes { get; set; }
    }
}
