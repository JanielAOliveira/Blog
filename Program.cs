
using Blog;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

internal class Program
{
    private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$; Trusted_Connection=False; TrustServerCertificate=True";

    private static void Main(string[] args)
    {
        Database.Connection = new SqlConnection(CONNECTION_STRING);
        Database.Connection.Open();
        
        Load();

        
        Console.ReadKey();
        Database.Connection.Close();
    }
    private static void Load()
    {
        Console.Clear();
        Console.WriteLine("MENU BLOG");
        Console.WriteLine("------------------------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Gestão de usuário");
        Console.WriteLine("2 - Gestão de perfil");
        Console.WriteLine("3 - Gestão de categoria");
        Console.WriteLine("4 - Gestão de tag");
        Console.WriteLine("5 - Vincular perfil/usuário");
        Console.WriteLine("6 - Vincular post/tag");
        Console.WriteLine("7 - Relatórios");
        Console.WriteLine();
        Console.WriteLine();

        var option = short.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
                MenuUserScreen.Load();
                break;
            case 2:
                MenuRolesScreen.Load();
                break;
            case 3:
                UpdateTagScreen.Load();
                break;
            case 4:
                MenuTagScreen.Load();
                break;
            case 5:
                ListRolesScreen.Load();
                break;
            case 6:
                UpdateTagScreen.Load();
                break;
            case 7:
                DeleteTagScreen.Load();
                break;
            default: Load(); break;
        }
    }


    // private static void ReadUsers(Repository<User> repository)
    //     {
    //         var users = repository.Read();
    //         foreach (var item in users)
    //             Console.WriteLine(item.Email);
    //     }
    // public static void ReadUsersWithRoles(SqlConnection connection)
    // {
    //     var repository = new UserRepository(connection);
    //     var items = repository.GetWithRoles();

    //     foreach (var item in items)
    //     {
    //         Console.WriteLine(item.Name);
    //         foreach(var role in item.Roles)
    //         {
    //             Console.WriteLine($" - {role.Name}");
    //         }
    //     }
    // }
    // public static void ReadRoles(SqlConnection connection)
    // {
    //     var repository = new Repository<Role>(connection);
    //     var items = repository.Get();

    //     foreach (var item in items)
    //         Console.WriteLine(item.Name);

    // }
    // public static void ReadTags(SqlConnection connection)
    // {
    //     var repository = new Repository<Tag>(connection);
    //     var items = repository.Get();

    //     foreach (var item in items)
    //         Console.WriteLine(item.Name);

    // }



}


