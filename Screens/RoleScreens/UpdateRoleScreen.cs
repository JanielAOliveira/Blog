using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public static class UpdateRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizar um perfil");
        Console.WriteLine("--------------------");
        Console.Write("Qual o ID do perfil? ");
        var id = Console.ReadLine();
        Console.Write("Nome: ");
        var name = Console.ReadLine();
        Console.Write("Slug: ");
        var slug = Console.ReadLine();

        Update(new Role
        {
            Id = int.Parse(id),
            Name = name,
            Slug = slug
        });
        Console.ReadKey();
        MenuRolesScreen.Load();

    }
    public static void Update(Role role)
    {
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Update(role);
            Console.WriteLine("Usuario atualizado com sucesso");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possivel atualizar o usuário");
            Console.WriteLine($"{ex.Message}");
        }
    }


}
