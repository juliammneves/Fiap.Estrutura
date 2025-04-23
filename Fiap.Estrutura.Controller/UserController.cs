using Fiap.Estrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Estrutura.Controller
{
    public class UserController
    {
        public bool validateUser(string usuario, string senha)
        {
            UserRepository userRepository = new UserRepository();
            return userRepository.validateUser(usuario, senha);
        }
    }
}
