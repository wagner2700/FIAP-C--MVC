namespace FIAP.Models
{
    public class ClienteModel
    {
        public int Clienteid { get; set; }

        public string Nome { get; set; }

        public string Email { get; set;}

        public DateTime DataNAscimento { get; set; }

        public string Observacao { get; set; }

        public int RepresentanteId { get; set; }

        public RepresentanteModel Representante { get; set; }

    }
}
