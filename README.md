# ClarityEmailSender

**ClarityEmailSender** is a reusable and asynchronous C#/.NET library designed to simplify sending emails across multiple applications. It includes robust features like retry logic, logging, and Excel export of email attempt data. Easily integrate it with a console app, Web API, or frontend.

---

## 🚀 Features

- ✅ Asynchronous email sending using SMTP
- 🔁 Automatic retry logic (up to 3 attempts)
- 📊 Logging of email attempts (with optional Excel file export)
- 🔐 Appsettings-based configuration for credentials
- 🌐 API-ready and frontend-compatible architecture
- ♻️ Reusable service for other .NET apps

---

## 📦 Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/mark-pruisner/ClarityEmailSender.git
   ```
2. Open the solution in Visual Studio or VS Code.
3. Restore dependencies (if using a `.csproj`-based structure):
   ```bash
   dotnet restore
   ```

---

## ⚙️ Configuration

Update your `appsettings.json` file with your SMTP credentials:

```json
{
  "EmailSettings": {
    "SmtpServer": "smtp.example.com",
    "Port": 587,
    "Username": "your_email@example.com",
    "Password": "your_password",
    "From": "your_email@example.com",
    "EnableSsl": true
  }
}
```

Make sure to **exclude sensitive settings** from source control by using `.gitignore` or `appsettings.Development.json`.

---

## 🧪 Usage Example

```csharp
var emailService = new EmailService(_logger, _config);
await emailService.SendEmailAsync("recipient@example.com", "Subject", "Body text");
```

---

## 📁 Project Structure (Planned or Actual)

```
ClarityEmailSender/
│
├── EmailService.cs           # Core async email logic
├── RetryPolicy.cs            # Handles retry logic
├── ExcelLogger.cs            # Logs to .xlsx
├── appsettings.json          # Configurable SMTP and settings
├── Controllers/              # (Optional) API Controllers
├── WebFrontend/              # (Optional) ASP.NET Frontend
└── README.md                 # Project info and usage
```



