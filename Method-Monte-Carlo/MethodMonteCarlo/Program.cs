using System.Threading.Channels;

namespace MethodMonteCarlo;

class Program
{
    // Оценка числа π
    static void Main(string[] args)
    {
        int totalPoints = 1000000; // Количество случайных точек
        int pointsInsideCircle = 0; // Количество точек внутри круга
        
        Random random = new Random();
        
        for (int i = 0; i < totalPoints; i++)
        {
            // Генерируем случайные координаты (x, y)
            double x = random.NextDouble();
            double y = random.NextDouble();
            
            // Проверяем, попадает ли точка в круг
            if (x * x + y * y <= 1)
            {
                pointsInsideCircle++;
            }
        }
        
        // Оценка числа π
        double piEstimate = 4.0 * pointsInsideCircle / totalPoints;
        Console.WriteLine($"Оценка числа π: {piEstimate}");
    }
}

