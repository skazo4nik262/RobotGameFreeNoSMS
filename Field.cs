// класс поля
using System.Drawing;

internal class Field
{
    private static Field instance;  // тут организовать синглтон

    public static Field GetInstance()
    {
        if (instance == null)
            instance = new Field();
        return instance;
    }
    public int X { get; internal set; }
    public int Y { get; internal set; }

    public int[,] Cells { get; set; }   //хранение ячеек в свойстве Cells

    public void DrawCleanField(int x, int y)
    {
        Paint paint = Paint.GetInstance();
        paint.Graphics.FillRectangle(Brushes.White, 200 + x * 50, 200 + y * 50, 50, 50);
    }

    internal bool CheckRobotEndGame(Robot robot, Field field) // сравнение координат робота с координатами финишной точки
    {
        if (robot.X == field.X && robot.Y == field.Y)
           return true;
        return false;
    }
}

