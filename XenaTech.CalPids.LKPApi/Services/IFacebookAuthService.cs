using System.Threading.Tasks;
using XenaTech.CalPids.LKPApi.External.Contracts;

namespace XenaTech.CalPids.LKPApi.Services
{
    public interface IFacebookAuthService
    {
        Task<FacebookTokenValidationResult> ValidateAccessTokenAsync(string accessToken);

        Task<FacebookUserInfoResult> GetUserInfoAsync(string accessToken);
    }
}