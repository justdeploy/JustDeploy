
@set PKG_DIR="..\..\..\packages"
@set COPY_OPTS=/Y /F /R /D

c:\windows\system32\xcopy %COPY_OPTS% "%PKG_DIR%\Common.Logging.2.0.0\lib\2.0\*" .
c:\windows\system32\xcopy %COPY_OPTS% "%PKG_DIR%\Common.Logging.Log4Net.2.0.0\lib\2.0\*" .
c:\windows\system32\xcopy %COPY_OPTS% "%PKG_DIR%\log4net.1.2.11\lib\net40-full\*" .
