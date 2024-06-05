using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dogs.API.Model;

namespace dogs.API.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> Get();
        Usuario Get(string login);
        Usuario Get(int id);
        void Add(Usuario usuario);
        void Updade(Usuario usuario);
        void Delete(int id);
    }
}