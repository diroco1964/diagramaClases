using System;
public class CajeroAutomatico{

public int pinCuenta;
public int numCuenta;
public string ubicacionCajero;
public double saldoDisponible;

public void ingresarCliente () {
    
     Console.WriteLine("Ingerese su numero de cuenta");
     numCuenta = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Ingerese su contraseña");
     pinCuenta = int.Parse(Console.ReadLine());
}

public void consultarSaldo (int numCuenta, int pinCuenta, int saldoDisponible){
     int numero;
     int contraseña;
     Console.WriteLine("Para consultar su saldo ingrese su numero de cuenta");
     numero = int.Parse(Console.ReadLine());
     Console.WriteLine("Ingrese su pin");
     contraseña=int.Parse(Console.ReadLine());

     if (numero == numCuenta && contraseña == pinCuenta)
    {
        Console.WriteLine("Cuenta verificada. Mostrando saldo...");
        Console.WriteLine($"{saldoDisponible}");
    }
    else
    {
        Console.WriteLine("Número de cuenta o PIN incorrecto.");
    }
    

}

}