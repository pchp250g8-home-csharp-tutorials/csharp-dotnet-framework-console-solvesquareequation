SolveSquareEquation. C# Tutorials. Simple Input/Output. Algorithms. DotNet FrameWork Platform. Console Application. 
A console application in the C# programming language. 
The program does the following:
1. Asks you to enter the coefficients of a quadratic equation that needs to be solved.
2. Displays the equation being solved in linear form on the screen.
3. Checks if the entered coefficients are equal to 0.
4. The following cases are possible:
    1. All coefficients are equal to zero. The phrase "Solution - any number" will be displayed on the screen.
    2. The coefficients "a" and "b" are equal to zero, but "c" is not. In this case, the message "The equation has no solutions" will be displayed.
    3. The coefficient "a" is zero, but "b" and "c" are not. In this case, the solution calculated using the formula "x=-c/b" will be displayed on the screen.
    4. All coefficients are non-zero. Then the quadratic equation is solved:
       1. The discriminant is found using the formula "d=b*b-4*a*c".
       2. The sign of the previously obtained expression is calculated (can be: -1, 0, 1). 1 is added to the value.
       3. This is the number of roots of the quadratic equation.
       4. If the number of roots of a quadratic equation is greater than zero (can be 0, 1 or 2), then
          the program displays solutions to formulas
         "x1=-b-sqrt(d)/(2*a)" and "x2=-b+sqrt(d)/(2*a)". Otherwise, the phrase "the equation has no roots" is displayed.
Developed in the Microsoft Visual Studio integrated environment.



SolveSquareEquation. Занятия по С#. Простой ввод/вывод. Алгоритмы. Платформа DotNet FrameWork. Консольное приложение.
Консольное приложение написанное на языке программирования C#. 
Программа делает следующее:
  1. Просит ввести коэффицееты квадратного уравнения, которое нужно решить.
  2. Выводит на экран запись решаемое уравнение в линейной форме.
  3. Проверяет введённые коэффициенты на равенство 0.
  4. Далее возможны следующие случаи:
       1. Все коэффициенты равны нулю. На экран будет выведена фраза на английском языке "Решение - любое число".
       2. Коэффициенты "a" и "b" равны нулю, а "с" нет. В данном случае будет выдано сообщение "Уравнение не имеет решений".
       3. Коэффициент "a" равен нулю, а "b" и "с" нет. В этом случае на экран будет выведено решение, вычисляемое по формуле "x=-с/b".
       4. Все коэффицинеты не равны нулю. Тогда решается квадратное уравнение:
          1. Находится дискриминант по формуле "d=b*b-4*a*c".
          2. Вычисляется знак выражения, полученного ранее. (можент быть: -1, 0, 1). К значению прибавляется 1.
          3. Это и есть число корней квадратного уравнения.
          4. Если число корней квадратного уравнения больше нуля (может быть 0, 1 или 2), то на экран выводятся решения по фомулам
             "x1=-b-sqrt(d)/(2*a)" и "x2=-b+sqrt(d)/(2*a)". В противном случае выводится фраза "уравнение не имеет корней".
Разработано в интегрированной среде Microsoft Visual Studio.


