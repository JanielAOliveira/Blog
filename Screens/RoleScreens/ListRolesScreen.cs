using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public static class ListRolesScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Listar os perfis vinculado ao usuário");
        Console.WriteLine("------------------------");

        List();
        Console.ReadKey();
        MenuRolesScreen.Load();
    }

    public static void List()
    {
        var repository = new UserRepository(Database.Connection);
        var items = repository.GetWithRoles();

        foreach (var item in items)
        {
            Console.WriteLine($" {item.Id} - {item.Name} - {item.Slug}");
            foreach (var role in item.Roles)
            {
                Console.WriteLine($" {role.Id} - {role.Name} - {role.Slug}");
            }
        }
    }
}
