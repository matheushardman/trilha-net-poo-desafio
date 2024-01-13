using DesafioPOO.Models;

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "9998958899", modelo: "OPA11", imei: "178965342", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "9999948899", modelo: "KA20", imei: "265478139", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");