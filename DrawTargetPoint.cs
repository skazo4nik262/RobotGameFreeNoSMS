using System.Drawing;

internal class DrawTargetPoint : IRobotCommand
{
    public void Execute()
    {
        Paint paint = Paint.GetInstance();
        Field field = Field.GetInstance();

        paint.Graphics.FillRectangle(Brushes.White, 200 + field.X * 50, 200 + field.Y * 50, 50, 50); 
        paint.Graphics.FillRectangle(Brushes.Green, 200 + field.X * 50, 200 + field.Y * 50, 50, 50); 
    }
}