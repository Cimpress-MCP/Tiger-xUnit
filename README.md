# Tiger.xUnit

## What It Is

Tiger.xUnit is a library of useful assertions for the xUnit.net unit testing framework, making it easier to work with Tiger types returned by systems under test.

## Why You Want It

Tiger types are unfamiliar to unit testing frameworks, whose assertions typically work on straight-values. Many have variants, extensions, or modes of operation that work on collections, and it is on these that this library is modeled.

```
// arrange (omitted)

// act
var actual = sut.PerformAction(input); // returns Option<TSome>

// assert
var innerValue = Assert.Some(actual);
Assert.Equal(expected, innerValue);
```

xUnit.net's `Assert.Single` method takes a collection, asserts that the collection contains only one element, and returns that element for further testing. Following this pattern: `Assert.Some` takes an option value, asserts that it is in the Some state, and returns the Some value for further testing. The assertions provided for a type are as follows:

- `Option`: `TSome Assert.Some(Option<TSome>)`, `void Assert.None(Option<TSome>)`
- `Either`: `TLeft Assert.Left(Either<TLeft, TRight>)`, `TRight Assert.Right(Either<TLeft, TRight>)`
- `Result`: `Error Assert.Err(Result<TOk>)`, `TOk Assert.Ok(Result<TOk>)`
- `Try`: `Error Assert.Err(Try<TOk>)`, `TOk Assert.Ok(Try<TOk>)`, `void Assert.None(Try<TOk>)`

Specific exceptions are thrown for each kind of assertion failure, typed to inform xUnit that the test result was a failure, rather than an error.

## How You Develop It

This project is using the standard [`dotnet`](https://dot.net) build tool.

This repository is attempting to use the [GitFlow](http://jeffkreeftmeijer.com/2010/why-arent-you-using-git-flow/) branching methodology. Results may be mixed, please be aware.

## Thank You

Seriously, though. Thank you for using this software. The author hopes it performs admirably for you.
