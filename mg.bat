@echo off
setlocal

SET PYTHONPATH=%~dp0\src;%PYTHONPATH%
SET MG_INSTALLER=PIP

IF EXIST "%~dp0\python.exe" (
  "%~dp0\python.exe" -m msgraph.cli %* | more 
) ELSE (
  python -m msgraph.cli %* | more 
)
