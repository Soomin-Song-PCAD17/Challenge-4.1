/// 4.1 If number contains 3
/// Write a method that checks if given number (positive integer)
/// contains digit 3. Do not convert number to other type. Do not
/// use built-in functions like Contains(), StartsWith(), etc.
/// 

#region Test Cases
CheckIf3IsInInteger(3);
CheckIf3IsInInteger(0);
CheckIf3IsInInteger(9874903);
CheckIf3IsInInteger(16984);
CheckIf3IsInInteger(367765);
#endregion

bool CheckIf3IsInInteger(int number)
{
    Console.Write($"{number} contains 3: ");
    while (number>2)
    {
        if (number % 10 == 3) { Console.WriteLine("true"); return true; }
        if (number > 10) { number /= 10; }
    }
    Console.WriteLine("false");
    return false;
}
