using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var eagle = new Bird();
            eagle.CanFly = true;
            eagle.HasClaws = true;
            eagle.HasFeathers = true;
            eagle.HasWings = true;

            Console.WriteLine($"Write true or false for each of the following statements. \n" +
                              $"An eagle can fly: {eagle.CanFly}\n" +
                              $"An eagle has claws: {eagle.HasClaws}\n" +
                              $"An eagle has feathers: {eagle.HasFeathers}\n" +
                              $"An eagle has wings: {eagle.HasWings}\n");

            var snake = new Reptile()
            {
                HasScales = true,
                HasTail = true,
                IsColdBlooded = true,
                LaysEggs = true
            };
            Console.WriteLine($"HasScales = {snake.HasScales}\n" +
                              $"HasTail = {snake.HasTail}\n" +
                              $"IsColdBlooded = {snake.IsColdBlooded}\n" +
                              $"LaysEggs = {snake.LaysEggs}\n");
        }
    }
}
