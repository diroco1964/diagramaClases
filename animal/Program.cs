using System;

public class Program{
    public static void Main(string[] args){
        //ANIMAL 
        Pato jergonChico = new Pato();
        jergonChico.especie= "Pato jergon chico";
        jergonChico.grupo= "Ave";
        jergonChico.clase= "vertebrado";
        jergonChico.tipoAlimentacion= "Omnivoro";
        jergonChico.tipoSonido="Graznar";
        jergonChico.mostarInfoAnimal(jergonChico.especie,jergonChico.clase,jergonChico.tipoAlimentacion,jergonChico.grupo);
        jergonChico.hacerSonido(jergonChico.tipoSonido);
        jergonChico.patoDomesticado();
        Console.WriteLine("--------------------------------");

        //LOMBRIZ

        Lombriz lombrizTierra1= new Lombriz();
        lombrizTierra1.especie="Lombriz de tierra";
        lombrizTierra1.grupo="anélidos oligoquetos";
        lombrizTierra1.clase="Invertebrado";
        lombrizTierra1.tipoAlimentacion= "Omnivoro";
        lombrizTierra1.mostarInfoAnimal(lombrizTierra1.especie,lombrizTierra1.clase,lombrizTierra1.tipoAlimentacion,lombrizTierra1.grupo);
        lombrizTierra1.cavarSuelo();
    }
}
    

public class Animal{
    public string especie;
    public string grupo;
    public int edad;
    public string genero;
    public string clase;
    public string tipoAlimentacion;
    public string tipoSonido;

    public void alimentar(string tipoAlimentacion){
        if(tipoAlimentacion.Equals("Hervivoro")){
            Console.WriteLine($"Este animal es {tipoAlimentacion} por tanto se alimenta de plantas");
        } else if(tipoAlimentacion.Equals("Omnivoro")){
            Console.WriteLine($"Este animal es {tipoAlimentacion} por tanto se alimenta elementos de origen vegetal como animal");
        } else{
            Console.WriteLine($"Este animal es {tipoAlimentacion} por tanto se alimenta de carne");
        }

    }
    public void hacerSonido(string tipoSonido){
        Console.WriteLine($"Hace un sonido conocico como {tipoSonido}");
    }

    public void mostarInfoAnimal(string especie, string clase, string tipoAlimentacion, string grupo){
        Console.WriteLine($"Este animal es de la especie: {this.especie},");
        Console.WriteLine($"Grupo: {this.grupo},");
        Console.WriteLine($"{this.clase} y {this.tipoAlimentacion}");
        

    }
    
    }

    public class Pato:Animal{

    
        public string tipoPico;
        

        public void patoDomesticado(){
            string respuesta=""; 
            Console.WriteLine("¿Quieres domesticar este Pato?");
            Console.WriteLine("Responda con un si o no");
           respuesta:Console.ReadLine();


        if (respuesta.Equals("si")){
               Console.WriteLine("Este pato esta domesticado");
            } else{
                 Console.WriteLine("Este pato no esta domesticado");
            }

        }

    }

    public class Lombriz:Animal{
        public int canAnillos;

        public void cavarSuelo(){
            string respuesta=""; 
            Console.WriteLine("¿Quieres que la lombriz cave?");
            Console.WriteLine("Responda con un si o no");
           respuesta:Console.ReadLine();
             if (respuesta.Equals("si")){
               Console.WriteLine("La lombriz esta cavando");
            } else{
                 Console.WriteLine("La lombriz esta en reposo");
            }


        }

    }