using System.Globalization;

Console.WriteLine("Welcome to C# tips!");


//#region Formatting value tips


/****************************************************************************************************************************************************************
 * Note: Format the value with your system's currency.
 ****************************************************************************************************************************************************************/
Console.WriteLine("\n===================================================");
decimal value = 1580.20M;
Console.WriteLine($"{value:C}");


/****************************************************************************************************************************************************************
 * Note: The CultureInfo.DefaultThreadCurrentCulture is used to set the default culture for the current thread. This affects how values are formatted and parsed.
 * If you want to format a value in a specific culture without changing the default culture for the thread, you can use the CultureInfo directly.
 ****************************************************************************************************************************************************************/
Console.WriteLine("\n===================================================");
decimal formattedValue = 1429.10M;

Console.WriteLine("Formatting with specific culture:");
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");     // United States
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");     // United States
Console.WriteLine($"{formattedValue:C}");

// You can also use the CultureInfo directly. This is useful if you want to format a value in a specific culture without changing the default culture for the thread.
Console.WriteLine("Formatting with specific culture and currency symbol (inline):");
Console.WriteLine($"{formattedValue.ToString("C", new CultureInfo("pt-BR"))}");     // R$ 1.429,10
Console.WriteLine($"{formattedValue.ToString("C", new CultureInfo("en-US"))}");     // $1,429.10

// Or 

