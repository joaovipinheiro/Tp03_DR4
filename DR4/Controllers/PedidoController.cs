using Microsoft.AspNetCore.Mvc;

namespace DR4.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PedidoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Operações CRUD
        // Exemplos: Index, Create, Edit, Delete
    }

}
