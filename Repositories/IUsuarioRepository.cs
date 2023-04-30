using CrudDynamoDB.Models;

namespace CrudDynamoDB.Repositories
{
    public interface IUsuarioRepository
    {
        Task Adicionar(Usuario usuario);
        Task Atualizar(Usuario usuario);
        Task<IEnumerable<Usuario>> Buscar(string site);
        Task<Usuario?> Buscar(string site, string email);
        Task Deletar(string site, string email);
    }
}
