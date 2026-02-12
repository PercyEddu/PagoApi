using TESTAPI.Interfaces;

namespace TESTAPI.Implementations
{
    public class EmailNotificador : INotificador
    {
        public void Enviar(string mensaje)
        {
            // Simulación de envío de email
            Console.WriteLine($"Email enviado: {mensaje}");
        }
    }
}
