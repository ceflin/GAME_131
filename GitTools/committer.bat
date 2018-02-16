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
GOTO :COMMIT

:COMMIT
set /P userComments=Enter the comment for this commit: 
git commit -m "%userComments%"
GOTO :PUSH

:PUSH
git push origin master