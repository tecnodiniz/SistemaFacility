using SistemaFB.Main;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SistemaFB.Models
{
    public class ContatosDAO : Contatos
    {
        private readonly static string _conn = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public void GetSegurado(int id)
        {
            var sql = "SELECT c.nome, c.CNPJ, c.Email, c.Endereco, c.Numero,c.Complemento,c.CEP,c.UF,c.Cidade,c.Bairro, t.id AS TelefoneId," +
                "t.Telefone,t.Celular " +
                "FROM Clientes c " +
                "LEFT JOIN Telefones t ON c.id = t.ClienteId " +
                "WHERE C.id = @id";

            try
            {
                using (var cn = new SqlConnection(_conn))
                {
                    cn.Open();

                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    Id = id;
                                    Nome = dr["Nome"].ToString();
                                    CNPJ = dr["CNPJ"].ToString();
                                    Email = dr["Email"].ToString();
                                    Endereco = dr["Endereco"].ToString();
                                    Numero = dr["Numero"].ToString();
                                    Complemento = dr["Complemento"].ToString();
                                    CEP = dr["CEP"].ToString();
                                    UF = dr["UF"].ToString();
                                    Cidade = dr["Cidade"].ToString();
                                    Bairro = dr["Bairro"].ToString();
                                    TelefoneId = Convert.ToInt32(dr["TelefoneId"]);
                                    Telefone = dr["Telefone"].ToString();
                                    Celular = dr["Celular"].ToString();
                                }
                            }
                        }
                    }
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha:" + ex.Message);
            }
        }

        
    }
}