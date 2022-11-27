 Console.WriteLine("Введите трёхзначное число");
 var numbers = Convert.ToInt64(Console.ReadLine());
        while (numbers >= 100)
        {
            numbers /= 10;
        }
        var digit = numbers % 10;
        Console.WriteLine("Вторая цифра в числе = "+digit);