using System.Diagnostics;

namespace WebAppCoreNouvelle.Services
{
    public class SingletonService : ISingletonService
    {
        public SingletonService()
        {
            Debug.WriteLine("Singleton service: " + Guid.NewGuid().ToString()); 
        }
    }

    public interface ISingletonService
    {

    }
}
