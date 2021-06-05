# _Pierre's Sweet and Savory Treats_ 🍭
#### _This is our 12th week project for Epicodus that covers the basics for Many-to-Many relationships and Identity Authentication._
#### By _Jesse White_
## Technologies Used
* _CSHTML_ 📝
* _CSS_ 🎨
* _C#_ 🆒
* _.NET_ 🥅
* _MySql_ 💽
* _Entity Framework_ 🎞
* _Identity_ 🔐
## Description 📜
_Pierre is back and continues to grow his massive monopoly on the baked goods market. He has broken into the candy making business and needs a website to manage his different treats and flavors for customers to enjoy._
## Setup and Use 🏗

### Prerequisites 💻

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run and interact with the console app.
- [MySQL Community Server][https://dev.mysql.com/downloads/file/?id=484914]

### Installation

1. Clone the repository: `$ git clone {https://github.com/JesseDWhite/PierresSweets.Solution}`
2. Navigate to the `{PierresSweets.Solution}` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup a SQL database using MySQL:
   - Create an `appsettings.json` file in the `{PierresSweets}` directory
   - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:
   ```
     {
        "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Port=3306;database=jesse_white;uid=root;pwd=<password>;"
         }
     }
   ```
   - Open your terminal and run the command: `mysql -uroot -p<mysql_password>` (replace `<mysql_password>` with your MySQL password) and select the enter key to launch MySQL servers
5. To run the console app:
 - Navigate to `{PierresSweets.Solution/PierresSweets}` in your command line
   - Run the commands:
     - `dotnet restore` to restore the dependencies that are listed in `{PierresSweets.csproj}`
     - `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
     - `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
     - `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
     - `dotnet build` to build the project and its dependencies into a set of binaries
     - `dotnet tool install --global dotnet-ef` to install EF Core tools
     - `dotnet ef migrations add Initial` and `dotnet ef database update`
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
6. Visit the application via web browser at: `localhost:5000/`
## Known Bugs 🐛
* _Price only allows increments of $0.25._
* _User favorites page does not show favorites that have been added._
* _Buttons on some of the pages are in a bad spot with their sizing and position._
* _Background image does not fit the size of the page it the screen is minimized._
## License ⚖
_MIT © Jesse White 2021_
## Contact Information 🤳
Jesse White _jesse.white6@gmail.com_