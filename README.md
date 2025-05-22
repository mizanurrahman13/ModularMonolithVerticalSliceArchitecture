# Building a Modular Monolith With Vertical Slice Architecture in .NET

"You shouldn't start a new project with microservices, even if you're sure your application will be big enough to make it worthwhile." — Martin Fowler. I bet you have heard this phrase. And it exists for a reason.

Modern application development often pushes teams toward microservices, but this architecture isn't always the best starting point. Because microservices, while flexible, are "premium" solutions with high complexity, overhead, and operational costs. Moreover, when starting with microservices, your development speed is limited because you need to coordinate multiple services together, often in different repositories.

So is it better to start a project with a good old Monolith? Not exactly.

A Modular Monolith offers the best parts of two worlds from a Monolith and Microservices Architectures. It combines the simplicity of development and deployment while providing clear boundaries between modules.

## Table of Contents

- [Getting Started](#getting-started)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/mizanurrahman13/ModularMonolithVerticalSliceArchitecture.git
   ```
2. Navigate to the project directory
   ```sh
   cd ModularMonolithVerticalSliceArchitecture
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Migrations:
   Follow docs folder Migration Commands file

## Architecture Overview

Clean Architecture in .NET 9 ensures modularity by separating concerns into distinct layers, while Vertical Slice Architecture organizes code around features, keeping all relevant logic together for better maintainability and developer efficiency.

## Features

- **Built with .NET 9**: Utilizes the latest features for efficient development.
- **Clean Architecture**: Clean Architecture in .NET 9 promotes a modular, maintainable, and scalable software structure by separating concerns into distinct layers—Domain, Application, Infrastructure, and Presentation—ensuring dependency inversion, testability, and flexibility while preventing business logic from being tightly coupled to frameworks or external systems.
- **Vertical Slice Architecture** : Vertical Slice Architecture in .NET 9 organizes code by features instead of layers, keeping all relevant logic—data access, business rules, and API endpoints—together in self-contained slices, improving maintainability, scalability, and developer efficiency by reducing unnecessary abstractions and dependencies.
- **PostgreSQL**: PostgreSQL is an open-source, scalable, and extensible database with ACID compliance, advanced query optimization, strong security, and robust community support..
- **EF Core**: Popular .NET ORM.

## Technologies Used

- **.NET 9**
- **Clean Architecture**
- **Vertical Slice Architecture**
- **PostgreSQL**
- **EF Core**

## Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Create a Pull Request

## License

Distributed under the MIT License. See `LICENSE` for more information.
