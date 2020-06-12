# **Parks Lookup API**

#### Author: **_Jessica Hvozdovich_**
#### June 12, 2020

### Description

_This application demonstrates the building of an API with C#/.NET Core. The Park Lookup API catalogs national and state park data, with a few fantastical locations sprinkled in as well. It has full CRUD functionality that can be accessed in a user-friendly Swagger interface._

### Instructions for use:
1. Open Terminal (macOS) or PowerShell (Windows)
2. To download the API project Directory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/jhvozdovich/parks-lookup.git
cd parks-lookup (or the file name you created for the main Directory of the download)
```
3. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project Directory you can open all of the files with the command:
```
code .
```
4. Create a file within the ParksLookup subfolder named appsettings.json.
5. Add the following code:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=jessica_hvozdovich;uid=root;pwd=epicodus"
  }
}
```
* Add your MySQL password and make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.
<!-- 
IF MVC IS ADDED:
6. To download the MVC project Directory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/jhvozdovich/park-lookup-mvc.git *****USE CORRECT URL
cd park-lookup-mvc (or the file name you created for the main Directory of the download)
```
7. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project Directory you can open all of the files with the command:
```
code .
``` -->


#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local Instance 3306 with the password you set.

#### To create a local version of the database:
1. Open a terminal within your code editor.
2. Within the open API directory, navigate to the ParksLookup folder with the following command:
```
cd ParksLookup
```
3. Run the following command to recreate the project's database structure:
```
dotnet ef database update
```
4. Verify that the database structure is present by refreshing the MySQL workbench schemas. There should now be a directory for jessica_hvozdovich.
5. To run the database on your local host, run the following commands:
```
dotnet restore
dotnet build
dotnet run
```
6. The Swagger documentation for this project is accessible from the home directory of the local host. Click on the http://localhost:5000 link in your terminal that appeared after the dotnet run command or paste the link to the local host in your browser.
7. To test API calls in Swagger:
* CLick on a tab for one of the Methods.
* In the expanded view for the method click "Try it out"
* GET: Enter any optional search parameters (name: Yosemite) or required search parameters(id: 1)
* POST/PUT/DELETE: If the method changes information in the database, specify the id if necessary and enter any new information in the fields provided by in the "Request body" section and select "application/json" from the dropdown.
* Click Execute to run your command.

8. If the user would rather test the API calls in Postman, the paths are described as the User Input in the paths below. 

##### Example for Read:
* Select GET from the dropdown menu
* Paste the following in the Request URL bar:
```
http://localhost:5000/api/parks/
```
* Click Send, successful responses will return a 200OK result along with a list of all parks that have been seeded or added to your local database.
* If there is a "could not get response" error be sure the program is still running at http://localhost:5000 

##### Example for Create:
* Select POST from the dropdown menu
* Paste the following in the Request URL bar:
```
http://localhost:5000/api/parks/
```
* In the Body tab, select the raw button and JSON from the dropdown.
* Paste your new park in the body text box with information in the following format:
<!-- UPDATE WHEN COMPLETED -->
```
{
  "Name": "ENTER PARK NAME",
  "Classification" : "ENTER STATE OR NATIONAL",
  "State": "ENTER PARK STATE",
  "Hours": "ENTER PARK HOURS",
  "PhotoUrl": : "ENTER PHOTO URL"
}
```
* Click Send, successful responses will return a 200OK result.
* If there is a "could not get response" error be sure the program is still running at http://localhost:5000 
* To easily access the format of Post/Put requests - run a GET request and copy the format of the JSON response returned.


<!--  IF MVC IS FINISHED
#### To run the MVC program:
To install the necessary dependencies and start a localhost, after replicating the database and ensuring it is also running on a different session (Example: API on port 5000, MVC on port 5006), run the following commands:
```
dotnet restore
dotnet build
dotnet run
``` -->

### Known Bugs

No bugs have been identified at the time of this update.


### Support and Contact Information

_Have a bug or an issue with this application? [Open a new issue](https://github.com/jhvozdovich/parks-lookup/issues) here on GitHub._

### Technologies Used

* C#
* `ASP.NET` Core
* Swagger
* MySQL
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User can view all Parks** | User Input:"GET api/parks" | Output: “List of all Parks” |
| **User can view Details for each Park** | User Input:"GET api/parks/ENTERIDNUMBER" | Output: ""Name": "Yosemite",  "Classification": "National", "State": "California", "Hours": "24/7", "Landmarks":{ Yosemite Valle","Half Dom","Yosemite Falls", "PhotoUrl": : "www.sample.com""|
| **User can Add a Park** | User Input:"POST api/parks" --- "Name": "Yosemite", "Classification": "National", "State": "California", "Hours": "24/7", "PhotoUrl": : "www.sample.com""| | Output: “200 OK” |
| **User can update a Park's Details** | User Input:"PUT api/parks/ENTERIDNUMBER" --- "Name": "Yosemite",   "State": "California", "Hours": "24/7", "Landmarks": {Yosemite Valley, Half Dome, Yosemite Falls}, "PhotoUrl": : "www.sample.com""| Output: "200 OK" |
| **User can delete Parks** | User Input:"DELETE api/parks/ENTERIDNUMBER" | Output: “200 OK” |
| **User can search for a Park by Name** | User Input:"GET /api/parks?name=Yosemite" | Output: ""Name": "Yosemite",  "Classification": "National", "State": "California", "Hours": "24/7", "Landmarks":{ Yosemite Valley, Half Dome, Yosemite Falls }, "PhotoUrl": : "www.sample.com"" |
| **User can search for a Park by State** | User Input:"User Input:"GET /api/parks?state=California" | Output: ""Name": "Yosemite", "Classification": "National", "State": "California", "Hours": "24/7", "Landmarks": {Yosemite Valley, Half Dome, Yosemite Falls}, "PhotoUrl": : "www.sample.com"" |
| **User can search for a Park by multiple parameters** | User Input:"User Input:"GET /api/parks?name=Yosemite&state=California" | Output: ""Name": "Yosemite", "Classification": "National", "State": "California", "Hours": "24/7", "Landmarks": {Yosemite Valley, Half Dome, Yosemite Falls}, "PhotoUrl": : "www.sample.com"" |
| **User can view all Landmarks** | User Input:"GET api/landmarks" | Output: “List of all Landmarks” |
| **User can view Details for each Landmark** | User Input:"GET api/parks/ENTERIDNUMBER" | Output: ""new Landmark { "landmarkId": 1, "parkId": 1, "name": "Yosemite Valley" }"|
| **User can Add a Landmark** | User Input:"POST api/landmarks" --- "parkId": 1, "name": "Yosemite Falls"  | Output: “200 OK” |
| **User can update a Landmark's Details** | User Input:"PUT api/parks/ENTERIDNUMBER" --- "parkId": 1, "name": "Yosemite Fallz"| Output: "200 OK" |
| **User can delete Landmarks** | User Input:"DELETE api/parks/ENTERIDNUMBER" | Output: “200 OK” |
| **User can search for a Landmark by Name** | User Input:"GET /api/parks?name=Yosemite" | Output: {"landmarkId": 1, "parkId": 1, "name": "Yosemite Valley"},{"landmarkId": 2, "parkId": 1, "name": "Yosemite Falls"}|
| **User enters home page** | User Input:"URL: localhost:5000/" | Output: “Swagger API Documentation” |


### Stretch Goals
* MVC
* One to many relationship 

#### Resources
* [Yosemite Photo](https://www.nationalgeographic.com/content/dam/expeditions/destinations/north-america/private/Yosemite/Hero-Yosemite.ngsversion.1524840074980.adapt.1900.1.jpg)
* [Gravity Falls Illustration](https://vignette.wikia.nocookie.net/gravityfalls/images/2/22/Opening_Bigfoot.png/revision/latest?cb=20160119145704)
* [Zion Photo](https://www.nps.gov/npgallery/GetAsset/988A495E-155D-451F-67EE640C7B3812F6/proxy/hires?)
* [Everglades Photo](https://www.nps.gov/common/uploads/banner_image/akr/homepage/510DA558-1DD8-B71B-0BF2DBBE49B06F9F.jpg)

#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Jessica Hvozdovich_**