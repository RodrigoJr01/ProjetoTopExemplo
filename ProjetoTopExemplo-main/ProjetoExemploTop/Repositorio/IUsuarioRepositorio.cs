using ProjetoExemploTop.Models;

namespace ProjetoExemploTop.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Usuario? Validar(string email, string senha);
    }
}
