namespace Blog.Screens.RoleScreens;

public static class MenuRolesScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("MENU GESTÃO DE PERFIS");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("1 - Listar perfis");
        Console.WriteLine("2 - Cadastrar perfis");
        Console.WriteLine("3 - Atualizar perfis");
        Console.WriteLine("4 - Excluir perfis");
        Console.WriteLine();
        Console.WriteLine();
        
        var option = int.Parse(Console.ReadLine());

        switch (option)
        {   
            case 1:
                ListRoleScreen.Load();
                break;
            case 2:
                CreateRoleScreen.Load();
                break;
            case 3:
                UpdateRoleScreen.Load();
                break;
            case 4:
                DeleteRoleScreen.Load();
                break;
            default: Load(); break;
        }
        
    }
}
