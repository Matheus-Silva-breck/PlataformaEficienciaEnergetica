namespace PlataformaEficienciaEnergetica.Models
{
    public class Predio
    {
        public int PredioId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double ConsumoEnergetico { get; set; }
        public double? UsoEnergiaRenovavel { get; set; } 

        public ICollection<DadosEnergia> DadosEnergia { get; set; } = [];
    }
}