using ApplicationLogic.BindingModels;
using ApplicationLogic.DataAccessLogic;
using ApplicationLogic.DataStorage;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace ApplicationView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = GetConfiguredContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<MainForm>());
        }

        static IUnityContainer GetConfiguredContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<ICrudLogic<Product>, 
                ProductLogic>(new HierarchicalLifetimeManager());
            container.RegisterType<ICrudLogic<Order>,
                OrderLogic>(new HierarchicalLifetimeManager());
            container.RegisterType<ICrudLogic<Warehouse>,
                WarehouseLogic>(new HierarchicalLifetimeManager());
            container.RegisterType<FileStorage>(new HierarchicalLifetimeManager());
            return container;
        }
    }
}
