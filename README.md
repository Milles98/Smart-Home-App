# Smart Home App

Smart Home App is a WPF application designed to manage and control smart home devices.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Installation

1. Clone the repository:
git clone https://github.com/yourusername/smart-home-app.git

2. Open the solution in Visual Studio:
cd smart-home-app
start SmartHomeApp.sln

3. Build the solution:
    - In Visual Studio, go to `Build > Build Solution`.

## Usage

1. Run the application:
    - Press `F5` or go to `Debug > Start Debugging`.

2. Ensure all resources are correctly referenced:
    - Verify that all image files and other resources are in the correct directories.
    - Check that the properties of these files are set to "Copy to Output Directory" if necessary.

## Troubleshooting

### Common Issues

#### XamlParseException: Cannot locate resource

If you encounter an error similar to:System.Windows.Markup.XamlParseException: 'Provide value on 'System.Windows.Baml2006.TypeConverterMarkupExtension' threw an exception.'

This usually indicates that a resource file (e.g., an image) cannot be found. Ensure that:
- The file exists in the specified directory.
- The path in the XAML file is correct.
- The file's properties are set to "Copy to Output Directory".

## Contributing

1. Fork the repository.
2. Create a new branch:
git checkout -b feature/your-feature-name
3. Make your changes and commit them:
git commit -m "Add your commit message"
4. Push to the branch:
git push origin feature/your-feature-name
5. Open a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

    
    
    
    
