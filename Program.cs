using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "11999999999", modelo: "Nokia 3310", imei: "1234567890", 64);
nokia.InstalarAplicativo(nomeApp: "Snake");
nokia.Ligar();
Smartphone iphone = new Iphone(numero: "11988888888", modelo: "iPhone 12", imei: "0987654321", 128);
iphone.InstalarAplicativo(nomeApp: "iMessage");
iphone.Ligar();