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

### <ins>Exercise02 - Polymorphism</ins>

#### Write a program to read the data for N products (N provided by the user). At the end, display the price tag for each product in the same order in which they were entered.

#### Every product has a name and a price. Imported products have a customs fee, while used products have a manufacturing date.

#### These specific data must be added to the price tag as shown in the example. For imported products, the customs fee must be added to the product's final price.

#### Please implement the program according to the design shown on the side.

<img src="Images/Exercise02-Polymorphism-UML.png" alt="Exercise02-Polymorphism-UML">

#### Example:

Enter the number of products: <strong>3</strong><br>
Product #1 data:<br>
Common, used or imported (c/u/i)? <strong>i</strong><br>
Name: <strong>Tablet</strong><br>
Price: <strong>260.00</strong><br>
Customs fee: <strong>20.00</strong><br>
Product #2 data:<br>
Common, used or imported (c/u/i)? <strong>c</strong><br>
Name: <strong>Notebook</strong><br>
Price: <strong>1100.00</strong><br>
Product #3 data:<br>
Common, used or imported (c/u/i)? <strong>u</strong><br>
Name: <strong>Iphone</strong><br>
Price: <strong>400.00</strong><br>
Manufacture date (DD/MM/YYYY): <strong>15/03/2017</strong><br>

PRICE TAGS:<br>
Tablet  $280.00 (Customs fee: $20.00)<br>
Notebook $1100.00<br>
Iphone (used) $400.00 (Manufacture date: 15/03/2017)

### <ins>Exercise03 - Abstract Methods</ins>

#### Write a program that reads the data of N shapes (where N is provided by the user) and then displays the areas of these shapes in the same order in which they were entered.

<img src="Images\Exercise03 - Abstract Methods.png" alt="Exercise03 - Abstract Methods">

#### Example:

Enter the number of shapes: <strong>2</strong><br>
Shape #1 data:<br>
Rectangle or Circle (r/c)? <strong>r</strong><br>
Color (Black/Blue/Red): <strong>Black</strong><br>
Width: <strong>4.0</strong><br>
Height: <strong>5.0</strong><br>
Shape #2 data:<br>
Rectangle or Circle (r/c)? <strong>c</strong><br>
Color (Black/Blue/Red): <strong>Red</strong><br>
Radius: <strong>3.0</strong><br>

SHAPE AREAS:<br>
20.00<br>
28.27