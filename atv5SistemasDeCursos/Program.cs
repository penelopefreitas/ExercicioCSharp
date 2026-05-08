namespace atv5SistemasDeCursos;

class Program
{
    static void Main(string[] args)
    {
       List<Curso> cursos = new List<Curso>
       {
        new CursoTecnico("Desenvolvimento de Sistemas", 360),
        new Superior("Ciberssegurança", 500)
       };
       foreach(var curso in cursos)
       {
        curso.ExibirResumo();
       }
    }
}
