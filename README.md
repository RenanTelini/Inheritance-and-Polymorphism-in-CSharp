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

### <ins>Exercise01 - Polymorphism</ins>

#### A company has both regular and outsourced employees.

#### For each employee, the company wants to record their name, hours worked, and hourly rate. Outsourced employees also have an additional expense.

#### Employee payment is calculated as the hourly rate multiplied by the hours worked. Outsourced employees also receive a bonus corresponding to 110% of their additional expense.

#### Write a program to read the data for N employees (N provided by the user) and store them in a list. After reading all the data, display the name and payment of each employee in the same order in which they were entered.

<img src="Images\Exercise01-Polymorphism-UML.png" alt="Exercise01-Polymorphism-UML">

#### Example:

Enter the number of employees: <strong>3</strong><br>
Employee #1 data:<br>
Outsourced (y/n)? <strong>n</strong><br>
Name: <strong>Alex</strong><br>
Hours: <strong>50</strong><br>
Value per hour: <strong>20.00</strong><br>
Employee #2 data:<br>
Outsourced (y/n)? <strong>y</strong><br>
Name: <strong>Bob</strong><br>
Hours: <strong>100</strong><br>
Value per hour: <strong>15.00</strong><br>
Additional charge: <strong>200.00</strong><br>
Employee #3 data:<br>
Outsourced (y/n)? <strong>n</strong><br>
Name: <strong>Maria</strong><br>
Hours: <strong>60</strong><br>
Value per hour: <strong>20.00</strong>

PAYMENTS:<br>
Alex - $1000.00$<br>
Bob - $1720.00$<br>
Maria - $1200.00$