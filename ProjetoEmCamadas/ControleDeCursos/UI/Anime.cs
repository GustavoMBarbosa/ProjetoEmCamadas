using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class Anime : Form
    {
        Animes objCurso = new Animes();
        public Anime()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            dtgCursos.DataSource = objCurso.ListarAnime();
        }
        

        private void FrmCursos_Load(object sender, EventArgs e)
        {

        }

        private void dtgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAnime.Text = dtgCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtepisodios.Text = dtgCursos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiretor.Text = dtgCursos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSinopse.Text = dtgCursos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEstudio.Text = dtgCursos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtusuarioid.Text = dtgCursos.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objCurso.nome = txtAnime.Text;
            objCurso.episodios = int.Parse(txtepisodios.Text);
            objCurso.diretor = txtDiretor.Text;
            objCurso.sinopse = txtSinopse.Text;
            objCurso.estudio = txtEstudio.Text;
            objCurso.usuario_id = int.Parse(txtusuarioid.Text);

            objCurso.CadastraAnime();
            MessageBox.Show("Cadastro com sucesso");

            txtAnime.Clear();
            txtSinopse.Clear();
            txtEstudio.Clear();
            txtDiretor.Clear();
            txtepisodios.Clear();
            txtusuarioid.Clear();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            objCurso.id = int.Parse(txtCodigo.Text);
            objCurso.nome = txtAnime.Text;
            objCurso.sinopse = txtSinopse.Text;
            objCurso.estudio = txtEstudio.Text;
            objCurso.diretor = txtDiretor.Text;
            objCurso.episodios = int.Parse(txtepisodios.Text);
            objCurso.usuario_id = int.Parse(txtusuarioid.Text);
            objCurso.AlterarAnime();
            MessageBox.Show("Alterado com sucesso");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objCurso.id = int.Parse(txtCodigo.Text);
            objCurso.ExcluirAnime();
            MessageBox.Show("Excluido com sucesso");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            objCurso.ListarAnime();
        }
    }
}
