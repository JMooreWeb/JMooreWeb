using System.Threading.Tasks;

namespace JMooreWeb.Services
{
	public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
