using BibliotecaAPI.Domains;

namespace BibliotecaAPI.Interfaces
{
    public interface ILivroRepository
    {
        List<Livro> Listar();
        
        Livro? BuscarPorId(int id); //<- A interrogação (?) significa que o método pode retornar null. | Esse método pode retornar um livro ou NADA.

        Livro Adicionar(Livro livro);

       





    }
}
