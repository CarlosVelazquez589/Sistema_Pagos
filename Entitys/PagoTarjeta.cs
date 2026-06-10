class PagoTarjeta : Pago
{
    public PagoTarjeta(string titular, double monto) : base(titular, monto)
    {
    }

    public override double CalcularComision()
    {
        return 2000;
    }
}