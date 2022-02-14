using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SistemaFB.Models
{
    public class Usuario
    {
        private readonly static string _conn = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Grupo { get; set; }

        public int Ramal { get; set; }

        public bool Logar() {

            var result = false;
            var sql = "SELECT Id, NomeUsuario, Login, Senha FROM UsuarioSistema WHERE Login = '"+ this.Login +"'";

            try
            {
                using (var cn = new SqlConnection(_conn))
                {
                    cn.Open();

                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows) {
                                if (dr.Read()) {

                                    if (this.Senha == dr["Senha"].ToString())
                                    {
                                        Nome = dr["NomeUsuario"].ToString();
                                        result = true;
                                    }
                                }
                                
                                
                            }
                        }
                    }
                }
            }
            catch(Exception ex) {

                Console.WriteLine("Falha" + ex);
            }
            return result;
        
        
        }
    }
}