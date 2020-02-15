using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Threading.Tasks;

namespace IdentityTest.Services
{
    public class EmailServerService : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //TODO
            return null;
            throw new NotImplementedException();
        }
    }
}
