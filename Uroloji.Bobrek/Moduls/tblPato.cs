using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroloji.Bobrek.Moduls
{
    public class tblPato
    {
        [Key]
        public int ID { get; set; }

        
        public int? HId { get; set; }
        [ForeignKey("HId")]
        public tblHastaBilgi TblHastaBilgi { get; set; }


        [StringLength(50)]
        public string Patoloji { get; set; }
        [StringLength(50)]
        public string AltGrup { get; set; }
        [StringLength(20)]
        public string FuhrmanGraf { get; set; }
        [StringLength(10)]
        public string PatoEvre { get; set; }
        [StringLength(2)]
        public string CerSin { get; set; }
        
    }
}
