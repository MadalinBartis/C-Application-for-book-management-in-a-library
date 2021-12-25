# C-Application-for-book-management-in-a-library

<p>This C# application for book management in a library is made in romanian language.</p> 

The project contains two Windows Form Aplication applications. The first form is a database connection application. This searches the user file for your name and password. If both are found, the application will connect to the database. Otherwise, an error message will be displayed.

If the application goes through the user connection phase, the application will open in the second form. In this phase, the following will be displayed: the card table, the search button, the add button, the loan button, and the delete button. The search will be done from two perspectives: the search according to the name of the book or according to the name of the author.

If the search mode is not selected, the program will display the answers according to both options (author + book).
The following fields will be specified for the add function: Title, Book Id, Author (Name, First Name, Author Id), Publisher, Year, Language, Quantity, Category. 
Books whose id already exists cannot be inserted.

The loan function has the fields: ID Card, Last Name, First Name, Address, Amount, From, To. After each loan transaction, the customer database will be automatically updated. If we modify the data of an existing customer, they will be overwritten over the data present in the database. For each loan operation, it will be necessary to specify the customer's data, quantity and loan periods, respectively.

A customer can borrow several books at once, but only the same type. If the number of cards requested by the customer is not sufficient, then an error message will be displayed. For the delete function it is necessary to select the books that we want to delete from the database, and then press the button.
In the case of both deletion and loan, selection from the displayed book table is required. Otherwise, an error message will be displayed.
Pressing the Ok button in any of the above cases will update the database. The Total Display button will display the entire database on the screen, and the Logout button will return to the first form, the login stage.

During the project, the program was tested repeatedly, and the following errors were corrected:
• the addition of the books is done even if the id exists in the database => corrected by checking the ids in the database, the addition being done after this stage
• the search is done only by writing the full name of the book / author => solved by using the LIKE operator
• the search had not taken into account the case where the search mode was not specified => solved by conditioning the search in both ways, in case of not specifying a mode.
• the loan was made, even if the amount was 0 => solved by a check


