using System;

namespace Aula0208_POO.Modelo
{
    class Moto : Veiculo, IMotorizado
    { 
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("MOTO: Acelerado pela manopla.");
            Velocidade += 10;
        }

        public void Frenar()
        {
            Console.WriteLine("MOTO: Freando pelo pedal e manopla.");
            Velocidade += 7;
        }
    }
}
