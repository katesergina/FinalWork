# Итоговая проверочная работа

## Задача

- Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


### *Описание решения задачи*

- Объявляется два массива: первый массив и вторый такой же длины. 
- Потом добавляется метод, в котором есть цикл соразмерный длине массива, внутри цикла проверка условия ( <=3 (длина меньше либо равна 3 символа)), если условие выполняется, то элемент первого массива заносится в count элемент второго массива. 
-  После присвоения переменная count увеличивается на 1 и возвращается к циклу, в котором i увеличивается на 1. И так проверяется до конца.
