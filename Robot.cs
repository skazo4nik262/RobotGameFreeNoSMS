// класс робота
internal class Robot
{
    public int X { get; internal set; } //хранение текущих координат
    public int Y { get; internal set; }

    private static Robot instance;  // организовать синглтон
    public static Robot GetInstance()
    {
        if (instance == null)
            instance = new Robot();
        return instance;
    }

}