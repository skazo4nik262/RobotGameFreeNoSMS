﻿// класс для ввода данных
internal class MoveRobotRightCommand : IRobotCommand
{
    public void Execute()
    {
        Robot robot = Robot.GetInstance();
        Field field = Field.GetInstance();
        if (robot.X == 5)
            return;

        int x = robot.X + 1;
        if (field.Cells[x, robot.Y] == 1 || field.Cells[x, robot.Y] == 4)
        {
            field.DrawCleanField(robot.X, robot.Y);
            robot.X = x;
        }
    }
}