# 🏥 Hospital Management System (HMS)

The **Hospital Management System (HMS)** is a **C# console application** designed to simulate and manage daily hospital operations — including doctors, patients, nurses, rooms, departments, and billing.  
This project showcases **advanced Object-Oriented Programming (OOP)** principles in C# for modularity, scalability, and maintainability.

---

## 🚀 Key Features

- 👨‍⚕️ **Personnel Management** – Register and manage doctors, nurses, and patients using structured OOP classes.  
- 💾 **Data Storage** – `Hospital` (static class) acts as the **in-memory data store** for all entities.  
- 🏠 **Resource Management** – Book and release hospital rooms using the **immutable `Room` struct**.  
- 💰 **Billing & Invoicing** – Generate patient bills and calculate totals (implements `IBillable`).  
- 🧾 **Action Logging** – Automatically logs **Add / Update / Remove** operations into `log.txt` using **partial classes**.  
- 🧠 **Comprehensive OOP** – Full use of inheritance, polymorphism, interfaces, operator overloading, and static/partial classes.

---

## 🛠️ Technologies and Tools

| 🧩 Technology | 💡 Description |
|---------------|----------------|
| **Language** | C# (.NET Core / .NET Framework) |
| **Application Type** | Console Application |
| **Programming Paradigm** | Object-Oriented Programming (OOP) |
| **Temporary Storage** | `List<T>` (In-Memory) |
| **Documentation** | XML Documentation Comments (`///`) |

---

## 🧱 Solution Structure

The project follows a **clean folder structure** ensuring **Separation of Concerns** and maintainability.

HospitalHMS/
├── HospitalHMS.sln
└── HospitalHMS/
├── Program.cs # Main entry point and interactive menu
├── Interfaces/ # Contracts (IStaff, IBillable)
│ ├── IStaff.cs
│ └── IBillable.cs
├── Models/ # Core data models
│ ├── Enums.cs # Enumerations (Gender, RoomType, BillItemType)
│ ├── Person.cs # Abstract base class
│ ├── Doctor.cs # (Sealed, IComparable, Operator Overloading)
│ ├── Patient.cs # (DeepClone, Inner IComparer, Explicit Cast)
│ ├── Nurse.cs # (IStaff)
│ ├── Department.cs # (Composition & Aggregation)
│ ├── Room.cs # (Immutable Struct)
│ └── Hospital.cs # (Static Data Store)
├── Services/ # Business logic services
│ └── Billing.cs # (IBillable, Implicit Cast)
└── Utilities/ # Helper tools and logging system
├── Utility.Common.cs # (Partial Class - ID Generation, Formatting)
└── Utility.Logging.cs # (Partial Class - LogAction, File I/O)

markdown
Copy code

---

## ⚙️ Implemented OOP Concepts

| 🧠 Feature | 🧩 Class / Entity | 🔍 Implementation Detail |
|-------------|------------------|---------------------------|
| **Abstract Inheritance** | `Person` | Base abstract class for `Doctor`, `Patient`, and `Nurse`. |
| **Deep Copy** | `Patient` | Implements `DeepClone()` for unique object copies. |
| **Operator Overloading** | `Doctor` | Overloads `==` and `!=` based on unique `Id`. |
| **Composition & Aggregation** | `Department` | Composition (`HeadDoctor`) + Aggregation (lists of staff). |
| **Partial Classes** | `Utility` | Split into `Utility.Common.cs` & `Utility.Logging.cs` for separation of logic. |
| **Immutable Struct** | `Room` | Methods `Book()` and `Release()` return new modified instances. |
| **Implicit / Explicit Casts** | `Billing`, `Patient` | `Billing → decimal` (total), `Patient → int` (stay duration). |

---

## 💻 How to Run

### 1️⃣ Clone the Repository
```bash
git clone [Repository-Link-Here]
cd HospitalHMS/HospitalHMS
2️⃣ Build and Run
bash
Copy code
dotnet run
3️⃣ Usage
The main menu appears immediately.

Default data (doctors, patients, rooms) loads automatically.

Select options by number to interact with the system.

All actions are logged to log.txt in the application directory.

🧩 Developer Notes
🧠 Data is in-memory only and will be lost upon program closure (except for log.txt).

🔒 System.Threading.Interlocked.Increment ensures thread-safe ID generation.

📝 Full XML Documentation Comments (///) provided for all classes and methods.

🧑‍💻 Author
Developed by: [Your Name]
💬 Feel free to contribute or suggest improvements!

🌟 License
This project is released under the MIT License.
See LICENSE for more information.