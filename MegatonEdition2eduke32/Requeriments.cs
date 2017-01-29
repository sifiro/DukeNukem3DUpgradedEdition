using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegatonEdition2eduke32
{
    public partial class Requeriments : Form
    {
        public Requeriments()
        {
            InitializeComponent();
        }

        private void Requeriments_Load(object sender, EventArgs e)
        {
            this.l_state.Text="Detectando Steam";
            utils.getSteamdir();
            
        }
    }
}
