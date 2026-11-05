# Caleb_26471_Lab2

A Windows Forms desktop application built with C# and .NET 10.
Lab 2 — converts the console programs from Lab 1 into a proper desktop app with four screens.

---

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download) (or later)
- Windows (Windows Forms is Windows-only)
- Visual Studio 2022 or later (recommended)

---

## How to run

1. Clone or download the repository.
2. Open `Caleb_26471_Lab2.slnx` in Visual Studio.
3. Press **F5** to build and run, or use `dotnet run` from the project folder.

> **Login note:** Any non-empty username and password combination is accepted. There is no fixed credential check.

---

## Screens

### Login
- Enter any non-empty username and password to proceed.

### Choose
- Pick between **Bicycle Rental** and **Mushroom Identifier**.

### Bicycle Rental
- Enter a start hour (0–23) and end hour (1–24).
- Click **Calculate** to see the total cost in RWF.
- Rates vary by time of day:
  | Hours | Rate per hour |
  |-------|--------------|
  | 00:00 – 06:59 | 500 RWF |
  | 07:00 – 13:59 | 1 000 RWF |
  | 14:00 – 18:59 | 1 500 RWF |
  | 19:00 – 20:59 | 1 000 RWF |
  | 21:00 – 23:59 | 500 RWF |
- **Reset** clears the fields. **Back** returns to Choose. **Logout** returns to Login.

### Mushroom Identifier
- Answer up to 4 yes/no questions to identify your mushroom.
- 6 possible results: Agaric Jaunissant, Amanite tue-mouche, Cépe de bordeaux, Coprin chevelu, Girolle, Pied bleu.
- **Start Over** restarts the identification. **Back** returns to Choose. **Logout** returns to Login.

---

## Project structure

```
Caleb_26471_Lab2/
├── BicycleForm.cs / .Designer.cs / .resx
├── ChooseForm.cs  / .Designer.cs / .resx
├── LoginForm.cs   / .Designer.cs / .resx
├── MushroomForm.cs / .Designer.cs / .resx
├── Program.cs
├── Caleb_26471_Lab2.csproj
├── Caleb_26471_Lab2.slnx
├── .gitignore
└── README.md
```

---

## Screenshots

_Coming soon_
