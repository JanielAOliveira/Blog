using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public static class CreateUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("CRIAR NOVO USUÁRIO");
        Console.WriteLine("--------------------------");
        Console.Write("Nome: ");
        var name = Console.ReadLine();
        Console.Write("Email: ");
        var email = Console.ReadLine();
        Console.Write("Digite uma senha: ");
        var password = Console.ReadLine();
        Console.Write("Digite o segmento: ");
        var bio = Console.ReadLine();
        Console.Write("Qual a url: ");
        var image = Console.ReadLine();
        Console.Write("Qual o slug: ");
        var slug = Console.ReadLine();

        Create(new User
        {
            Name = name,
            Email = email,
            PasswordHash = password,
            Bio = bio,
            Image = image,
            Slug = slug

        });
        Console.ReadKey();
        MenuUserScreen.Load();
    }
    public static void Create(User user)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Create(user);
            Console.WriteLine("Usuário criado com sucesso");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Não foi possivel criar o usuário");
            Console.WriteLine(e.Message);
        }
    }
}
