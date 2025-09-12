
using Microsoft.EntityFrameworkCore;

namespace Comandas.Wf
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InicializarBancoDeDados();

            InitializeComponent();
        }

        private void InicializarBancoDeDados()
        {
            using(var banco = new ComandasDbContext())
            {
                banco.Database.Migrate();
            }
        }
    }
}
