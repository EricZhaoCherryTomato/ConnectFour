using System;
using Autofac;

namespace ConnectFour
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var game = scope.Resolve<IGame>();
                game.Start();
                Console.ReadKey(true);
            }
        }
    }
}