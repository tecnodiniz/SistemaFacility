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

            var sql = "SELECT p.Id, p.Apolice, s.Nome, p.Fechada, p.InicioVigencia, p.TerminoVigencia, SUBSTRING(r.descricao,6,100) AS Ramo, SUBSTRING(r.descricao,6,100) AS Modalidade " +
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
                                        Convert.ToInt32(dr["Id"]),
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

        public void GetApoliceDetalhada(int id)
        {
            var sql = "SELECT c.Nome AS Segurado,s.Nome AS Seguradora,u.NomeUsuario AS Produtor,SUBSTRING(r.descricao,6,100) AS Ramo,p.Fechada,p.Protocolada,p.Emitida,p.FisicoRecebido,p.InicioVigencia,p.TerminoVigencia,p.Apolice,p.CI,p.CiaAnterior,p.ApoliceAnterior,p.ValorEmRisco,p.PremioLiquido,p.IOF,p.PremioTotal,p.Fracionamento,p.CustoApolice,p.Comissao,p.PgmtoaVista,p.nParcelas,p.TaxaJuros,p.DataBoleto,p.ValorBoleto,p.DataEnvio,p.UltimoEndosso " +
                "FROM Propostas p " +
                "INNER JOIN Clientes c ON p.ClienteId = c.id " +
                "INNER JOIN Seguradoras s ON p.SeguradoraID = s.id " +
                "INNER JOIN Ramo r ON p.RamoID = r.id " +
                "INNER JOIN UsuarioSistema u ON p.ProdutorID = u.Id " +
                "WHERE p.id = @id ";

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
                                    ApoliceId = id;
                                    ClienteNome = dr["Segurado"].ToString();
                                    Seguradora = dr["Seguradora"].ToString();
                                    ProdutorNome = dr["Produtor"].ToString();
                                    Ramo = dr["Ramo"].ToString();
                                    Fechada = Convert.ToDateTime(dr["Fechada"]);
                                    Protocolada = Convert.ToDateTime(dr["Protocolada"]);
                                    Emitida = Convert.ToDateTime(dr["Emitida"]);
                                    FisicoRecebido = Convert.ToDateTime(dr["FisicoRecebido"]);
                                    InicioVigencia = Convert.ToDateTime(dr["InicioVigencia"]);
                                    TerminoVigencia = Convert.ToDateTime(dr["TerminoVigencia"]);
                                    nApolice = dr["Apolice"].ToString();
                                    CI = dr["CI"].ToString().Replace("Null","-");
                                    CiaAnterior = dr["CiaAnterior"].ToString().Replace("Null", "-"); ;
                                    ApoliceAnterior = dr["ApoliceAnterior"].ToString().Replace("Null", "-"); ;
                                  
                                    if (Convert.IsDBNull(dr["ValorEmRisco"]))
                                    {
                                        ValorEmRisco = 0;
                                        ValorEmRisco.ToString("C");
                                    }
                                    else
                                    {
                                        ValorEmRisco = Convert.ToDouble(dr["ValorEmRisco"]);
                                    }

                                    PremioLiquido = Convert.ToDouble(dr["PremioLiquido"]);
                                    IOF = Convert.ToDouble(dr["IOF"]); IOF.ToString("F");
                                    PremioTotal = Convert.ToDouble(dr["PremioTotal"]); PremioTotal.ToString("C");
                                    Fracionamento = Convert.ToDouble(dr["Fracionamento"]); Fracionamento.ToString("C");
                                    CustoApolice = Convert.ToDouble(dr["CustoApolice"]); CustoApolice.ToString("C");
                                    Comissao = Convert.ToDouble(dr["Comissao"]);Comissao.ToString("C");
                            




                                }
                            }
                        }
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