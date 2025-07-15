using DesafioPOO.Models;

Console.WriteLine("Smartphone NOKIA");

Smartphone nokia = new Nokia("(85)985605596","Nokia Plus", "N sei oq é", 64);
nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();
nokia.ReceberLigacao();


Console.WriteLine("\n");


Console.WriteLine("Smartphone IPHONE");

Smartphone iphone = new Iphone("(85)987977891", "Iphone 11", "N sei oq é", 128);
iphone.InstalarAplicativo("Telegram");
iphone.Ligar();
iphone.ReceberLigacao();