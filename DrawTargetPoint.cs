using System.Drawing;

internal class DrawTargetPoint : IRobotCommand
{
    public void Execute()
    {
        Paint paint = Paint.GetInstance();
        Field field = Field.GetInstance();

        paint.Graphics.FillRectangle(Brushes.White, 200 + field.X * 50, 200 + field.Y * 50, 50, 50); //рисование бэкграунда цели самурая по координатам (белый цвет)
        paint.Graphics.FillEllipse(Brushes.Green, 200 + field.X * 50, 200 + field.Y * 50, 50, 50); //рисование цели самурая по координатам (зеленый цвет)
    }
}