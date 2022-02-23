using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SistemaFB.Models
{
    public class Cliente
    {
        private readonly static string _conn = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public int Id { get; set; }
        public string Segurado { get; set; }
        public string CNPJ { get; set; }
        public string Celular { get; set; }
        public int Apolices { get; set; }

        public Cliente() { }

        public Cliente(int id, string segurado, string cnpj, string celular, int apolices) {
            Id = id;
            Segurado = segurado;
            CNPJ = cnpj;
            Celular = celular;
            Apolices = apolices;
        
        }
        public static List<Cliente> GetClientes()
        {
            var listaClientes = new List<Cliente>();
            var sql = "SELECT TOP 10 p.ClienteId As Cod,c.nome,c.CNPJ, t.Celular ,COUNT(p.ClienteId) AS qtdPropostas " +
                "FROM Clientes c " +
                "INNER JOIN Propostas p ON c.id = p.ClienteId " +
                "INNER JOIN Telefones t ON t.ClienteId = c.id  " +
                "GROUP by c.nome, p.ClienteId, c.CNPJ, t.Celular";

            try 
            {
                using (var cn = new SqlConnection(_conn))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    listaClientes.Add(new Cliente(
                                        Convert.ToInt32(dr["Cod"]),
                                        dr["nome"].ToString(),
                                        dr["CNPJ"].ToString(),
                                        dr["Celular"].ToString(),
                                        Convert.ToInt32(dr["qtdPropostas"])
                                        ));
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Falha", ex.Message);

            }
            return listaClientes;
        }


    }
    

}