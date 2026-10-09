// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     System.Console.WriteLine(letter);

// }
// System.Console.WriteLine(subject.Length);

// int[] grades = { 4, 5, 3, 5, 4 };
// int total = 0;

// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
//     total += grade;
// }
// System.Console.WriteLine(total / grades.Length);

// string[] students = { "Аня", "Ярослав", "Вика" };
// int total = 0;

// foreach (string student in students)
// {
//     total += 1;
//     System.Console.WriteLine($"{total}.{student}");
// }


// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] += 5;
//     System.Console.WriteLine(points[i]);
// }

// string[] students = { "Аня", "Ярослав", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     System.Console.WriteLine($"{number}. {student}");
//     number++;
// }


// Console.WriteLine();
// Console.WriteLine("Самостоятельное задание под буквой A");

// int[] nums = { 5, 55, 12, 42, 3 };
// int total = 0;

// foreach (int num in nums)
// {
//     System.Console.WriteLine(num);
//     total += num;
// }
// System.Console.WriteLine($"сумма данных чисел: {total}");


// Console.WriteLine();
// Console.WriteLine("Самостоятельное задание под буквой Б");

// string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// foreach (string day in days)
// {
//     System.Console.WriteLine(day + "!");
// }


// using System.Data;

// System.Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     System.Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// System.Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// using System.Collections;
// using System.Numerics;

// Console.WriteLine();
// System.Console.WriteLine("Индивидуальный вариант задание 4");

// int[] chisla = { 542, 521, 73, 421, 2556, 34 };
// int total = 0;
// int twototal = 0;

// foreach (int chislo in chisla)
// {
//     total += chislo;
//     switch (chislo)
//     {
//         case > 400:
//           twototal += chislo;
//             break;
//         default:
//             break;
//     }
// }
// System.Console.WriteLine($"общая сумма всех цен: {total}");
// System.Console.WriteLine($"сумма цен больше 400: {twototal}");


System.Console.WriteLine();
System.Console.WriteLine("Индивидуальный вариант задание 9");

int[] chisla = { 2, 5, 6, 754, 41 };

for (int i = 0; i < chisla.Length; i++)
{
    chisla[i] += 1;
    System.Console.WriteLine(chisla[i]);
}


