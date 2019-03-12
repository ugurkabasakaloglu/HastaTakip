using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroloji.Bobrek.Moduls
{
    public class tblHastaBilgi
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HastaId { get; set; }
        [StringLength(50)]
        public string Hadi { get; set; }
        [StringLength(50)]
        public string Sadi { get; set; }
        [StringLength(20)]
        public string ProtNo { get; set; }
        //[DataType(DataType.Date)] 
        public DateTime OpTarih { get; set; }
        [StringLength(150)]
        public string OpTur { get; set; }
        public int? Takip { get; set; }
        public int? Anah { get; set; }

        public virtual ICollection<tblDemograf> TblDemograflar { get; set; }
        public virtual ICollection<tblOperatif> TblOperatifler { get; set; }
        public virtual ICollection<tblPato> TblPatolar { get; set; }
        public virtual ICollection<tblPostOp> TblPostOplar { get; set; }
        public virtual ICollection<tblTakip> TblTakipler { get; set; }


    }
}
