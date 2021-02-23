using System.Threading.Tasks;
using RMWPFPresentation.Models;

namespace RMWPFPresentation.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}