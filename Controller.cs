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

        Random random = new Random();
        string number = "";
        int count3 = 0;
        int count4 = 0;

        for (int i = 0; i < 25; i++)
        {
            int digit = random.Next(1, 5); // Генерация случайной цифры от 1 до 4

            if (digit == 3 && count3 < 1)
            {
                number += digit;
                count3++;
            }
            else if (digit == 4 && count4 < 1)
            {
                number += digit;
                count4++;
            }
            else if (digit != 3 && digit != 4)
            {
                number += digit;
            }
            else
            {
                i--; // Если условия для 3 или 4 не выполнились, повторяем генерацию
            }
        }

Console.WriteLine(number);

        Console.WriteLine("1 - свободная ячейка, 2 - стена, 3 - старт робота, 4 - целевая точка");
        string firstCommands = number;

        int[] value = new int[25];
        for(int i = 0; i < 25; i++)
            value[i] = int.Parse(firstCommands[i].ToString());

        mainCommander.Execute(value);   // первый запрос на 25 символов (рисование поля) передается в mainCommander в метод Execute

        mainCommander.SetInterpretator(new RobotCommander());  // смена интерпретатора у mainCommander на RobotCommander

        Console.WriteLine("1 - вверх, 2 - вниз, 3 - влево, 4 - вправо");
        while (!field.CheckRobotEndGame(robot, field)) // остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)
        {
            mainCommander.Execute(Console.ReadLine().Select(s=>int.Parse(s.ToString())).ToArray());
            
        }
    }
}
