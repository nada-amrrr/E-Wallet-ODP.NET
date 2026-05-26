# 💳 E-Wallet Application

A desktop e-wallet application built in **C# / WinForms** connected to an **Oracle Database** via **ODP.NET**. The app supports user authentication, balance management, money transfers, deposits, and withdrawals — with all transaction logic handled through Oracle stored procedures.

---

## 📌 Overview

This project simulates a real-world digital wallet system where users can:
- Log in securely with a username, password, and 4-digit PIN
- View their current wallet balance
- Transfer money to other users with PIN verification
- Deposit and withdraw funds
- View their full transaction history
- See their linked bank accounts

---

## ✨ Features

- **User Authentication** — login with username + password
- **PIN Verification** — required for all money transfers
- **Wallet Transfers** — send money to another user by ID, with balance and PIN checks
- **Deposits & Withdrawals** — add or remove funds from wallet
- **Transaction History** — view all past transactions (sent & received) ordered by date
- **Linked Banks** — each user can be linked to multiple Egyptian banks
- **Error Handling** — handles wrong PIN, insufficient balance, sender/receiver not found, and DB errors with rollback

---

## 🗄️ Database Schema

### Tables

| Table | Description |
|---|---|
| `user_data` | Stores user accounts (id, username, email, password, PIN, balance) |
| `banks` | List of Egyptian banks |
| `userbanks` | Many-to-many relationship between users and their linked banks |
| `Transactions` | All transactions (transfers, deposits, withdrawals) with status |

### Sequences
- `seq_user_id` — auto-generates user IDs starting from 21
- `seq_transaction_id` — auto-generates transaction IDs starting from 31

### Stored Procedures

| Procedure | Description |
|---|---|
| `view_balance` | Returns balance for a given user ID |
| `get_user_balance` | Returns user ID, balance, and PIN by username |
| `get_transactions_by_user` | Returns full transaction history for a user (sent & received) |
| `getuserbanks` | Returns all banks linked to a user |
| `make_wallet_transfer` | Executes a transfer with PIN check, balance check, and rollback on failure |

---

## 🏦 Seeded Data

The database comes pre-loaded with:
- **20 users** with balances ranging from 3,100 to 15,800 EGP
- **12 Egyptian banks** including National Bank of Egypt, Banque Misr, CIB, QNB Al Ahli, HSBC Egypt, and more
- **30 transactions** covering transfers, deposits, and withdrawals with statuses: SUCCESS, FAILED, PENDING

---

## 🛠️ Tech Stack

| Technology | Role |
|---|---|
| C# / .NET | Application logic |
| Windows Forms (WinForms) | Desktop GUI |
| Oracle Database | Data storage |
| ODP.NET | Oracle-to-.NET database connector |
| PL/SQL | Stored procedures and sequences |

---

## 🚀 How to Run

### Prerequisites
- Visual Studio 2019 or later
- Oracle Database (XE or full) installed and running
- ODP.NET (Oracle.ManagedDataAccess) NuGet package

### Setup
1. Run the `Oracle database script.txt` in your Oracle SQL client (SQL*Plus or SQL Developer) to create tables, insert data, and create stored procedures
2. Open the solution in Visual Studio
3. Update the connection string in the code with your Oracle DB credentials:
   ```
   Data Source=localhost/XE;User Id=YOUR_USER;Password=YOUR_PASSWORD;
   ```
4. Build and run the project (`F5`)

---

## 📁 Project Structure

```
E-Wallet-ODP.NET/
├── E-wallet code/
│   └── WinFormsApp3/        # C# WinForms application source code
└── Oracle database script.txt   # Full Oracle DB setup script
```

---

## ⚙️ Transfer Logic (Stored Procedure)

The `make_wallet_transfer` procedure handles all transfer validation:

1. Checks if the **receiver exists**
2. Validates the **sender's PIN**
3. Checks for **sufficient balance**
4. Updates both balances and **logs the transaction**
5. **Rolls back** on any unexpected error

Possible status responses: `completed`, `wrong pin`, `insufficient balance`, `receiver not found`, `sender not found`, `error`
