using System;

namespace RPS
{
	public class Player
	{
		public string name;
		public variants element;
		
		public Player()  //Задаем конструктор случайного значения
        {
			Random rnd = new Random();     //Создание объекта для генерации чисел
			int value = rnd.Next(0, 2);     //Получаем индекс значения варианта (в диапазоне от 0 до 2)
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
			if (bot.element == alex.element)			//Проверка на ничью
            {
				return "Ничья";

			}
			string winner;								//Переменная winner в которой будет победитель 
			if (bot.element == variants.scissors)		//Поиск победителя
            {
				winner = bot.name;
            }
			else
            {
				winner = alex.name;
            }
											
											
            return "Победил игрок с именем: " +winner;
        }
    }
}
