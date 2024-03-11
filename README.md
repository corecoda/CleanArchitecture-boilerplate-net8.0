# .NET Clean Architecture Project Structure

This repository provides a structured approach to kickstart your .NET projects, facilitating faster development and eliminating the initial project structuring hurdles by employing the clean architecture pattern.

## Repository Structure

The repository consists of two main solution folders:

### src

The `src` folder encapsulates the core implementation of the application. It is organized into five projects:

1. **Application**: Contains the business logic, entities, domain services, and interfaces.
2. **Domain**: Defines the database entity models.
3. **Persistence**: Implements interfaces and repositories defined in the Application layer, utilizing frameworks like Entity Framework or Dapper.
4. **Infrastructure**: Houses the software logic responsible for communication with the Data Plane through a software interface.

### test

The `test` folder contains the test project, enabling comprehensive testing of the application's functionalities.

## Getting Started

To get started with using this project structure for your .NET applications, simply clone this repository and begin customizing the projects based on your specific requirements.

## Contributing

Contributions to enhance this project structure or fix any issues are welcome! Feel free to fork this repository, make your changes, and submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
