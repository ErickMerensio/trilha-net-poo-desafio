﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("123456","Modelo 1","1111111111",64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("4987", "Modelo 2", "2222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");