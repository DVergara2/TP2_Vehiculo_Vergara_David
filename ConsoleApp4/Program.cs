using System;

namespace vehiculos
{
    class Program
    {
        class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }

            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Vehiculo vehi = new Vehiculo("Toyota", "Corola", 2020);
            vehi.MostrarInformacion();
        }
    }
}