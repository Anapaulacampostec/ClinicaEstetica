using System;
using System.Data.SqlClient;

namespace ClinicaEstetica.DAL
{
    public class Conexao
    {
        protected SqlConnection conexao;
        protected SqlCommand command;
        protected SqlDataReader dataReader;

        protected void Conectar()
        {
            try
            {
                conexao = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog=ClinicaEstetica; Integrated Security=true");
                conexao.Open();
            }
            catch (System.Exception erro)
            {

                throw new Exception(erro.Message);
            }
        }
        protected void Desconectar()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
        }
    }
}