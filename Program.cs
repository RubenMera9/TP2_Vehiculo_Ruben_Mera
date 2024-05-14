using System;

namespace vehiculos
{
    class Program
    {
        class Vehiculo
        {
            private string _Marca;
            public string Marca
            {
                get { return _Marca; }
                set { _Marca = value; }
            }
            private string _Modelo;
            public string Modelo
            {
                get { return _Modelo; }
                set { _Modelo = value; }
            }
            private int _Año;
            public int Año
            {
                get { return _Año; }
                set { _Año = value; }
            }

            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAño: {Año}");
            }
        }

        class bicicleta : Vehiculo
        {
            private int _Numeromarchas;
            public int Numeromarchas
            {
                get { return _Numeromarchas; }
                set { _Numeromarchas = value; }
            }
            public bicicleta(string marca, string modelo, int año, int numeromarcha) : base(marca, modelo, año)
            {
                Numeromarchas = numeromarcha;
            }
            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Bicicleta \nMarchas: {Numeromarchas}");
            }
        }

        class Motocicleta : Vehiculo
        {
            public Motocicleta(string marca, string modelo, int año) : base(marca, modelo, año)
            {
            }
            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Motocicleta");
            }
        }

        class Camion : Vehiculo
        {
            private double _CapacidadCarga;
            public double CapacidadCarga
            {
                get { return _CapacidadCarga; }
                set { _CapacidadCarga = value; }
            }
            public Camion(string marca, string modelo, int año, double capacidadCarga) : base(marca, modelo, año)
            {
                CapacidadCarga = capacidadCarga;
            }
            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Camión \nCapacidad de carga (toneladas): {CapacidadCarga}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------VEHICULOS--------");
            Vehiculo vehi = new Vehiculo("Toyota", "Corolla", 2020);
            Vehiculo vehi2 = new Vehiculo("Chevrolet", "Camaro", 2022);
            vehi.MostrarInformacion();
            Console.WriteLine("-----------------");
            vehi2.MostrarInformacion();

            bicicleta bic = new bicicleta("BMX", "Modelo X", 2023, 5);
            Console.WriteLine("-----------------");
            bic.MostrarInformacion();

            Motocicleta moto = new Motocicleta("Honda", "CBR", 2023);
            Console.WriteLine("-----------------");
            moto.MostrarInformacion();

            Camion cam = new Camion("Volvo", "FH16", 2024, 40);
            Console.WriteLine("-----------------");
            cam.MostrarInformacion();
        }
    }
}
