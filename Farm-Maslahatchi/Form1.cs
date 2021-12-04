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
        private IList<DoriSinonim> dorilar;
        public Farm_maslahatchi()
        {
            InitializeComponent();
            Dori = new GenericRepository<DoriNarh>(Constants.DoriNarhId, Constants.DoriNarhVersion);
            Sinonim = new GenericRepository<DoriSinonim>(Constants.DoriSinonimId, Constants.DoriSinonimVersion);
            Birnima();
        }
        private async void Birnima()
        {
            dorilar = await Sinonim.GetAll();
        }
        private void Farm_maslahatchi_Load(object sender, EventArgs e)
        {
            
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<DoriSinonim> result;
            if (search_txt.Text.Length > 1)
                result = dorilar.Where(p => p.SavdoNomiVaSinonimi.Contains(search_txt.Text));
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
