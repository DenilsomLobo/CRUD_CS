namespace GRUD_APP_1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textSexo = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.labelCodcontato = new System.Windows.Forms.Label();
            this.textCodcontato = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelConfirmar = new System.Windows.Forms.Label();
            this.listViewBusca = new System.Windows.Forms.ListView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.textDeleteId = new System.Windows.Forms.TextBox();
            this.labelTextID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 19);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(71, 12);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(344, 27);
            this.textNome.TabIndex = 1;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(12, 63);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(80, 20);
            this.labelSexo.TabIndex = 2;
            this.labelSexo.Text = "Sexo(M/F):";
            this.labelSexo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textSexo
            // 
            this.textSexo.Location = new System.Drawing.Point(98, 56);
            this.textSexo.Name = "textSexo";
            this.textSexo.Size = new System.Drawing.Size(36, 27);
            this.textSexo.TabIndex = 3;
            this.textSexo.TextChanged += new System.EventHandler(this.textSexo_TextChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(12, 117);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(44, 20);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Data:";
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(62, 110);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(191, 27);
            this.textData.TabIndex = 5;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(12, 168);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(59, 20);
            this.labelCidade.TabIndex = 6;
            this.labelCidade.Text = "Cidade:";
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(77, 161);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(338, 27);
            this.textCidade.TabIndex = 7;
            // 
            // labelCodcontato
            // 
            this.labelCodcontato.AutoSize = true;
            this.labelCodcontato.Location = new System.Drawing.Point(12, 223);
            this.labelCodcontato.Name = "labelCodcontato";
            this.labelCodcontato.Size = new System.Drawing.Size(90, 20);
            this.labelCodcontato.TabIndex = 8;
            this.labelCodcontato.Text = "Codcontato:";
            // 
            // textCodcontato
            // 
            this.textCodcontato.Location = new System.Drawing.Point(108, 220);
            this.textCodcontato.Name = "textCodcontato";
            this.textCodcontato.Size = new System.Drawing.Size(307, 27);
            this.textCodcontato.TabIndex = 9;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 281);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelConfirmar
            // 
            this.labelConfirmar.Location = new System.Drawing.Point(1, 429);
            this.labelConfirmar.Name = "labelConfirmar";
            this.labelConfirmar.Size = new System.Drawing.Size(218, 23);
            this.labelConfirmar.TabIndex = 11;
            this.labelConfirmar.Click += new System.EventHandler(this.labelConfirmar_Click);
            // 
            // listViewBusca
            // 
            this.listViewBusca.Location = new System.Drawing.Point(441, 45);
            this.listViewBusca.Name = "listViewBusca";
            this.listViewBusca.Size = new System.Drawing.Size(595, 388);
            this.listViewBusca.TabIndex = 12;
            this.listViewBusca.UseCompatibleStateImageBehavior = false;
            this.listViewBusca.SelectedIndexChanged += new System.EventHandler(this.listViewBusca_SelectedIndexChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(441, 10);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscar.TabIndex = 13;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(12, 343);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(94, 29);
            this.buttonDeletar.TabIndex = 14;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // textDeleteId
            // 
            this.textDeleteId.Location = new System.Drawing.Point(161, 345);
            this.textDeleteId.Name = "textDeleteId";
            this.textDeleteId.Size = new System.Drawing.Size(47, 27);
            this.textDeleteId.TabIndex = 15;
            // 
            // labelTextID
            // 
            this.labelTextID.AutoSize = true;
            this.labelTextID.Location = new System.Drawing.Point(128, 352);
            this.labelTextID.Name = "labelTextID";
            this.labelTextID.Size = new System.Drawing.Size(27, 20);
            this.labelTextID.TabIndex = 16;
            this.labelTextID.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 448);
            this.Controls.Add(this.labelTextID);
            this.Controls.Add(this.textDeleteId);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.listViewBusca);
            this.Controls.Add(this.labelConfirmar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textCodcontato);
            this.Controls.Add(this.labelCodcontato);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textSexo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textNome;
        private Label labelSexo;
        private TextBox textSexo;
        private Label labelData;
        private TextBox textData;
        private Label labelCidade;
        private TextBox textCidade;
        private Label labelCodcontato;
        private TextBox textCodcontato;
        private Button buttonSalvar;
        private Label labelConfirmar;
        private ListView listViewBusca;
        private Button buttonBuscar;
        private Button buttonDeletar;
        private TextBox textDeleteId;
        private Label labelTextID;
    }
}