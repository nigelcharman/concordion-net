# Introduction #

There are some minor differences in how the Java and .Net versions and operate with concordion.  These are listed below.

## HTML output ##

Some HTML output will differ between the .NET and Java versions of the Framework.  This is because of differences in how Java and .NET parse XML files.

## Exception Stack Trace Output ##

The stack traces will differ slightly in format from the Java and .NET versions of the framework but this is because of the different way that .NET outputs Exception messages.

## Run Command ##

The run command does not use the system properties like Java does, but instead uses information from the configuration.