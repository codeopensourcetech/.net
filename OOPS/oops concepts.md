The two most fundamental core concepts on which OOP has been built upon in C# are this pointer and Dynamic Dispatch.

Obviously, there are principles like Encapsulation, Polymorphism, Abstraction, and Inheritance, but these are the consequence and not the generating force behind the OO paradigm in C#.

## Polymorphism
Polymorphism means one thing in many form.Basically polymorphism is capability of one object to behave in multiple ways. Example : A man role changes at home, college, and outside the home. There are following types of polymorphism :

Static polymorphism(compile time) :It is achieved using function overloading and operator overloading.

Dynamic polymorphism(runtime time) : It is achieved using function overriding means using virtual function.

## Encapsulation
Encapsulation is a mechanism of binding the data member & member function into a single unit known as class.Encapsulation provides a way for abstraction.In OOP the encapsulation is mainly achieved by creating classes, the classes expose public methods and properties. The class is kind of a container or capsule or a cell, which encapsulate the set of methods, attribute and properties to provide its indented functionalities to other classes.
Encapsulation is implemented by using access specifiers. An access specifier defines the scope and visibility of a class member. Available access specifiers are public, private, protected, internal etc

## Abstraction
Data abstraction is a mechanism to provide the essential features without describing the background details. Means provide the functions to access the hidden (private) data.

The importance of abstraction is derived from its ability to hide irrelevant details and from the use of names to reference objects. Abstraction is essential in the construction of programs. It places the emphasis on what an object is or does rather than how it is represented or how it works. Thus, it is the primary means of managing complexity in large programs.

## Encapsulation vs Abstraction
Abstraction and Encapsulation are related features in object oriented programming. Abstraction allows making relevant information visible and Encapsulation enables a programmer to implement the desired level of abstraction. That means hidden part of class acts like Encapsulation and exposed part of class acts like Abstraction.

## Inheritance
Inheritance in OOP allows us to create a new class using an existing one meaning extending one class to another.

## Abstract Class:
The abstract keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class.
Cannot create instance of an abstract class.
All functions not having an implementation should be marked with keyword abstract in an abstract class.

The sealed keyword enables you to prevent the inheritance of a class or certain class members that were previously marked virtual.

