using Aula0208_POO.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO
{
    class Program
    {
            static void Main(string[] args)
            {
                Carro car = new Carro();
                car.Modelo = "Ferrari";
                car.Acelerar();
                ExecutaTesteMotor(car);

                Console.WriteLine("\n");

                Moto moto = new Moto();
                moto.Acelerar();
                ExecutaTesteMotor(moto);

                Console.WriteLine("\n");

                Barco barco = new Barco();
                barco.Acelerar();
                ExecutaTesteMotor(barco);

                Console.ReadKey();
            }

            static void ExecutaTesteMotor(IMotorizado vec)
            {
                Console.WriteLine("Velocidade atual: " + vec.Velocidade);
                vec.Acelerar();
                vec.Acelerar();
                vec.Acelerar();
                Console.WriteLine("Velocidade atual: " + vec.Velocidade);
                vec.Frenar();
                vec.Frenar();
                Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            }
        
    }
}
