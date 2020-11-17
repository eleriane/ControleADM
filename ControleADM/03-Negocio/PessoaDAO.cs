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
            return true;
        }
        public bool insira(Pessoa pessoa)
        {
            return true;
        }
        public bool altere(Pessoa pessoa)
        {
            return true;
        }
        public List<Pessoa> consulte(Pessoa p)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            NpgsqlDataReader reader = null;
            try
            {
                string query =  "select * from " + '"'  + "Pessoa" + '"' ;
                dal.OpenConnection();
                reader = dal.ExecuteDataReader(query);

                while (reader.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.id = Convert.ToInt32(reader["id"]);
                    pessoa.nome = reader["nome"].ToString();
                    pessoa.cpf = long.Parse( reader["cpf"].ToString());
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
