using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DeckController
{
    class Conexao
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strQuery;


        public Conexao()
        {
            conexao = new MySqlConnection("Server=localhost;Database=db_deck2;Uid=root;Port=3306;Pwd=34686328;");
        }

        public void novo(string nome, string tipo)
        {
            strQuery = "INSERT INTO tb_carta (nome, tipo) VALUES (@nome, @tipo)";
            comando = new MySqlCommand(strQuery, conexao);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@tipo", tipo);

            conexao.Open();

            comando.ExecuteNonQuery();
        }

        public void editar(string id, string nome, string tipo)
        {
            strQuery = "UPDATE tb_carta set nome = @nome, tipo = @tipo WHERE id = @id";
            comando = new MySqlCommand(strQuery, conexao);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@id", id);
            conexao.Open();

            comando.ExecuteNonQuery();
        }

        public void excluir(string id)
        {
            strQuery = "DELETE from tb_carta WHERE id = @id";

            comando = new MySqlCommand(strQuery, conexao);
            comando.Parameters.AddWithValue("@id", id);

            conexao.Open();

            comando.ExecuteNonQuery();
        }

        public MySqlDataReader consultar(string id)
        {
            strQuery = "SELECT * FROM tb_carta WHERE id = @id";

            comando = new MySqlCommand(strQuery, conexao);
            comando.Parameters.AddWithValue("@id", id);
    
        conexao.Open();

            dr = comando.ExecuteReader();

            return dr;
        }

        public DataTable exibir()
        {
            strQuery = "SELECT * FROM tb_carta";

            da = new MySqlDataAdapter(strQuery, conexao);
            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }

        public void close()
        {
            conexao.Close();
            conexao = null;
            comando = null;
        }
    }
  
}
