using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uroloji.Bobrek.Migrations;

namespace Uroloji.Bobrek.Moduls
{
    public class UrolojiContext:DbContext
    {
        public UrolojiContext() : base("UrolojiContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion
                <UrolojiContext, Configuration>("UrolojiContext"));
        }
        public virtual DbSet<tblHastaBilgi> TblHastaBilgis { get; set; }
        public virtual DbSet<tblDemograf> Demografs { get; set; }
        public virtual DbSet<tblOperatif> Operatifs { get; set; }
        public virtual DbSet<tblPostOp> PostOps { get; set; }
        public virtual DbSet<tblPato> Patos { get; set; }
        public virtual DbSet<tblTakip> Takips { get; set; }

    }
}
