using Farm_Maslahatchi.Services.Repository;
using Farm_Maslahatchi.UI_Controls;
using FarmMaslahatchi.Data;
using FarmMaslahatchi.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Maslahatchi
{
    public partial class Farm_maslahatchi : MaterialSkin.Controls.MaterialForm
    {
        private GenericRepository<DoriNarh> Dori;
        private GenericRepository<DoriSinonim> Sinonim;
        public Farm_maslahatchi()
        {
            InitializeComponent();
            Dori = new GenericRepository<DoriNarh>(Constants.DoriNarhId, Constants.DoriNarhVersion);
            Sinonim = new GenericRepository<DoriSinonim>(Constants.DoriSinonimId, Constants.DoriSinonimVersion);
        }
        private void Farm_maslahatchi_Load(object sender, EventArgs e)
        {
            
        }

        private async void search_txt_TextChanged(object sender, EventArgs e)
        {
            var dorilar = await Dori.GetAll();
            var result = dorilar.Where(p => p.DoriNomi.StartsWith(search_txt.Text));
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
