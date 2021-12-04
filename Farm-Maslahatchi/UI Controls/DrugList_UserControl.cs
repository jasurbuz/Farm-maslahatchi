using FarmMaslahatchi.Data.Model;
using MaterialSkin.Controls;
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
    public partial class DrugList_UserControl : UserControl
    {
        public DrugList_UserControl()
        {
            InitializeComponent();
        }

        private void DrugList_UserControl_Load(object sender, EventArgs e)
        {
            
        }

        public void  FillUserControl(IEnumerable<DoriSinonim> doriSinonims)
        {
            foreach (var item in doriSinonims)
            {
                Label name = new Label();
                name.Text = item.XalqaroNomi;
                name.Dock = DockStyle.Top;
                this.Controls.Add(name);
            }
        }
    }
}
