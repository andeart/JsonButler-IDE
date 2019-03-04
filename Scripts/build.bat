@echo off

set configurationName=%1
set runTests=%2

if not "%configurationName%"=="Release" (
    set "configurationName=Debug"
)

nuget restore ./JsonButlerIde/JsonButlerIde.sln

REM A bit of a hassle to ensure we're always calling the latest MSBuild available on the system.
REM Especially true in our case because of this error: https://social.msdn.microsoft.com/Forums/vstudio/en-US/fd220999-5761-475a-bf86-98dff6b35218/unable-to-compile-vsix-project-that-is-a-part-of-my-solution-using-amd64-msbuild-from-vs2015?forum=msbuild
for /f "usebackq tokens=*" %%m in (`"%~dp0get-msBuild-path.bat"`) do (
    call %%m ./JsonButlerIde/JsonButlerIde.sln /p:Configuration=%configurationName% 
)

python ./Scripts/test.py "./JsonButlerIde/JsonButlerIde/bin/%configurationName%/JsonButlerIde.vsix"