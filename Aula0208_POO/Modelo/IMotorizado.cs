namespace Aula0208_POO.Modelo
{
    interface IMotorizado
    {
        int Velocidade { get; set; }
        void Acelerar();
        void Frenar();   
    }
}
