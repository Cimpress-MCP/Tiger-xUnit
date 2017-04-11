# Tiger.xUnit

## What It Is

Tiger.xUnit is a library of useful assertions for the xUnit.net unit testing framework, making it easier to work with Tiger types returned by systems under test.

## Why You Want It

Tiger types are unfamiliar to unit testing frameworks, whose assertions typically work on straight-values. Many have variants, extensions, or modes of operation that work on collections, and it is on these that this library is modeled.

```csharp
// arrange (omitted)

// act
Option<TSome> actual = sut.PerformAction(input);

// assert
TSome innerValue = Assert.Some(actual);
Assert.Equal(expected, innerValue);
```

xUnit.net's `Assert.Single` method takes a collection, asserts that the collection contains only one element, and returns that element for further testing. Following this pattern: `Assert.Some` takes an option value, asserts that it is in the Some state, and returns the Some value for further testing. The assertions provided for a type are as follows:

- `Option`: `TSome Assert.Some<TSome>(Option<TSome>)`, `void Assert.None<TSome>(Option<TSome>)`
- `Either`: `TLeft Assert.Left<TLeft, TRight>(Either<TLeft, TRight>)`, `TRight Assert.Right<TLeft, TRight>(Either<TLeft, TRight>)`
- `Result`: `Error Assert.Err<TOk>(Result<TOk>)`, `TOk Assert.Ok<TOk>(Result<TOk>)`
- `Try`: `Error Assert.Err<TOk>(Try<TOk>)`, `TOk Assert.Ok<TOk>(Try<TOk>)`, `void Assert.None<TOk>(Try<TOk>)`

Specific exceptions are thrown for each kind of assertion failure, typed to inform xUnit that the test result was a failure, rather than an error.

## The Source Package

xUnit.net allows custom assertions to be added to its `Assert` class by taking a dependency on the package `xunit.assert.source` rather than `xunit.assert`. (The typical package `xunit` is a metapackage delivering `xunit.core` and `xunit.assert`.) This is the functionality that this package leans on, and it would be less useful if adding the Tiger extensions took that away. If this is required functionality, depend on these packages:

- `Tiger.xUnit.Source`

...and the Tiger extensions will be added in such a way that `Assert` can be further extended.

## How You Develop It

This project is using the standard [`dotnet`](https://dot.net) build tool. A brief primer:

- Restore NuGet dependencies: `dotnet restore`
- Build the entire solution: `dotnet build`
- Run all unit tests: `dotnet test`
- Pack for publishing: `dotnet pack -o "$(pwd)/artifacts"`

The parameter `--configuration` (shortname `-c`) can be supplied to the `build`, `test`, and `pack` steps with the following meaningful values:

- “Debug” (the default)
- “Release”

This repository is attempting to use the [GitFlow](http://jeffkreeftmeijer.com/2010/why-arent-you-using-git-flow/) branching methodology. Results may be mixed, please be aware.

## Thank You

Seriously, though. Thank you for using this software. The author hopes it performs admirably for you.
