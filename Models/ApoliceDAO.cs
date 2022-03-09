using SistemaFB.Main;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SistemaFB.Models
{
    public class ApoliceDAO : Apolice
    {
        private readonly static string _conn = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public List<Apolice> GetApolice(int id)
           {

            List<Apolice> resultado = new List<Apolice>();

            var sql = "SELECT p.Apolice, s.Nome, p.Fechada, p.InicioVigencia, p.TerminoVigencia, SUBSTRING(r.descricao,6,100) AS Ramo, SUBSTRING(r.descricao,6,100) AS Modalidade " +
                "FROM Propostas p " +
                "INNER JOIN Seguradoras s ON p.SeguradoraID = s.id " +
                "INNER JOIN Ramo r ON p.RamoID = r.id " +
                "INNER JOIN Modalidade m ON p.ModalidadeID = m.id " +
                "WHERE ClienteId = @id ORDER BY Fechada DESC";

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
                                while (dr.Read())
                                {
                                    resultado.Add(new Apolice(
                                        dr["Apolice"].ToString(),
                                        dr["Nome"].ToString(),
                                        Convert.ToDateTime(dr["Fechada"]),
                                        Convert.ToDateTime(dr["InicioVigencia"]),
                                        Convert.ToDateTime(dr["TerminoVigencia"]),
                                        dr["Ramo"].ToString(),
                                        dr["Modalidade"].ToString()
                                        )); 
                           
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
            return resultado;
        }
    }
}