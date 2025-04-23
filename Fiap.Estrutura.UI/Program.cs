using Fiap.Estrutura.Controller;

UserController usuario = new UserController();
if (usuario.validateUser("admin", "senha123"))
{
   Console.WriteLine("Usuário válido");
}
else
{
    Console.WriteLine("Usuário ou senha inválidos");
}

