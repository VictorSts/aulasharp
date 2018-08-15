using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelo
{
        class Moto : Veículo, IMotorizado
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
                Velocidade -= 7;
            }
        }
}
