# VendingMachingCapstone
Module 1 capstone at Tech Elevator

Software Functionality:
-The user can navigate through the command line and perform many actions like choosing to display the vending machine items, feed the machine money, select and purchase a product, receive change and see a message based on what they purchased.
-The vending machine is stocked via an input file which includes the name, slot location, type of product and price.
-As the user inputs money there is a current money provided line which updates as the user purchases items.
-If the user wants to go back and see the vending machine items they will see that the quantity is updated.
-When the user decides to finish transaction they receive proper change, the machine's balance is updated to $0 and they receive a special message based on what was purchased.
-With each purchase it is logged to an audit file where I can view the date purchased, time of purchase, type of action performed and also see the user's balance and the machine's balance.

Technology:
Software written using C# in Visual Studio 2017. Also utilized file I/O.

Features to Come:
-I would like to update the software so it uses a database instead of a file
-Add different vending machines with different types of products
-Write a detailed sales report with the gross amount of sales included
