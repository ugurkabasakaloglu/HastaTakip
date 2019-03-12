using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uroloji.Bobrek.Moduls;
namespace Uroloji.Bobrek
{
    public partial class AnaForm : Form
    {
        UrolojiContext _db;
        public AnaForm()
        {
            InitializeComponent();
        }

        void Listele()
        {

            var lst = (from s in _db.TblHastaBilgis
                       where s.Hadi.Contains(txtAd.Text)
                       where s.Sadi.Contains(txtSoyad.Text)
                       where s.ProtNo.Contains(txtProtNo.Text)
                       where s.OpTarih.Equals(dtpOpTar.Value.Date)
                       //where s.OpTarih== DateTime.Parse(dtpOpTar.Text)
                       select s).ToList();
            int i = 0;
            foreach(var hasta in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value= hasta.Hadi;
                Liste.Rows[i].Cells[1].Value = hasta.Sadi;
                Liste.Rows[i].Cells[2].Value = hasta.ProtNo;
                Liste.Rows[i].Cells[3].Value = hasta.OpTarih;
                i++;
            }
        }

        void Kaydet()
        {
            IdBul();
            try
            {
                tblHastaBilgi hst = new tblHastaBilgi()
                {
                    HastaId = int.Parse(lblHastaId.Text),
                    Hadi = txtAdKayit.Text,
                    Sadi = txtSoyadKayit.Text,
                    ProtNo = txtProKayit.Text,
                    OpTarih = Convert.ToDateTime(dtpTarihKayit.Text),
                    OpTur = txtOpKayit.Text,
                    Takip = Convert.ToInt32(txtTakipKayit.Text),
                    Anah = Convert.ToInt32(txtAnahtarKayit.Text)
                };
                _db.TblHastaBilgis.Add(hst);
                //_db.SaveChanges();

                tblOperatif opt = new tblOperatif();
                {
                    opt.HId = int.Parse(lblHastaId.Text);
                    opt.PksAcil = txtPks.Text;
                    opt.Sk = txtSik.Text;
                    opt.Coop = txtCo.Text;
                    opt.Iskm=txtİskemi.Text!="" ? int.Parse(txtİskemi.Text):-1;
                    opt.ProtS =txtPort.Text!="" ? int.Parse(txtPort.Text):-1;
                    opt.YrdYnt = txtYardim.Text;
                    opt.CerSin = txtCerrahi.Text;
                    opt.Sure =txtSure.Text!="" ? int.Parse(txtSure.Text):-1;
                    opt.Dren = txtDren.Text;
                    opt.Kanam = txtKanama.Text!="" ? int.Parse(txtKanama.Text):-1;
                    opt.Piyes = txtPiyes.Text!="" ? int.Parse(txtPiyes.Text):-1;
                }
                _db.Operatifs.Add(opt);
                //_db.SaveChanges();

                tblDemograf dmg = new tblDemograf()
                {
                    HId = int.Parse(lblHastaId.Text),
                    Yas = txtYasKayit.Text !="" ? int.Parse(txtYasKayit.Text):-1,
                    Boy = txtBoyKayit.Text != "" ? int.Parse(txtBoyKayit.Text):-1,
                    Kilo = txtKiloKayit.Text != "" ? int.Parse(txtKiloKayit.Text):-1,
                    BMI = txtBmiKayit.Text != "" ? int.Parse(txtBmiKayit.Text):-1,
                    Asa = txtAsaKayit.Text != "" ? int.Parse(txtAsaKayit.Text):-1,
                    Dr = txtDrKayit.Text,
                    Cinsiyet = txtCinsiyetKayit.Text,
                    Taraf = txtTarafKayit.Text,
                    Lkz = txtLokalKayit.Text,
                    Dur = txtDurumKayit.Text,
                    KoMor = txtKoKayit.Text,
                };
                _db.Demografs.Add(dmg);
                //_db.SaveChanges();

                tblPato pato = new tblPato()
                {
                    HId = int.Parse(lblHastaId.Text),
                    Patoloji = txtPatoKayit.Text,
                    AltGrup = txtAltKayit.Text,
                    FuhrmanGraf = txtFuhrmanKayit.Text,
                    PatoEvre = txtEvreKayit.Text,
                    CerSin = txtSinirKayit.Text
                };
                _db.Patos.Add(pato);
                //_db.SaveChanges();

                tblTakip takip = new tblTakip()
                {
                    HId = int.Parse(lblHastaId.Text),
                    Pstop3LNuks = txtUcNuks.Text,
                    Pstop3Kre = txtUcKre.Text != "" ? decimal.Parse(txtUcKre.Text):0,
                    Pstop6LNuks = txtAltıNuks.Text,
                    Pstop6Kre = txtAltiKre.Text != "" ? decimal.Parse(txtAltiKre.Text):0,
                    Pstop12LNuks = txtOnikiNuks.Text,
                    Pstop12Kre = txtOnikiKre.Text!="" ? decimal.Parse(txtOnikiKre.Text):0,
                };
                _db.Takips.Add(takip);
                //_db.SaveChanges();

                tblPostOp post = new tblPostOp()
                {
                    HId = int.Parse(lblHastaId.Text),
                    Pek = txtPerop.Text,
                    Dren = txtDren.Text,
                    PstopAna = txtAnaliz.Text,
                    Sonda = txtSonda.Text,
                    HostSure = txtHostSure.Text != "" ? int.Parse(txtHostSure.Text):-1,
                    PreOpKre = txtPreKre.Text != "" ? decimal.Parse(txtPreKre.Text):0,
                    PstOpKre = txtPoKre.Text != "" ? decimal.Parse(txtPoKre.Text):0,
                    PreOpHCT = txtPreHct.Text != "" ? decimal.Parse(txtPreHct.Text):0,
                    PreOpHb = txtPreHb.Text != "" ? decimal.Parse(txtPreHb.Text):0,
                    PstopHCT = txtPoHct.Text != "" ? decimal.Parse(txtPoHct.Text):0,
                    PstopHB = txtPoHb.Text != "" ? decimal.Parse(txtPoHb.Text):0,
                    Takip = txtTkp.Text,
                    Tel = txtTel.Text,
                    PstopGecKomp = txtPoGeKo.Text,
                    KompClavien = txtKomp.Text,
                };
                _db.PostOps.Add(post);




                _db.SaveChanges();
                MessageBox.Show("Yeni Kayıt Oluşturuldu.");
                Temizle();
                IdBul();
            }
            catch (Exception e)
            {
                MessageBox.Show("Tekrar Deneyiniz.:"+e);
            }
        }

