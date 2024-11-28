using JudoAPI.Data;
using JudoAPI.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AulasController : BaseController<Aula>
{
    public AulasController(JudoContext context) : base(context) { }
}
