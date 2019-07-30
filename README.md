# StoreAPI
StoreAPI coding challenge for Applaudo Studios

Collection StoreAPI - PostMan:
https://www.getpostman.com/collections/429d56b564f94a9e1e86

Database dump:
File in Git named: Database.sql
ConnectionString: "Server=localhost\\SQLEXPRESS;Database=StoreAPI;Trusted_Connection=True"
SQL Server 2014

Comments:
1. For front end I have build an SPA using VUE.JS:
    I have used Visual Studio Code for this part, and the folder for the front end is in this URL: 
2. For authentication I have used IdentityServer4 yet I have not implemented role-based authentication.
3. The API uses authorization "Bearer Token" JWT type.
4. It was intended to show images for each product, but I only did the upload part. The images are uploaded in a folder named "Uploads" inside wwwroot in the API.

URLs and ports:
The URLs and ports are in the properties for each project and also in the appsettings.json file in each project.
Authentication: AuthenticationStoreAPI(http://localhost:50847/)
API: StoreAPI(http://localhost:50237/)
Application: StoreAPIApplication(http://localhost:54500/)

Authentication:
The authentication uses de UserName for Login, not the email.
The user name must contain only these characters: "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789."

Users that already exists:
UserName: administrator19
Password: Administrator19

UserName: administrator89
Password: Administrator89

To create a new user, the password must have the following format:
1. The required lenght is: 6 characters.
2. It requires digits.
3. It requires upper case.
