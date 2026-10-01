// Console.WriteLine("Границы целочисленнвх типов");
// Console.WriteLine($"byte: {byte.MinValue} .. {float.MaxValue}");
// Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
// Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
// Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Границы дробых типов");
// Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
// Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
// Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Переполнение byte");

// byte maxByte = 255;
// byte overflowed = (byte)(maxByte + 1);
// Console.WriteLine($"255 + 1 для byte = {overflowed}");


// Console.WriteLine();
// Console.WriteLine("char");

// char firstLetter = 'A';
// char separator = '=';
// int charAsNumber = firstLetter;

// Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
// Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
// Console.WriteLine($"Табуляция:\tпосле таба");
// Console.WriteLine($"Перенос:\nпосле переноса");

// Console.WriteLine();
// Console.WriteLine($"decimal против double");

// double priceDouble = 0.1 + 0.2;
// decimal priceDecimal = 0.1m + 0.2m;

// Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// Console.WriteLine($"decimal: 0.1m + 0.2m = {priceDecimal}");


// Console.WriteLine();
// Console.WriteLine("var");

// var studentAge = 20;
// var gpa = 4.75;
// var fullName = "Смирнова А.С.";

// Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

// Console.WriteLine();
// Console.WriteLine("Ввод текста");

// Console.Write("Введите ваше имя: ");
// string enteredName = Console.ReadLine();

// Console.Write("Введите название вашей группы: ");
// string enteredGroup = Console.ReadLine();

// Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

// Console.WriteLine();
// Console.WriteLine("Ввод чисел: Convert и Parse");

// Console.Write("Введите ваш год рождения: ");
// string birthYearInput = Console.ReadLine();

// int birthYearConvert = Convert.ToInt32(birthYearInput);
// int birthYearParse = int.Parse(birthYearInput);

// Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// Console.WriteLine($"int.Parse:       {birthYearParse}");
// Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

// Console.WriteLine();
// Console.WriteLine("Ввод чисел: TryParse");

// Console.Write("Введите количество прочитанных книг за семестр: ");
// string booksInput = Console.ReadLine();

// bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

// Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
// Console.WriteLine($"Значение переменной booksCount {booksCount}");

// Console.Write("Введите имя и фамилию:");
// string name = Console.ReadLine();
// Console.Write("Введите группу: ");
// string nameGroup = Console.ReadLine();
// Console.Write("Введите год рождения: ");
// int birthYear = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл: ");
// double averageGrade = double.Parse(Console.ReadLine());
// Console.Write("Введите любимую букву: ");
// char loveChar = Console.ReadLine()[0];

// int ageIn2030 = 2030 - birthYear;

// Console.WriteLine();
// Console.WriteLine("Анкета");
// Console.WriteLine($"{name}, группа {nameGroup}");
// Console.WriteLine($"Год рождения: {birthYear} (в 2030 будет {ageIn2030} год)");
// Console.WriteLine($"Средний балл: {averageGrade}");
// Console.WriteLine($"Балл >= 4.0: {averageGrade >= 4.0}");
// Console.WriteLine($"Любимая буква: {loveChar}");


// //Задание 1. КалькуляторИМТ ★
// Console.Write("Введите рост в метрах: ");
// double height = double.Parse(Console.ReadLine());
// Console.Write("Введите вес: ");
// double weight = double.Parse(Console.ReadLine());

// double IMT = weight / (height * height);
// Console.WriteLine($"ИМТ: {IMT:F2}");


// Console.Write("Введите фамилию: ");
// string lastName = Console.ReadLine();
// Console.Write("Введите имя: ");
// string name = Console.ReadLine();
// char initial = name[0];
// Console.WriteLine($"{lastName} {initial}.");


//ЦЕЛОЕ ЧИСЛО
Console.Write("Введите целое число: ");
string input1 = Console.ReadLine();
bool success1 = int.TryParse(input1, out int number);
Console.WriteLine($"Успешно: {success1}, значение: {number}");

//ДРОБНОЕ ЧИСЛО
Console.Write("Введите дробное число: ");
string input2 = Console.ReadLine();
bool success2 = double.TryParse(input2, out double fraction);
Console.WriteLine($"Успешно: {success2}, значение: {fraction}");

//ДАТА
Console.Write("Введите дату (дд.мм.гггг): ");
string input3 = Console.ReadLine();
bool success3 = DateTime.TryParse(input3, out DateTime date);
Console.WriteLine($"Успешно: {success3}, значение: {date:dd.MM.yyyy}");