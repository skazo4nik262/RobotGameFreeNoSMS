//самое начало программы
using System.Diagnostics;
using System.Drawing;

Field field = Field.GetInstance();
Robot robot = Robot.GetInstance();

MainCommander mainCommander = new MainCommander();
Controller controller = new Controller(mainCommander);
controller.StartListner();
if (field.CheckRobotEndGame(robot, field))
{
    robot = Robot.GetInstance();
    field = Field.GetInstance();
    controller.StartListner();
}