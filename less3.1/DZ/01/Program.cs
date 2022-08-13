// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


bool IsPalindrome(string s)
{
    for (int i = 0; i < s.Length / 2; ++i)
        if (s[i] != s[s.Length - 1 - i]) return false;
    return true;
}


Console.WriteLine("Введите число: ");
string num = Console.ReadLine();


Console.WriteLine(IsPalindrome(num) == true ? "Число является полиндромам" : "Число не является полиндромом");
