using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public static class UpdateUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("ATUALIZAR USUÁRIO");
        Console.WriteLine("-----------------------------");
        Console.Write("ID: ");
        var id =  Console.ReadLine();
        Console.Write("Nome (Se necessário): ");
        var name = Console.ReadLine();
        Console.Write("Email (Se ncessário): ");
        var email = Console.ReadLine();
        Console.Write("Password (Se necessários): ");
        var password = Console.ReadLine();
        Console.Write("Bio: ");
        var bio = Console.ReadLine();
        Console.Write("Url: ");
        var image = Console.ReadLine();
        Console.Write("Slug: ");
        var slug = Console.ReadLine();

        Update(new User
            {
                Id = int.Parse(id),
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

    public static void Update(User user)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Update(user);
            Console.WriteLine("Usuário atualizado");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possivel atualizar o usuário");
            Console.WriteLine($"{ex.Message}");
        }
    }
}
