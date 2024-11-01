using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int score = 0;
        int targetPosition;

        Console.WriteLine("Добро пожаловать в игру 'Стрельба'!");
        Console.WriteLine("Вам нужно стрелять по целям. У вас 5 попыток.");

        for (int i = 0; i < 5; i++)
        {
            // Генерируем случайную позицию цели
            targetPosition = random.Next(1, 11);
            Console.WriteLine($"\nЦель появилась на позиции: {targetPosition}");
            Console.Write("Введите вашу стрельбу (позиция от 1 до 10): ");

            // Чтение ввода игрока
            if (int.TryParse(Console.ReadLine(), out int shot))
            {
                if (shot == targetPosition)
                {
                    Console.WriteLine("Попадание! Вы получили 1 очко.");
                    score++;
                }
                else
                {
                    Console.WriteLine("Промах!");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите число от 1 до 10.");
                i--; // Уменьшаем счетчик попыток, чтобы не терять попытку
            }
        }

        Console.WriteLine($"\nИгра окончена! Ваш счет: {score}");
    }
}
