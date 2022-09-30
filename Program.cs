using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando smartphone nokia");
Smartphone nokia = new Nokia("99999-1111", "1100", "12345", 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Bora Car");

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Testando smartphone Iphone");
Smartphone iphone = new Iphone("99999-2222", "14 Pro Max", "67890", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iFood");
