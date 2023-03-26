using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgorithmM_12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.Write("Введитете логин пользователя:");
            user.Login= Console.ReadLine();
            Console.WriteLine();
            Console.Write("Введите имя пользователя:");
            user.Name= Console.ReadLine();
            Console.WriteLine();
            Console.Write("Есть ли у вас подписка на приложение?(да / нет):");
            string subscription = Console.ReadLine();
            if (subscription == "да")
            {
                user.IsPremium = true;
            }
            else { user.IsPremium = false; }

            Welcome(user);

        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
        static string Welcome(User user)
        {
            if(user == null)
            {
                return "Нет данных по пользователю";
            }
            else
            {
                Console.WriteLine($"Добро пожаловать {user.Name}");
            }
            if (!user.IsPremium)
            {
                ShowAds();
                return "";
            }
            else
            {
                return "";
            }

        }
    }
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
}
