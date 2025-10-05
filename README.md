# â ToDoApp.NET-Maui

A modern **cross-platform To-Do application** built using **.NET MAUI** (Multi-platform App UI).  
The app allows you to create, edit, mark, and delete tasks â all within a simple and elegant interface that works on **Android, iOS, Windows, and macOS**.

---

## đ§­ Table of Contents

1. [About the Project](#about-the-project)  
2. [Features](#features)  
3. [Requirements](#requirements)  
4. [Getting Started](#getting-started)  
5. [Project Structure](#project-structure)  
6. [Future Improvements](#future-improvements)  
7. [Feedback & Contributions](#feedback--contributions)  
8. [Author](#author)

---

## đ§Š About the Project

This project demonstrates a **multi-platform To-Do app** developed with **.NET MAUI**, Microsoft's framework for building native apps using a single C# codebase.  
Itâs designed as a lightweight example of how to use **MVVM patterns** and **platform-specific integrations** in a clean, modular architecture.

> [!NOTE]  
> This project can serve as a **template or learning reference** for developers exploring .NET MAUI fundamentals and MVVM architecture.

---

## đ Features

- đ **Add new tasks** quickly  
- â **Mark tasks as completed / pending**  
- âď¸ **Edit existing tasks**  
- đď¸ **Delete tasks** easily  
- đž **Local data persistence**  
- đť **Cross-platform UI** (Android, iOS, Windows, macOS)  
- âď¸ **MVVM architecture** for clean separation of logic and presentation  

> [!TIP]  
> The app structure makes it easy to extend with new features such as categories, due dates, or cloud sync.

---

## đ§° Requirements

To build and run this project, ensure you have the following:

| Tool / Component | Minimum Version | Notes |
|------------------|-----------------|-------|
| [.NET SDK](https://dotnet.microsoft.com/en-us/download) | **9.0** | Required for building the MAUI project |
| **Visual Studio 2022/2023** | Latest | With **.NET MAUI workload** installed |
| **Android SDK / Xcode** | Depends on platform | For mobile builds |
| **Windows 10+ / macOS Monterey+** | â | For desktop builds |

> [!IMPORTANT]  
> Make sure the **MAUI workloads** are properly installed in Visual Studio.  
> You can verify this by opening the **Visual Studio Installer â Modify â .NET Multi-platform App UI development**.

---

## âď¸ Getting Started

Follow these steps to run the project locally:

### 1ď¸âŁ Clone the repository

```bash
git clone https://github.com/Jakub-Chrzanowski/ToDoApp.NET-Maui.git
cd ToDoApp.NET-Maui
```

### 2ď¸âŁ Open in Visual Studio

- Open the solution file: `ToDoApp.sln`  
- Select your target platform (e.g., Android, Windows, iOS)  
- Ensure all NuGet packages restore successfully

### 3ď¸âŁ Build and Run

Click **âś Run** or press **F5** in Visual Studio.

> [!TIP]  
> If you encounter SDK or platform errors, check the **Target Frameworks** in your `.csproj` file and confirm that your environment supports them.

---

## đď¸ Project Structure

```
ToDoApp.NET-Maui/
âââ ToDoApp/
â   âââ Models/          # Data models (e.g., TaskItem)
â   âââ ViewModels/      # MVVM logic and data binding
â   âââ Views/           # UI Pages (XAML)
â   âââ Platforms/       # Platform-specific code (Android, iOS, etc.)
â   âââ App.xaml(.cs)    # Global styles and configuration
â   âââ MauiProgram.cs   # App startup and service registration
âââ ToDoApp.sln          # Solution file
âââ .gitignore
âââ README.md
```

> [!NOTE]  
> Folder names and structure may vary slightly depending on the current implementation.

---

## đŽ Future Improvements

Here are some potential enhancements and roadmap ideas:

- âď¸ **Cloud synchronization** (REST API / Firebase integration)  
- đ **Local notifications / reminders**  
- đď¸ **Task categorization and tagging**  
- đ **Due dates and priorities**  
- đ **Dark / Light theme switching**  
- đ§Š **Localization / multi-language support**

> [!TIP]  
> Contributions and pull requests are welcome! Feel free to fork the repo and improve functionality or UI.

---

## đŹ Feedback & Contributions

If you find bugs or want to suggest improvements, please open an [Issue](../../issues) or submit a [Pull Request](../../pulls).  
Your feedback is greatly appreciated! đ

---

## đ¨âđť Author

**Jakub Chrzanowski**  
GitHub: [@Jakub-Chrzanowski](https://github.com/Jakub-Chrzanowski)

---

> [!NOTE]  
> Built with â¤ď¸ using **.NET MAUI** and the **MVVM** design pattern.