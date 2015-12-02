@ECHO off
:: Uses the SQLCMD utility to run a SQL script that creates the FantasyFootballDB Database.

ECHO Attempting to create the FantasyFootballDB database...
sqlcmd -S localhost\SQLExpress -E /i Create_FantasyFootballDB.sql
ECHO.
ECHO If no error is shown the FatasyFootballDB was created successfully.
ECHO.
PAUSE