using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
//We need to add SendGrid pakage before
namespace Portafolio.Servicios
{
    public interface IServicioEmailSendGrid 
    {
        Task Enviar(ContactoViewModel contacto);
    }
    public class ServicioEmailSendGrid: IServicioEmailSendGrid
    {
        private readonly IConfiguration configuration;

        public ServicioEmailSendGrid(IConfiguration configuration)
        {
            this.configuration = configuration;

        }
        public async Task Enviar(ContactoViewModel contacto) 
        {
            
            var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = configuration.GetValue<string>("SENDGRID_FROM"); //Aquí es de donde se envia en Email
            var nombre = configuration.GetValue<string>("SENDGRID_NOMBRE");//El nombre de quien envia el mensaje


            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(email, nombre);
            var subject = $"El cliente {contacto.Email} quiere contactarte";
            var to = new EmailAddress(email, nombre);
            var plainTextContent = contacto.Mensaje;
            var htmlContent = $@"De: {contacto.Nombre} Email: {contacto.Email} Mensaje: {contacto.Mensaje}";
            var SingleEmail = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(SingleEmail);
        }
    }
}
