using DesafioPOO.Models;

Nokia meuNokia = new Nokia("1197083-9569","Nokia trends 2024","78695844220",64);
Console.WriteLine($"Numero  do Nokia:{meuNokia.Numero}");
meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Iphone meuIphone = new Iphone("0119709839569","Iphone 18","784515646556",128);
Console.WriteLine($"Numero do Iphone {meuIphone.Numero}");
meuIphone.Ligar();
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("Intagram");
