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
    int samurai = 0;
    int field = 0;
    int walls = 0;
    string[] result = new string[25];

    public string[] Random()
    {
        for (int i = 0; i < 25; i++)
        {
            result[i] = random.Next(1, 5).ToString();

            switch (result[i])
            {
                case "2":
                    walls++;
                    break;
                case "3":
                    samurai++;
                    break;
                case "4":
                    field++;
                    break;
            }

        }
        return result;
    }
}