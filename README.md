# 🚖 RideHailing - Enterprise-Grade Microservices Backend

[![.NET 8](https://img.shields.io/badge/.NET-8.0-purple)](https://dotnet.microsoft.com/)
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-16-blue)](https://www.postgresql.org/)
[![Apache Kafka](https://img.shields.io/badge/Apache%20Kafka-3.x-black)](https://kafka.apache.org/)
[![Redis](https://img.shields.io/badge/Redis-7.x-red)](https://redis.io/)
[![Microsoft Orleans](https://img.shields.io/badge/Orleans-8.x-orange)](https://dotnet.github.io/orleans/)
[![Clean Architecture](https://img.shields.io/badge/Architecture-Clean-green)](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)

> **High-performance, scalable ride-hailing platform engineered with Domain-Driven Design (DDD), CQRS, and Event-Driven Architecture (EDA) principles. Built for distributed systems, real-time operations, and horizontal scalability.**

---

## 🏗️ Architectural Excellence

### Clean Architecture Implementation
Leveraging **Onion Architecture** principles with strict dependency inversion, ensuring maximum testability, maintainability, and framework independence. The domain layer remains pristine—completely agnostic to infrastructure concerns.

### Technology Stack

#### Core Framework
- **.NET 8** - Latest LTS with native AOT compilation support
- **C# 12** - Leveraging primary constructors, collection expressions, and enhanced pattern matching
- **ASP.NET Core 8** - Minimal APIs with source generators for optimal performance

#### Persistence Layer
- **Entity Framework Core 8** - Code-first with Fluent API configuration
- **PostgreSQL 16** - ACID-compliant RDBMS with JSONB support
- **Npgsql** - High-performance .NET data provider with prepared statements
- **Repository Pattern** - Abstraction over data access with Unit of Work implementation

#### Distributed Systems
- **Apache Kafka** - Event streaming platform for eventual consistency
- **Microsoft Orleans** - Virtual Actor Model for stateful, distributed computations
- **Redis** - In-memory data structure store for distributed caching and session management

#### Security & Authentication
- **BCrypt.NET** - Adaptive hashing with configurable work factor (2^11 iterations)
- **JWT (JSON Web Tokens)** - Stateless authentication with RS256 asymmetric signing

#### Design Patterns & Principles
- **SOLID Principles** - Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion
- **Domain-Driven Design (DDD)** - Rich domain models, value objects, aggregates, and bounded contexts
- **CQRS** - Command Query Responsibility Segregation
- **Repository Pattern** - Data access abstraction with generic implementation
- **Unit of Work** - Transactional consistency across multiple repositories

#### Observability & Monitoring
- **Serilog** - Structured logging with multiple sinks
- **OpenTelemetry** - Distributed tracing with W3C Trace Context propagation

#### DevOps & Infrastructure
- **Docker** - Containerization with multi-stage builds
- **GitHub Actions** - CI/CD pipelines with automated deployments

---

## 📁 Project Structure

```
RideHailing/
│
├── RideHailing.Domain/               # 🎯 Core business logic (no dependencies)
│   ├── Entities/                     # Rich domain entities with behavior
│   │   ├── BaseEntity.cs            # Audit fields (Id, CreatedAt, UpdatedAt)
│   │   └── User.cs                  # Aggregate root with encapsulation
│   └── Enums/                        # Type-safe constants
│       └── UserRole.cs
│
├── RideHailing.Application/          # 📋 Use cases & business orchestration
│   └── Interfaces/                   # Abstractions (Repository, Services)
│       ├── IUserRepository.cs
│       └── IPasswordHasher.cs
│
├── RideHailing.Infrastructure/       # 🔧 External concerns implementation
│   ├── Persistence/                  # EF Core DbContext, Migrations
│   │   └── RideHailingDbContext.cs
│   ├── Repositories/                 # Repository implementations
│   │   └── UserRepository.cs
│   ├── Security/                     # Authentication, Hashing
│   │   └── PasswordHasher.cs
│   └── DependencyInjection.cs       # Service registration
│
├── RideHailing.Contracts/            # 📦 DTOs (decoupled from domain)
│   ├── Requests/                     # Inbound API models
│   │   └── Auth/
│   │       └── RegisterUserRequest.cs
│   └── Responses/                    # Outbound API models
│       └── Auth/
│           └── RegisterUserResponse.cs
│
└── RideHailing.Api/                  # 🌐 HTTP entry point
    ├── Controllers/                  # RESTful endpoints
    ├── Program.cs                    # Startup configuration
    └── appsettings.json             # Configuration
```

---

## 🚀 Getting Started

### Prerequisites
- .NET 8 SDK
- PostgreSQL 16
- Docker (optional)

### Setup

1. **Clone the repository**
```bash
git clone https://github.com/somyasubham9/RideHailing.Api.git
cd RideHailing
```

2. **Update connection string** in `RideHailing.Api/appsettings.json`
```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=RideHailingDb;Username=postgres;Password=yourpassword"
}
```

3. **Run migrations**
```bash
cd RideHailing.Infrastructure
dotnet ef migrations add InitialCreate --startup-project ../RideHailing.Api
dotnet ef database update --startup-project ../RideHailing.Api
```

4. **Run the application**
```bash
cd ../RideHailing.Api
dotnet run
```

5. **Open Swagger UI**
```
https://localhost:7XXX/swagger
```

---

## 📊 Current Progress

### ✅ Completed (Sprint 1 - PBI #1)
- Domain entities (User, BaseEntity)
- Repository pattern implementation
- EF Core DbContext with Fluent API
- BCrypt password hashing
- Clean Architecture foundation
- DI configuration

### 🔄 In Progress
- User registration API endpoint
- JWT authentication
- Driver entity

---

## 🎓 Learning Outcomes

This project demonstrates mastery of:
- Clean Architecture & Separation of Concerns
- Domain-Driven Design tactical patterns
- Repository Pattern with Unit of Work
- Entity Framework Core & Fluent API
- Dependency Injection
- Async/Await patterns
- SOLID principles in practice

---

## 👨‍💻 Author

**Somya Subham**  
Backend Developer

---

## ⭐ Star this repository if you find it helpful!

*Built with ❤️ using Clean Architecture principles*
