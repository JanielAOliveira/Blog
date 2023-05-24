using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public static class ListRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Listar os perfis");
        Console.WriteLine("------------------------");
       
        List();
        Console.ReadKey();
        MenuRolesScreen.Load();


    }

    public static void List()
    {
        var repository = new Repository<Role>(Database.Connection);
        var roles = repository.Get();

        foreach (var item in roles)
        {
            Console.WriteLine($"ID: {item.Id} - Nome: {item.Name} - Slug: {item.Slug}");
        }


    }
}
