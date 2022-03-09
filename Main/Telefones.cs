using SistemaFB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaFB.Main
{
    public class Telefones : Contatos
    {
        public Telefones() { }

        public Telefones(int telefoneId, string telefone, string celular)
        {
            TelefoneId = telefoneId;
            Telefone = telefone;
            Celular = celular;
        }
    }
}