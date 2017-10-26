# Pair Programming Workshop 

Projects in various languages for the PhillyXP Pair Programming / TDD Workshop requiring no additional configuration and minimal dependencies.

## C# Project

The solution and corresponding project files can be found within the `csharp` folder.
If you don't have a unit test runner configured for your IDE or editor you can run tests via the command line by running the following command from the scripts directory

```
PS C:\..\pair-programming-workshop\csharp\scripts> .\runtests.bat 

```
This project includes dependencies for unit testing ([NUnit](http://nunit.org/)) and stubbing / mocking ([Moq](https://github.com/moq/moq4)).

## Javascript Project

The project is contained within the `javascript` folder, and assumes that you have node installed already. It comes pre-configured with a test runner, linting, and an .editorconfig file. You can use npm scripts to run the project and the tests.

``` javascript
npm install //(or yarn) to install necessary dependencies locally
npm start // to run the project with index.js as the entry point
npm test // to run tests added in the test folder
```