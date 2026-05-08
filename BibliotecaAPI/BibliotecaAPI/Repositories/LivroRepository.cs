using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using BibliotecaAPI.Domains;
using BibliotecaAPI.Interfaces;
using BibliotecaAPI.Services;

namespace BibliotecaAPI.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly string _caminhoArquivo = "Dados/livros.json"; //<- Caminho do arquivo onde os livros serão salvos.

        //implementando método para listar todos os livros cadastrados.
        public List<Livro> Listar()
        {
            //Usamos try/catch nesse método pois estamps trabalhando com arquivos.
            // E operações realizadas com arquivos podem dar erros por vários motivos.
            try
            {
                // verificar se o arquivo ainda não existe.
                if (!File.Exists(_caminhoArquivo))
                {
                    return new List<Livro>();
                }
                //Se o arquio existir, vamos ler o conteúdo do JSON.
                string json = File.ReadAllText(_caminhoArquivo);

                return JsonSerializer.Deserialize<List<Livro>>(json) //<- Converter o json para uma lista de livros
                        ?? new List<Livro>(); //<- Caso a conversão der null, retorna uma lista vazia.
            }
            catch
            {
                return new List<Livro>(); //<- Se der qualquer outro erro na leitura, retornar lista vazia.
            }
        }      
        
                    public Livro?BuscarPorId(int id)
                    {
                    Livro livro = Listar().FirstOrDefault(livro => livro.Id == id);
                    return livro;
                    } 
                    private void Salvar(List<Livro> livros) //<- método privado -> usado somente dentro da Repository. | Esse método salva a lista de livros no arquivo JSON
                    {
                        Directory.CreateDirectory("Dados");

                    //Converte a lista de livros pra JSON
                    string json = JsonSerializer.Serialize(livros, new
                     JsonSerializerOptions
                    {
                        WriteIndented = true
                    });
                     File.WriteAllText(_caminhoArquivo, json); // Escreve o JSON dentro do arquivo.
                    }   
                    public Livro Adicionar(Livro livro)
                    {
                        List<Livro> livros = Listar();
                     //Gera ids automaticamente
                      livro.Id = livros.Any() ? livros.Max(livro => livro.Id) + 1 : 1; //<- Se já houver livros, pega o maior Id e soma 1 | Se não houver livros, começa com Id 1
                                                                                       //função Any() -> valida se existe algo e retorna true/false.

                      livros.Add(livro);
                      Salvar(livros);

                      return livro;
                      
                    }
        }            
}

