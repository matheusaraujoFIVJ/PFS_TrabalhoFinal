namespace JudoAPI.Models;

public class Aula
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public DateTime Data { get; set; }
    public string Descricao { get; set; }
    public int ProfessorId { get; set; }
    public Usuario Professor { get; set; }
    public ICollection<AlunoAula> AlunoAulas { get; set; }
}

