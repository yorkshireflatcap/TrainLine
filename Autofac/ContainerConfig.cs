using Autofac;
using Newtonsoft.Json;
using ohce;
using ohce.Helpers;
using ohce.Language;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public static class ContainerConfig
    {

        public static IContainer Configure()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            // Find and add any interfaces
            containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
           
            return containerBuilder.Build(); // build the container
        }
    }
}
