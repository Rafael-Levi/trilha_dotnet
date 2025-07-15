namespace DesafioPOO.Models
{
    public class Iphone(string numero, string modelo, string emei, int memoria) : Smartphone(numero, modelo, emei, memoria)
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no IPHONE");
        }
    }
}