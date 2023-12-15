//самое начало программы
using System.Diagnostics;
using System.Drawing;

Console.WriteLine("Нажмите 'enter' чтобы начать игру в самурая..");
Console.WriteLine("4111211122111221112231122 - пример поля");
Console.ReadLine();

MainCommander mainCommander = new MainCommander();
Controller controller = new Controller(mainCommander);
controller.StartListner();