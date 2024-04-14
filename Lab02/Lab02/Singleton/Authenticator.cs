namespace Singleton
{
    public class Authenticator
    {
        private static readonly object lockObject = new object();
        private static Authenticator instance;

        private Authenticator() { }

        public static Authenticator GetInstance()
        {
            // Перевірка, чи екземпляр вже створений
            if (instance == null)
            {
                // Захищений блок для багатопотоковості
                lock (lockObject)
                {
                    // Перевірка, чи екземпляр ще не створений
                    if (instance == null)
                    {
                        instance = new Authenticator();
                    }
                }
            }
            return instance;
        }

        public void Authenticate(string username, string password)
        {
            // Логіка аутентифікації
            Console.WriteLine($"Authenticating {username} with password {password}");
        }
    }
}
