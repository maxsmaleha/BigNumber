﻿using System;

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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public static BigNumber operator +(BigNumber a, BigNumber b)
        {
            throw new NotImplementedException();
        }
    }
}