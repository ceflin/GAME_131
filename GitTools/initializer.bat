@ echo off
cls

set /P myUserName=Please enter your username: 
set /P myEmail=Please enter your email: 
REM echo Username: %myUserName%
REM echo Email: %myEmail%

set /P clone=Do you wish to clone a repository or create a new one (clone or new): 
if "%clone%"=="new" goto :CREATENEWREPO
if "%clone%"=="clone" goto :CLONEREPO
else echo I'm sorry I didn't understand your input.


:CREATENEWREPO
git init
goto :CONFIGGIT

:CLONEREPO
set /P myRepo=Please enter the URL of your repository: 
echo Repository URL: %myRepo%

git clone %myRepo%

set/P repoName=Enter the name of the repository folder: 
cd %repoName%
goto :CHECKBRANCH

:CHECKBRANCH
set /P branchName=Enter the name of your new branch: 
git branch %branchName%
git checkout %branchName%

:CONFIGGIT
git config user.name "%myUserName%"
git config user.email "%myEmail%"
