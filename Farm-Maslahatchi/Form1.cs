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
        private void Farm_maslahatchi_Load(object sender, EventArgs e)
        {
            
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
