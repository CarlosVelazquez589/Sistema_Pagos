using System;

abstract class Pago
{
    private string titular;
    private double monto;

    public string Titular
    {
        get { return this.titular; }
        set { this.titular = value; }
    }

    public double Monto
    {
        get { return this.monto; }
        set { this.monto = value; }
    }

    public Pago(string titular, double monto)
    {
        this.Titular = titular;
        this.Monto = monto;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Titular: " + Titular);
        Console.WriteLine("Monto original: $" + Monto);
    }

    public abstract double CalcularComision();

    public void ProcesarPago()
    {
        double comision = CalcularComision();
        double montoFinal = Monto + comision;

        Console.WriteLine("Procesando pago...");
        Console.WriteLine("Comisión aplicada: $" + comision);
        Console.WriteLine("Monto final: $" + montoFinal);
        Console.WriteLine("Pago realizado correctamente.");
    }
}