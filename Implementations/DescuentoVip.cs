using TESTAPI.Interfaces;

namespace TESTAPI.Implementations
{
    public class DescuentoVip:IDescuento
    {
        //public bool AplicaPara(decimal monto) => monto > 100 && monto <= 1000;
        public bool AplicaPara(decimal monto)
        {
            return (monto > 100 && monto <= 1000);
        } 
        //public decimal Aplicar(decimal monto) => monto * 0.8m;
        public decimal Aplicar(decimal monto) 
        {
            Console.WriteLine("Descuento VIP");
            return (monto * 0.8m);
        } 
    }
}
