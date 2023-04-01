namespace Fiap.Web.ASPNET.Models
{
    public class RepresentanteModel
    {
        public int RpresentanteId { get; set; }
        public string  NomeRepresentante { get; set; }
        public string Cpf { get; set; }
        public string Token { get; set; }

        public RepresentanteModel(int rpresentanteId, string nomeRepresentante)
        {
            RpresentanteId = rpresentanteId;
            NomeRepresentante = nomeRepresentante;
        }

       
        public RepresentanteModel()
        {

        }

        public RepresentanteModel(int rpresentanteId, string nomeRepresentante, string cpf) : this(rpresentanteId, nomeRepresentante)
        {
            Cpf = cpf;
        }
    }
}