        void Temizle()
        {
            foreach(Control ct in tabPage1.Controls)
            {
                if(ct is TextBox)
                {
                    ct.Text = "";
                    dtpTarihKayit.Value = DateTime.Now;
                }
            }
            foreach (Control ct in tabPage2.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = "";
                    dtpTarihKayit.Value = DateTime.Now;
                }
            }
            foreach (Control ct in tabPage3.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = "";
                    dtpTarihKayit.Value = DateTime.Now;
                }
            }
            foreach (Control ct in tabPage4.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = "";
                    dtpTarihKayit.Value = DateTime.Now;
                }
            }
            foreach (Control ct in tabPage5.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = "";
                    dtpTarihKayit.Value = DateTime.Now;
                }
            }
            foreach (Control ct in tabPage6.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = "";
                    dtpTarihKayit.Value = DateTime.Now;
                }
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            _db = new UrolojiContext();
            Listele();
            IdBul();
        }

        void IdBul()
        {
            int a=0;
            try
            {
                 a = (from s in _db.TblHastaBilgis
                         orderby s.HastaId descending
                         select s).First().HastaId;
                a += 1;
                lblHastaId.Text = a.ToString();
            }
            catch (Exception)
            {
                a += 1;
                lblHastaId.Text = a.ToString();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnYeniHasta_Click(object sender, EventArgs e)
        {
            pnlHastaBul.Visible = false;
        }

        private void btnHastaBul_Click(object sender, EventArgs e)
        {
            pnlHastaBul.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }
}
