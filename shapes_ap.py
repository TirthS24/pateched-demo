import math

class Shape:
    """Base class for different shapes."""
    def area(self):
        """Compute the area of the shape."""
        raise NotImplementedError("This method should be overridden in subclasses.")
    
    def perimeter(self):
        """Compute the perimeter of the shape."""
        raise NotImplementedError("This method should be overridden in subclasses.")

class Rectangle(Shape):
    def __init__(self, length, width):
        self.length = length
        self.width = width
    
    def area(self):
        return self.length * self.width
    
    def perimeter(self):
        return 2 * (self.length + self.width)

class Circle(Shape):
    def __init__(self, radius):
        self.radius = radius
    
    def area(self):
        return math.pi * self.radius ** 2
    
    def perimeter(self):
        return 2 * math.pi * self.radius

class Triangle(Shape):
    def __init__(self, side1, side2, side3):
        self.side1 = side1
        self.side2 = side2
        self.side3 = side3
    
    def area(self):
        # Use Heron's formula
        s = self.perimeter() / 2
        return math.sqrt(s * (s - self.side1) * (s - self.side2) * (s - self.side3))
    
    def perimeter(self):
        return self.side1 + self.side2 + self.side3

# Example usage
if __name__ == "__main__":
    rect = Rectangle(10, 5)
    print("Rectangle Area:", rect.area())
    print("Rectangle Perimeter:", rect.perimeter())

    circle = Circle(7)
    print("\nCircle Area:", circle.area())
    print("Circle Perimeter:", circle.perimeter())

    triangle = Triangle(3, 4, 5)
    print("\nTriangle Area:", triangle.area())
    print("Triangle Perimeter:", triangle.perimeter())
