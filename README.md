# Trade Categorizer
This is a simple console application that categorizes trades based on their value and client sector, following a set of rules.

## Technologies Involved
 - C#
 - .NET 7
 - xUnit
 - Sql server

## How to Use
- Clone this repository or download the source code.
- Open the solution in Visual Studio or any other C# IDE.
- Build the solution.
- Run the console application by pressing F5 or by selecting the "TradeCategorizer.Console" project as the startup project.
- The application will display the category of each trade.
- How to Execute Unit Tests
- Open the solution in Visual Studio or any other C# IDE.
- Build the solution.
- Open the Test Explorer.
- Click on "Run All" to run all unit tests.

## Rules
There are three category rules:

- LOWRISK: Trades with a value less than 1,000,000 and a client from the Public Sector.
- MEDIUMRISK: Trades with a value greater than or equal to 1,000,000 and a client from the Public Sector.
- HIGHRISK: Trades with a value greater than or equal to 1,000,000 and a client from the Private Sector.

If a trade does not match any of these rules, an InvalidTradeException is thrown.
