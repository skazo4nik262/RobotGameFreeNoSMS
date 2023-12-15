using System.Collections.Generic;

public class RandomGeneratingOfField
{

    private static RandomGeneratingOfField instance;  // тут организовать синглтон

    public static RandomGeneratingOfField GetInstance()
    {
        if (instance == null)
            instance = new RandomGeneratingOfField();
        return instance;
    }

    Random random = new Random();
    string number = ""; // очень важная штука, удаление которой всё ломает
    int count3 = 0, count4  = 0;

    public string Random()
    {
        for (int i = 0; i < 25; i++)
        {
            int digit = random.Next(1, 5);

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
            else i--;
        }
        
        return number;
    }
}