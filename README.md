#Welcome to the Example Notes App!

## Overview 
This is a simple application that allows you to create, edit and view notes. 
Please note this is only the API, there is no frontend.  

This application was written with .NET core 3.1 and utilizes Entity Framework for handling the data storage. For this app, note data will only be stored in local memory temporally since this will not be distributed. However, if needed, this could easily be attached to live SQL database to store notes. 

## Running the application 
Once the code is cloned from github. Open up the solution in Visual Studio. Next, to keep things simple, just compile and run the code in the IIS express server. This should be all that is required to test this simple API. 

## Postman Validations. 
Once you have the IIS Server running, you can then begin to use this API. 
To test this API, I have added some pre-defined postman calls. in the following files **Notes Example.postman_collection.json** 

## Notes Payload
Each note has the following information 

UserName - The user how creates the note
Title - note title 
Contents - the information in the note.
Create Date  - date created
Edit Date - Date last edited 


## API Overview

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
This should return 200 status code on success. 

###Edit Note
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
 This is simply for testing purposes for this example. This will create any number of notes passed as the argument. 
 To create the note, the API generates random numbers and letters for the title content and user name. 
 
 
 ### Further Information 
 Because this was an example i limited the capabilities just to what the assment was. If this was a real app, there would be many more features needed. 
 I also ran out of time, but there are a few unit tests that i would have liked to add to this. 
 
 
