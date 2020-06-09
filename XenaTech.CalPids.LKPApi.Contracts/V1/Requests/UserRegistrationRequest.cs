using System.ComponentModel.DataAnnotations;

namespace XenaTech.CalPids.LKPApi.Contracts.V1.Requests
{
    public class UserRegistrationRequest
    {
        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }
    }
}