using System;
using System.Collections.Generic;

// =========================
// CLASE PERSONA
// =========================
class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}

// =========================
// HERENCIA Y POLIMORFISMO
// =========================
class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("Sonido de animal");
    }
}

class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Guau, guau");
    }
}

class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Miau");
    }
}

// =========================
// ENCAPSULAMIENTO
// =========================
class CuentaBancaria
{
    private decimal saldo;

    public void Depositar(decimal monto)
    {
        saldo += monto;
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}

// =========================
// INTERFAZ
// =========================
interface IVehiculo
{
    void Encender();
    void Apagar();
}

class Carro : IVehiculo
{
    public void Encender()
    {
        Console.WriteLine("El carro ha encendido.");
    }

    public void Apagar()
    {
        Console.WriteLine("El carro ha apagado.");
    }
}

class Motocicleta : IVehiculo
{
    public void Encender()
    {
        Console.WriteLine("La motocicleta ha encendido.");
    }

    public void Apagar()
    {
        Console.WriteLine("La motocicleta ha apagado.");
    }
}

// =========================
// PROGRAMA PRINCIPAL
// =========================
class Program
{
    static void Main()
    {
        // ====================================
        // 1. SINTAXIS BÁSICA Y VARIABLES
        // ====================================
        Console.WriteLine("Bienvenidos al proyecto del Grupo XYZ");

        int edad = 20;
        string nombre = "Sebastian";
        double promedio = 95.5;
        bool aprobado = true;

        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Promedio: {promedio}");
        Console.WriteLine($"Aprobado: {aprobado}");

        // ====================================
        // 2. ESTRUCTURAS DE CONTROL
        // ====================================
        Console.Write("\nIngrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }

        Console.WriteLine("\nNúmeros del 1 al 10:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // ====================================
        // 3. CLASES Y OBJETOS
        // ====================================
        Console.WriteLine("\n--- Personas ---");

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

        Persona persona3 = new Persona
        {
            Nombre = "Maria",
            Edad = 22
        };

        persona1.Presentarse();
        persona2.Presentarse();
        persona3.Presentarse();

        // ====================================
        // 4. HERENCIA
        // ====================================
        Console.WriteLine("\n--- Herencia ---");

        Perro perro = new Perro();
        Gato gato = new Gato();

        perro.HacerSonido();
        gato.HacerSonido();

        // ====================================
        // 5. POLIMORFISMO
        // ====================================
        Console.WriteLine("\n--- Polimorfismo ---");

        List<Animal> animales = new List<Animal>();

        animales.Add(perro);
        animales.Add(gato);

        foreach (Animal animal in animales)
        {
            animal.HacerSonido();
        }

        // ====================================
        // 6. ENCAPSULAMIENTO
        // ====================================
        Console.WriteLine("\n--- Cuenta Bancaria ---");

        CuentaBancaria cuenta = new CuentaBancaria();

        cuenta.Depositar(1000);

        Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo()}");

        // ====================================
        // 7. INTERFACES Y ABSTRACCIÓN
        // ====================================
        Console.WriteLine("\n--- Vehículos ---");

        Carro carro = new Carro();
        Motocicleta moto = new Motocicleta();

        carro.Encender();
        carro.Apagar();

        moto.Encender();
        moto.Apagar();

        Console.WriteLine("\nFin del programa.");
    }
}




