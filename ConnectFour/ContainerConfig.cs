using Autofac;

namespace ConnectFour
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Board>().As<IBoard>();

            builder.RegisterType<Game>().As<IGame>();

            return builder.Build();
        }
    }
}
