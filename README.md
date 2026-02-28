# 🧮Commission Calculator — Implementation Notes

> This document describes how to run, test, and the key design decisions made during implementation..

---

## 🚀 How to Run the Application
### ▶ Backend (.NET API)
1.Navigate to the API project folder: 

cd api

dotnet restore

dotnet run

### ▶ Frontend (React App)

1 Navigate to the UI folder:

cd ui

npm install

npm start

---

## 🧪 How to Test
Option 1 — Using Swagger

Open Swagger:

http://localhost:5111/swagger

Execute:

POST /Commision

Sample Request:

{
  "localSalesCount": 10,
  "foreignSalesCount": 10,
  "averageSaleAmount": 100
}

Expected Response:

{
  "avalphaTechnologiesCommissionAmount": 550,
  "competitorCommissionAmount": 95.5
}

Option 2 — Using Frontend

Enter values in the form.

Click Calculate Commission.

Results will display in the UI.

If invalid input is provided, a meaningful error message will be shown.
---

## ⚙️ Key Design Decisions
1️⃣ Service Layer Abstraction

Business logic was moved to a dedicated CommissionService and exposed through ICommissionService to:

Follow SOLID principles

Improve testability

Keep controllers lightweight

2️⃣ DTO Models

Separate request and response DTOs were created to:

Maintain clear API contracts

Avoid exposing internal logic

Support future extensibility

3️⃣ Centralized Validation

Validation logic was extracted into a CommissionValidator class to:

Enforce clean separation of concerns

Keep controller focused only on orchestration

Enable easier maintenance

4️⃣ Frontend Structure

Frontend was structured using:

Models (DTO mapping)

Service layer (API communication)

Utility for error handling

Clean React component

This improves maintainability and separation of responsibilities.

5️⃣ Error Handling
Backend returns proper HTTP status codes.

Frontend displays meaningful error messages.



## 🧪 Suggested Test Cases

If expanded further, the following test scenarios would be covered:

✅ Valid Input

Local: 10

Foreign: 10

Average: 100

Expected Avalpha: 550

Expected Competitor: 95.5

✅ Zero Values

Local: 0

Foreign: 0

Average: 100

Expected result: 0

❌ Negative Input

Any negative value

Expected: 400 Bad Request

❌ Extremely Large Input

Sales count > 1,000,000

Expected: Validation error
