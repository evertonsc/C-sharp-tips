# C# Tips 💡

A growing collection of useful C# tips and best practices. Each tip is briefly explained.

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
