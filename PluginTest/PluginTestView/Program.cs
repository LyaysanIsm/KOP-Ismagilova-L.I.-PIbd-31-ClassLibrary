using ApplicationLogic.DataAccessLogic;
using ApplicationLogic.DataStorage;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace PluginTestView
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            IUnityContainer container = GetContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<MainForm>());
        }

        private static IUnityContainer GetContainer()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ICrudLogic<Product>, 
                ProductLogic>(new HierarchicalLifetimeManager());
            unityContainer.RegisterType<ICrudLogic<Supply>,
                SupplyLogic>(new HierarchicalLifetimeManager());
            unityContainer.RegisterType<FileStorage>(new HierarchicalLifetimeManager());
            return unityContainer;
        }
    }
}
