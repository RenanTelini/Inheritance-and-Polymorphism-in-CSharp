# Inheritance and Polymorphism in C#

#### This exercise is based on the <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/?couponCode=MT260714G2">"C# COMPLETO Programação Orientada a Objetos + Projetos"</a> course.

### <ins>Upcasting and Downcasting</ins>

#### Upcasting
- Casting from subclass to superclass
- Common use: polymorphism

#### Downcasting
- Casting from superclass to subclass
- `as` keyword
- `is` keyword
- Common use: methods accepting generic parameters (ex: Equals)

### <ins>Override, Base and Virtual keywords</ins>

#### Override Method

- It is the implementation of a superclass method in the subclass.
- For a regular (non-abstract) method to be overridden, it must be declared with the `virtual` keyword.
- When overriding a method, the `override` keyword must be used.

#### Example:

#### Suppose the following withdrawal rules:

- Checking account: a fee of 5.00 is charged.
- Savings account: no fee is charged.

<img src="Images\Override, Base and Virtual Keyword.png" alt="Override, Base and Virtual Keyword">

#### How can this be solved? A: by overriding the withdraw method in the SavingsAccount subclass.

#### base Keyword

#### It is possible to call the superclass implementation using the base keyword.

#### For example, suppose the withdrawal rule for a savings account is to perform the withdrawal normally using the superclass (Account) implementation, and then deduct an additional 2.0.