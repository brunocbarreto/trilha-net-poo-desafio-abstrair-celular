using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia1 = new Nokia("4567689", "Modelo2", "333333335", 32);
nokia1.InstalarAplicativo("Instagram");
nokia1.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone1 = new Iphone("57495", "Modelo3", "333333334", 64);
iphone1.InstalarAplicativo("Spotify");
iphone1.ReceberLigacao();




