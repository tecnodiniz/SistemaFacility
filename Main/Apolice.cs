using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaFB.Main
{
    public class Apolice
    {
        public int ApoliceId { get; set; }
        public int SeguradoraId { get; set; }
        public string Seguradora { get; set; }
        public int ClienteId { get; set; }
        public string ClienteNome{ get; set; }
        public int ProdutorId { get; set; }
        public string ProdutorNome { get; set; }
        public int RamoId { get; set; }
        public string  Ramo{ get; set; }
        public int ModalidadeId { get; set; }
        public string Modalidade { get; set; }
        public DateTime Fechada { get; set; }
        public DateTime Protocolada { get; set; }
        public DateTime Emitida { get; set; }
        public DateTime FisicoRecebido { get; set; }
        public DateTime InicioVigencia { get; set; }
        public DateTime TerminoVigencia { get; set; }
        public string nApolice { get; set; }
        public string CI { get; set; }
        public string CiaAnterior { get; set; }
        public string ApoliceAnterior { get; set; }
        public double ValorEmRisco { get; set; }
        public double PremioLiquido{ get; set; }
        public double IOF { get; set; }
        public double PremioTotal { get; set; }
        public double Fracionamento { get; set; }
        public double CustoApolice{ get; set; }
        public double Comissao{ get; set; }
        public string PgmtoAvista{ get; set; }
        public int nParcelas{ get; set; }
        public double TaxaJuros{ get; set; }
        public string DataBoleto{ get; set; }
        public double ValorBoleto{ get; set; }
        public string DataEnvio{ get; set; }
        public string UltimoEndosso{ get; set; }

        public Apolice() { }
        public Apolice(int apoliceId, string apolice, string seguradora, DateTime fechada  , DateTime inicio, DateTime terminoVigencia ,string ramo, string modalidade)
        {
            ApoliceId = apoliceId;
            nApolice = apolice;
            Seguradora = seguradora;
            Fechada = fechada;
            InicioVigencia = inicio;
            TerminoVigencia = terminoVigencia;
            Ramo = ramo;
            Modalidade = modalidade;

        }

       
    }
}