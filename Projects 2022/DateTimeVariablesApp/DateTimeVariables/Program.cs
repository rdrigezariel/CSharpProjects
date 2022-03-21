using System.Globalization;

DateTime today = DateTime.Now;
TimeOnly timeNow = TimeOnly.FromDateTime(DateTime.Now);
DateOnly dateToday = DateOnly.FromDateTime(DateTime.Now);

DateTime birthday = DateTime.Parse("06/30/1992");
DateTime birthdayTwo = DateTime.ParseExact("06/30/1992", "d", CultureInfo.InvariantCulture);

Console.WriteLine(today);
Console.WriteLine(timeNow);
Console.WriteLine(dateToday);
Console.WriteLine(birthday.ToString(CultureInfo.InvariantCulture));
Console.WriteLine(birthdayTwo);