# CodeTestRjnm

Description: 
    Sample Payment System API that will return the ff. given a user account:
        - Balance
        - Payment List
            -- Date
            -- Amount
            -- status
            -- Remarks
                * Added field as it is necessary
                    - Transaction ID
                    - Transaction Description
                * should probably have the ff. fields but was left out as it was not mentioned in the User Story:
                    - Date Created & Posted

Assumptions:
1. Security Protocols are in place (Encryption, DDoS protection, etc.).
2. Client is authenticated and is expected to send the request.
3. For simplification, any account can be requested by client.

Technical Decisions:
1. Tech: ASP.NET Core
2. IDE: MS Visual Studio 2019
3. Data Storage: EF Core - Local Database(MS SQL)
4. Test Conducted: Functional Test
5. Database contents are kept short just to showcase what was tasked to do
6. Account Class is introduced to show how the feature can integrate to the whole system
7. Helper Class is introduce to allow modularization and prevent possible repetiti

Build and Run:
    Requirements:
        - MS Visual Studio 2019
        - MS SQL Server
        - ASP.NET Core Module/Hosting Bundle
        - IIS/APACHE SERVER

    Steps:
    1. Open Solution provided in Visual Studio 2019
        a. Load Database file provided (CodeTestRjnmDB) to an SQL Server
        b. Open "appsettings.json" and update the Connection String of the server where database was deployed
                * preferrable to use SQL Server Authentication to lessen steps after the update
        c. Optional: Run project in VS to ensure nothing was damaged and is working
    2. Publish Solution 
        a. Right Click the solution and Click Publish
        b. Choose the location to be published i.e. wwwroot folder
    6. After publishing
        a. IIS
              i. open IIS and Add a New Website
             ii. Select location where solution was published and provide DNS for the website
            iii. open hosts file and coonfigure local DNS for the website (c:\windows\system32\drivers\etc\hosts)
                i.e. "127.0.0.1        test.codetest.com"
        b. APACHE (LINUX)
              i. Create service file for .net app (/etc/systemd/system/ServiceFile.service)
             ii. Configure Service File to point to application DLL file
            iii. start the service
    7. Go to Application Pools in IIS and Set website's .NET CLR version to "No Managed Code" as we are hosting only .NET Core
    8. Browse to "<DNS>/api/PaymentHistory/<Account Number>"
        * Account Numbers Available: 
            - 11111111111
            - 22222222222
            - 33333333333

CI Deployment Notes:
1. Upload code to an online repository (i.e. Github, Azure Repos, Bitbucket, etc.) where Azure Devops is granted access to or can be configured to be.
    * An agent must be available to handle the tasks. 
2. Configure the build definition of the code (in this case, .NET Core)
3. Enable Continuous Integration to trigger build jobs when any change is introduced to the repo.
3. Release Pipelines can then be configured for CD. 
