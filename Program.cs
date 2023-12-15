//самое начало программы
using System.Diagnostics;
using System.Drawing;

MainCommander mainCommander = new MainCommander();
Controller controller = new Controller(mainCommander);
controller.StartListner();