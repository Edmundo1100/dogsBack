using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dogs.API.Database;
using dogs.API.Model;

namespace dogs.API.Repositories.usuario
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly DogsContext _db;

        public UsuarioRepository(DogsContext db)
        {
            _db = db;
        }

        public List<Usuario> Get()
        {
            return _db.Usuarios.ToList();
        }
        public Usuario Get(string login)
        {
            return _db.Usuarios.FirstOrDefault(usuario => usuario.Login == login)!;
        }
        public Usuario Get(int id)
        { 
            return _db.Usuarios.Find(id)!;
        }
        public void Add(Usuario usuario)
        {
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
        }
        public void Updade(Usuario usuario)
        {
            _db.Usuarios.Update(usuario);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Usuarios.Remove(Get(id));
            _db.SaveChanges();
        }

    }
}