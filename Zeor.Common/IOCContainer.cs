using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeor.Common
{
    public class IOCContainer
    {
        private static volatile IOCContainer instance;

        private static object syncRoot = new object();

        private IUnityContainer container = null;

        public static IOCContainer Instance
        {
            get
            {
                if (IOCContainer.instance == null)
                {
                    lock (IOCContainer.syncRoot)
                    {
                        if (IOCContainer.instance == null)
                        {
                            IOCContainer.instance = new IOCContainer();
                        }
                    }
                }
                return IOCContainer.instance;
            }
        }

        private IOCContainer()
        {
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            this.container = new UnityContainer().LoadConfiguration(section);
        }

        public T Resolve<T>()
        {
            return this.container.Resolve<T>(new ResolverOverride[0]);
        }
    }
}
