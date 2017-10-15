# Pair Programming Workshop 
Projects in various languages for the PhillyXP Pair Programming / TDD Workshop requiring no configuration

## C# Project

Find the solution and project files in the csharp directory.
If you don't have a unit test runner in your IDE you can run tests via the command line by running the following command from the scripts directory

```
PS C:\..\pair-programming-workshop\csharp\scripts> .\runtests.bat 

```

## Javascript Project

The project is contained within the `javascript` folder, and assumes that you have node installed already. It comes pre-configured with a test runner, linting, and an .editorconfig file. You can use npm scripts to run the project and the tests.

``` javascript
npm install //(or yarn) to install necessary dependencies locally
npm start // to run the project with index.js as the entry point
npm test // to run tests added in the test folder
```

## Elixir Project

The project is contained within the `elixir` folder, and assumes that you have Elixir installed already. This project makes use of ExUnit, a built-in unit testing library for Elixir. Run the `mix test` command in the `elixir` directory to run the unit tests:

``` elixir
mix test
```