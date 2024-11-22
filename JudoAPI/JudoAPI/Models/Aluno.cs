namespace JudoAPI.Models;
public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Faixa { get; set; }
    public float? Peso { get; set; }
    public string Colegio { get; set; }
    public ICollection<AlunoAula> AlunoAulas { get; set; }
}