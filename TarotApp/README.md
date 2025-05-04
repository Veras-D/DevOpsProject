# Tarot Card Reader

A simple Tarot card application built with Avalonia UI and .NET.

## Features

- Draw random Tarot cards from the Major Arcana
- Display card image and name
- Dark mode UI
- Cross-platform (Windows and Linux)

## Requirements

- .NET 8.0 SDK

## Development Setup

1. Clone the repository:
```bash
git clone https://github.com/yourusername/tarot-app.git
cd tarot-app
```

2. Restore the dependencies:
```bash
dotnet restore
```

3. Run the application:
```bash
dotnet run
```

## Building the Application

### For Linux:
```bash
dotnet publish --runtime linux-x64 --configuration Release -p:PublishSingleFile=true --self-contained true -o release/linux
```

### For Windows:
```bash
dotnet publish --runtime win-x64 --configuration Release -p:PublishSingleFile=true --self-contained true -o release/windows
```

## Docker Support

Build the Docker image:
```bash
docker build -t tarot-app .
```

Run the Docker container:
```bash
docker run --rm -it tarot-app
```

## Testing

Run the tests:
```bash
dotnet test
```

## Release Process

1. Create a new tag with version number:
```bash
git tag v1.0.0
git push --tags
```

2. GitHub Actions will automatically build and create a release with binaries for Linux and Windows.

## License

This project is licensed under the MIT License - see the LICENSE file for details.
