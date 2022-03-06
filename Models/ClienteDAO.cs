using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SistemaFB.Models
{
    public class ClienteDAO
    {
        private readonly static string _conn = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public List<Cliente> GetCliente(string nome)
        {
            List<Cliente> resultado = new List<Cliente>();

            string valorPesquisa = "%" +
                  (!String.IsNullOrWhiteSpace(nome) ?
                    nome.Trim().ToUpper() :
                    String.Empty) + "%";

            var sql = "SELECT p.ClienteId As Cod,c.nome,c.CNPJ,   t.Celular ,COUNT(p.ClienteId) AS qtdPropostas FROM Clientes c INNER JOIN Propostas p ON c.id = p.ClienteId LEFT JOIN Telefones t ON t.ClienteId = c.id WHERE c.nome LIKE @SEGURADO GROUP by c.nome, p.ClienteId, c.CNPJ, t.Celular";

            
            try
            {
                using (var cn = new SqlConnection(_conn))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                      cmd.Parameters.Add("@SEGURADO", SqlDbType.VarChar).Value = valorPesquisa;

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {

                                while (dr.Read())
                                {
                                    resultado.Add(new Cliente(
                                        Convert.ToInt32(dr["Cod"]),
                                        dr["nome"].ToString(),
                                        dr["CNPJ"].ToString(),
                                        dr["Celular"].ToString(),
                                        Convert.ToInt32(dr["qtdPropostas"]))
                                        
                                        
                                        );
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha", ex.Message);

            }
            return resultado;
        }
    }
}