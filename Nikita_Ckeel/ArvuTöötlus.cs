using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel
{
    internal class ArvuTöötlus
    {
        public static int[] Arvud(int min, int max)
        {

            Random rnd = new Random();

            int N = rnd.Next(-100, 101);
            int M = rnd.Next(-100, 101);

            // Переменные для хранения меньшего и большего числа
            int MIN, MAX;

            // Сравниваем N и M, чтобы определить, какое число меньшее, а какое большее
            if (N < M)
            {
                MIN = N;
                MAX = M;
            }
            else
            {
                MIN = M;
                MAX = N;
            }

            // Вычисляем количество чисел между MIN И MAX
            int length = MIN - MAX + 1;

            // Создаём массив нужного размера для хранения квадратов чисел
            int[] ruudud = new int[length];

            // Заполняем массив квадратами всех чисел от MIN И MAX
            for (int i = 0; i < length; i++)
            {
                int number = MAX + i;         // Текущее число
                ruudud[i] = number * number;    // Квадрат числа
            }

            // Возвращаем массив с квадратами
            return ruudud;
        }
    }
}
