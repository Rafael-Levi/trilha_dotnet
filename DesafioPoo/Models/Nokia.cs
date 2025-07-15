namespace DesafioPOO.Models
{
    public class Nokia(string numero, string modelo, string emei, int memoria) : Smartphone(numero, modelo, emei, memoria)
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no NOKIA");
        }
    }
}