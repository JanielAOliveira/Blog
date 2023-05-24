using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public static class DeleteRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Deletar um perfil");
        Console.WriteLine("---------------------------");
        Console.Write("Digite o ID do perfil a ser deletado: ");
        var id = Console.ReadLine();

        Delete(int.Parse(id));
        Console.ReadKey();
        MenuRolesScreen.Load();

    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("Perfil deletado com sucesso");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possivel deletar o usuário");
            Console.WriteLine($"{ex.Message}");
        }
    }
}
