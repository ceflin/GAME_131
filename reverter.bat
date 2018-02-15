@echo off
cls

set /P userChoice=Enter 1, 2, or 3 for soft, mixed, or hard reset: 
echo Your choice: %userChoice%

if "%userChoice%"=="1" GOTO :SOFTRESET
if "%userChoice%"=="2" GOTO :MIXEDRESET
if "%userChoice%"=="3" GOTO :HARDRESET

:SOFTRESET
set /P checkChoice=Are you sure you want to reset (Y or N): 
if "%checkChoice%"=="Y" set /P doubleCheck=Are you really sure you want to reset (Y or N): 
if "%checkChoice%"=="N" GOTO :EXIT

if "%doubleCheck%"=="Y" git reset --soft HEAD~
if "%doubleCheck%"=="N" GOTO :EXIT

:MIXEDRESET
set /P checkChoice=Are you sure you want to reset (Y or N): 
if "%checkChoice%"=="Y" set /P doubleCheck=Are you really sure you want to reset (Y or N): 
if "%checkChoice%"=="N" GOTO :EXIT

if "%doubleCheck%"=="Y" git reset --mixed HEAD~
if "%doubleCheck%"=="N" GOTO :EXIT

:HARDRESET
set /P checkChoice=Are you sure you want to reset (Y or N): 
if "%checkChoice%"=="Y" set /P doubleCheck=Are you really sure you want to reset (Y or N): 
if "%checkChoice%"=="N" GOTO :EXIT

if "%doubleCheck%"=="Y" git reset --hard HEAD~
if "%doubleCheck%"=="N" GOTO :EXIT

:EXIT
exit /b