using JudoAPI.Data;
using JudoAPI.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AlunosController : BaseController<Aluno>
{
    public AlunosController(JudoContext context) : base(context) { }
}
