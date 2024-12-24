# F# Mutable Tuple Bug

This repository demonstrates a subtle issue involving mutable variables within tuples in F#.  When a function takes a tuple containing mutable variables as an argument, modifications to those variables within the function do not affect the original variables outside the function's scope.

The `bug.fs` file contains code exhibiting this behavior. The `bugSolution.fs` file provides the correct approach to solve this, demonstrating how to update mutable variables within a tuple using a different strategy (not using tuples in the function definition).

## How to Reproduce

1. Clone this repository.
2. Open `bug.fs` in an F# editor.
3. Run the code. Observe that the mutable variables are not updated as expected within the tuple.
4. Open `bugSolution.fs` to review a working example. 

## Solution

The solution involves avoiding the use of tuples as function arguments for this particular use case, where in-place modifications are required.
