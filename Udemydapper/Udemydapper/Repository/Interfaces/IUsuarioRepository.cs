using Udemydapper.Model;

namespace Udemydapper.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        public List<Usuario> GetUsuarios();
        public Usuario GetUsuarioById(int id);
        public bool Remove(int id);

    }
}
