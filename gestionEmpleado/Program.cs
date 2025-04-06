using System;

public class Program
{
    static void Main()
    {
        SistemaGestion sistema = new SistemaGestion();

        Departamento  departamentoIT = new Departamento("Tecnología");
        Puesto desarrollador =new Puesto("Desarrollador", 120000);
     

        Empleado empleado1 = new Empleado("Laura");
       

        sistema.AgregarEmpleado(empleado1);
       

        sistema.AsignarDepartamento(empleado1,departamentoIT);
      

        sistema.AsignarPuesto(empleado1,desarrollador);
        

        sistema.MostrarSalarios();
    }
}
public class Empleado{
    public string nombre;
    public Puesto puesto;

    public Departamento departameto;
    public  Empleado(string nombre)
    {
        this.nombre = nombre;
    }

    public double CalcularSalario()
    {
        return puesto != null ? puesto.salarioBasico : 0;
    }
}

public class Puesto{
    public string nombre;
    public double salarioBasico;

    public Puesto(string nombre, double salarioBasico)
    {
        this.nombre = nombre;
        this.salarioBasico = salarioBasico;
    }

}

public class Departamento
{
    public string nombre;

    public Departamento(string nombre)
    {
        this.nombre = nombre;
    }
}

public class SistemaGestion
{
    public  List<Empleado> empleados = new List<Empleado>();

    public void AgregarEmpleado(Empleado empleado)
    {
        empleados.Add(empleado);
    }

    public void AsignarPuesto(Empleado empleado, Puesto puesto)
    {
        empleado.puesto = puesto;
    }

    public void AsignarDepartamento(Empleado empleado, Departamento departamento)
    {
        empleado.departameto= departamento;
    }

    public void MostrarSalarios()
    {
        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine($"{empleado.nombre} - {empleado.puesto?.nombre} - ${empleado.CalcularSalario()}");
        }
    }
}