using Farm_Maslahatchi.UI_Controls;
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
        public Farm_maslahatchi()
        {
            InitializeComponent(); 
        }

        public List<string> DrugSynonyms { get; set; }
        private void Farm_maslahatchi_Load(object sender, EventArgs e)
        {
            
            DrugList_UserControl drugList = new DrugList_UserControl();
            drugList.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(drugList, 0, 1);
            Synonims_UserControl synonims = new Synonims_UserControl(DrugSynonyms);
            synonims.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(synonims, 1, 1);

        }
    }
}
