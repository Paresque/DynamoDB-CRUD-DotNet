using Amazon.DynamoDBv2.DataModel;
using CrudDynamoDB.Models;

namespace CrudDynamoDB.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IDynamoDBContext _context;

        public UsuarioRepository(IDynamoDBContext context)
        {
            _context = context;
        }

        public async Task Adicionar(Usuario usuario)
        {
            await _context.SaveAsync(usuario);
        }

        public async Task Atualizar(Usuario usuario)
        {
            await _context.SaveAsync(usuario);
        }

        public async Task<IEnumerable<Usuario>> Buscar(string site)
        {
            return await _context.QueryAsync<Usuario>(site).GetRemainingAsync();
        }

        public async Task<Usuario?> Buscar(string site, string email)
        {
            var lista = await _context.QueryAsync<Usuario>(site, Amazon.DynamoDBv2.DocumentModel.QueryOperator.Equal, new object[] { email })
                .GetRemainingAsync();

            return lista.FirstOrDefault();
        }

        public async Task Deletar(string site, string email)
        {
            await _context.DeleteAsync<Usuario>(site, email);
        }
    }
}
