using DesafioPOO.Models;
Iphone iphone14 = new Iphone("11-96735-8581","Iphone 14 Pro Max", "123456789123456", 256);
Nokia nokiac21 = new Nokia("11-97386-8432", "Nokia C21 Plus", "111111111111111", 128);

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone 14 Pro Max:");
Console.WriteLine("");
iphone14.ReceberLigacao();
iphone14.Ligar();
iphone14.InstalarAplicativo("Clash Royale");

Console.WriteLine("");

Console.WriteLine("Smartphone Nokia C21 Plus:");
Console.WriteLine("");
nokiac21.ReceberLigacao();
nokiac21.Ligar();
nokiac21.InstalarAplicativo("Banana Kong");


