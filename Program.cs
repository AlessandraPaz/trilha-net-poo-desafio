using DesafioPOO.Models; // Certifique-se de que este 'using' está no seu arquivo Program.cs

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        // Instanciando um objeto Nokia
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Smartphone nokia = new Nokia(numero: "1234-5678", modelo: "G20", imei: "111111111", memoria: 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        Console.WriteLine($"Número: {nokia.Numero}, Modelo: {nokia.Modelo}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}GB");

        Console.WriteLine("\n-----------------------------------\n");

        Console.WriteLine("Smartphone iPhone:");
        // Instanciando um objeto Iphone
        Smartphone iphone = new Iphone(numero: "9876-5432", modelo: "14 Pro Max", imei: "222222222", memoria: 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
        Console.WriteLine($"Número: {iphone.Numero}, Modelo: {iphone.Modelo}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}GB");
    }
}
