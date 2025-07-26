using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");
    }
}
