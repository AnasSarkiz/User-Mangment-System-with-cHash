# User Management System

## Overview

The **User Management System** is a modern, Windows Forms-based application built with C# targeting .NET Framework 4.8. It provides a secure and user-friendly interface for managing users, roles, and authentication in a desktop environment. The system is designed with a contemporary dark theme, flat UI elements, and modular user controls for extensibility and maintainability.

---
## UI Screenshots

**Login Screen:**

![Login Screen](https://media.discordapp.net/attachments/1140353862608359464/1389351273748500610/image.png?ex=68644db4&is=6862fc34&hm=09f3e54cbd28c64efa655278da8bca23798ea2ad264c798541f0cb6e5df091ba&=&format=webp&quality=lossless)

**Dashboard:**

![Dashboard](https://media.discordapp.net/attachments/1140353862608359464/1389351491025768549/image.png?ex=68644de8&is=6862fc68&hm=816871ee9f33ec55f0e87f00ec5b48c5183d2f5616c82aa7d62c2dd79a9e92c3&=&format=webp&quality=lossless)

**UserList:**

![UserList](https://media.discordapp.net/attachments/1140353862608359464/1389351578649104495/image.png?ex=68644dfd&is=6862fc7d&hm=21eca2d683ef185a2f1973a59bd6674db86d66692c7d0366efa36c0069af56ee&=&format=webp&quality=lossless)

---

## Features

- **User Authentication**
  - Secure login with password hashing.
  - Account lockout after configurable failed attempts (with escalating lock durations).
  - Real-time feedback for login status and lockout reasons.

- **User Management**
  - Add, edit, and list users with roles.
  - Track failed login attempts and lock status.
  - Modern, intuitive forms for user input.

- **Role Management**
  - Assign roles (Admin, Editor, Viewer) to users.
  - Role-based access control for sensitive features.
  - Admin-only access to role management.

- **Event Logging**
  - View a log of system events and user actions.
  - Read-only event log with modern styling.

- **Modern UI/UX**
  - Dark theme with flat buttons and Segoe UI font.
  - Responsive layout with header and side navigation panels.
  - Consistent styling across all forms and user controls.

---

## Technologies Used

- **.NET Framework 4.8**
- **C# 7.3**
- **Windows Forms (WinForms)**
- **SQL Server** (for user data storage)
- **ADO.NET** (for database access)
- **Custom password hashing utility**

---

## Project Structure

- `Forms/`
  - `Form1.cs` - Login form.
  - `DashboardForm.cs` - Main dashboard after login.
  - `UCaddUser.cs` - User control for adding users.
  - `UClistUsers.cs` - User control for listing users.
  - `UCroleMng.cs` - User control for managing roles.
  - `UCevents.cs` - User control for viewing event logs.

- `DAL/`
  - `UserDAL.cs` - Data access layer for user operations.

- `Models/`
  - `User.cs` - User model.
  - `UserRole.cs` - Enum for user roles.

- `Utilities/`
  - `PasswordHasher.cs` - Utility for secure password hashing and verification.

---

## Database Schema

The system uses a SQL Server database with a `Users` table. Key columns include:

- `username` (PK)
- `password_hash`
- `role`
- `failed_attempts`
- `last_attempt`
- `is_looked` (account lock status, BIT)

---

## Getting Started

1. **Clone the repository**
   git clone https://github.com/yourusername/user-management-system.git

2. **Open in Visual Studio 2022**
   - Open the solution file.

3. **Configure the Database**
   - Update the connection string in `DbHelper` to point to your SQL Server instance.
   - Run the provided SQL scripts to create and migrate the `Users` table.

4. **Build and Run**
   - Build the solution.
   - Run the application (F5).

---

## Usage

- **Login:** Enter your username and password. Accounts are locked after repeated failed attempts.
- **Dashboard:** Navigate using the side menu to add users, view users, manage roles (admin only), or view event logs.
- **Add User:** Fill in the username, password, confirm password, and select a role.
- **Role Management:** Only accessible to Admin users.
- **Event Log:** View system and user activity logs.

---

## Customization

- **UI Theme:** All forms and controls use a consistent dark theme. You can further customize colors and fonts in the designer files.
- **Roles:** Add or modify roles in the `UserRole` enum and update the UI as needed.
- **Lockout Policy:** Adjust lockout thresholds and durations in `Form1.cs`.

---

## Security Notes

- Passwords are securely hashed before storage.
- Account lockout helps prevent brute-force attacks.
- Role-based access control restricts sensitive operations.

---

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

---

## License

This project is licensed under the MIT License.

---

## Contact

For questions or support, please open an issue on GitHub.

