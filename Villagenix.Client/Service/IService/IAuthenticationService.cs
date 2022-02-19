using System.Threading.Tasks;
using Villagenix.Models;

namespace Villagenix.Client.Service.IService
{
    public interface IAuthenticationService
    {
        Task<RegisterationResponseDTO> RegisterUser(UserRequestDTO userForRegisteration);

        Task<AuthenticationResponseDTO> Login(AuthenticationDTO userFromAuthentication);

        Task Logout();
    }
}
