// класс для рисования самурая
using System.Drawing;

internal class DrawRobotCommand : IRobotCommand
{
    Paint paint = Paint.GetInstance();
    Robot robot = Robot.GetInstance();

    public void Execute()
    {
        paint.Graphics.FillRectangle(Brushes.White,200+ robot.X * 50, 200+robot.Y * 50, 50, 50); 
        paint.Graphics.FillRectangle(Brushes.Red, 200+ robot.X * 50, 200+robot.Y * 50, 50, 50); 
    }
}

