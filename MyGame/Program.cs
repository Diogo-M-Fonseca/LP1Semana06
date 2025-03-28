using System;
using System.Data;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy[] enemies = new Enemy[int.Parse(args[0])];

            for (int numOfEnemies = 0; numOfEnemies < int.Parse(args[0]); numOfEnemies++)
            {
            Console.Write($"Nome do inimigo {numOfEnemies + 1}: ");
            enemies[numOfEnemies] = new Enemy(Console.ReadLine());
            }

            foreach (Enemy newEnemy in enemies)
             {
                Console.WriteLine(newEnemy.GetName(), newEnemy.GetHealth(), newEnemy.GetShield());
 
             }
        }
    }
}