
# YouTube Tools

YouTube Tools is a Windows Forms application built with C# that automates the process of playing YouTube videos using Selenium WebDriver. This tool allows you to open multiple instances of YouTube videos, mute them, and play them automatically. It supports headless mode, preventing detection by YouTube, and can handle random delays between actions.

## Features

- Open multiple instances of YouTube videos.
- Mute video playback.
- Headless mode for running without a visible browser window.
- Random delay between actions to mimic human behavior.
- Prevent detection by YouTube through various Chrome options.
- Automatic replay of videos after a specified interval.

## Requirements

- .NET Framework
- ChromeDriver
- Selenium WebDriver

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/YouTubeTools.git
   ```

2. Open the solution in Visual Studio.

3. Restore the NuGet packages.

4. Build the project.

## Usage

1. Launch the application.
2. Enter the YouTube video key (e.g., `En-CLgCWiZk`).
3. Set the number of instances to open.
4. Choose the desired options:
   - Headless mode
   - Mute audio
   - Prevent detection
   - Random delay
5. Click the "Run" button to start the process.
6. Click the "Stop" button to stop the process.

## Code Overview

The main logic of the application is in the `FrmMain` class, which inherits from `Form`. Key functionalities include:

- `OpenVideo`: Opens a new YouTube video in a new browser window and starts playing it.
- `GetElement`: Retrieves a web element using XPath with a specified wait time.
- `Start`: Initializes the ChromeDriver, sets options, and starts the video playback process.
- `Stop`: Stops the video playback process and cleans up resources.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgments

- [Selenium WebDriver](https://www.selenium.dev/)
- [ChromeDriver](https://sites.google.com/chromium.org/driver/)
