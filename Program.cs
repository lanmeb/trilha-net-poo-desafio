using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "123", modelo: "modelo1", imei: "2222", memoria:65);
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");

Console.WriteLine("");


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "13", modelo: "modelo21", imei: "22242", memoria:45);
nokia.Ligar();
nokia.InstalarAplicativo("Teams");