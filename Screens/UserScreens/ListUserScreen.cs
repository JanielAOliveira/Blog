using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public static class ListUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de Usuários");
        Console.WriteLine("-------------------");
        List();
        Console.ReadKey();
        MenuUserScreen.Load();
    }   
    private static void List()
    {
        var repository = new Repository<User>(Database.Connection);
        var user = repository.Get();
        foreach(var item in user)
            Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
    }
}
