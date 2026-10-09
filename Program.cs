// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     System.Console.WriteLine(letter);

// }
// System.Console.WriteLine(subject.Length);

int[] grades = { 4, 5, 3, 5, 4 };
int total = 0;

foreach (int grade in grades)
{
    System.Console.WriteLine(grade);
    total += grade;
}
System.Console.WriteLine(total / grades.Length);