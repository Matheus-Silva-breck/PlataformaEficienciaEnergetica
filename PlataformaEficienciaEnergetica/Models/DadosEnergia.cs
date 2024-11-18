namespace PlataformaEficienciaEnergetica.Models
{
    public class DadosEnergia
    {
        public int DadosEnergiaId { get; set; }
        public int PredioId { get; set; }
        public double ConsumoTotal { get; set; }
        public DateTime Data { get; set; }
        public required Predio Predio { get; set; }
    }
}