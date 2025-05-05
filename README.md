# 🔮 Tarot Card Reader

[![Tests](https://github.com/veras-d/DevOpsProject/actions/workflows/test.yml/badge.svg)](https://github.com/veras-d/DevOpsProject/actions/workflows/test.yml)
[![GitHub release](https://img.shields.io/github/v/release/veras-d/DevOpsProject)](https://github.com/veras-d/DevOpsProject/releases)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A modern, cross-platform Tarot card application built with Avalonia UI and .NET 8, providing an intuitive interface for drawing and interpreting cards from the Major Arcana.

<div align="center"">
  <img src="https://i.imgur.com/zki0R5V.png"/>
</div>

## ✨ Features

- 🃏 Draw random Tarot cards from the Major Arcana deck
- 🖼️ Beautiful card imagery with detailed visuals
- 📱 Responsive design that works on various screen sizes
- 🌓 Elegant dark mode UI
- 🖥️ Cross-platform compatibility (Windows, Linux)
- 🐳 Docker support for containerized deployment

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or newer

### Installation

#### Download Release

Download the latest release for your platform from the [Releases page](https://github.com/veras-d/DevOpsProject/releases).

#### Build from Source

1. Clone the repository:
   ```bash
   git clone https://github.com/veras-d/DevOpsProject.git
   cd DevOpsProject
   ```

2. Restore the dependencies:
   ```bash
   dotnet restore
   ```

3. Run the application:
   ```bash
   dotnet run --project TarotApp
   ```

## 💻 Development

### Project Structure

```
├── TarotApp               # Main application project
│   ├── Models             # Data models
│   ├── Services           # Business logic
│   ├── ViewModels         # MVVM view models
│   └── Views              # UI components
└── TarotApp.Tests         # Unit tests
```

### Building the Application

#### For Linux:
```bash
dotnet publish TarotApp/TarotApp.csproj --runtime linux-x64 --configuration Release -p:PublishSingleFile=true -p:UseAppHost=true --self-contained true -o release/linux
```

#### For Windows:
```bash
dotnet publish TarotApp/TarotApp.csproj --runtime win-x64 --configuration Release -p:PublishSingleFile=true -p:UseAppHost=true --self-contained true -o release/windows
```

#### For macOS:
```bash
dotnet publish TarotApp/TarotApp.csproj --runtime osx-x64 --configuration Release -p:PublishSingleFile=true -p:UseAppHost=true --self-contained true -o release/macos
```

## 🐳 Docker Support

### Building the Docker Image

```bash
docker build -t tarot-app -f TarotApp/Dockerfile .
```

### Running the Container

```bash
docker run --rm -it tarot-app
```

## 📦 CI/CD Pipeline

This project uses GitHub Actions for continuous integration and deployment:

- **test.yml**: Runs on push to main/master/develop branches and pull requests
  - Builds the application
  - Runs all tests

- **release.yml**: Triggered when a tag is pushed
  - Builds the application for Windows and Linux
  - Creates release artifacts
  - Publishes a new GitHub Release

## 📝 Release Process

1. Update version number in relevant files
2. Create a new tag with version number:
   ```bash
   git tag v1.0.0
   git push --tags
   ```
3. GitHub Actions will automatically build and create a release with binaries for Linux and Windows.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/your-feature`)
3. Commit your changes (`git commit -m 'Add some new feature'`)
4. Push to the branch (`git push origin feature/your-feature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Buy Me a Ko-Fi
[![Ko-Fi](https://img.shields.io/badge/Ko--fi-F16061?style=for-the-badge&logo=ko-fi&logoColor=white)](https://ko-fi.com/verivi)

