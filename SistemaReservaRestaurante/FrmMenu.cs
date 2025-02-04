using LoginRegistrationForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservaRestaurante
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreservar_Click(object sender, EventArgs e)
        {
            FrmMesa mesa = new FrmMesa();
            mesa.Show();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            FrmClienteAdd cliente = new FrmClienteAdd();
            cliente.Show();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            FrmRegistrar r = new FrmRegistrar();
            r.Show();
        }

        private void btnservir_Click(object sender, EventArgs e)
        {
            FrmServirMesaLocal local = new FrmServirMesaLocal();      
            local.Show();
        }
    }
}
