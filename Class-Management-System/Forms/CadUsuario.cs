using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Management_System.ServicesImpl;

namespace Class_Management_System.Forms
{
    public partial class CadUsuario : Form
    {
        public CadUsuario()
        {
            InitializeComponent();
        }
        private void CarregaPerfil()
        {
            try
            {
                DataBaseServiceImpl dbService = new DataBaseServiceImpl();
                dbService.CarregaCmb(cmbPerfil, "EXEC SPCARREGA_PERFIL")
;            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
