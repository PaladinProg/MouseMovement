/*using Microsoft.AspNetCore.Mvc;
using MouseMovement.Data; // Указываем пространство имен модели
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class MouseMovementController : Controller
{
    private readonly MouseMovementContext _context;

    public MouseMovementController(MouseMovementContext context)
    {
        _context = context;
    }

    [HttpPost("submit")]
    public async Task<IActionResult> Submit(List<(int X, int Y, DateTime Time)> coordinates)
    {
        var movement = new MouseMovement.Data.MouseMovement { Coordinates = coordinates };
        await _context.MouseMovements.AddAsync(movement);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index", "Home");
    }
}*/
using Microsoft.AspNetCore.Mvc;
using MouseMovement.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MouseMovement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MouseMovementController : ControllerBase
    {
        private readonly MouseMovementContext _context;

        public MouseMovementController(MouseMovementContext context)
        {
            _context = context;
        }

        [HttpPost("submit")]
        public async Task<IActionResult> Submit(List<(int X, int Y, DateTime Time)> coordinates)
        {
            var movement = new MouseMovement.Data.MouseMovement { Coordinates = coordinates };
            await _context.MouseMovements.AddAsync(movement);
            await _context.SaveChangesAsync();

            return Ok("Coordinates saved successfully.");
        }
    }
}