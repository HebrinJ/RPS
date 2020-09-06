using System;

namespace RPS
{
	public class Player
	{
		public string name;
		public variants element;
		
		public Player()  //Задаем конструктор случайного значения
        {
			//Создание объекта для генерации чисел
			Random rnd = new Random();

			//Получить случайное число (в диапазоне от 0 до 2)
			int value = rnd.Next(0, 2);
			element = (variants)value;
			name = "bot";
        }
		public Player(variants element, string name)  //Задаем конструктор который принимает вариант
		{
			this.element = element;
			this.name = name;
			
		}


        public string whoWins(Player bot, Player alex) //Функция вывод победителя
        {
			if (bot.element == alex.element)
            {
				return "Ничья";

			}
			string winner;
			if (bot.element == variants.scissors)
            {
				winner = bot.name;
            }
			else
            {
				winner = alex.name;
            }
											//Логика определения победителя
											//Переменная winner в которой победитель 
            return "Победил: " +winner;
        }
    }
}
