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
        private IList<DoriNarh> doriNarxlar;
        public Farm_maslahatchi()
        {
            InitializeComponent();
            Dori = new GenericRepository<DoriNarh>(Constants.DoriNarhId, Constants.DoriNarhVersion);
            Sinonim = new GenericRepository<DoriSinonim>(Constants.DoriSinonimId, Constants.DoriSinonimVersion);

        }
        private async void Birnima()
        {
            dorilar = await Sinonim.GetAll();
            doriNarxlar = await Dori.GetAll();
        }

        private void chiqarish(IEnumerable<DoriSinonim> doriSinonims)
        {
            var yuztacha = doriSinonims.Take(100);
            foreach (var item in yuztacha)
            {
                DrugList_UserControl drugList_User = new DrugList_UserControl();
                drugList_User.FillUserControl(item);
                drugList_User.Dock = DockStyle.Top;
                drugList.Items.Add(item.SavdoNomiVaSinonimi);
            }
        }

        private void Farm_maslahatchi_Load(object sender, EventArgs e)
        {
            Birnima();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<DoriSinonim> result;
                drugList.Controls.Clear();
                if (search_txt.Text.Length > 1)
                {
                    result = dorilar.Where(p => p.SavdoNomiVaSinonimi.Contains(search_txt.Text));
                    if (result != null)
                        chiqarish(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void drugList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = drugList.SelectedItem.ToString();
            var res = dorilar.Where(a => a.SavdoNomiVaSinonimi.Contains(item));
            synonimsList.Items.Clear();
            if(res != null)
            {
                foreach (var syn in res)
                {
                    SynonimsItem_UC synonimsItem = new SynonimsItem_UC();
                    synonimsItem.directLabel(syn.SavdoNomiVaSinonimi);
                    synonimsItem.Dock = DockStyle.Top;
                    synonimsList.Items.Add(syn.SavdoNomiVaSinonimi);
                }
            }
        }

        private void synonimsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var item = synonimsList.SelectedItem.ToString();
                var result = doriNarxlar.FirstOrDefault(a => a.DoriNomi == item);
                if (result != null)
                    DoriNarxiList.Items.Add(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                        
        }
    }
}
