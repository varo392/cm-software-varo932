<<<<<<< HEAD
set TEXTTEST_HOME=%~dp0
cd %TEXTTEST_HOME%

if not exist "venv" (
    py -m venv venv
)

venv\Scripts\pip install texttest

if %ERRORLEVEL% GEQ 1 (
    pause
) else (
    venv\Scripts\texttestc.py -con %*
)
=======
set TEXTTEST_HOME=%~dp0
cd %TEXTTEST_HOME%

if not exist "venv" (
    py -m venv venv
)

venv\Scripts\pip install texttest

if %ERRORLEVEL% GEQ 1 (
    pause
) else (
    venv\Scripts\texttestc.py -con %*
)
>>>>>>> 6a4b9ba17e222d481b4320690b2cc76948ef446c
