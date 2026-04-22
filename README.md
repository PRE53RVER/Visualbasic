# 📊 NotenKalkulator

> A Windows Forms desktop application built with Visual Basic .NET for calculating and averaging school subject grades across multiple semesters.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Subjects Covered](#subjects-covered)
- [How It Works](#how-it-works)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Running the Application](#running-the-application)
- [Grade Calculation Logic](#grade-calculation-logic)
- [Project Structure](#project-structure)
- [Screenshots](#screenshots)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

**NotenKalkulator** (German for *Grade Calculator*) is a desktop utility designed to help students calculate their subject averages across two semesters and compute a final overall grade. The app supports 10 school subjects, handles oral and written grades where applicable, and produces a final GPA-style score.

Built with **Visual Basic .NET** and **Windows Forms**, it provides a clean, panel-based interface for entering grades per subject and computing results instantly.

---

## Features

- ✅ Calculate semester averages for individual subjects
- ✅ Combine oral and written grades into a semester score
- ✅ Compute cross-semester averages (Semester 1 + Semester 2)
- ✅ Calculate overall grade average across all 10 subjects
- ✅ Derive a final **note** (grade) using a standard formula
- ✅ Clean, organized panel layout — one section per subject
- ✅ Instant calculation on button click — no page reloads or delays

---

## Subjects Covered

| Subject | German Name | Input Type |
|---|---|---|
| Technical Field (Business) | Technisches Fachgebiet (TF) | Marketing, Beschaffung, Projekt, Macro, Buchhaltung |
| German | Deutsch | Oral + Written per Semester |
| English | Englisch | Oral + Written per Semester |
| Religion | Religion | Oral + Written |
| Mathematics | Mathematik | Semester 1 & 2 |
| Elective (WPU) | Wahlpflichtunterricht | Semester 1 & 2 |
| Physics | Physik | Oral + Written per Semester |
| Politics | Politikwissenschaft (Powi) | Oral + Written per Semester |
| Chemistry | Chemie | Oral + Written per Semester |
| Sports | Sport | Direct average input |

---

## How It Works

Each subject has its own panel with dedicated input fields and a calculate button:

1. **Enter your grades** in the provided text boxes for each subject.
2. **Click the calculate button** for that subject to compute the semester or subject average.
3. Repeat for all subjects.
4. **Click the final "Calculate Overall" button** to compute the total average and derive your final grade.

### Grade Formula

The final grade (*Note*) is calculated using the formula:

```
Note = (17 - Gesamt) / 3
```

Where `Gesamt` is the average of all 10 subject scores.

---

## Getting Started

### Prerequisites

- **Operating System**: Windows 7 / 8 / 10 / 11
- **.NET Framework**: Version 4.0 or higher
- **Visual Studio** (for development): 2010 or later with VB.NET support

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/PRE53RVER/Visualbasic.git
   cd Visualbasic
   ```

2. **Open the solution in Visual Studio:**

   Double-click `NotenKalkulator.sln` or open it via **File → Open → Project/Solution**.

3. **Build the project:**

   Go to **Build → Build Solution** (or press `Ctrl + Shift + B`).

### Running the Application

**Option A — From Visual Studio:**

Press `F5` or click the **Start** button to run in debug mode.

**Option B — Run the compiled executable:**

Navigate to the `bin/Release/` folder and double-click `NotenKalkulator.exe`.

> **Note:** If you receive a missing .NET runtime error, download and install the [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework) from Microsoft's official site.

---

## Grade Calculation Logic

Below is a summary of how each subject's grade is computed:

```
' Technical Field (TF) — average of 5 sub-subjects
TF_Average = (Marketing + Beschaffung + Projekt + Macro + Buchhaltung) / 5

' Subjects with oral + written grades per semester
Semester2 = (Oral + Written) / 2
Final_Subject_Average = (Semester1 + Semester2) / 2

' Overall average across all 10 subjects
Gesamt = (Sport + German + English + Religion + Math + WPU + Physics + Powi + Chemistry + TF) / 10

' Final grade derivation
Note = (17 - Gesamt) / 3
```

---

## Project Structure

```
NotenKalkulator/
├── NotenKalkulator.sln          # Visual Studio solution file
├── NotenKalkulator.vbproj       # Project configuration
├── Form1.vb                     # Main application logic (button handlers & calculations)
├── Form1.Designer.vb            # Auto-generated UI layout code
├── Form1.resx                   # Resource file (icons, strings)
└── README.md                    # Project documentation
```

---

## Screenshots

> 📸 *Screenshots coming soon — run the application locally to see the full UI.*
>
> To add your own screenshot:
> 1. Run the app and press `Alt + PrtScn` to capture the window.
> 2. Save it as `screenshot.png` in a `/screenshots/` folder.
> 3. Reference it here:
>
> ```markdown
> ![NotenKalkulator UI](screenshots/screenshot.png)
> ```

---

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository
2. Create a new branch: `git checkout -b feature/your-feature-name`
3. Make your changes and commit: `git commit -m "Add your feature"`
4. Push to your fork: `git push origin feature/your-feature-name`
5. Open a Pull Request

---

## License

This project is open source and available under the [MIT License](LICENSE).

---

<p align="center">Made with ❤️ using Visual Basic .NET</p>
