namespace JudoAPI.Models;

public class AlunoAula
{
    public int AlunoId { get; set; }
    public Aluno Aluno { get; set; }
    public int AulaId { get; set; }
    public Aula Aula { get; set; }
}
