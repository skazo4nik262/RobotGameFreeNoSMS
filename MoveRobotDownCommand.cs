// класс для ввода данных
internal class MoveRobotDownCommand : IRobotCommand
{
    public void Execute()
    {
        Robot robot = Robot.GetInstance();
        Field field = Field.GetInstance();
        if (robot.Y == 5)
            return;

        int y = robot.Y + 1;
        if (field.Cells[robot.X, y] == 1 || field.Cells[robot.X, y] == 4)
        {
            field.DrawCleanField(robot.X, robot.Y);
            robot.Y = y;
        }
    }
}