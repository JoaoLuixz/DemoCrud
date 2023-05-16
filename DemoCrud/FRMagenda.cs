using DAL;
namespace DemoCrud
{
    public partial class FRMagenda : Form
    {
        private Repositorio repositorio;
        public FRMagenda()
        {
            InitializeComponent();
        }

        private void FRMagenda_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
            bindingSourceAgenda.DataSource = repositorio;
        }
    }
}