# System.Linq Exercises

This is as direct a port as possible from [Turing School's Ruby Enum Exercises](https://github.com/turingschool/enums-exercises.git) to C# [Microsoft LINQ](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/). Even this readme is largely identical; as a result, the same MIT license is carried forward.

## Setup

Clone this repository and build via your preferred method. If you have never executed a C# program, [Microsoft's Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/) may be of use.

## How the Exercises are Organized

These exercises are broken up by method -- each Linq method will be covered by
2 test files. In one test file, we'll practice using the Linq method
in question (`Select()`, `Find()`, etc). In the other, we'll look at how the Linq
method might be implemented in terms of the fundamental `for each` process.

## Solving the Exercises

After cloning the repository down, and checking out a new branch, we are ready
to get started on these Linq exercises.

The goal of these exercises is to help you understand Linq, both how
the methods work and how they can be replicated through the use of `for each`.

For each method, there are two files of interest. Let's look at `Select` as an example:

1. `exercises/SelectPatternTest.cs`
2. `exercises/SelectTest.cs`

In the `SelectPattern.cs` you'll find a collection of exercises which do what `Select()` is good at,
but they do it just with `for each`. This file will give us some insight into how select may work internally,
hopefully helping us gain a deeper understanding around when we might use each one.

Then, in the other file, `SelectTest.cs` you'll find the same examples using `Select` itself.
These examples will generally be much more concise, and will give a good demonstration
of how using the appropriate Linq method (as opposed to doing everything with `for each`)
can make our lives much easier!

__Running the Test Files__

Please refer to the [Microsoft Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/) or your IDE's ([rider](https://www.jetbrains.com/help/rider/Getting_Started_with_Unit_Testing.html#step-3-run-the-tests), [Visual Studio](https://learn.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2022)).

__Recommended Exercise Order__

You should perform the exercises in the order below:

* `Select`
* `Where`
* `Find`
* `Count`
* `Aggregate`
* `Any`
* `All`
* `GroupBy`

You should perform the pattern test first, and then the test.

For example, you should work on `SelectPatternTest.cs` followed by `SelectTest.cs`
Upon completing that, you should do `WherePatternTest.cs` and then
`WherePattern.cs` and so forth.

__Recommended Workflow__

Here's how we recommend you work through the exercises:

* Open your text editor with two panes (left and right)
* In the left pane, open the pattern file like `WherePatternTest.cs`
* In the right pane, open the matching file like `WhereTest.cs`
* Run the `WherePattern.cs` and solve the first exercise
* Run the `select_test.cs` and solve the same exercise
* Repeat for each matching pair of exercises
* Commit your solutions after finishing each file

## Contributing Patches

### Creating New Exercises

Check out master:

```bash
$ git checkout master
```

Create a new branch:

```bash
$ git checkout -b new-exercises
```

Make up one extra test for each test suite. Remember to delete the implementation once it's passing, and add a `skip` annotation to it.

```bash
$ git diff
$ git add -A
$ git commit -m "Add more exercises"
```

Push your branch up to GitHub:

```bash
$ git push -u origin new-exercises
```

Submit a pull request (go to the front page of your own `LinqExercises` repository, there should be a button to compare/create a pull request for the branch that you just pushed up).

### Keeping in sync with the upstream repository

`origin` is your fork of the project. We'll need to connect to the upstream repository.

To do this, add a new remote named upstream that points to the plato721 repository:

```bash
$ git remote add upstream git@github.com:plato721/LinqExercises.git
```

Then pull down the updated version of upstream:

```bash
$ git fetch upstream
```

And now make sure you're on master:

```bash
$ git checkout master
$ git branch # should say *master
```

Make master point to the exact commit that upstream/master is pointing at:

```bash
$ git reset --hard upstream/master
```

## License

The MIT License (MIT)

Copyright (c) 2014 Jumpstart Lab
