// класс для ввода данных
internal class Controller
{
    private MainCommander mainCommander;
    Robot robot = Robot.GetInstance();
    Field field = Field.GetInstance();

    public Controller(MainCommander mainCommander)
    {
        this.mainCommander = mainCommander;
        mainCommander.SetInterpretator(new FieldCommander());
    }

    internal void StartListner()
    {
        Console.WriteLine("2 - непреадолимое для самурая препятствие, 1 - возможность для достижения цели самурая , 3 - самурай, 4 - цель жизни самурая");
        Console.WriteLine("Введите 25 символов для определения поля битвы самурая");
        string firstCommands = Console.ReadLine();  //внесение данных о поле в одне строку 25 символов

        int[] value = new int[25]; //массив куда поместится поле, которое станет двухмерным в будущем
        for(int i = 0; i < 25; i++)
            value[i] = int.Parse(firstCommands[i].ToString());

        mainCommander.Execute(value);   // первый запрос на 25 символов (рисование поля) передается mainCommander в метод Execute

        mainCommander.SetInterpretator(new RobotCommander());  // смена интерпретатора у mainCommander на RobotCommander

        while ((robot.X != field.X) || (robot.Y != field.Y)) // остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)
            mainCommander.Execute(Console.ReadLine().Select(s=>int.Parse(s.ToString())).ToArray());
    }
}
