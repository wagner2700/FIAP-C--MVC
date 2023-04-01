namespace FIAP.Models
{
    public class RepresentanteModel
    {
        public int RepresentanteId { get; set; }

        public string NomeRepresentante { get; set; }
        public string Cpf { get; set; }

        public string Token { get; set; }

        public RepresentanteModel(int representanteId, string nomeRepresentante, string cpf) : this(representanteId, nomeRepresentante)
        {
            Cpf = cpf;
        }

        public RepresentanteModel()
        {
        }

        public RepresentanteModel(int representanteId, string nomeRepresentante)
        {
            RepresentanteId = representanteId;
            NomeRepresentante = nomeRepresentante;
        }
    }
}
