@echo off
cls

set /P userFiles=Enter the number of files you wish to add: 
echo %userFiles%

if %userFiles% GTR 0 GOTO :REPEAT

:REPEAT
set /P inputFile=Enter the name of the file you wish to add: 
git add %inputFile%
set userFiles -= 1
echo %userFiles%