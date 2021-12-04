using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Maslahatchi.UI_Controls
{
    public partial class SynonymsItem_UC : UserControl
    {
        private readonly string _drugName;
        private readonly string _drugPrice;

        public SynonymsItem_UC(string drugName, string drugPrice)
        {
            InitializeComponent();
            this._drugName = drugName;
            this._drugPrice = drugPrice;
        }

        private void SynonymsItem_UC_Load(object sender, EventArgs e)
        {
            
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
