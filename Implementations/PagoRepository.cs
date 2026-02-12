using TESTAPI.Interfaces;

namespace TESTAPI.Implementations
{
    public class PagoRepository:IPagoRepository
    {
        public void Guardar(decimal monto) 
        {
            // Simulación de guardado en BD
            Console.WriteLine($"Pago guardado: {monto:C}");
        }
    }
}
