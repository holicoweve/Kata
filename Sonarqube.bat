dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover 
SonarScanner.MSBuild.exe begin /k:"Kata" /d:sonar.host.url="http://localhost:9000" /d:sonar.login="33349dbaaa7e546da3b5fb1ee5834d365904b09a"
MsBuild.exe /t:Rebuild
SonarScanner.MSBuild.exe end /d:sonar.login="33349dbaaa7e546da3b5fb1ee5834d365904b09a"