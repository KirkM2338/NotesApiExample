
#Welcome to the Example Notes App!

## Overview 
This is a simple application that allows you to create, edit and view notes. Please note this is only the API, there is no frontend.  

This application was written with .NET core 3.1 and utilizes enitity framework for handling the data. For this app, note data will only be stored in local memory temporaly since this will not be distributed. However, if needed this could easily be attached to live sql database to store note contents. 

## Running the application 
Once the code is cloned locally. Open up the solution in Visual Studio. Next,to keep things simple just compile and run the code in the IIS express server. This should be all that is required to test this small API

## Notes Payload
Each note has the following information 

UserName - The user how creates the note
Title - note title 
Contents - the information in the note.
Create Date  - date created
Edit Date - Date last edited 


## Postman Validations. 
To simple testing this API I have added some pre-defined postman calls. in the following files  **Notes Example.postman_collection.json**

## Api Over

### Get All Notes
Route https://localhost:44363/note/createnote

Returns all notes created in JSON 

### Get Single Notes
Route https://localhost:44363/note/createnote/#
Returns single note designed by ID in JSON 


