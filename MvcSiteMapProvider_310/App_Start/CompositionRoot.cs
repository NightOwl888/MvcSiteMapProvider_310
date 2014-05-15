using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using MvcSiteMapProvider_310.DI;
using MvcSiteMapProvider_310.DI.Unity;
using MvcSiteMapProvider_310.DI.Unity.ContainerExtensions;


internal class CompositionRoot
{
    public static IDependencyInjectionContainer Compose()
    {
        var container = new UnityContainer();
        container.AddNewExtension<MvcSiteMapProviderContainerExtension>();

        return new UnityDependencyInjectionContainer(container);
    }
}
