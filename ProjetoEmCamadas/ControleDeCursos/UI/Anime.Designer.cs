
namespace ControleDeCursos
{
    partial class Anime
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
            this.txtusuarioid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtepisodios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtgCursos = new System.Windows.Forms.DataGridView();
            this.txtEstudio = new System.Windows.Forms.TextBox();
            this.lblValorMensalidade = new System.Windows.Forms.Label();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.txtAnime = new System.Windows.Forms.TextBox();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuarioid
            // 
            this.txtusuarioid.Location = new System.Drawing.Point(301, 155);
            this.txtusuarioid.Name = "txtusuarioid";
            this.txtusuarioid.Size = new System.Drawing.Size(143, 20);
            this.txtusuarioid.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID do usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "N de Episodios:";
            // 
            // txtepisodios
            // 
            this.txtepisodios.Location = new System.Drawing.Point(116, 155);
            this.txtepisodios.Name = "txtepisodios";
            this.txtepisodios.Size = new System.Drawing.Size(100, 20);
            this.txtepisodios.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Diretor:";
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(281, 6);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(163, 20);
            this.txtDiretor.TabIndex = 32;
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnListar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Location = new System.Drawing.Point(12, 214);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(432, 57);
            this.pnlCRUD.TabIndex = 31;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(27, 13);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 30);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(123, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 30);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(318, 13);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(90, 30);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(222, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtgCursos
            // 
            this.dtgCursos.BackgroundColor = System.Drawing.Color.White;
            this.dtgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCursos.Location = new System.Drawing.Point(12, 290);
            this.dtgCursos.Name = "dtgCursos";
            this.dtgCursos.Size = new System.Drawing.Size(432, 175);
            this.dtgCursos.TabIndex = 30;
            // 
            // txtEstudio
            // 
            this.txtEstudio.Location = new System.Drawing.Point(116, 181);
            this.txtEstudio.Name = "txtEstudio";
            this.txtEstudio.Size = new System.Drawing.Size(328, 20);
            this.txtEstudio.TabIndex = 27;
            // 
            // lblValorMensalidade
            // 
            this.lblValorMensalidade.AutoSize = true;
            this.lblValorMensalidade.Location = new System.Drawing.Point(12, 184);
            this.lblValorMensalidade.Name = "lblValorMensalidade";
            this.lblValorMensalidade.Size = new System.Drawing.Size(45, 13);
            this.lblValorMensalidade.TabIndex = 29;
            this.lblValorMensalidade.Text = "Estudio:";
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(116, 87);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(328, 62);
            this.txtSinopse.TabIndex = 26;
            // 
            // lblConteudo
            // 
            this.lblConteudo.Location = new System.Drawing.Point(12, 100);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(97, 32);
            this.lblConteudo.TabIndex = 28;
            this.lblConteudo.Text = "Sinopse:";
            // 
            // txtAnime
            // 
            this.txtAnime.Location = new System.Drawing.Point(116, 47);
            this.txtAnime.Name = "txtAnime";
            this.txtAnime.Size = new System.Drawing.Size(328, 20);
            this.txtAnime.TabIndex = 24;
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Location = new System.Drawing.Point(12, 50);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCurso.TabIndex = 25;
            this.lblNomeCurso.Text = "Nome do Anime:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 23;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "Código:";
            // 
            // Anime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 477);
            this.Controls.Add(this.txtusuarioid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtepisodios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiretor);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.dtgCursos);
            this.Controls.Add(this.txtEstudio);
            this.Controls.Add(this.lblValorMensalidade);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.txtAnime);
            this.Controls.Add(this.lblNomeCurso);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Anime";
            this.Text = "Anime";
            this.pnlCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuarioid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtepisodios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dtgCursos;
        private System.Windows.Forms.TextBox txtEstudio;
        private System.Windows.Forms.Label lblValorMensalidade;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.TextBox txtAnime;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}