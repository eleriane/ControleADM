using ControleADM.DataAccess;
using ControleADM.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace ControleADM.Negocio
{
    public class PessoaDAO : IAcessoDadosObject<Pessoa>
    {
        private DALHelper dal = new DALHelper();

        public bool exclua(Pessoa pessoa)
        {
            NpgsqlDataReader reader = null;
            try
            {
                string query = "delete   from " + '"' + "Pessoa" + '"' +
                    " where id = " + pessoa.id;
                dal.OpenConnection();
                reader = dal.ExecuteDataReader(query);
                reader.Close();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                this.dal.CloseConection();
            }
            return true;
        }
        public bool insira(Pessoa pessoa)
        {
            NpgsqlDataReader reader = null;
            char aspas = '"';
            try
            {
                string query = "insert into " + aspas + "Pessoa" + aspas + "(" +
                            +aspas + "Id" + aspas + "," +
                            aspas + "CPF" + aspas + "," +
                            aspas + "Nome" + aspas + "," +
                            aspas + "Endereco" + aspas + ")" +
                            " VALUES " + pessoa.id + ", " +
                              pessoa.cpf + ", " +
                              aspas + pessoa.nome + aspas + ", " +
                              aspas + pessoa.endereco + aspas + ") ";

                dal.OpenConnection();
                reader = dal.ExecuteDataReader(query);
                reader.Close();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                this.dal.CloseConection();
            }
            return true;
        }
        public bool altere(Pessoa pessoa)
        {
            NpgsqlDataReader reader = null;
            char aspas = '"';
            try
            {
                string query = "update " + aspas + "Pessoa" + aspas + "set " +
                            +aspas + "Id" + aspas + " = " + pessoa.id + ", " +
                            aspas + "CPF" + aspas + " = " + pessoa.cpf + ", " +
                            aspas + "Nome" + aspas + " = " + aspas + pessoa.nome + aspas + ", " +
                            aspas + "Endereco" + aspas + " = " + aspas + pessoa.endereco + aspas + ") ";

                dal.OpenConnection();
                reader = dal.ExecuteDataReader(query);
                reader.Close();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                this.dal.CloseConection();
            }
            return true;
        }

        public List<Pessoa> consulte(Pessoa p)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            NpgsqlDataReader reader = null;
            try
            {
                string query = "select * from " + '"' + "Pessoa" + '"' +
                    " where id = " + p.id;
                dal.OpenConnection();
                reader = dal.ExecuteDataReader(query);

                while (reader.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.id = Convert.ToInt32(reader["id"]);
                    pessoa.nome = reader["nome"].ToString();
                    pessoa.cpf = long.Parse(reader["cpf"].ToString());
                    pessoas.Add(pessoa);
                }
                reader.Close();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                this.dal.CloseConection();
            }
            return pessoas;
        }
    }
}
