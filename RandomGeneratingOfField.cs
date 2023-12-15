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
    string[] result = new string[25]; // массив для поля (очень важная штука, удаление которой всё ломает)

    Dictionary<string, int> genIskl = new Dictionary<string, int>();

    public string[] Random()
    {
        genIskl.Add("samurai", 1);
        genIskl.Add("walls", 4);
        genIskl.Add("finish", 1);

        for (int i = 0; i < 25; i++)
        {
            result[i] = random.Next(0,5).ToString();
            switch (result[i])
            {
                case "3":
                    genIskl["samurai"]--;
                break;

                case "2":
                    genIskl["walls"]--;
                break;

                case "4":
                    genIskl["finish"]--;
                break;
            }
        }

        return result;
    }
}