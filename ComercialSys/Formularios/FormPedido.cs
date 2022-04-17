using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys.Formularios
{
    public partial class FormPedido : MetroFramework.Forms.MetroForm
    {
        public FormPedido(Form parent)
        {
            InitializeComponent();

            //MdiParent
            MdiParent = parent;

        }
    }
}
