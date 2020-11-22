using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using DataAccessLayer.Interfaces;
using DataAccessLayer.CrudLogic;
using DataAccessLayer.BindingModels;
using DataAccessLayer.ViewModels;
using Unity.Lifetime;
using DataAccessLayer.BusinessLogic;
using DataAccessLayer.DatabaseModels;

namespace WinFormsView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var unityContainer = BuildContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(unityContainer.Resolve<MainForm>());
        }

        private static IUnityContainer BuildContainer()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICrudLogic<ProductBindingModel, ProductViewModel>, 
                ProductCrudLogic>(new HierarchicalLifetimeManager());
            container.RegisterType<IBackupLogic<Product>, 
                BackupLogic>(new HierarchicalLifetimeManager());
            return container;
        }
    }
}
