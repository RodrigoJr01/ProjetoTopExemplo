using ProjetoExemploTop.Models;

namespace ProjetoExemploTop.Repositorio
{
    public interface IProdutoRepositorio
    {
        IEnumerable<Produto> ListarTodos();
        Produto? ObterPorId(int id); 
        void Adicionar(Produto produto);
        void Atualizar(Produto produto); 
        void Excluir(int id); 

    }
}
