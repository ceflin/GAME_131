@echo off
cls

set /P userChoice=Do you wish to pull or fetch: 

if "%userChoice%"=="pull" GOTO :PULL
if "%userChoice%"=="fetch" GOTO :FETCH
else GOTO :EXIT

:PULL
git pull

:FETCH
set /P userRemote=Enter the name of the remote you wish to fetch from (or origin): 
echo You chose: %userRemote%
git fetch %userRemote%

:EXIT
echo I'm sorry I didn't understand your choice. 
exit /b