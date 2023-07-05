using Autofac;

namespace ohce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = DI.ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.CorrectGreeting(args[0]);
                app.Run(args[0]);
            }
        }
    }
}
