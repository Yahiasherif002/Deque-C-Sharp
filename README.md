# DEQUE
This repository contains a C# implementation of a `Deque` (double-ended queue) data structure using a linked list.

## Overview

A `Deque` is a linear data structure that supports inserting and removing elements from both ends. This implementation utilizes a linked list to achieve constant time complexity for adding and removing elements at both the front and rear ends of the queue.

## Usage

To use the `Deque` class in your C# project, follow these steps:

1. Include the `Deque.cs` file in your project.
2. Create a `Deque` instance by specifying the type of elements it will store, for example:
    ```csharp
    Deque<int> deque = new Deque<int>();
    ```
3. Use the available methods to manipulate the `Deque`:
    - `Add(item)` / `AddFront(item)` / `AddRear(item)`: Add an element to the deque.
    - `RemoveFront()` / `RemoveRear()`: Remove and return the element from the front or rear of the deque.
    - `PeekFront()` / `PeekRear()`: Retrieve the element from the front or rear without removing it.
    - `Clear()`: Remove all elements from the deque.
    - `Count`: Get the number of elements in the deque.

## Example

```csharp
Deque<string> deque = new Deque<string>();

deque.AddRear("First");
deque.AddRear("Second");
deque.AddFront("Third");

Console.WriteLine(deque.RemoveFront()); // Output: Third
Console.WriteLine(deque.PeekRear());    // Output: Second