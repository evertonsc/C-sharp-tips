# C# Tips 💡

A growing collection of useful C# tips and best practices. Each tip is briefly explained.
This repository is being created to be used as a cheatset for C#, saving interesting functionalities for a great development.
The README.md and the code will always be in development, aggregating some tips every moment.

## How to use
---
You will need .NET 6 to execute correctly the code. 

1- Build & run the code with `dotnet run` on your terminal;
2- There's a menu enumerating some tips. Choose a valid option to see its tips.

---

## 1. Monetary values
 
Use the :C format specifier to display numbers as currency based on your system's locale. This is useful for showing monetary values in a user-friendly and localized format.

```csharp
decimal valor = 1580.20M;
Console.WriteLine($"{valor:C}");
```
#### Don't forget to use "M" after the value


## 2. Change system's location
 
Use the :C format specifier to display numbers as currency based on your system's locale. This is useful for showing monetary values in a user-friendly and localized format.

```csharp
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");     // United States
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");     // Brazil
Console.WriteLine($"{valor:C}");
```
#### Don't forget to use "M" after the value
