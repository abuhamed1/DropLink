# DropLink Downloader 🚀

A professional, multi-tier desktop application built with C# and .NET Windows Forms for downloading YouTube videos and extracting high-quality audio files.

## Features ✨
- **Multi-Format Downloads:** Support for multiple video qualities (1080p, 720p, 480p, 360p, 240p, 144p).
- **Audio Extraction:** High-quality "Audio Only (MP3)" conversion feature.
- **Asynchronous Execution:** Built with background threading (`Task.Run`) to keep the user interface smooth and responsive during long processes.
- **Live Logging System:** Real-time console output mapping directly onto the UI layout.
- **Data Persistence:** Integrated history tracking powered by SQL Server database records.

## Architecture 🏛️
The project is built using a clean, scalable **N-Tier Architecture** pattern divided into:
1. **DropLink (UI Layer):** Windows Forms interface handling user input and thread synchronization.
- **DropLinkBusinessLayer (BLL):** Core management layer configuring execution logic and process monitoring.
- **Domains (Domain Layer):** Shared enterprise entities accessible across all functional scopes.

## Technology Stack 🛠️
- **Language:** C#
- **Framework:** .NET Framework / .NET Core
- **Database:** Microsoft SQL Server
- **Core CLI Utility:** Powered by `yt-dlp` core libraries.

## License 📄
This project is licensed under the MIT License - feel free to use, modify, and distribute!
