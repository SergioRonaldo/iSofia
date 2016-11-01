using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSofia
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void mAE_USUARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mAE_USUARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sofiaDataSet);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sofiaDataSet.MAE_USUARIOS' Puede moverla o quitarla según sea necesario.
            this.mAE_USUARIOSTableAdapter.Fill(this.sofiaDataSet.MAE_USUARIOS);

        }

        private void cANCELARbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
