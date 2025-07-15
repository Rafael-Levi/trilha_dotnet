namespace DesafioPOO.Models
{
    public abstract class Smartphone(string numero, string modelo, string emei, int memoria)
    {
        public string Numero { get; set; } = numero;

        public string Modelo { get; set; } = modelo;
        public string EMEI { get; set; } = emei;

        public int Memoria { get; set; } = memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}