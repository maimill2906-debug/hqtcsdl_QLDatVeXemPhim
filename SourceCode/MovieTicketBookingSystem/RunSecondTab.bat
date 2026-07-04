@echo off
cd /d "%~dp0"
copy /y bin\Debug\net48\MovieTicketBookingSystem.exe bin\Debug\net48\MovieTicketBookingSystem_Temp.exe >nul
copy /y bin\Debug\net48\MovieTicketBookingSystem.exe.config bin\Debug\net48\MovieTicketBookingSystem_Temp.exe.config >nul
start bin\Debug\net48\MovieTicketBookingSystem_Temp.exe
exit
