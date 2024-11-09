# Day 79

## Desafio:

	Desenvolva um aplicativo em C# que implemente um sistema de controle de acesso, permitindo gerenciar permissões e autorizações de usuários em um sistema.
        
**Resultado:**

```cshap

public class SistemaControle
{
    Dictionary<string, string> usuarios = new Dictionary<string, string>();

    public string AdicionarUsuario(string usuario, string auth)
    {
        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(auth))
        {
            return "Usuário ou autenticação inválidos!";
        }

        if (usuarios.ContainsKey(usuario))
        {
            return "Já existe um usuário com esse nome.";
        }
        
        usuarios[usuario] = auth;
        return "Seu usuário foi criado!";
    }

    public string PermicaoAcesso(string usuario, string auth)
    {
        if (usuarios.TryGetValue(usuario, out string savedAuth) && savedAuth == auth)
        {
            return "Acesso permitido!";
        }
        else
        {
            return "Acesso negado!";
        }
    }

     static void Main(string[] args)
    {
        SistemaControle sistema = new SistemaControle();

        Console.WriteLine(sistema.AdicionarUsuario("user1", "senha123")); // Deve exibir: "Seu usuário foi criado!"
        Console.WriteLine(sistema.AdicionarUsuario("user1", "senha456")); // Deve exibir: "Já existe um usuário com esse nome."
        Console.WriteLine(sistema.AdicionarUsuario("user2", "senha789")); // Deve exibir: "Seu usuário foi criado!"

        Console.WriteLine(sistema.PermicaoAcesso("user1", "senha123")); // Deve exibir: "Acesso permitido!"
        Console.WriteLine(sistema.PermicaoAcesso("user1", "senha456")); // Deve exibir: "Acesso negado!"
        Console.WriteLine(sistema.PermicaoAcesso("user2", "senha789")); // Deve exibir: "Acesso permitido!"
        Console.WriteLine(sistema.PermicaoAcesso("user3", "senha000")); // Deve exibir: "Acesso negado!"
    }
}
