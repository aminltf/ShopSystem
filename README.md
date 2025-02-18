# 🛍️ ShopSystem - Modern E-commerce Backend  

ShopSystem is a modern **e-commerce backend system** built with **.NET 8, EF Core, and GraphQL**.  
It follows **Modular Monolith and Clean Architecture** principles, utilizing **CQRS, MediatR, and Repository Pattern** for a scalable and maintainable structure.  

## 🚀 Key Features  
✅ **GraphQL API** for flexible and efficient data retrieval  
✅ **CQRS Pattern** to separate read and write operations  
✅ **MediatR** for decoupled request handling  
✅ **Entity Framework Core** for database interactions  
✅ **SOLID Principles** for clean and maintainable code  

---

## 📂 Project Structure
📦 ShopSystem
┣ 📂 src
┃ ┣ 📂 ShopSystem.API → API Layer (GraphQL)
┃ ┣ 📂 ShopSystem.Application → Business Logic Layer (CQRS, MediatR)
┃ ┣ 📂 ShopSystem.Domain → Domain Models and Value Objects
┃ ┣ 📂 ShopSystem.Infrastructure → Database and Identity Management (EF Core)
┃ ┣ 📂 ShopSystem.Modules → Modular Feature Implementations
┃ ┃ ┣ 📂 🛒 Products → Products Module
┃ ┃ ┣ 📂 📦 Orders → Orders Module
┃ ┃ ┣ 📂 👥 Customers → Customers Module
┃ ┗ 📂 ShopSystem.Persistence → Database Context and Configurations
┣ 📂 tests → Unit Tests
┗ 📜 README.md → Documentation
