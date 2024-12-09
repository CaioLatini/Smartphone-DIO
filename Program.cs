using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone



// Testando o Nokia
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

// Testando o iPhone
Smartphone iphone = new Iphone("987654321", "iPhone 14", "987654321098765", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
