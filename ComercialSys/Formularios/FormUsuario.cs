﻿using System;
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
    public partial class FormUsuario : MetroFramework.Forms.MetroForm
    {
        public FormUsuario(Form parent)
        {
            InitializeComponent();

            //MdiParent
            MdiParent = parent;
        }
    }
}
