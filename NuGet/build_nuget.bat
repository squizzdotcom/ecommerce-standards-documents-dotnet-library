@ECHO OFF

ECHO Ensure a 'Release' build of the library has been completed and that
ECHO the Package.nuspec file has been updated with the correct version
PAUSE

copy ..\Source\bin\Release\EcommerceStandardsDocuments.dll EcommerceStandardsDocuments\lib\net4\EcommerceStandardsDocuments.dll
NuGet.exe pack EcommerceStandardsDocuments\Package.nuspec

ECHO Generated NuGet package can now be pushed to repository
PAUSE