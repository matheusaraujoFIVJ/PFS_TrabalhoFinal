using JudoAPI.Data;
using JudoAPI.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProfessoresController : BaseController<Professor>
{
    public ProfessoresController(JudoContext context) : base(context) { }
}
