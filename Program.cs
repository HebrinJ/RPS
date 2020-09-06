using System;



namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя:");         //Запрашиваем имя пользователя
            string inputName = Console.ReadLine();
            
            while (true)                                    //Запускаем цикл для повторной игры
            {

                //Предлагаем сыграть и получаем значение от пользователя
                Console.WriteLine($"Привет {inputName}. Сыграем?! Введите один из вариантов (камень, ножницы или бумага) или выход");
                string inputEl = Console.ReadLine();
                variants playerVariant;
                //Проверяем совпадает ли введенное значение с заданными и присваиваем в случае успеха
                if (inputEl == "бумага")
                {
                    playerVariant = variants.paper;
                }
                else if (inputEl == "камень")
                {
                    playerVariant = variants.rock;
                }
                else if (inputEl == "ножницы")
                {
                    playerVariant = variants.scissors;
                }
                else if (inputEl == "выход")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверное значение");
                    break;
                }
                //создаем объекты игрока и бота
                Player gamer = new Player(playerVariant, inputName);
                Player bot = new Player();


                Console.WriteLine(bot.whoWins(bot, gamer));            //определяем победителя
                Console.WriteLine("Хочешь сыграть ещё? (да/нет)");      //предлагаем сыграть ещё раз
                string playAgain = Console.ReadLine();
                if (playAgain != "да")                                  //Прерываем цикл если пользователь отказывается
                {
                    break;
                }


            }
        }
    }
}
