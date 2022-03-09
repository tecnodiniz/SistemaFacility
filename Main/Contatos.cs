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

        /*Telefones*/
        public int TelefoneId { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        /*Apolices/Contratos*/
        /*GetCliente*/
        public int v1;
        public string v2;
        public string v3;
        public string v4;
        public int v5;
        public int Apolices { get; set; }


        public Contatos() { }

        public Contatos(int id, string nome, string cnpj, string email, string endereco, string numero, string complemento, 
            string cep, string uf, string cidade, string bairro, int telefoneId, string telefone, string celular, int apolices)
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
            /*Telefones*/
            TelefoneId = telefoneId;
            Telefone = telefone;
            Celular = celular;
            /*Apolices*/
            Apolices = apolices;
   
               
        }

        public Contatos(int id, string nome, string cnpj, string celular, int apolices)
        {
            this.v1 = id;
            this.v2 = nome;
            this.v3 = cnpj;
            this.v4 = celular;
            this.v5 = apolices;
        }

    
    }
}