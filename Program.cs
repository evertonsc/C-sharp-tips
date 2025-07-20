using System.Globalization;

Console.WriteLine("Hello, World!\n");


//#region Tip 1

decimal valor = 1580.20M;
Console.WriteLine($"{valor:C}");

//#endregion Tip 1

//#region Tip 2

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");     // United States
Console.WriteLine($"{valor:C}");

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");     // Brazil

//#endregion Tip 2