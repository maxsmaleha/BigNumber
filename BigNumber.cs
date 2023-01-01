using System.Collections.Generic;
using System.Linq;

namespace Interview
{
    /* Задача:
     * Необходимо реализовать класс BigNumber для работы с длинными числами:
     * - конструктор
     * - преобразование в строку
     * - оператор сложения

     * !Нельзя использовать готовые реализации длинных чисел

     * Требования к длинному числу:
     * - целое
     * - положительное
     * - произвольное число разрядов (может быть больше, чем допускает long)
     * Ограничения на строку - параметр конструктора BigNumber:
     * - содержит только цифры
     * - отсутствуют ведущие нули
     * 
     * Пример использования:
     * var a = new BigNumber("175872");
     * var b = new BigNumber("1234567890123456789012345678901234567890");
     * var r = a + b;
     * 
     * Для проверки решения необходимо запустить тесты.
     */

    public class BigNumber
    {
        // лучше хранить в обратном порядке
        private int[] digits;

        public BigNumber(string x)
        {
            digits = Enumerable.Repeat(-1, x.Length + 1).ToArray(); //new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                var chr = x[x.Length - 1 - i];
                digits[i] = int.Parse(chr.ToString());
            }
        }

        public override string ToString()
        {
            var str = "";
            for (int i = 0; i < digits.Length; i++)
            {
                var chr = digits[digits.Length - 1 - i].ToString();
                if (!string.IsNullOrEmpty(chr) && chr != "-1")
                {
                    str += chr;
                }
            }

            return str;
        }

        public static BigNumber operator +(BigNumber a, BigNumber b)
        {
            var aa = a.ToString();
            var bb = b.ToString();

            var max = aa.Length > bb.Length ? aa : bb;

            var list = new List<string>();
            var mem = 0;
            for (int i = 0; i < max.Length; i++)
            {
                var num1 = int.Parse(i >= aa.Length ? "0" : aa[aa.Length - 1 - i].ToString());
                var num2 = int.Parse(i >= bb.Length ? "0" : bb[bb.Length - 1 - i].ToString());
                var sum = num1 + num2 + mem;

                mem = sum / 10;
                list.Add((sum % 10).ToString());
            }

            if (mem != 0)
            {
                list.Add(mem.ToString());
            }

            var str = list.Aggregate("", (acc, cur) => cur + acc);

            return new BigNumber(str);
        }
    }
}