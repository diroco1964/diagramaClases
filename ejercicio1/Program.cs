using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Autobus
       Autobus bus39= new Autobus();
       Console.WriteLine("----------------------------------");
       bus39.modelo= "GP38";
       bus39.marca= "Nissan";
       bus39.capPasajeros= 35; 
       bus39.mostrarInfo(bus39.modelo, bus39.marca);
       bus39.cargarPasajeros(35);

       //Tren
        Tren sanMartin= new Tren();
        Console.WriteLine("----------------------------------");
        sanMartin.modelo= "PPRE54";
        sanMartin.marca="Toyota";
        sanMartin.ruta= "Retiro-SanMartin";
        sanMartin.tipoCarga= "Material Construcción";
        sanMartin.mostrarInfo(sanMartin.modelo,sanMartin.modelo);
        sanMartin.cambiarRuta(sanMartin.ruta);
        sanMartin.informarCarga(sanMartin.tipoCarga);

        // Avión 
        Avion boeing45= new Avion();
        Console.WriteLine("----------------------------------");
        boeing45.modelo= "b45A";
        boeing45.marca= "Boeing";
        boeing45.aereopSalida= "Aeropuerto Internacional Ministro Pistarini";
        boeing45.aereopLlegada="Aeropuerto Internacional El Dorado"; 
        boeing45.informarAerepuertos(boeing45.aereopSalida,boeing45.aereopLlegada);
    }
}

public class Vehiculo {
    public string modelo;
    public string marca;
    public int año;
    public int numSerie;




    public void arrancar(){
        Console.WriteLine("El vehículo esta encendido");
    }
    public void detener() {
        Console.WriteLine("Vehículo apagado");
    }
    public void acelerar(){
        Console.WriteLine("Estas aumentado la velocidad");
    }
    public void frenar() {
        Console.WriteLine("Frenando el vehículo");
    }

    public void mostrarInfo(string modelo, string marca){
        Console.WriteLine($"Este vehiculo es un modelo: {this.modelo} marca:{this.marca}");

    }
}

//CLASE AUTOBUS 
public class Autobus:Vehiculo {
    public int capPasajeros;
    public int numPuertasint;
    public int numAsientosint;

  

    public void cargarPasajeros ( int capPasajeros){
        
        Console.WriteLine("CuantosPasajeros desean Subir");
        int cantPasajeros= int.Parse(Console.ReadLine());
        if(cantPasajeros<=capPasajeros){
            Console.WriteLine("Subiendo Pasajeros");
        }

        else{
            Console.WriteLine($"Solo pueden subir {capPasajeros} pasajeros");
        }
    }  
    }

// CLASE TREN 
    public class Tren:Vehiculo{
        public int numVagones;
        public string tipoCombustible;
        public string ruta ;
        public string tipoCarga;

        public void mostarRuta(string ruta){
            Console.WriteLine($"la ruta de este tren es {ruta}");
        }
        public void cambiarRuta( string ruta){
            Console.WriteLine("Cambiar la ruta de este viaje");
            Console.WriteLine("Ingresa la nueva ruta");
            string nuevaRuta=Console.ReadLine();
            this.ruta= nuevaRuta;
            Console.WriteLine($"La nueva ruta es {this.ruta}");
        }

        public void informarCarga(string tipoCarga){
            Console.WriteLine($"Este tren lleva una carga tipo {this.tipoCarga}"); 
        }
    }

// CLASE AVION
    public class Avion:Vehiculo {
        public int numVuelo;
        public string ruta;
        public double capacidadCarga;
        public int cantTripulancion; 
        public string aereopSalida;
        public string aereopLlegada;

       public void informarAerepuertos(string aereopSalida, string aereopLlegada)
        {
             Console.WriteLine($"Este vuelo sale del aeropuerto: {aereopSalida}");
            Console.WriteLine($"Y aterrizará en el aeropuerto: {aereopLlegada}");
        }

        public void activarPilotoAutomatico(){
            Console.WriteLine($"El vuelo {this.numVuelo} ha activado el piloto automatico");
        }

    }

    