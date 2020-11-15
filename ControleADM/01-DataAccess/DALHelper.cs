using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Npgsql;

namespace ControleADM.DataAccess
{
    public class DALHelper
    {
        string server = "localhost";
        string port = "5432";
        string database = "macoratti";
        string userId = "macoratti";
        string userPassword = "numsey";

        public NpgsqlConnection conexaoBD { get; set; }
        public string stringConexaoBD { get; set; }

        public DALHelper()
        {
            this.stringConexaoBD = string.Format("Server={0};Port={1};Database={2};User Id={3};Password={4};",
                                                                    server, port, database, userId, userPassword);
            this.conexaoBD = new NpgsqlConnection(this.stringConexaoBD);
        }

        public DALHelper(string stringConexaoBD)
        {
            this.conexaoBD = new NpgsqlConnection(this.stringConexaoBD);
        }

        public static DALHelper Create()
        {
            return new DALHelper();
        }

        public static DALHelper Create(string stringConexaoBD)
        {
            return new DALHelper(stringConexaoBD);
        }

        public void OpenConnection()
        {
            if (this.conexaoBD.State == System.Data.ConnectionState.Closed)
            {
                this.conexaoBD.Open();
            }
        }

        public void CloseConection()
        {
            this.conexaoBD.Close();
        }

        public NpgsqlDataReader ExecuteDataReader(string sql)
        {
            NpgsqlDataReader dr = null;
            try
            {
                if (this.conexaoBD.State == System.Data.ConnectionState.Closed)
                {
                    this.conexaoBD.Open();
                }
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexaoBD);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}