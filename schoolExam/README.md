<!-- Title -->
<h1 align="center">🚀 Exam & Question Management System - C# OOP</h1>

<p align="center">
  <img src="https://img.shields.io/badge/Language-C%23-blue?style=for-the-badge&logo=csharp" alt="C# Badge"/>
  <img src="https://img.shields.io/badge/Framework-.NET%209.0-purple?style=for-the-badge&logo=dotnet" alt=".NET Badge"/>
  <img src="https://img.shields.io/badge/Paradigm-OOP-orange?style=for-the-badge&logo=codeforces" alt="OOP Badge"/>
  <img src="https://img.shields.io/badge/License-MIT-green?style=for-the-badge" alt="MIT Badge"/>
</p>

---

### 🧭 Overview
This project implements a **flexible and scalable system** for managing various types of questions and exams using **advanced C# Object-Oriented Programming (OOP)** principles.  
It demonstrates the use of **abstraction**, **inheritance**, **polymorphism**, and **interfaces** to ensure clean, maintainable, and extensible code.

---

## 🌟 Key Features

| 💡 Feature | 📝 Description | ⚙️ OOP Concept |
|-------------|----------------|----------------|
| **Advanced OOP Design** | Uses abstract base classes (`Question`, `Exam`) to define shared logic and attributes. | `abstract class` |
| **Diverse Question Types** | Supports Multiple Choice (MCQ) and True/False question formats. | Inheritance |
| **Specialized Exam Types** | Implements `FinalExam` and `PracticalExam` with different behaviors. | Polymorphism |
| **Custom Display Logic** | Each exam type has a unique `ShowExam()` implementation: | Method Overriding |
|  | - **Practical Exam:** Displays the correct answer immediately.<br> - **Final Exam:** Displays all questions and total grade. |  |
| **Cloning & Comparison** | Supports deep copying and sorting using standard interfaces. | `ICloneable`, `IComparable` |

---

## 🛠️ Project Structure

Each class resides in its own file for clarity and modularity.

| 📄 File / Class | 🔍 Description |
|-----------------|----------------|
| **Answer.cs** | Represents a possible answer choice. Implements `ICloneable`. |
| **Question.cs** | *(Abstract)* Defines shared attributes and logic. Implements `IComparable` & `ICloneable`. |
| **TrueOrFalseQuestion.cs** | Inherits from `Question`. Used mainly in `FinalExam`. Uses constructor chaining. |
| **MCQQuestion.cs** | Inherits from `Question`. Used in both `FinalExam` and `PracticalExam`. |
| **Subject.cs** | Represents a course. Uses `CreateSubjectExam()` to link an `Exam` instance. |
| **Exam.cs** | *(Abstract)* Defines common properties like `TimeLimit` and `NumberOfQuestions`. |
| **FinalExam.cs** | Displays all questions and grades at the end. |
| **PracticalExam.cs** | Displays each question with its correct answer immediately. |
| **Program.cs** | Entry point demonstrating polymorphism between exam types. |

---

## 🧩 UML Concept (Simplified)

---

## ⚙️ How to Run

### 1️⃣ Prerequisites
- Install **.NET SDK 6.0+**
- Ensure `dotnet` CLI is available in your system PATH.

### 2️⃣ Clone the Repository
bash
`git clone https://github.com/YourUsername/ExamSystem.git`
`cd ExamSystem`

### 3️⃣ Run App
`dotnet run`

### 📸 Example Output
<img width="1230" height="709" alt="image" src="https://github.com/user-attachments/assets/d0fd8643-079f-4d3d-82f3-2d032479344c" />

