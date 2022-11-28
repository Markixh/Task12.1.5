namespace Task12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            User user1 = new User();
            user1.Login = "user1";
            user1.IsPremium = true;
            user1.Name = "Андрей";
            users.Add(user1);

            User user2 = new User();
            user2.Login = "user2";
            user2.IsPremium = true;
            user2.Name = "Елена";
            users.Add(user2);

            User user3 = new User();
            user3.Login = "user3";
            user3.IsPremium = false;
            user3.Name = "Ольга";
            users.Add(user3);

            foreach (User user in users)
            {
                Console.WriteLine("Привет " + user.Name);
                if (!user.IsPremium)
                {
                    ShowAds();
                }                
            }
        }

        class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
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
    }
}