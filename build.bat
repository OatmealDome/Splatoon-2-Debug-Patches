@echo off

rem ******************************************************************
rem 
rem  (c) 2018 OatmealDome
rem  Licensed under GPLv3
rem 
rem  <3 Simonx22
rem  Shoutouts to MasterF0x, Wii Sports, Khangaroo, and Dualie (3096)
rem 
rem  ******************************************************************

echo.
echo Cleaning up
echo.
rmdir /s /q build

echo.
echo Preparing build
echo.
mkdir build
mkdir build\Testfire
mkdir build\Splatfest-ZENYASAI\

echo.
echo Translating Testfire
echo.
MenuTranslator\precompiled\MenuTranslator.exe src\testfire.pchtxt src\english.json build\Testfire\ips-main.pchtxt

echo.
echo Translating Splatfest
echo.
MenuTranslator\precompiled\MenuTranslator.exe src\splatfest.pchtxt src\english.json build\Splatfest-ZENYASAI\ips-main.pchtxt

echo.
echo Build complete.
echo.

pause