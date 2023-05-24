using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public static class CreateRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Cadastrar novo perfil");
        Console.WriteLine("------------------------");
        Console.Write("Nome: ");
        var name = Console.ReadLine();
        Console.Write("Slug: ");
        var slug = Console.ReadLine();

        Create(new Role
        {
            Name = name,
            Slug = slug
        });
        Console.ReadKey();
        MenuRolesScreen.Load();

    }

    public static void Create(Role role)
    {
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Create(role);
            Console.WriteLine("Perfil criado com sucesso");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possivel criar um novo perfil");
            Console.WriteLine($"{ex.Message}");           
 
        }
    }
}
