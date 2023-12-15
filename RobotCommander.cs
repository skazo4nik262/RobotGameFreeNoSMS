// класс для ввода данных
internal class RobotCommander : ICommander
{
    Queue<IRobotCommand> robotCommands = new Queue<IRobotCommand>();

    public RobotCommander()
    {
        robotCommands.Enqueue(new DrawRobotCommand());
        robotCommands.Enqueue(new DrawTargetPoint());
        Thread thread = new Thread(RunCommand);
        thread.Start();
    }

    public void Execute(int[] arrayOfDoings)
    {
        for (int i = 0; i < arrayOfDoings.Length; i++)
        {

            switch (arrayOfDoings[i])
            {
                case 1:
                    MoveRobotUpCommand up = new MoveRobotUpCommand(); robotCommands.Enqueue(up); break;
                case 2:
                    MoveRobotDownCommand down = new MoveRobotDownCommand(); robotCommands.Enqueue(down); break;
                case 3:
                    MoveRobotLeftCommand left = new MoveRobotLeftCommand(); robotCommands.Enqueue(left); break;
                case 4:
                    MoveRobotRightCommand right = new MoveRobotRightCommand(); robotCommands.Enqueue(right); break;
            }
            robotCommands.Enqueue(new DrawRobotCommand());
        }
    }

    void RunCommand(object obj)
    {
        while (!Field.GetInstance().CheckRobotEndGame(Robot.GetInstance(), Field.GetInstance()))
        {
            Thread.Sleep(500);
            if (robotCommands.Count > 0)
            {
                var command = robotCommands.Dequeue();
                command.Execute();
            }
        }
        Console.Title = "Win";
        Console.WriteLine("Win");
    }
}

