using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("11223","X","321654",4);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("\n ------------------ \n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("11224","teste","321654",4);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Shein");