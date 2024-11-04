using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroCurso : MaterialForm
    {
        String cursosFileName = "cursos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public FormCadastroCurso()
        {
            InitializeComponent();
        }
        private void Salvar()
        {
            var line = $"{txtCodigo.Text};" +
                $"{txtDuracao.Text};" +
                $"{txtNome.Text};" +
                $"{cboArea.Text};" +
                $"{cboNivel.Text};" +
                $"{cboPeriodo.Text};";
            if (!isAlteracao)
            {
                var file = new StreamWriter(cursosFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else // alteração
            {
                string[] alunos = File.ReadAllLines(cursosFileName);
                alunos[indexSelecionado] = line;
                File.WriteAllLines(cursosFileName, alunos);
            }
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }

            }
        }
        private void FormCadastroAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                TabControlCadastro.SelectedIndex = 1;
            }
        }
        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Código é Obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome Obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDuracao.Text))
            {
                MessageBox.Show("Duração Obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuracao.Focus();
                return false;
            }
            return true;
        }

        private void CarregaListView()
        {
            mlvCursos.Columns.Clear();
            mlvCursos.Items.Clear();
            mlvCursos.Columns.Add("Código");
            mlvCursos.Columns.Add("Duração");
            mlvCursos.Columns.Add("Nome");
            mlvCursos.Columns.Add("Área");
            mlvCursos.Columns.Add("Nível");
            mlvCursos.Columns.Add("Período");

            string[] cursos = File.ReadAllLines(cursosFileName);

            foreach (string curso in cursos)
            {
                var campos = curso.Split(';');
                mlvCursos.Items.Add(new ListViewItem(campos));
            }
            mlvCursos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
        }


        private void FormCadastroCurso_Load(object sender, EventArgs e)
        {

        }


        private void tabPageCadastro_Click(object sender, EventArgs e)
        {

        }

        private void tabPageConsulta_Enter_1(object sender, EventArgs e)
        {
            CarregaListView();
        }
        private void Excluir()
        {
            List<string> alunos = File.ReadAllLines(cursosFileName).ToList();
            alunos.RemoveAt(indexSelecionado);
            File.WriteAllLines(cursosFileName, alunos);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (mlvCursos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente deletar o curso selecionado?",
                    "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = mlvCursos.SelectedItems[0].Index;
                    Excluir();
                    CarregaListView();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum Curso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 0;
            txtCodigo.Focus();
        }
        private void Editar()
        {
            if (mlvCursos.SelectedItems.Count > 0)
            {
                indexSelecionado = mlvCursos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = mlvCursos.SelectedItems[0];
                txtCodigo.Text = item.SubItems[0].Text;
                txtDuracao.Text = item.SubItems[1].Text;
                txtNome.Text = item.SubItems[2].Text;
                cboArea.Text = item.SubItems[3].Text;
                cboNivel.Text = item.SubItems[4].Text;
                cboPeriodo.Text = item.SubItems[5].Text;
                TabControlCadastro.SelectedIndex = 0;
                txtCodigo.Focus();

            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas. \r\n"
                + "Deseja Cancelar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastro.SelectedIndex = 1;
            }
        }

        private void mlvCursos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }
    }
}
