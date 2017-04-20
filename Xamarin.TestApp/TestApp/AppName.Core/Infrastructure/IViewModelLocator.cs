namespace AppName.Core.Infrastructure
{
    public interface IViewModelLocator
    {
        T Resolve<T>();
    }
}
