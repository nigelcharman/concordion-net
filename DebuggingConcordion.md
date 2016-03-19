# Introduction #

Debugging Concordion.NET in Visual Studio 2008 is fairly easy.  You use Gallio.Echo.exe to run the tests from the command-line from within your project.

You should open the properties for the Gallio.ConcordionAdapter project then:

  * Under Start Action, select your local Gallio.Echo.exe location (remember to use Gallio with the proper version)
  * Under command-line arguments, type:
```
/pd:Gallio.ConcordionAdapter\bin\Debug /runner:Local /wd:. Concordion.Spec\bin\Debug\Concordion.Spec.dll
```

this will use the current Gallio.ConcordionAdapter and Concordion.Spec project.  You may need to replace the reference to Concordion.Spec.dll with the path to your .dll.

  * Set the working directory to wherever is best for you, if you're working on the Concordion.Spec project then it's best to set it to the root of your working folder.

Here is what I have set up on my machine:

<img src='http://img245.imageshack.us/img245/4791/debuggingconcordionvs20.jpg' alt='Image Hosted by ImageShack.us' /><br />By <a href='http://profile.imageshack.us/user/x97mdr'>x97mdr</a> at 2009-05-09