Console.WriteLine($"{formattedValue.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
Console.WriteLine($"{formattedValue.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");


/****************************************************************************************************************************************************************
 * Note: Format the value with decimals.
 ****************************************************************************************************************************************************************/
Console.WriteLine("\n===================================================");
decimal decimalPointsValue = 19999.10M;
Console.WriteLine("Formatting with decimals:");
Console.WriteLine($"Currency value: {decimalPointsValue:C4}"); // $19,999.1000

// If you want to format the value without the currency symbol, you can use the "N" format specifier.
Console.WriteLine($"Number value: {decimalPointsValue:N4}"); // 19,999.1000


/****************************************************************************************************************************************************************
 * Note: Format the value with percent. It also consider the current culture. 
    - If you are using "en-US" culture, it will format the value with "." ==> 85.00%
    - If you are using "pt-BR" culture, it will format the value with "," ==> 85,00%
 ****************************************************************************************************************************************************************/
Console.WriteLine("\n===================================================");
decimal percentValue = 0.85M;
Console.WriteLine("Formatting with percent:");
Console.WriteLine($"Percent value: {percentValue:P2}");     // 85.00%


/****************************************************************************************************************************************************************
 * Note: Format the value with filling the number with zeros.
 ****************************************************************************************************************************************************************/
Console.WriteLine("\n===================================================");
int leadingZeroValue = 654321;
Console.WriteLine($"Number with leading zeros: {leadingZeroValue:D10}"); // 0000654321


/****************************************************************************************************************************************************************
 * Note: Format the value with customized format.
 ****************************************************************************************************************************************************************/
Console.WriteLine("\n===================================================");
int number = 123456;
Console.WriteLine("Formatting with customized format:");
Console.WriteLine($"Number with customized format: {number:##-##-##}"); // 123,456

//#endregion Formatting value tips



//#region Date tips

/****************************************************************************************************************************************************************
 * Note: Format the date with customized format.
 * You can use the "d" format specifier to format the date as a short date string, or the "D" format specifier to format the date as a long date string.
 * You can also use the "f" format specifier to format the date as a full date string, or the "F" format specifier to format the date as a full date and time string.
 * The "g" format specifier formats the date as a general date and time string, or the "G" format to the date as a general date and time string with seconds.
 * The "M" format specifier formats the date as a month and day string, or the "Y" format specifier formats the date as a year and month string.
 * The "s" format specifier formats the date as a sortable date and time string, which is useful for storing dates in a database or for sorting dates in a list.
 * The "u" format specifier formats the date as a universal sortable date and time string, which is useful for storing dates in a database or for sorting dates in a list.
 * The "o" format specifier formats the date as an ISO 8601 date and time string, which is useful for storing dates in a database or for sorting dates in a list.
 * The "r" format specifier formats the date as a RFC 1123 date and time string, which is useful for storing dates in a database or for sorting dates in a list.
 * The "t" format specifier formats the date as a short time string, or the "T" format specifier formats the date as a long time string.
 ****************************************************************************************************************************************************************/
Console.WriteLine("\n===================================================");

DateTime date = new DateTime(2023, 10, 15, 14, 30, 0);
Console.WriteLine("Formatting date with customized format:");
Console.WriteLine($"Short date: {date:d}");                             // 10/15/2023
Console.WriteLine($"Long date: {date:D}");                              // Sunday, October 15, 2023
Console.WriteLine($"Full date: {date:f}");                              // Sunday, October 15, 2023 2:30 PM
Console.WriteLine($"Full date with seconds: {date:F}");                 // Sunday, October 15, 2023 2:30:00 PM
Console.WriteLine($"General date and time: {date:g}");                  // 10/15/2023 2:30 PM
Console.WriteLine($"General date and time with seconds: {date:G}");     // 10/15/2023 2:30:00 PM
Console.WriteLine($"Month and day: {date:M}");                          // October 15
Console.WriteLine($"Year and month: {date:Y}");                         // October 2023
Console.WriteLine($"Sortable date and time: {date:s}");                 // 2023-10-15T14:30:00
Console.WriteLine($"Universal sortable date and time: {date:u}");       // 2023-10-15 14:30:00Z
Console.WriteLine($"ISO 8601 date and time: {date:o}");                 // 2023-10-15T14:30:00.0000000
Console.WriteLine($"RFC 1123 date and time: {date:r}");                 // Sun, 15 Oct 2023 14:30:00 GMT
Console.WriteLine($"Short time: {date:t}");                             // 2:30 PM
Console.WriteLine($"Long time: {date:T}");                              // 2:30:00 PM
/****************************************************************************************************************************************************************
 * Note: Format the date with custom format string.
 * You can use the "yyyy" format specifier to format the year as a four-digit number, or the "yy" format specifier to format the year as a two-digit number.
 * You can use the "MM" format specifier to format the month as a two-digit number, or the "M" format specifier to format the month as a one-digit number.
 * You can use the "dd" format specifier to format the day as a two-digit number, or the "d" format specifier to format the day as a one-digit number.
 * You can use the "HH" format specifier to format the hour as a two-digit number in 24-hour format, or the "hh" format specifier to format the hour as a two-digit number in 12-hour format.
 * You can use the "mm" format specifier to format the minutes as a two-digit number, or the "ss" format specifier to format the seconds as a two-digit number.
 ****************************************************************************************************************************************************************/
Console.WriteLine("\n===================================================");
Console.WriteLine("Formatting date with custom format string:");
Console.WriteLine($"Custom format: {date:yyyy-MM-dd HH:mm:ss}");                                // 2023-10-15 14:30:00
Console.WriteLine($"Custom format with month and day: {date:MM/dd}");                           // 10/15
Console.WriteLine($"Custom format with year and month: {date:yyyy-MM}");                        // 2023-10
Console.WriteLine($"Custom format with hour and minutes: {date:HH:mm}");                        // 14:30
Console.WriteLine($"Custom format with hour and minutes in 12-hour format: {date:hh:mm tt}");   // 02:30 PM
Console.WriteLine($"Custom format with seconds: {date:ss}");                                    // 00
Console.WriteLine($"Custom format with day of the week: {date:dddd}");                          // Sunday
Console.WriteLine($"Custom format with abbreviated day of the week: {date:ddd}");               // Sun
Console.WriteLine($"Custom format with month name: {date:MMMM}");                               // October
Console.WriteLine($"Custom format with abbreviated month name: {date:MMM}");                    // Oct
Console.WriteLine($"Custom format with week of the year: {CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday)}"); // 42


//#endregion Date tips