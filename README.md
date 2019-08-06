# Airport Challenge in C#

## Objectives
I am learning C# and wanted to explore the language in further detail. I especially wanted to practice unit testing and mocking. One of the techniques Makers Academy taught us for learning new languages was to translate previous projects into the language we are learning which will help to grasp the syntax and equivalent tools. One of the projects that I thought would enable me to effectively explore the areas I want to is the Week 1 Airport Challenge, which I originally coded in Ruby <a href="https://github.com/jordantroberts/airport_challenge">here</a> and later JavaScript <a href="https://github.com/jordantroberts/JavaAir">here</a>.  

## Learnings

### Error Handling
I experimented with `try` and `catch` blocks and throwing Exceptions, which can be seen in an <a href="https://github.com/jordantroberts/CSharp-Airport/commit/80160dc63f5683b7437ca73a8a7cde02f9c9a723">earlier commit</a> but I decided not to keep this in after researching WHEN to throw Exceptions, which seems to be when there is an external problem and when something "exceptional" actually happens. I felt that for this small program, preventing the Plane object from landing through the code itself and informing the user of this via the console was sufficient. However, it was one of my objectives to explore error handling which is why I attempted this.

### Stubbing / mocking
I wanted to practice using Moq for mocking in my unit tests. I mocked the Weather object in my Airport tests to isolate the Airport that I wanted to test. I also stubbed the output of the weather to make sure that I could cover all test cases - e.g. when it's stormy and when it's sunny.

### Dependency injection
My reasoning for using dependency injection here is that a class should have one responsibility. An Airport is responsible for the coming and going of planes. It needs access to the weather information to make decisions but it is not responsible for determining the weather. Information about the weather should be provided by a separate class and injected as a dependency, which is what I attempted to implement.

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

## User Stories
```
As an air traffic controller
So I can get passengers to a destination
I want to instruct a plane to land at an airport

As an air traffic controller
So I can get passengers on the way to their destination
I want to instruct a plane to take off from an airport and confirm that it is no longer in the airport

As an air traffic controller
To ensure safety
I want to prevent takeoff when weather is stormy

As an air traffic controller
To ensure safety
I want to prevent landing when weather is stormy

As an air traffic controller
To ensure safety
I want to prevent landing when the airport is full

As the system designer
So that the software can be used for many different airports
I would like a default airport capacity that can be overridden as appropriate
```

## Acknowledgments
Jordan Roberts
(Originally a Makers Academy challenge)
