using System;

namespace OOP_FootballHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalKeeper goalkeeper1 = new GoalKeeper { Name = "Пенчо Пенев", Age = 20, Number = 11, Height = 195 };
            Defender defender1 = new Defender { Name = "Тромчо Тромов", Age = 21, Number = 28, Height = 196 };
            Midfield midfielder1 = new Midfield { Name = "Мишо Мишев", Age = 22, Number = 25, Height = 197 };
            Striker striker1 = new Striker { Name = "Роберто Епана", Age = 23, Number = 3, Height = 193 };

            GoalKeeper goalkeeper2 = new GoalKeeper { Name = "Дионисии Денев", Age = 23, Number = 1, Height = 190 };
            Defender defender2 = new Defender { Name = "Андрей Тотев", Age = 22, Number = 4, Height = 197 };
            Midfield midfielder2 = new Midfield { Name = "Данката Денев", Age = 21, Number = 8, Height = 183 };
            Striker striker2 = new Striker { Name = "Джери Спасов", Age = 19, Number = 17, Height = 183 };

            Coach coach1 = new Coach { Name = "Калоян Кочев", Age = 35 };
            Coach coach2 = new Coach { Name = "Бени Бонев", Age = 33 };


        }
    }
}
