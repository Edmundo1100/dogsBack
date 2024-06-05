using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dogs.API.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Senha { get; set; } = null!;
    }
}