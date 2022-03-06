using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SistemaFB.Models
{
    public class Contatos
    {
        private readonly static string _conn = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public int Id { get; set; }
        public string Nome{ get; set; }
        public string CNPJ{ get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
   

        public Contatos() { }

        public Contatos(int id, string nome, string cnpj, string email, string endereco, string numero, string complemento, 
            string cep, string uf, string cidade, string bairro)
        {
            Id = id;
            Nome = nome;
            CNPJ = cnpj;
            Email = email;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            CEP = cep;
            UF = uf;
            Cidade = cidade;
            Bairro = bairro;
   
               
        }
        public void GetSegurado(int id)
        {
            var sql = "SELECT Nome, CNPJ, Email, Endereco, Numero, Complemento, CEP, UF, Cidade, Bairro FROM Clientes WHERE id = @id";

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

       /* public static List<Contatos> GetClientes()
        {

            var listaContatos= new List<Contatos>();
            var sql = "SELECT TOP 100 * FROM Clientes";
            try
            {
                using (var cn = new SqlConnection(_conn)) {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    listaContatos.Add(new Contatos(
                                        Convert.ToInt32(dr["id"]),
                                        dr["Nome"].ToString(),
                                        dr["CNPJ"].ToString(),
                                        dr["Email"].ToString(),
                                        dr["Endereco"].ToString(),
                                        dr["Numero"].ToString(),
                                        dr["Complemento"].ToString(),
                                        dr["CEP"].ToString(),
                                        dr["UF"].ToString(),
                                        dr["Cidade"].ToString(),
                                        dr["Bairro"].ToString()

                                        ));
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
            return listaContatos;

        }*/

    }
}