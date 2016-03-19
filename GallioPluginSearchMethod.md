# How does Gallio find my specifications? #

In the early stages of development with Gallio there has been a lot of issues with how Gallio finds the Concordion specifications and runs them.  This article hopes to resolve that issue by defining exactly how Concordion links a specification file to a fixture.

For the Gallio framework to find and execute the Concordion specifications the following requirements must be in place:

  1. Gallio must successfully find and load the Gallio.ConcordionAdapter plugin.  This plugin is specific to a version of Gallio so if the plugin is not being loaded you should verify that it works with the latest Gallio.
  1. Gallio must be searching the assembly where the specifications reside.  In Gallio.Echo this means that the assembly must be specified on the command line.  In Gallio.Icarus it means the assembly must be added to the current project.
  1. Gallio then searches the current assembly for two things.  If either condition is not present then the plugin will not explore the specification assembly for tests.
    1. The `[ConcordionAssembly]` attribute. This must be specified as an assembly-level attribute in your AssemblyInfo.cs (or other appropriate place) like so `[assembly:ConcordionAssembly]`
    1. The specification assembly must have a reference to the Concordion.dll assembly
  1. Gallio then searches all exported types (classes marked as public) looking for types with the `[ConcordionTest]` attribute.
  1. If an exported type with the `[ConcordionTest]` attribute on it is found then Gallio tries to execute the specification with Concordion and reports the results
  1. When Concordion finds a specification fixture to run it has to find the .html file that contains the specification itself.  It does this by:
    1. Removing the word Test from the end of the fixture name and appending .html to the end of the fixture name.  Thus, AccountTest.cs looks for Account.html
    1. It determines the directory the specification resides in by taking the namespace of the fixture and replacing the '.' with '\' and prepending the BaseInputDirectory from the specification configuration file.
    1. Example:  BaseInputDirectory of C:\Specifications, !Namespace of Com.MyCompany and Fixture of AccountTest.cs will look for its matching specification at C:\Specifications\Com\MyCompany\Account.html
  1. If all goes well Gallio will report successes and failures back to you!

# Caveats #

  * In build 0.1.31.94 and earlier the `[ConcordionAssembly]` attribute needs to take two parameters.  This is a bug.  The arguments are ignored by Concordion but need to be there.  You can place dummy values in the arguments.  **This is fixed in later versions**