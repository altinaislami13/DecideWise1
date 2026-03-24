# Architecture

## Layers

### Models
Represents core data like Option and Criterion.

### Services
Handles decision-making logic.

### Data
Implements Repository Pattern for file storage.

### UI
Handles user interaction via console.

---

## Design Decisions

- Used layered architecture for separation of concerns
- Used Repository Pattern to isolate data access

---

## SOLID Principles

- Single Responsibility Principle:
Each class has a single purpose.
Example: DecisionService handles logic, FileRepository handles storage.
Repository Pattern is used to separate data access logic from business logic.