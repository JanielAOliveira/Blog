using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class ListRolesScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Listar os perfis vinculados ao usuário");
            Console.WriteLine("------------------------");
            Console.Write("Digite o ID do usuário: ");
            var idUser = int.Parse(Console.ReadLine());

            Vincular(idUser);
            Console.ReadKey();
            ListRolesScreen.Load();
        }

        public static void Vincular(int userId)
        {
            var repository = new UserRepository(Database.Connection);
            var users = repository.GetWithRoles();

            var user = users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                Console.WriteLine($"Usuário ID: {user.Id}, Nome: {user.Name}");
                foreach (var role in user.Roles)
                {
                    Console.WriteLine($"Perifl ID: {role.Id} - Nome: {role.Name}, Slug: {role.Slug}");
                }
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }
    }
}
