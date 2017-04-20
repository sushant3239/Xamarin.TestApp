namespace AppName.Core.ApplicationServices
{
    public interface INavigationService
    {
        void ShowView(string viewName, object navigtaionParameter = null);
    }
}
