using IdentityModel;
using IdentityServer4.Validation;
using System.Threading.Tasks;
using Spotify.Domain.User.Repository;

namespace Spotify.Idp.GrantTypeValidator
{
    public class CustomPasswordValidator : IResourceOwnerPasswordValidator
    {
        public IUserRepository _userRepository { get; }
        public CustomPasswordValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var password = context.Password;
            var username = context.UserName;

            var user = await _userRepository.GetUserByPassword(username, password);

            if (user != null)
                context.Result = new GrantValidationResult(user.Id.ToString(), OidcConstants.AuthenticationMethods.Password);

        }
    }
}
