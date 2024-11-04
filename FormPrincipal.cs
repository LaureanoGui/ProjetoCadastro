using ReaLTaiizor.Forms;

namespace ProjetoCadastro
{
    public partial class FormPrincipal : MaterialForm
    {


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAluno formAluno = new FormCadastroAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCurso formCurso = new FormCadastroCurso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }
    }
}
