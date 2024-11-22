# Geometric Shapes Calculator Library

This library provides a collection of classes for calculating geometric properties of basic shapes in multiple programming languages (Python, JavaScript, and C#).

## Features

- Calculate area and perimeter for:
  - Rectangles
  - Circles
  - Triangles

## Implementation Details

The library is implemented in three languages:

### Python (shapes_ap.py)
- Abstract `Shape` base class
- Concrete implementations for Rectangle, Circle, and Triangle
- Methods for calculating area and perimeter
- Simple and straightforward API

### JavaScript (shapes_ap1.js)
- JavaScript implementation of the shapes library
- Follows similar structure to Python version

### C# (shapes_ap2.cs)
- Full C# implementation with abstract base class
- Strongly typed implementation
- Includes a Program class with usage examples
- Demonstrates calculating area and perimeter for all shapes

## Usage Example (C#)

```csharp
// Create a rectangle
var rect = new Rectangle(10, 5);
Console.WriteLine(rect.Area());      // Calculate area
Console.WriteLine(rect.Perimeter()); // Calculate perimeter

// Create a circle
var circle = new Circle(7);
Console.WriteLine(circle.Area());
Console.WriteLine(circle.Perimeter());

// Create a triangle
var triangle = new Triangle(3, 4, 5);
Console.WriteLine(triangle.Area());
Console.WriteLine(triangle.Perimeter());
```

## Class Structure

Each shape implementation includes:
- Constructor for shape-specific parameters
- Area calculation method
- Perimeter calculation method

### Available Shapes

1. **Rectangle**
   - Parameters: length, width
   - Area = length × width
   - Perimeter = 2(length + width)

2. **Circle**
   - Parameters: radius
   - Area = πr²
   - Perimeter = 2πr

3. **Triangle**
   - Parameters: side1, side2, side3
   - Area calculated using Heron's formula
   - Perimeter = sum of all sides

## Requirements
- Python 3.x for Python implementation
- Modern JavaScript runtime for JS implementation
- .NET environment for C# implementation
