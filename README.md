# Airport Challenge in C#

## Objectives
I am learning C# and wanted to explore the language in further detail. I especially wanted to practice unit testing and mocking. One of the techniques Makers Academy taught us for learning new languages was to translate previous projects into the language we are learning which will help to grasp the syntax and equivalent tools. One of the projects that I thought would enable me to effectively explore the areas I want to is the Week 1 Airport Challenge, which I originally coded in Ruby <a href="https://github.com/jordantroberts/airport_challenge">here</a> and later JavaScript <a href="https://github.com/jordantroberts/JavaAir">here</a>.  

## Learnings

_Error Handling_
I experimented with `try` and `catch` blocks and throwing Exceptions, which can be seen in an <a href="https://github.com/jordantroberts/CSharp-Airport/commit/80160dc63f5683b7437ca73a8a7cde02f9c9a723">earlier commit</a> but decided not to keep this in after researching when to throw Exceptions, which seems to be when there is an external problem and when something "exceptional" actually happens. I felt that for this small program, preventing the user from doing so and telling them why on the console was sufficient. However I wanted to explore error handling and learning about how to do so and also how to catch them effectively.

_Stubbing / mocking_
I wanted to practice using Moq for mocking in my unit tests. I mocked the Weather object in my Airport tests to isolate the Airport that I wanted to test. I also stubbed the output of the weather to make sure that I could cover all test cases - e.g. when it's stormy and when it's sunny. 

_Dependency injection_
My reasoning for using dependency injection here is that a class should have one responsibility. An Airport is responsible for the coming and going of planes. It needs access to the weather information to make decisions but it is not responsible for determining the weather. Information about the weather should be provided by a separate class and injected as a dependency.

## Technologies used:
* C#
* NUnit for unit testing
* Moq for mocking

## How to run this program
1. Clone this repo
2. Open this program in Visual Studio.
3. Build and run the program. You can create / delete new airports and planes in the `Program.cs` file.

## How to test this program
1. Clone this repo
2. Open this program in Visual Studio.
3. If using Visual Studio Community, select 'Run Unit Tests' under 'Run'. This may be different if using a PC.

## Acknowledgments
Jordan Roberts
