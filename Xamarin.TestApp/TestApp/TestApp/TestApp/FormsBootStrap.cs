using AppName.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class FormsBootStrap
    {

        public void SetViewModelLocator(IViewModelLocator viewModelLocator)
        {
            Resolver.Locator = viewModelLocator;
        }
    }
}
