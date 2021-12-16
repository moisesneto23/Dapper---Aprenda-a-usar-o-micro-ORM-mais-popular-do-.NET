using Dapper;
using System.Data;
using System.Data.SqlClient;
using Udemydapper.Model;
using Udemydapper.Repository.Interfaces;

namespace Udemydapper.Repository
{
    public class UsuarioReposirory : IUsuarioRepository
    {
        private IDbConnection _conect;
        public UsuarioReposirory()
        {
            _conect =  new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=Ecommerce;Trusted_Connection=True;");
            
        }
        public Usuario GetUsuarioById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetUsuarios()
        {
            return _conect.Query<Usuario>("select * from Usuarios").ToList();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
