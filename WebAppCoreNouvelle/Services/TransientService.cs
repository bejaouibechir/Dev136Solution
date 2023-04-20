using System.Diagnostics;

namespace WebAppCoreNouvelle.Services
{
    public class TransientService: ITransientService
    {
        public TransientService()
        {
            Debug.WriteLine("Transient service: " + Guid.NewGuid().ToString());
        }
    }
    public interface ITransientService
    {

    }
}
