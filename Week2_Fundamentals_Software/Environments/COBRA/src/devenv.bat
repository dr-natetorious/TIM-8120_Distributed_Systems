@ECHO ON
@SETLOCAL enableextensions enabledelayedexpansion
@SET base_path=%~dp0
@PUSHD %base_path%

@SET ImageName=cobra

@CALL docker build -t %ImageName% .
@IF NOT ERRORLEVEL 0 GOTO ERROR
@CALL docker run -it -v %base_path%:/src -w /src %ImageName% bash
@IF NOT ERRORLEVEL 0 GOTO ERROR
GOTO END

:ERROR
@ECHO Failed to perform the last step, exiting early.

:END
@POPD