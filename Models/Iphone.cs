namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(numero, modelo, imei, memoria) : base(numero, modelo, imei, memoria)
        { }

        public override InstalarAplicativo(string nomeApp)
        {
            console.WriteLine($"Instalando o aplicado "{nomeApp}" no iPhone");
        }
    }
}