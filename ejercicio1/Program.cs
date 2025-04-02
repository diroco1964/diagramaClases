using System;



public class Vehiculo {
    modelo:string;
    marca:string;
    año: int;
    numSerie:int;

    public void arrancar(){
        Console.WriteLine("El vehículo esta encendido");
    }
    public void detener() {
        Console.WriteLine("Vehículo apagado");
    }
    publiv void acelerar(){
        Console.WriteLine("Estas aumentado la velocidad");
    }
    publicvoid frenar() {
        Console.WriteLine("Frenando el vehículo");
    }
}

public class Autobus:Vehiculo {
    capPasajeros:int;
    numPuertas:int;
    numAsientos:int;

    public void cargarPasajeros (this.capPasajeros){
        
        console.WriteLine("CuantosPasajeros desean Subir");
        int cantPasajeros=Console.ReadLine();

        if(cantPasajeros<=cantPasajeros){
            Console.WriteLine("Subiendo Pasajeros");
        }

        else{
            Console.WriteLine($"Solo pueden subir" capPasajeros);
        }
    }  
    }

    public class Tren:Vehiculo{
        numVagones:int;
        tipoCombustible:string;
        ruta:string;
        tipoCarga:string;

        public void cambiarRuta(this.ruta)
        {
            console.WriteLine("Cambiar la ruta de este viaje");
            console.WriteLine("Ingresa la nueva ruta");
            string nuevaRuta:Console.WriteLine();
            this.ruta= nuevaRuta;
        }

        public void informarCarga(tipoCarga){
            console.WriteLine("Este tren lleva una carga tipo +" this.tipoCarga);
        }

    }