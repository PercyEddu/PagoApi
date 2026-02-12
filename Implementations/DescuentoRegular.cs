using TESTAPI.Interfaces;

namespace TESTAPI.Implementations
{
    public class DescuentoRegular:IDescuento
    {
        //public bool AplicaPara(decimal monto) => monto <= 100;
        public bool AplicaPara(decimal monto)
        {
            return (monto <= 100);
        } 
        //public decimal Aplicar(decimal monto) => monto * 0.95m;
        public decimal Aplicar(decimal monto) 
        {
            Console.WriteLine("Descuento Regular");
            return monto * 0.95m;
        } 
    }
}
