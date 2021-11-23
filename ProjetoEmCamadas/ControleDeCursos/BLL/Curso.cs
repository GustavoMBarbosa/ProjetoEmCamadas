using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControleDeCursos
{
    class Usuario
    {
        public int id;
        public string nome,email, senha;
        public string tabela = "usuario";
        //Declarando a classe de conexão
        Conexao objConexao = new Conexao();
        public void CadastrarUsuario()
        {
            string inserir = $@"insert into {tabela} values(null,'{nome}',
                             '{email}' , '{senha}');";
            //chamando o metodo ExecutarComando para executar o meu insert
            objConexao.ExecutarComando(inserir);
        }

        public void AlterarUsuario()
        {
            string alterar = $@"update {tabela} set id='{id}',nome='{nome}',
                             email='{email}' , senha='{senha}';";
            objConexao.ExecutarComando(alterar);
        }

        public void ExcluirUsuario()
        {
            string excluir = $@"delete from {tabela} where id = '{id}';";          
            objConexao.ExecutarComando(excluir);
        }

        public DataTable ListarUsuario()     //Requer: using System.Data;
        {
            string consulta = $"select * from {tabela} order by id;";
            return objConexao.ExecutarConsulta(consulta);
            
        }
    }
    class Animes
    {
        public int id;
        public string nome, diretor, sinopse, estudio;
        public int episodios, usuario_id;
        public string tabela = "anime";
        //Declarando a classe de conexão
        Conexao objConexao = new Conexao();
        public void CadastraAnime()
        {
            string inserir = $@"insert into {tabela} values(null,'{nome}',
                             '{episodios}' , '{diretor}' , '{sinopse} , '{estudio}' ,
                             '{usuario_id}');";
            //chamando o metodo ExecutarComando para executar o meu insert
            objConexao.ExecutarComando(inserir);
        }
        public DataTable ListarAnime()
        {
            string consulta = $"select * from {tabela} order by id;";
            return objConexao.ExecutarConsulta(consulta);
        }
        public void ExcluirAnime()
        {
            string excluir = $@"delete from {tabela} where id = '{id}';";
            objConexao.ExecutarComando(excluir);
        }
        public void AlterarAnime()
        {
            string alterar = $@"update {tabela} set id='{id}',nome='{nome}',
                                episodios='{episodios}', diretor='{diretor}',
                                sinopse='{sinopse}', estudio='{estudio}', usuario_id='{usuario_id};";
            objConexao.ExecutarComando(alterar);
        }       
    }
}
