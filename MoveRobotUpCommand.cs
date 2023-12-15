// класс для ввода данных
internal class MoveRobotUpCommand : IRobotCommand
{
    public void Execute()
    {
        Robot robot = Robot.GetInstance();
        Field field = Field.GetInstance();
        if (robot.Y == 0)
            return;

        int y = robot.Y - 1;
        if (field.Cells[robot.X, y] == 1 || field.Cells[robot.X, y] == 4)
        {
            field.DrawCleanField(robot.X, robot.Y);
            robot.Y = y;
        }
    }
}