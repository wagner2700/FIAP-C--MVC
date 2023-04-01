using FIAP.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.Controllers
{
    public class RepresentanteController : Controller

    {

        private IList<RepresentanteModel> representantes;

        public RepresentanteController()
        {
            // De uma forma rudimentar, podemos dizer que esse bloco de código 
            // simula o retorno de uma consulta no banco de dados
            representantes = new List<RepresentanteModel>();
            representantes.Add(new RepresentanteModel(1, "444.143.658-05", "José Carlos Silva"));
            representantes.Add(new RepresentanteModel(2, "062.572.723-19", "Maria José Fernandes"));
            representantes.Add(new RepresentanteModel(2, "920.680.661-06", "Carlos Silva"));
        }

        public IActionResult Index()
        {
            // Retornando para View a lista de Representantes
            return View(representantes); // <-- Atenção
        }
    }
}


