# Description #
Concordion is an acceptance testing framework that allows users to place their specifications in HTML file.  These files contain references to fixtures in test code that are executed by Concordion.

So what exactly is Concordion?

## Who? ##

Concordion was developed for Java by David Peterson.  You can find his blog [here](http://blog.davidpeterson.co.uk/).  I managed to scratch together this port of Concordion for .NET!

Concordion is mainly aimed at the development team that consists of analysts/clients and developers working together in an agile fashion.  The analysts/clients work together with the developer to write the specifications in HTML.  The developers then write their fixtures in a .NET language and Concordion runs the two together producing red/green results like a unit test.

## What? ##

There is an excellent explanation of why Concordion is a better choice over other acceptance testing frameworks that require a lot of scripting (like Fit or Fitnesse) [here](http://www.concordion.org/Technique.html).

Basically the user provides a set of specifications written in HTML, and a set of matching fixtures written in a .NET language.  The user or developer can run these specifications using the Gallio framework which is available with a wide variety of runners.  Gallio provides the flexibility to run your tests in a wide variety of environments.

## When? ##

The Concordion.NET port is now in an Alpha stage of release.  Most of the language (except for concordion:run) is implemented fully by the port and full compliance with the Java version of the language is coming for the time of the Beta release.

It is anticipated that Concordion.NET will maintain stride with the Java releases in terms of functionality in the future.

## Where? ##

You can find lots of information about Concordion at the original site, http://www.concordion.org.  Information about the differences between the Java and .NET version and using Concordion with Gallio can be found in the wiki.

## Why? ##

I have been a user of fitnesse for over a year now.  While it met our initial needs there were a number of stumbling blocks.  Putting fitnesse pages in source control, executing fitnesse as part of continuous integration, exporting results of tests and the brittle-ness of the large scripts were all part of the reason we were looking for a replacement.

I saw the Concordion site and was intrigued.  While it still allowed HTML specification for end users its focus on putting the scripting in the backend fixtures where it could be easily maintained and refactored as a huge plus.  I found David's way of writing specs to be clear and concise ... plus ... the site was pretty!

## How? ##

Concordion.NET is written in C# on .NET 3.5. so you will need to have the .NET Framework 3.5 installed to be able to use it.  You will also need Gallio installed to be able to run your fixtures.