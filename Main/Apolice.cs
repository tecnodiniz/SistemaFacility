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
        public int ProdutorId { get; set; }
        public int RamoId { get; set; }
        public string Ramo{ get; set; }
        public int ModalidadeId { get; set; }
        public string Modalidade { get; set; }
        public DateTime Fechada { get; set; }
        public string Protocolada { get; set; }
        public string Emitida { get; set; }
        public string FisicoRecebido { get; set; }
        public DateTime InicioVigencia { get; set; }
        public DateTime TerminoVigencia { get; set; }
        public string nApolice { get; set; }
        public string CI { get; set; }
        public string CiaAnterior { get; set; }
        public string ApoliceAnterior { get; set; }
        public decimal ValorEmRisco { get; set; }
        public decimal PremioLiquido{ get; set; }
        public decimal IOF { get; set; }
        public decimal PremioTotal { get; set; }
        public decimal Fracionamento { get; set; }
        public decimal CustoApolice{ get; set; }
        public decimal Comissao{ get; set; }
        public string PgmtoAvista{ get; set; }
        public int nParcelas{ get; set; }
        public decimal TaxaJuros{ get; set; }
        public string DataBoleto{ get; set; }
        public decimal ValorBoleto{ get; set; }
        public string DataEnvio{ get; set; }
        public string UltimoEndosso{ get; set; }

        public Apolice() { }
        public Apolice(string apolice, string seguradora, DateTime fechada, DateTime inicio, DateTime terminoVigencia ,string ramo, string modalidade)
        {
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