using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Pago> pagos = new List<Pago>();
        int opcion;

        do
        {
            Console.WriteLine("===== SISTEMA DE PROCESAMIENTO DE PAGOS =====");
            Console.WriteLine("1. Registrar pago con tarjeta");
            Console.WriteLine("2. Registrar pago por transferencia");
            Console.WriteLine("3. Mostrar pagos");
            Console.WriteLine("4. Procesar pago");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarPagoTarjeta(pagos);
                    break;

                case 2:
                    RegistrarPagoTransferencia(pagos);
                    break;

                case 3:
                    MostrarPagos(pagos);
                    break;

                case 4:
                    ProcesarPago(pagos);
                    break;

                case 0:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 0);
    }

    static void RegistrarPagoTarjeta(List<Pago> pagos)
    {
        Console.Write("Ingrese el titular: ");
        string titular = Console.ReadLine();

        Console.Write("Ingrese el monto: ");
        double monto = double.Parse(Console.ReadLine());

        PagoTarjeta pago = new PagoTarjeta(titular, monto);
        pagos.Add(pago);

        Console.WriteLine("Pago con tarjeta registrado correctamente.");
    }

    static void RegistrarPagoTransferencia(List<Pago> pagos)
    {
        Console.Write("Ingrese el titular: ");
        string titular = Console.ReadLine();

        Console.Write("Ingrese el monto: ");
        double monto = double.Parse(Console.ReadLine());

        PagoTransferencia pago = new PagoTransferencia(titular, monto);
        pagos.Add(pago);

        Console.WriteLine("Pago por transferencia registrado correctamente.");
    }

    static void MostrarPagos(List<Pago> pagos)
    {
        if (pagos.Count == 0)
        {
            Console.WriteLine("No hay pagos registrados.");
        }
        else
        {
            for (int i = 0; i < pagos.Count; i++)
            {
                Console.WriteLine("Número de pago: " + (i + 1));
                pagos[i].MostrarInformacion();
                Console.WriteLine("-------------------------");
            }
        }
    }

    static void ProcesarPago(List<Pago> pagos)
    {
        if (pagos.Count == 0)
        {
            Console.WriteLine("No hay pagos registrados.");
            return;
        }

        MostrarPagos(pagos);

        Console.Write("Ingrese el número del pago que desea procesar: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 1 && numero <= pagos.Count)
        {
            pagos[numero - 1].MostrarInformacion();
            pagos[numero - 1].ProcesarPago();
        }
        else
        {
            Console.WriteLine("Número de pago inválido.");
        }
    }
}