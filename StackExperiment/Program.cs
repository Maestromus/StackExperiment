
using StackExperiment;

public class ReadFromFile : ExperClass
{
    static void Main(string[] args)
    {


        // Считываем содержимое файла
        string[] lines = File.ReadAllLines(@"D:\readText\Stack.txt");


        // Разбиваем содержимое файла на массив строк
        // string[] lines = text.Split('\n');


        // Проходим по всем строкам файла
        foreach (string line in lines)
        {
            // Выполняем математическую операцию над примером и выводим результат в консоль
            Console.WriteLine(line + " = " + CheckBrackets(line));
        }

    }
}
