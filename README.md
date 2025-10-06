# ✅ ToDoApp.NET-Maui

A modern **cross-platform To-Do application** built using **.NET MAUI** (Multi-platform App UI).  
The app allows you to create, edit, mark, and delete tasks — all within a simple and elegant interface that works on **Android, iOS, Windows, and macOS**.

---

## 🧭 Table of Contents

1. [About the Project](#about-the-project)  
2. [Features](#features)  
3. [Requirements](#requirements)  
4. [Getting Started](#getting-started)  
5. [Project Structure](#project-structure)  
6. [Future Improvements](#future-improvements)  
7. [Feedback & Contributions](#feedback--contributions)  
8. [Author](#author)

---

## 🧩 About the Project

This project demonstrates a **multi-platform To-Do app** developed with **.NET MAUI**, Microsoft's framework for building native apps using a single C# codebase.  
It’s designed as a lightweight example of how to use **MVVM patterns** and **platform-specific integrations** in a clean, modular architecture.

> [!NOTE]  
> This project can serve as a **template or learning reference** for developers exploring .NET MAUI fundamentals and MVVM architecture.

---

## 🚀 Features

- 📝 **Add new tasks** quickly  
- ✅ **Mark tasks as completed / pending**  
- ✏️ **Edit existing tasks**  
- 🗑️ **Delete tasks** easily  
- 💾 **Local data persistence**  
- 💻 **Cross-platform UI** (Android, iOS, Windows, macOS)  
- ⚙️ **MVVM architecture** for clean separation of logic and presentation  

> [!TIP]  
> The app structure makes it easy to extend with new features such as categories, due dates, or cloud sync.

---

## 🧰 Requirements

To build and run this project, ensure you have the following:

| Tool / Component | Minimum Version | Notes |
|------------------|-----------------|-------|
| [.NET SDK](https://dotnet.microsoft.com/en-us/download) | **9.0** | Required for building the MAUI project |
| **Visual Studio 2022/2023** | Latest | With **.NET MAUI workload** installed |
| **Android SDK / Xcode** | Depends on platform | For mobile builds |
| **Windows 10+ / macOS Monterey+** | — | For desktop builds |

> [!IMPORTANT]  
> Make sure the **MAUI workloads** are properly installed in Visual Studio.  
> You can verify this by opening the **Visual Studio Installer → Modify → .NET Multi-platform App UI development**.

> [!WARNING]
> According to Microsoft, Linux **MAUI Android workloads** for unknown reasons are not included in .NET 9.0. Even though that workloads are normally working on 8.0 version it is not quaranteed and tested on this project.

---

## ⚙️ Getting Started

Follow these steps to run the project locally:

### 1️⃣ Clone the repository

```bash
git clone https://github.com/Jakub-Chrzanowski/ToDoApp.NET-Maui.git
cd ToDoApp.NET-Maui
```

### 2️⃣ Open in Visual Studio

- Open the solution file: `ToDoApp.sln`  
- Select your target platform (e.g., Android, Windows, iOS)  
- Ensure all NuGet packages restore successfully

### 3️⃣ Build and Run

Click **▶ Run** or press **F5** in Visual Studio.

> [!TIP]  
> If you encounter SDK or platform errors, check the **Target Frameworks** in your `.csproj` file and confirm that your environment supports them.

---

## 🗂️ Project Structure

```
ToDoApp.NET-Maui/
├── ToDoApp/
│   ├── Models/          # Data models (e.g., TaskItem)
│   ├── Views/           # UI Pages (XAML)
│   ├── Platforms/       # Platform-specific code (Android, iOS, etc.)
│   ├── App.xaml(.cs)    # Global styles and configuration
│   └── MauiProgram.cs   # App startup and service registration
├── ToDoApp.sln          # Solution file
├── .gitignore
└── README.md
```

> [!NOTE]  
> Folder names and structure may vary slightly depending on the current implementation.

---

## 🔮 Future Improvements

Here are some potential enhancements and roadmap ideas:

- ☁️ **Cloud synchronization** (REST API / Firebase integration)  
- 🔔 **Local notifications / reminders**  
- 🗂️ **Task categorization and tagging**  
- 📅 **Due dates and priorities**  
- 🌙 **Dark / Light theme switching**  
- 🧩 **Localization / multi-language support**

> [!TIP]  
> Contributions and pull requests are welcome! Feel free to fork the repo and improve functionality or UI.

---

## 💬 Feedback & Contributions

If you find bugs or want to suggest improvements, please open an [Issue](../../issues) or submit a [Pull Request](../../pulls).  
Your feedback is greatly appreciated! 🙌

---

## 👨‍💻 Author

**Jakub Chrzanowski**  
GitHub: [@Jakub-Chrzanowski](https://github.com/Jakub-Chrzanowski)

---

> [!NOTE]  
> Built using **.NET MAUI** and the **MVVM** design pattern.
