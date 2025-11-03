# C# Fortune Teller Console App

A simple, interactive console application built with .NET and C# as a hands-on learning project. The app provides a personalized, randomly generated fortune to the user.

*(A great addition here would be a screenshot or an animated GIF of the application running!)*
``

## Features

### Current Features
* **Interactive Prompt:** Welcomes the user and asks for their name.
* **Personalized Greeting:** Uses the user's name to provide a friendly greeting.
* **Random Fortune Generation:** Selects a random fortune from a hardcoded list to display to the user.

### Planned Enhancements (Stretch Goals)
* **"Play Again" Loop:** A main menu that allows the user to ask for another fortune or exit the application.
* **Input Validation:** Gracefully handles empty or invalid user input.
* **External Fortune Storage:** Loads the list of fortunes from an external `fortunes.json` file.
* **OOP Design:** Refactors the project to use a `Fortune` class.
* **Visual Flair:** Adds `Thread.Sleep` for dramatic pauses and uses console colors to style the output.

## Tech Stack

* **Framework:** .NET 8
* **Language:** C#
* **Core Libraries:**
    * `System` (for `Console` I/O)
    * `System.Collections.Generic` (for `List<T>`)
    * `System.Random` (for random number generation)
* **Planned Libraries:**
    * `System.Text.Json` (for parsing `fortunes.json`)
    * `System.Threading` (for `Thread.Sleep`)

## Project Structure

```
FortuneTeller/
├── .gitignore
├── FortuneTeller.csproj    # .NET project file, manages dependencies
├── Program.cs              # Main application entry point and logic
├── fortunes.json           # (Future) External file to store fortunes
└── README.md               # You are here!
```

## Getting Started

### Prerequisites

* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (or higher)

### Installation & Running

1.  **Clone the repository (or set up your local project):**
    ```sh
    git clone [https://github.com/your-username/FortuneTeller.git](https://github.com/your-username/FortuneTeller.git)
    cd FortuneTeller
    ```

2.  **Run the application:**
    The simplest way to run the project is using the .NET CLI. This command will automatically restore dependencies, build, and run the app.

    ```sh
    dotnet run
    ```

### Available Scripts

* `dotnet run` - Compiles and runs the application.
* `dotnet build` - Compiles the project without running it.

### Application Flow

1.  **Welcome:** The application starts and displays a welcome message.
2.  **Get Input:** The user is prompted for their name, which is stored in a `string` variable.
3.  **Process:**
    * A `List<string>` holds all possible fortunes.
    * A `System.Random` object is created.
    * A random index is generated using `random.Next(fortunes.Count)`.
4.  **Display:** The application uses the random index to select a fortune from the list and displays it to the user.

### Learning Outcomes

This project is designed to teach and reinforce fundamental C# and .NET concepts:

* **.NET Project Management:** Using the `dotnet new console` and `dotnet run` commands.
* **C# Fundamentals:** Variables (`string`, `int`), string interpolation (`$"..."`), and console I/O (`Console.WriteLine`, `Console.ReadLine`).
* **Collections:** Using `List<T>` to store and access data.
* **Control Flow:** Using `if` statements and (eventually) `while` loops.
* **Core Libraries:** Using built-in classes like `Random`.
* **OOP (Stretch Goal):** Refactoring logic into separate methods and classes.
* **Data Serialization (Stretch Goal):** Reading and parsing a JSON file with `System.Text.Json`.

## Future Enhancements

Here is a brief roadmap of planned features:

* [ ] **Create "Play Again" Loop:** Implement a `while(true)` loop with a `switch` statement for a main menu (`1. Get Fortune`, `2. Exit`).
* [ ] **Add Input Validation:** Use an `if` statement to check `string.IsNullOrEmpty()` on the user's name and re-prompt if it's empty.
* [ ] **Load from JSON:**
    * Create `fortunes.json`.
    * Use `File.ReadAllText()` to read the file.
    * Use `JsonSerializer.Deserialize<List<string>>(...)` to parse the JSON into the `fortunes` list.
* [ ] **Add Color & Delay:** Use `Console.ForegroundColor` to change text color and `Thread.Sleep()` to add pauses before revealing the fortune.

## License

This project is open-source and available for educational purposes.
