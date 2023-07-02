# FileTimer

A console application to read/write dates from/to folders.

It uses several commands to achieve it

`o` -- opens a file to read/write. By default, when program is run, the file is set to be projectRoot/bin/.../FileTimer_{username}_data.txt.
When the file is parsed, all the dates from there are put into the local storage aka list of DateTimes

`u` -- adds a current date to the local storage
`r` -- prints all the dates from the local storage and calculates time between them
`s` -- saves all the changes to the file
`i` -- prints information about the program
`l` -- stops executing the program

This isn't a serious project but rather a task to understand how to work with the file streams in C#
