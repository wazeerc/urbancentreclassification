Overview

You will use the foundational C# skills you've been developing and apply them to manage and analyse
population data stored in a text file. This assignment will be an introduction to reading, processing, adding, and
deleting data. A report will be produced calculating some interesting statistics.

The Task

You are to write a C# application that can classify a urban center as either a city, town orrural area.
Classification is based on the following table:

Category Population
City > 50,000
Town 5,000-50,000
Rural < 5,000

The data is maintained in a text file. Your program must be able to open and read the information from the text
file. This information will be used to calculate the summary report. Any additions, updates or deletion of data
will need to be saved to a file. When saving, thought will need to be given whether you overwrite the existing file
or create a new file. You must use the open and save file form, from the .NET framework, to locate the file to
ope and/or save the file.

Your application needs to provide the following functionality:
display the urban center, population and classification
add a urban centerrecord
delete a urban centerrecord
browse records (next/previous)

The report will be displayed to the screen and should include:
total number of urban centre
total population
average population
largest population
smallest population

Data File format

All the data is loaded from a text file. The population data is in a tabularformat, one record perline as a text file.
Any changes made should be saved to a text file. If line is blank or begins with a '#' it can be ignored. A record
will be on its own line with field separated by a comma. Each record will contain the following information:
urban centre name
urban centre population

The Design

Make sure you understand what is required before you sit down to write the program. The design of the
program, including the GUI, is to be completed by yourself. The following ideas are just suggestions; you may
have otherideas. If you get inspiration from other programs, forums, please make sure you reference them
within the comments in your code.
The data is stored in a text file. How and when will you load the data? Will you store the data in an array or a list?
How will you display the loaded data, as a list box orin a form? How and when will you save any changes to the
data? Will you overwrite the existing file or will you provide a save-as functionality.
Think about how you will input the details when adding a record; will this be a form consisting label and text
boxes. Make sure you perform input validation? When you add a new record, what happens if there is already
have a record forthat urban centre ?
Browsing the data is the ability to move forward and backwards through the records. One idea would be to
display the records in a list box and allowing the userto scroll up and down through the list. If using a list box,
can you select a record in the list to delete the record? Perhaps it will just be a form and you use next and
previous buttons?
Each line of the file is a string. You will need to extract the population form the line to be able to classify the
urban centre as either a city, town orrural area. To do this you do will need to do some string processing. Have
a look at Chapter 8 of the text book for some hints on string processing. Don't forget to validate the input form
the file. What are some of the way a record can be invalid? Wrong order, missing a field? Is a blank line an error?
What will you do if a record is invalid, display an error message, stop processing or continue?
Can you break down the application into smaller step? Think about other programs you have written. Are there
any similar elements? Have you done a tutorial on how to read the contents of a file or write a file to disk?
Forthe report, how do you want to display the information to the screen? Will the information be display on the
main window, in a message box, in a tab or as anotherform? When will the information be displayed,
automatically or will the user need to hit a generate report button? Calculate by had the total, average, largest
and smallest population value, for one record, then two records etc. YOu can use these calculations to check
you program is working as expected.

