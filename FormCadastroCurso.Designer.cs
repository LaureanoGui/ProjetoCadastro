namespace ProjetoCadastro
{
    partial class FormCadastroCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCurso));
            TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            cboPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            cboNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            cboArea = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDuracao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            mlvCursos = new ReaLTaiizor.Controls.MaterialListView();
            imageList1 = new ImageList(components);
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Controls.Add(tabPageCadastro);
            TabControlCadastro.Controls.Add(tabPageConsulta);
            TabControlCadastro.Depth = 0;
            TabControlCadastro.Dock = DockStyle.Fill;
            TabControlCadastro.ImageList = imageList1;
            TabControlCadastro.Location = new Point(3, 64);
            TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastro.Multiline = true;
            TabControlCadastro.Name = "TabControlCadastro";
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Size = new Size(689, 315);
            TabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(cboPeriodo);
            tabPageCadastro.Controls.Add(cboNivel);
            tabPageCadastro.Controls.Add(cboArea);
            tabPageCadastro.Controls.Add(txtDuracao);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtCodigo);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(681, 280);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            tabPageCadastro.Click += tabPageCadastro_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(484, 242);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(588, 242);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cboPeriodo
            // 
            cboPeriodo.AutoResize = false;
            cboPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            cboPeriodo.Depth = 0;
            cboPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            cboPeriodo.DropDownHeight = 174;
            cboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeriodo.DropDownWidth = 121;
            cboPeriodo.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPeriodo.FormattingEnabled = true;
            cboPeriodo.Hint = "Período";
            cboPeriodo.IntegralHeight = false;
            cboPeriodo.ItemHeight = 43;
            cboPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            cboPeriodo.Location = new Point(6, 182);
            cboPeriodo.MaxDropDownItems = 4;
            cboPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPeriodo.Name = "cboPeriodo";
            cboPeriodo.Size = new Size(337, 49);
            cboPeriodo.StartIndex = 0;
            cboPeriodo.TabIndex = 5;
            // 
            // cboNivel
            // 
            cboNivel.AutoResize = false;
            cboNivel.BackColor = Color.FromArgb(255, 255, 255);
            cboNivel.Depth = 0;
            cboNivel.DrawMode = DrawMode.OwnerDrawVariable;
            cboNivel.DropDownHeight = 174;
            cboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNivel.DropDownWidth = 121;
            cboNivel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNivel.FormattingEnabled = true;
            cboNivel.Hint = "Nível";
            cboNivel.IntegralHeight = false;
            cboNivel.ItemHeight = 43;
            cboNivel.Items.AddRange(new object[] { "Técnico ", "Superior" });
            cboNivel.Location = new Point(6, 122);
            cboNivel.MaxDropDownItems = 4;
            cboNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(408, 49);
            cboNivel.StartIndex = 0;
            cboNivel.TabIndex = 4;
            // 
            // cboArea
            // 
            cboArea.AutoResize = false;
            cboArea.BackColor = Color.FromArgb(255, 255, 255);
            cboArea.Depth = 0;
            cboArea.DrawMode = DrawMode.OwnerDrawVariable;
            cboArea.DropDownHeight = 174;
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.DropDownWidth = 121;
            cboArea.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboArea.FormattingEnabled = true;
            cboArea.Hint = "Área";
            cboArea.IntegralHeight = false;
            cboArea.ItemHeight = 43;
            cboArea.Items.AddRange(new object[] { "Licenciatura", "Informática", "Indústria", "Administração" });
            cboArea.Location = new Point(349, 182);
            cboArea.MaxDropDownItems = 4;
            cboArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(315, 49);
            cboArea.StartIndex = 0;
            cboArea.TabIndex = 3;
            // 
            // txtDuracao
            // 
            txtDuracao.AnimateReadOnly = false;
            txtDuracao.AutoCompleteMode = AutoCompleteMode.None;
            txtDuracao.AutoCompleteSource = AutoCompleteSource.None;
            txtDuracao.BackgroundImageLayout = ImageLayout.None;
            txtDuracao.CharacterCasing = CharacterCasing.Normal;
            txtDuracao.Depth = 0;
            txtDuracao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDuracao.HideSelection = true;
            txtDuracao.Hint = "Duração em Semestres";
            txtDuracao.LeadingIcon = null;
            txtDuracao.Location = new Point(420, 123);
            txtDuracao.MaxLength = 32767;
            txtDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDuracao.Name = "txtDuracao";
            txtDuracao.PasswordChar = '\0';
            txtDuracao.PrefixSuffixText = null;
            txtDuracao.ReadOnly = false;
            txtDuracao.RightToLeft = RightToLeft.No;
            txtDuracao.SelectedText = "";
            txtDuracao.SelectionLength = 0;
            txtDuracao.SelectionStart = 0;
            txtDuracao.ShortcutsEnabled = true;
            txtDuracao.Size = new Size(244, 48);
            txtDuracao.TabIndex = 2;
            txtDuracao.TabStop = false;
            txtDuracao.TextAlign = HorizontalAlignment.Left;
            txtDuracao.TrailingIcon = null;
            txtDuracao.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 65);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(658, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.Hint = "Código do Curso";
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(6, 9);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = false;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(658, 48);
            txtCodigo.TabIndex = 0;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(mlvCursos);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(681, 280);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter_1;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(594, 238);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(515, 238);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(443, 238);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // mlvCursos
            // 
            mlvCursos.AutoSizeTable = false;
            mlvCursos.BackColor = Color.FromArgb(255, 255, 255);
            mlvCursos.BorderStyle = BorderStyle.None;
            mlvCursos.Depth = 0;
            mlvCursos.FullRowSelect = true;
            mlvCursos.Location = new Point(3, 3);
            mlvCursos.MinimumSize = new Size(200, 100);
            mlvCursos.MouseLocation = new Point(-1, -1);
            mlvCursos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mlvCursos.Name = "mlvCursos";
            mlvCursos.OwnerDraw = true;
            mlvCursos.Size = new Size(675, 219);
            mlvCursos.TabIndex = 0;
            mlvCursos.UseCompatibleStateImageBehavior = false;
            mlvCursos.View = View.Details;
            mlvCursos.MouseDoubleClick += mlvCursos_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormCadastroCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 382);
            Controls.Add(TabControlCadastro);
            DrawerTabControl = TabControlCadastro;
            Name = "FormCadastroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Curso";
            Load += FormCadastroCurso_Load;
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
        private ReaLTaiizor.Controls.MaterialComboBox cboPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox cboNivel;
        private ReaLTaiizor.Controls.MaterialComboBox cboArea;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDuracao;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialListView mlvCursos;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
    }
}