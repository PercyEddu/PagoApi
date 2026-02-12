namespace TESTAPI.Interfaces
{
    public interface IDescuento
    {
        bool AplicaPara(decimal monto);
        decimal Aplicar(decimal monto);
    }
}
