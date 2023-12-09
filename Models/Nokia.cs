namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(numero,modelo,imei,memoria) : base(numero,modelo,imei,memoria)
        { }

        public override InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo "{nomeApp}" no Nokia");
        }
    }
}