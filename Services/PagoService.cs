using TESTAPI.Interfaces;
using TESTAPI.DTO;
namespace TESTAPI.Services
{
    public class PagoService
    {
        //private readonly IDescuento _descuento;
        private readonly IEnumerable<IDescuento> _descuentos;
        private readonly IPagoRepository _repo;
        private readonly INotificador _notificador;
        public PagoService(IEnumerable<IDescuento> descuentos, IPagoRepository repo, INotificador notificador)
        {
            _descuentos = descuentos;
            _repo = repo;
            _notificador = notificador;
        }
        public ResponsePagoDTO ProcesarPago(decimal monto)
        {
            var descuento = _descuentos.First(d => d.AplicaPara(monto));
            var montoFinal = descuento.Aplicar(monto);
            _repo.Guardar(montoFinal);
            _notificador.Enviar("Pago procesado correctamente.");

            return new ResponsePagoDTO
            {
                MontoFinal = montoFinal,
                DescuentoAplicado = descuento.GetType().Name
            };
        }
    }
}
