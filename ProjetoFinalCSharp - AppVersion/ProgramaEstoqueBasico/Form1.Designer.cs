namespace ProgramaEstoqueBasico
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlePaginas = new System.Windows.Forms.TabControl();
            this.tabPaginaCadastro = new System.Windows.Forms.TabPage();
            this.label_ConfirmaCadastro = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.label_valorUnitario = new System.Windows.Forms.Label();
            this.label_quantidadeProduto = new System.Windows.Forms.Label();
            this.label_loteProduto = new System.Windows.Forms.Label();
            this.label_nomeProduto = new System.Windows.Forms.Label();
            this.textBox_ValorUnitarioProduto = new System.Windows.Forms.TextBox();
            this.textBox_QuantidadeProduto = new System.Windows.Forms.TextBox();
            this.textBox_LoteProduto = new System.Windows.Forms.TextBox();
            this.textBox_NomeProduto = new System.Windows.Forms.TextBox();
            this.tabPaginaProcura = new System.Windows.Forms.TabPage();
            this.button_ConfirmaProcura = new System.Windows.Forms.Button();
            this.label_ResultadoRelatorio = new System.Windows.Forms.Label();
            this.label_TextoEscolhaRelatorio = new System.Windows.Forms.Label();
            this.comboBox_EscolhaRelatorios = new System.Windows.Forms.ComboBox();
            this.label_creditos = new System.Windows.Forms.Label();
            this.tabControlePaginas.SuspendLayout();
            this.tabPaginaCadastro.SuspendLayout();
            this.tabPaginaProcura.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlePaginas
            // 
            this.tabControlePaginas.Controls.Add(this.tabPaginaCadastro);
            this.tabControlePaginas.Controls.Add(this.tabPaginaProcura);
            this.tabControlePaginas.Location = new System.Drawing.Point(0, 0);
            this.tabControlePaginas.Name = "tabControlePaginas";
            this.tabControlePaginas.SelectedIndex = 0;
            this.tabControlePaginas.Size = new System.Drawing.Size(713, 377);
            this.tabControlePaginas.TabIndex = 0;
            // 
            // tabPaginaCadastro
            // 
            this.tabPaginaCadastro.BackColor = System.Drawing.Color.Silver;
            this.tabPaginaCadastro.Controls.Add(this.label_creditos);
            this.tabPaginaCadastro.Controls.Add(this.label_ConfirmaCadastro);
            this.tabPaginaCadastro.Controls.Add(this.buttonLimpar);
            this.tabPaginaCadastro.Controls.Add(this.button_Cadastrar);
            this.tabPaginaCadastro.Controls.Add(this.label_valorUnitario);
            this.tabPaginaCadastro.Controls.Add(this.label_quantidadeProduto);
            this.tabPaginaCadastro.Controls.Add(this.label_loteProduto);
            this.tabPaginaCadastro.Controls.Add(this.label_nomeProduto);
            this.tabPaginaCadastro.Controls.Add(this.textBox_ValorUnitarioProduto);
            this.tabPaginaCadastro.Controls.Add(this.textBox_QuantidadeProduto);
            this.tabPaginaCadastro.Controls.Add(this.textBox_LoteProduto);
            this.tabPaginaCadastro.Controls.Add(this.textBox_NomeProduto);
            this.tabPaginaCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPaginaCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabPaginaCadastro.Name = "tabPaginaCadastro";
            this.tabPaginaCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaginaCadastro.Size = new System.Drawing.Size(705, 351);
            this.tabPaginaCadastro.TabIndex = 0;
            this.tabPaginaCadastro.Text = "Cadastro";
            // 
            // label_ConfirmaCadastro
            // 
            this.label_ConfirmaCadastro.AutoSize = true;
            this.label_ConfirmaCadastro.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConfirmaCadastro.Location = new System.Drawing.Point(10, 125);
            this.label_ConfirmaCadastro.Name = "label_ConfirmaCadastro";
            this.label_ConfirmaCadastro.Size = new System.Drawing.Size(0, 15);
            this.label_ConfirmaCadastro.TabIndex = 10;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonLimpar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(13, 155);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(100, 24);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Cadastrar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cadastrar.Location = new System.Drawing.Point(150, 155);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(100, 24);
            this.button_Cadastrar.TabIndex = 8;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = false;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // label_valorUnitario
            // 
            this.label_valorUnitario.AutoSize = true;
            this.label_valorUnitario.Location = new System.Drawing.Point(10, 100);
            this.label_valorUnitario.Name = "label_valorUnitario";
            this.label_valorUnitario.Size = new System.Drawing.Size(144, 13);
            this.label_valorUnitario.TabIndex = 7;
            this.label_valorUnitario.Text = "Valor Unitario do produto: R$";
            // 
            // label_quantidadeProduto
            // 
            this.label_quantidadeProduto.AutoSize = true;
            this.label_quantidadeProduto.Location = new System.Drawing.Point(10, 75);
            this.label_quantidadeProduto.Name = "label_quantidadeProduto";
            this.label_quantidadeProduto.Size = new System.Drawing.Size(119, 13);
            this.label_quantidadeProduto.TabIndex = 6;
            this.label_quantidadeProduto.Text = "Quantidade do produto:";
            // 
            // label_loteProduto
            // 
            this.label_loteProduto.AutoSize = true;
            this.label_loteProduto.Location = new System.Drawing.Point(10, 50);
            this.label_loteProduto.Name = "label_loteProduto";
            this.label_loteProduto.Size = new System.Drawing.Size(85, 13);
            this.label_loteProduto.TabIndex = 5;
            this.label_loteProduto.Text = "Lote do produto:";
            // 
            // label_nomeProduto
            // 
            this.label_nomeProduto.AutoSize = true;
            this.label_nomeProduto.Location = new System.Drawing.Point(10, 25);
            this.label_nomeProduto.Name = "label_nomeProduto";
            this.label_nomeProduto.Size = new System.Drawing.Size(92, 13);
            this.label_nomeProduto.TabIndex = 4;
            this.label_nomeProduto.Text = "Nome do produto:";
            // 
            // textBox_ValorUnitarioProduto
            // 
            this.textBox_ValorUnitarioProduto.Location = new System.Drawing.Point(160, 100);
            this.textBox_ValorUnitarioProduto.Name = "textBox_ValorUnitarioProduto";
            this.textBox_ValorUnitarioProduto.Size = new System.Drawing.Size(100, 20);
            this.textBox_ValorUnitarioProduto.TabIndex = 3;
            // 
            // textBox_QuantidadeProduto
            // 
            this.textBox_QuantidadeProduto.Location = new System.Drawing.Point(160, 75);
            this.textBox_QuantidadeProduto.Name = "textBox_QuantidadeProduto";
            this.textBox_QuantidadeProduto.Size = new System.Drawing.Size(100, 20);
            this.textBox_QuantidadeProduto.TabIndex = 2;
            // 
            // textBox_LoteProduto
            // 
            this.textBox_LoteProduto.Location = new System.Drawing.Point(160, 50);
            this.textBox_LoteProduto.Name = "textBox_LoteProduto";
            this.textBox_LoteProduto.Size = new System.Drawing.Size(100, 20);
            this.textBox_LoteProduto.TabIndex = 1;
            // 
            // textBox_NomeProduto
            // 
            this.textBox_NomeProduto.Location = new System.Drawing.Point(160, 25);
            this.textBox_NomeProduto.Name = "textBox_NomeProduto";
            this.textBox_NomeProduto.Size = new System.Drawing.Size(100, 20);
            this.textBox_NomeProduto.TabIndex = 0;
            // 
            // tabPaginaProcura
            // 
            this.tabPaginaProcura.AccessibleDescription = "";
            this.tabPaginaProcura.AccessibleName = "";
            this.tabPaginaProcura.BackColor = System.Drawing.Color.Silver;
            this.tabPaginaProcura.Controls.Add(this.button_ConfirmaProcura);
            this.tabPaginaProcura.Controls.Add(this.label_ResultadoRelatorio);
            this.tabPaginaProcura.Controls.Add(this.label_TextoEscolhaRelatorio);
            this.tabPaginaProcura.Controls.Add(this.comboBox_EscolhaRelatorios);
            this.tabPaginaProcura.Location = new System.Drawing.Point(4, 22);
            this.tabPaginaProcura.Name = "tabPaginaProcura";
            this.tabPaginaProcura.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaginaProcura.Size = new System.Drawing.Size(705, 351);
            this.tabPaginaProcura.TabIndex = 1;
            this.tabPaginaProcura.Text = "Relatorios";
            // 
            // button_ConfirmaProcura
            // 
            this.button_ConfirmaProcura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ConfirmaProcura.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ConfirmaProcura.Location = new System.Drawing.Point(148, 196);
            this.button_ConfirmaProcura.Name = "button_ConfirmaProcura";
            this.button_ConfirmaProcura.Size = new System.Drawing.Size(93, 27);
            this.button_ConfirmaProcura.TabIndex = 3;
            this.button_ConfirmaProcura.Text = "Procurar";
            this.button_ConfirmaProcura.UseVisualStyleBackColor = false;
            this.button_ConfirmaProcura.Click += new System.EventHandler(this.button_ConfirmaProcura_Click);
            // 
            // label_ResultadoRelatorio
            // 
            this.label_ResultadoRelatorio.AutoSize = true;
            this.label_ResultadoRelatorio.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultadoRelatorio.Location = new System.Drawing.Point(300, 10);
            this.label_ResultadoRelatorio.Name = "label_ResultadoRelatorio";
            this.label_ResultadoRelatorio.Size = new System.Drawing.Size(0, 14);
            this.label_ResultadoRelatorio.TabIndex = 2;
            // 
            // label_TextoEscolhaRelatorio
            // 
            this.label_TextoEscolhaRelatorio.AutoSize = true;
            this.label_TextoEscolhaRelatorio.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TextoEscolhaRelatorio.Location = new System.Drawing.Point(10, 25);
            this.label_TextoEscolhaRelatorio.Name = "label_TextoEscolhaRelatorio";
            this.label_TextoEscolhaRelatorio.Size = new System.Drawing.Size(231, 15);
            this.label_TextoEscolhaRelatorio.TabIndex = 1;
            this.label_TextoEscolhaRelatorio.Text = "Escolha um dos relatorios abaixo";
            // 
            // comboBox_EscolhaRelatorios
            // 
            this.comboBox_EscolhaRelatorios.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_EscolhaRelatorios.FormattingEnabled = true;
            this.comboBox_EscolhaRelatorios.Items.AddRange(new object[] {
            "Todos os produtos",
            "Produto mais caro",
            "Produto mais barato",
            "Maior lote",
            "Menor lote",
            "Lote mais caro",
            "Lote mais barato"});
            this.comboBox_EscolhaRelatorios.Location = new System.Drawing.Point(10, 50);
            this.comboBox_EscolhaRelatorios.Name = "comboBox_EscolhaRelatorios";
            this.comboBox_EscolhaRelatorios.Size = new System.Drawing.Size(231, 22);
            this.comboBox_EscolhaRelatorios.TabIndex = 0;
            // 
            // label_creditos
            // 
            this.label_creditos.AutoSize = true;
            this.label_creditos.BackColor = System.Drawing.Color.DimGray;
            this.label_creditos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_creditos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_creditos.Location = new System.Drawing.Point(5, 335);
            this.label_creditos.Name = "label_creditos";
            this.label_creditos.Size = new System.Drawing.Size(700, 15);
            this.label_creditos.TabIndex = 11;
            this.label_creditos.Text = "Programa de controle de estoque v1.0  | Desenvolvido em C# & WindowsForm por Andr" +
    "é de Brito Arnaud. ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(714, 377);
            this.Controls.Add(this.tabControlePaginas);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Controle de Estoque";
            this.tabControlePaginas.ResumeLayout(false);
            this.tabPaginaCadastro.ResumeLayout(false);
            this.tabPaginaCadastro.PerformLayout();
            this.tabPaginaProcura.ResumeLayout(false);
            this.tabPaginaProcura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlePaginas;
        private System.Windows.Forms.TabPage tabPaginaCadastro;
        private System.Windows.Forms.TabPage tabPaginaProcura;
        private System.Windows.Forms.TextBox textBox_ValorUnitarioProduto;
        private System.Windows.Forms.TextBox textBox_QuantidadeProduto;
        private System.Windows.Forms.TextBox textBox_LoteProduto;
        private System.Windows.Forms.TextBox textBox_NomeProduto;
        private System.Windows.Forms.Label label_nomeProduto;
        private System.Windows.Forms.Label label_loteProduto;
        private System.Windows.Forms.Label label_quantidadeProduto;
        private System.Windows.Forms.Label label_valorUnitario;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Label label_ConfirmaCadastro;
        private System.Windows.Forms.ComboBox comboBox_EscolhaRelatorios;
        private System.Windows.Forms.Label label_TextoEscolhaRelatorio;
        private System.Windows.Forms.Label label_ResultadoRelatorio;
        private System.Windows.Forms.Button button_ConfirmaProcura;
        private System.Windows.Forms.Label label_creditos;
    }
}

