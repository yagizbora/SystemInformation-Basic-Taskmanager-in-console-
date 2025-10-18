# System Information — Basic Console Task Manager

A small C# console application that displays system information and provides a simple task manager interface. This project is intended as a learning/example program for examining basic system metrics and managing processes from the command line.

## Requirements

- .NET SDK 6.0 or newer (or the version used in the project)
- Windows / Linux / macOS — behavior may vary by platform, especially for process management and system metrics

## Build and Run

1. Clone the repository:
   ```bash
   git clone https://github.com/yagizbora/SystemInformation-Basic-Taskmanager-in-console-.git
   cd SystemInformation-Basic-Taskmanager-in-console-
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run --project ./Path/To/YourProject.csproj
   ```
   Or, if the repository contains a single console project in the root:
   ```bash
   dotnet run
   ```

## Usage

When you run the application you'll typically be presented with a simple text menu. Example interactions might include:

- View system summary
- List processes
- Select a process to view details (by PID)
- Terminate a process (by PID)
- Refresh data or exit

Be careful when terminating processes — killing system or critical processes may destabilize your machine.

## Contributing

Contributions, suggestions, and bug reports are welcome. If you'd like to contribute:

1. Fork the repository
2. Create a feature branch (git checkout -b feature-name)
3. Make your changes and add tests if appropriate
4. Submit a pull request describing your changes

## License

This repository does not include a license file. If you intend to share this project, consider adding a license (for example, MIT) to clarify how others can use it.

## Author

yagizbora

If you'd like, I can:
- Update this README to match the exact commands and project structure found in the repository (I can inspect the source files and adapt instructions).
- Add screenshots, examples, or a CONTRIBUTING.md and LICENSE file.

Tell me which of these you'd prefer next.
