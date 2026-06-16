using System;
using System.Collections.Generic;

// ----- Clase Persona -----

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Utiliza los datos almacenados en el objeto para mostrar una presentación
    public void Presentarse()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}

// ----- Herencia entre clases de animales -----

class Animal
{
    // Permite que las clases hijas definan su propia versión del método
    public virtual void HacerSonido()
    {
        Console.WriteLine("Sonido de animal");
    }
}

class Perro : Animal
{
    // Reemplaza el comportamiento heredado de Animal
    public override void HacerSonido()
    {
        Console.WriteLine("Guau, guau");
    }
}

class Gato : Animal
{
    // Reemplaza el comportamiento heredado de Animal
    public override void HacerSonido()
    {
        Console.WriteLine("Miau");
    }
}

// ----- Encapsulamiento en una cuenta bancaria -----

class CuentaBancaria
{
    // El saldo es privado para evitar modificaciones directas
    private decimal saldo;

    // Suma el monto recibido al saldo actual
    public void Depositar(decimal monto)
    {
        saldo += monto;
    }

    // Devuelve el saldo actual de la cuenta
    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}

// ----- Interfaces y abstracción -----

// Define los métodos que todo vehículo debe implementar
interface IVehiculo
{
    void Encender();
    void Apagar();
}

class Carro : IVehiculo
{
    public void Encender()
    {
        Console.WriteLine("El carro ha sido encendido.");
    }

    public void Apagar()
    {
        Console.WriteLine("El carro ha sido apagado.");
    }
}

class Motocicleta : IVehiculo
{
    public void Encender()
    {
        Console.WriteLine("La motocicleta ha sido encendida.");
    }

    public void Apagar()
    {
        Console.WriteLine("La motocicleta ha sido apagada.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Mostrar información general del grupo
        Console.WriteLine("Bienvenidos Grupo POO");
        Console.WriteLine("Integrantes:");
        Console.WriteLine("Sebastian Jimenez Consoro");
        Console.WriteLine("Abraham Francisco Núñez");

        // Declaración de variables de distintos tipos de datos
        int cantidadIntegrantes = 2;
        string nombreGrupo = "Grupo POO";
        double calificacionEsperada = 100.0;
        bool proyectoCompletado = true;

        Console.WriteLine("\n========== EJERCICIO 1: VARIABLES ==========");
        Console.WriteLine($"\nGrupo: {nombreGrupo}");
        Console.WriteLine($"Cantidad de integrantes: {cantidadIntegrantes}");
        Console.WriteLine($"Calificación esperada: {calificacionEsperada}");
        Console.WriteLine($"Proyecto completado: {proyectoCompletado}");

        Console.WriteLine("\n========== EJERCICIO 2: ESTRUCTURAS DE CONTROL ==========");

        // Solicita un número al usuario
        Console.Write("\nIngrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        // Si el residuo es 0, el número es divisible entre 2
        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }

        Console.WriteLine("\nNúmeros del 1 al 10:");

        // Imprime los números del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n========== EJERCICIO 3: CLASES Y OBJETOS ==========");

        // Creación de objetos a partir de la clase Persona
        Persona persona1 = new Persona
        {
            Nombre = "Sebastian",
            Edad = 20
        };

        Persona persona2 = new Persona
        {
            Nombre = "Juan",
            Edad = 21
        };

        persona1.Presentarse();
        persona2.Presentarse();
        
        Console.WriteLine("\n========== EJERCICIO 4: HERENCIA ==========");

        // Crear objetos de las clases derivadas
        Perro perro = new Perro();
        Gato gato = new Gato();

        perro.HacerSonido();
        gato.HacerSonido();

        Console.WriteLine("\n========== EJERCICIO 5: POLIMORFISMO ==========");

        // La lista almacena distintos tipos de animales
        List<Animal> animales = new List<Animal>();

        // Agrega objetos de diferentes clases a la misma colección
        animales.Add(new Perro());
        animales.Add(new Gato());

        // Recorre la lista y ejecuta el método correspondiente a cada objeto
        foreach (Animal animal in animales)
        {
            animal.HacerSonido();
        }

        Console.WriteLine("\n========== EJERCICIO 6: ENCAPSULAMIENTO ==========");

        CuentaBancaria cuenta = new CuentaBancaria();

        // Deposita dinero en la cuenta
        cuenta.Depositar(1000);

        Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo()}");

        Console.WriteLine("\n========== EJERCICIO 7: INTERFACES Y ABSTRACCIÓN ==========");

        Carro carro = new Carro();
        Motocicleta motocicleta = new Motocicleta();

        carro.Encender();
        carro.Apagar();

        motocicleta.Encender();
        motocicleta.Apagar();
    }
}

