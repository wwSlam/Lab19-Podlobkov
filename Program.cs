// // int CountCharacter(string text, char target)
// // {
// //     int count = 0;

// //     foreach (char symbol in text)
// //     {
// //         if (symbol == target)
// //         {
// //             count++;
// //         }
// //     }

// //     return count;
// // }


// // Console.WriteLine(CountCharacter("мама", 'м'));
// // Console.WriteLine(CountCharacter("Код 2026", ' '));
// // Console.WriteLine(CountCharacter("", 'а'));

// // int CountDigits(string text)
// // {
// //     int count = 0;

// //     foreach (char symbol in text)
// //     {
// //         if (char.IsDigit(symbol))
// //         {
// //             count++;
// //         }
// //     }

// //     return count;
// // }


// // int CountLetters(string text)
// // {
// //     int count = 0;

// //     foreach (char symbol in text)
// //     {
// //         if (char.IsLetter(symbol))
// //         {
// //             count++;
// //         }
// //     }

// //     return count;
// // }


// // Console.WriteLine(CountDigits("Код 2026!"));
// // Console.WriteLine(CountLetters("Код 2026!"));


// int FindCharacterIndex(string text, char target)
// {
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             return i;
//         }
//     }

//     return -1;
// }


// // Console.WriteLine(FindCharacterIndex("banana", 'a'));
// // Console.WriteLine(FindCharacterIndex("banana", 'b'));
// // Console.WriteLine(FindCharacterIndex("banana", 'z'));
// // Console.WriteLine(FindCharacterIndex("", 'a'));


// // string sample = "  Привет, C#!  ";

// // string trimmed = sample.Trim();
// // string upper = sample.ToUpper();
// // string lower = sample.ToLower();
// // string replaced = sample.Replace(' ', '_');

// // Console.WriteLine($"Исходная: [{sample}]");
// // Console.WriteLine($"Без пробелов по краям: [{trimmed}]");
// // Console.WriteLine($"Верхний регистр: [{upper}]");
// // Console.WriteLine($"Нижний регистр: [{lower}]");
// // Console.WriteLine($"Замена пробелов: [{replaced}]");


// // int CountWords(string text)
// // {
// //     string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// //     return words.Length;
// // }

// // Console.WriteLine(CountWords("Я изучаю C#"));
// // Console.WriteLine(CountWords("  кот  дом  "));
// // Console.WriteLine(CountWords(""));
// // Console.WriteLine(CountWords("   "));


// Console.Write("Введите строку: ");
// string text = Console.ReadLine() ?? "";
// Console.Write("Введите один символ для поиска: ");
// char target = Convert.ToChar(Console.ReadLine());

// System.Console.WriteLine($"[{text}]");
// System.Console.WriteLine(text.Length);
// System.Console.WriteLine(CountLetters(text));
// System.Console.WriteLine(CountDigits(text));
// System.Console.WriteLine(CountCharacter(text, ' '));
// System.Console.WriteLine(CountWords(text));
// Trim(text);
// ToUpper(text);
// ToReplace(text);
// System.Console.WriteLine(FindCharacterIndex(text, target));


// int CountLetters(string text)
// {
//     int count = 0;
//     foreach (char symbol in text)
//     {
//         if (char.IsLetter(symbol))
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int CountDigits(string text)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (char.IsDigit(symbol))
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int CountCharacter(string text, char symbol)
// {
//     int count = 0;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == symbol)
//         {
//             count++;
//         }
//         else
//         {
//             continue;
//         }
//     }
//     return count;

// }

// void Trim(string text)
// {
//     text = text.Trim();
//     System.Console.WriteLine($"[{text}]");
// }

// int CountWords(string text)
// {
//     string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     return words.Length;
// }

// void ToUpper(string text)
// {
//     text = text.ToUpper();
//     System.Console.WriteLine($"[{text}]");
// }

// void ToReplace(string text)
// {
//     text = text.Replace(' ', '_');
//     System.Console.WriteLine($"[{text}]");
// }


// int index = FindCharacterIndex(text, target);

// if (index == -1)
// {
//     Console.WriteLine("Символ не найден");
// }
// else
// {
//     Console.WriteLine($"Первый индекс: {index}");
// }


Console.WriteLine();
Console.WriteLine("Вариант 1");

System.Console.WriteLine(FindLastCharacterIndex("banana", 'a'));

int FindLastCharacterIndex(string text, char target)
{
    int count = -1;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            count = i;
        }
    }
    return count;
}