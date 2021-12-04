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
    public partial class Synonims_UserControl : UserControl
    {
        private readonly List<string> _synonimList;

        public Synonims_UserControl(List<string> SynonimList)
        {
            InitializeComponent();
            _synonimList = SynonimList;
        }

        public Synonims_UserControl()
        {

        }
        private void Synonims_UserControl_Load(object sender, EventArgs e)
        {
            foreach (var synonym in _synonimList)
            {
                SynonymsItem_UC synonymsItem_ = new SynonymsItem_UC(synonym, synonym);
                this.Controls.Add(synonymsItem_);
            }
        }
    }
}
