using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dogs.API.Model;

namespace dogs.API.Repositories.usuario
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public static List<Usuario> _db = new List<Usuario>();

        public UsuarioRepository()
        {
        }

        public List<Usuario> Get()
        {
            return _db;
        }
        public Usuario Get(string login)
        {
            return _db.Find(usuario => usuario.Login == login)!;
        }
        public Usuario Get(int id)
        {
            return _db.Find(usuario => usuario.Id == id)!;
        }
        public void Add(Usuario usuario)
        {
            _db.Add(usuario);
        }
        public void Updade(Usuario usuario)
        {
            _db.Remove(Get(usuario.Id));
            _db.Add(usuario);
        }
        public void Delete(int id)
        {
            _db.Remove(Get(id));
        }

    }
}