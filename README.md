#Introduction 
This is an utilities library created in order to be uploaded to a Nuget Private feed, in the scope of a NuGet PoC

#Getting Started


1.	Install the library in your project: 

		Install-Package AnalyticAlways.CommonToolsCore -Source "https://analyticalways.pkgs.visualstudio.com/_packaging/AlfaTeamFeed/nuget/v3/index.json"

2.	Software dependencies: .net core 1.1

3.	Use it:

		var isValid=RegexUtil.IsRegexPatternValid("WTF!");


#Build and Test
There is a VSTS build that bnuild the code, test it and finally push a NuGet package to the private feed 

#Contribute
Please don't spend your time trying to improve my fucking yeah library!