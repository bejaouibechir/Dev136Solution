using System.Diagnostics;

namespace WebAppCoreNouvelle.Services
{
    public class ScopedService : IScopedService
    {
        public ScopedService()
        {
            Debug.WriteLine("Scoped service: " + Guid.NewGuid().ToString());
        }
    }
    public interface IScopedService
    {

    }
}
