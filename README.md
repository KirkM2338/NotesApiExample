
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

### Get Single Note
Route https://localhost:44363/note/#
Returns single note designated by ID in JSON 

### Create Note 
Route https://localhost:44363/note/createnote/

Example Body 
{
    "userName":"Kirk Montrose",
    "contents":"This is what a note is!",
    "Title":"Example :)"
 }
 
 ### Delete Note 
Route https://localhost:44363/note/delete/#
Deletes the note with designated by ID, 
This should return 200 status code on succces. 

EditNote
Route https://localhost:44363/noteapi/edit/#
Edits an existing note given a note ID and the updated body 

Example Payload 
{
    "userName":"Kirk Montrose",
    "contents":"Updated Content",
    "Title":"Example :) Update"
 }
  
 ### Create x random notes 
 Route  https://localhost:44363/noteapi/createrandomnotesfortesting/#
 This is simply for testing purposes for this example. This will create any number of notes passed as the aurgument. 
 To create the note, the API generates random numbers and letters for the title content and user name. 
 
 
 ### Further Information 
 Because this was an example i limited the capabilties just to what the assment was. If this was a real app, there would be many more features needed. 
 
 
 


