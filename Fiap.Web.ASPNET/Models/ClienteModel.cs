namespace Fiap.Web.ASPNET.Models
{
    public class ClienteModel
    {
        public int ClienteId { get; set; }
        public string Nome{ get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Observacao{ get; set; }


        public int RepresentanteId{ get; set; }
        public RepresentanteModel representante{ get; set; }
    }
}
