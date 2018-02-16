@echo off
cls

set /P userFiles=Enter the number of files you wish to add: 
echo %userFiles%

:REPEAT
if %userFiles% GTR 0 GOTO :ADDFILE

GOTO :STATUS


:ADDFILE
set /P fileName=Enter the name of the file you wish to add: 
echo Name of file to be commited: %fileName%
git add %fileName%
set /a userFiles -= 1
echo Number of files left: %userFiles% 
goto :REPEAT


:STATUS
git status
set /P remove=Do you wish to remove any files (Y or N): 
if "%remove%"=="Y" GOTO :REMOVEFILE
if "%remove%"=="N" GOTO :COMMIT
else echo I'm sorry I didn't understand your answer.
GOTO :STATUS

:REMOVEFILE
set /P fileRemove=Enter the name of the file you wish to remove: 
git remove %fileRemove%

:COMMIT
set /P userComments=Enter the comment for this commit: 
git commit -m "%userComments%"
GOTO :PUSH

:PUSH
git push origin master