# MagicLandExplorer
Sure, here's the revised `README.md` with all instructions in Markdown language:

```markdown
# MagicLandExplorer

MagicLandExplorer is a console application that allows users to explore various destinations and perform operations on them based on predefined tasks. These tasks include filtering destinations by duration, finding the destination with the longest duration, sorting destinations alphabetically, and displaying the top 3 longest-duration destinations.

## Installation

### Clone the repository

Clone the repository to your local machine:

```bash
git clone https://github.com/your-username/MagicLandExplorer.git
```

### Build the project

1. **Navigate to the project directory:**

   ```bash
   cd MagicLandExplorer
   ```

2. **Build the project:**

   Open the solution file (`MagicLandExplorer.sln`) in Visual Studio and build the project to restore NuGet packages and compile the code.

## Usage

1. **Prepare the Data File:**

   Ensure you have a valid `MagicLandData.json` file placed in the `data` directory. If the file is missing or incorrectly formatted, the application will not function correctly.

   The structure of `MagicLandData.json` should be as follows:

   ```json
   [
     {
       "category": "Category Name",
       "destinations": [
         {
           "name": "Destination Name",
           "type": "Destination Type",
           "location": "Destination Location",
           "duration": "Duration in minutes",
           "description": "Description of the destination"
         },
         {
           "name": "Another Destination",
           "type": "Another Type",
           "location": "Another Location",
           "duration": "Another Duration",
           "description": "Another Description"
         }
       ]
     },
     {
       "category": "Another Category",
       "destinations": [
         {
           "name": "Destination Name",
           "type": "Destination Type",
           "location": "Destination Location",
           "duration": "Duration in minutes",
           "description": "Description of the destination"
         }
       ]
     }
   ]
   ```

2. **Run the Application:**

   Run the application using Visual Studio or by navigating to the project directory in the command line and executing:

   ```bash
   dotnet run
   ```

3. **Interact with the Application:**

   Once the application is running, follow the on-screen instructions to choose an option:

   - `1`: Show destinations with duration less than 100 minutes
   - `2`: Show destination with the longest duration
   - `3`: Sort destinations by name
   - `4`: Show top 3 longest-duration destinations
   - `5`: Exit

   Enter the corresponding number and press `Enter` to execute the selected operation.

## Contributing

Contributions are welcome! If you'd like to contribute to this project, fork the repository and create a pull request with your proposed changes.
```

