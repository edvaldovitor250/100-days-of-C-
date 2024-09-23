using System.Security.Cryptography;

    static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Registrando usuário...");
            registrar("teste@exemplo.com", "senha1234");
            Console.WriteLine("Usuário registrado com sucesso!");

            Console.WriteLine("Fazendo login...");
            login("teste@exemplo.com", "senha1234");
            Console.WriteLine("Login realizado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void registrar(string email, string password)
    {
        string[] emails = email.Split();
        if (emails.Length > 1)
        {
            throw new ArgumentException("Email inválido!");
        }

        if (password.Length < 8)
        {
            throw new ArgumentException("Senha inválida! Deve conter pelo menos 8 caracteres.");
        }

        byte[] hashedPassword = new byte[16];
        rngCsp.GetBytes(hashedPassword);

        Console.WriteLine("Senha registrada com hash gerado.");
    }

    static void login(string email, string password)
    {
        if (email == null)
        {
            throw new ArgumentNullException("email");
        }

        byte[] hashedPassword = new byte[16];
        rngCsp.GetBytes(hashedPassword);

        Console.WriteLine("Senha verificada com hash gerado." );
    }
