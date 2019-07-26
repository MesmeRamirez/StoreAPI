# StoreAPI
StoreAPI coding challenge for Applaudo Studios

Collection StoreAPI - PostMan:
https://documenter.getpostman.com/view/8166245/SVSPmmCe

Database dump:
File in Git named: Database.sql
ConnectionString: "Server=localhost\\SQLEXPRESS;Database=StoreAPI;Trusted_Connection=True"
SQL Server

Comments:
1. For front end I have build an SPA using VUE.JS
2. For authentication I have used IdentityServer4
3. The API uses authorization "Bearer Token" JWT type.

Authentication:
The authentication uses de UserName for Login, not the email.
The user name must contain only these characters: "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789."

To create a new user, the password must have the following format:
1. The required lenght is: 6 characters.
2. It requires digits.
3. It requires upper case.
