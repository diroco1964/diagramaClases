using System;
public class Program
{
    public static void Main(string[] args)
    {
        Libro LaCosa=new Libro();
        LaCosa.idLibro = "44er";
        LaCosa.titulo="LaCosa";
        LaCosa.autor="Stephen King";
        LaCosa.año=1976;
        LaCosa.genero="terror";
        Biblioteca bibliotecaP= new Biblioteca();
        bibliotecaP.nombre="Alegria";
        bibliotecaP.agregarLibro(LaCosa);
        LaCosa.mostrarInfoLibro(LaCosa.idLibro,LaCosa.titulo,LaCosa.autor,LaCosa.año,LaCosa.genero);
        bibliotecaP.prestarLibro(LaCosa.idLibro);

    }
}


public class Libro{
    public string idLibro;
    public string titulo;
    public string autor;
    public int año;
    public string genero;

    public void mostrarInfoLibro(string idLibro, string titulo, string autor, int año,string genero){
        Console.WriteLine($"Titulo: {this.titulo}");
        Console.WriteLine($"Autor: {this.autor}");
        Console.WriteLine($"Año: {this.año}");
        Console.WriteLine($"Genero: {this.genero}");
    }

    public void abrir(){
        Console.WriteLine("Has abierto el libro");
    }
      public void cerrar(string titulo){
        Console.WriteLine("Has cerrado el libro");
    }

     public void leer(){
        Console.WriteLine("Estas Leyendo el libro");
    }

}

public class Biblioteca(){
    public string nombre;
    public string direccion;
    public string horaApertura;
    public string horaCierre;
    public string idLibro;
    public Libro[] inventario = new Libro[4];  
    public int indiceActual = 0;

   public void agregarLibro(Libro libro)
    {
        if (indiceActual < inventario.Length)  // Verificar si hay espacio en el arreglo
        {
            inventario[indiceActual] = libro;  // Agregar el libro en el siguiente espacio disponible
            indiceActual++;  // Aumentar el contador de libros agregados
            Console.WriteLine($"El libro '{libro.titulo}' agregado al inventario.");
        }
        else
        {
            Console.WriteLine("No hay espacio para más libros en la biblioteca.");
        }
    }
    

     public void prestarLibro(string idLibro)
    {
        bool libroEncontrado = false;

        // Buscar el libro por id en el inventario
        foreach (var libro in inventario)
        {
            if (libro != null && libro.idLibro == idLibro)  // Verificar si el libro existe y coincide con el ID
            {
                libroEncontrado = true;
                Console.WriteLine($"El libro '{libro.titulo}' ha sido prestado.");
                break;  // Salir del ciclo una vez que el libro sea encontrado
            }
        }

        if (!libroEncontrado)
        {
            Console.WriteLine("Este libro no está en nuestro inventario.");
        }
    }
}




