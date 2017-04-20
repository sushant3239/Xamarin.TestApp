using TestApp.UWP.Infrastructure;

namespace TestApp.UWP
{
    public class Setup
    {        
        private void BootStrap()
        {
            var bootStrap = new FormsBootStrap();
            bootStrap.SetViewModelLocator(new ViewModelLocator());
        }

        public void Initialize()
        {
            BootStrap();
            Container.Intialize();
        }
    }
}
