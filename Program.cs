using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;

namespace RepositoryPattern
{
    static class Program
    {

        public static IContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Container = Configure();
            Application.Run(new Form1(Container.Resolve<IProductRepository>()));
        }
        /// <summary>
        /// Setting dependency injection
        /// </summary>
        /// <returns></returns>
        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<Form1>();// apply form1

            return builder.Build();
        }
    }
}
