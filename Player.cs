using Microsoft.VisualBasic.CompilerServices;
using System;

namespace RPS
{
	public class Player
	{
		public string name;
		public variants element; 
					
		public Player()						//Задаем конструктор случайного значения
        {
			Random rnd = new Random();      //Создание объекта для генерации чисел
			int value = rnd.Next(0, 2);     //Получаем индекс значения варианта (в диапазоне от 0 до 2)
			element = (variants)value;
			name = "bot";
        }
		public Player(variants element, string name)  //Задаем конструктор который принимает вариант
		{
			this.element = element;
			this.name = name;
			
		}

		private string getVariantName(variants variant)     //Создаем метод для преобразования значений на русский язык
        {
			switch (variant)								//Переводим значения на русский язык для вывода пользователю
            {
				case variants.paper:
					return "бумага";
				case variants.rock:
					return "камень";
				case variants.scissors:
					return "ножницы";
				default:
					return "";

            }
				 
        }

        public string whoWins(Player bot, Player gamer)		//Метод вывод победителя
        {
			if (bot.element == gamer.element)				//Проверка на ничью
            {
				return $"У противника выпал {getVariantName(bot.element)} Ничья";

			}
			string winner;																	 //Переменная winner в которой будет победитель 
			if ( (bot.element == variants.paper && (gamer.element == variants.rock)) ||		 //Поиск победителя если нет ничьи
				(bot.element == variants.rock && (gamer.element == variants.scissors)) ||
				(bot.element == variants.scissors && (gamer.element == variants.paper)) )			
            {
				winner = bot.name;
			}
			else 
			{
				winner = gamer.name;
			}
			
			return $"У противника выпал {getVariantName(bot.element)} Победил игрок с именем: " +winner;
        }
    }
}
