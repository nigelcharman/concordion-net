# I followed your configuration instructions and Gallio finds the assembly but no tests are loaded? #

There could be several reasons for this problem:

  1. Are your specification fixtures declared public? Gallio will only look for exported (or public) types so any specification fixture you declare must be declared public to be found.

  1. Is your specification fixture decorated with the `[ConcordionTest]` attribute?  The Gallio.ConcordionAdapter plugin will only consider classes with this attribute as a specification to run.

  1. To run Concordion tests properly Gallio must be using the Local runner.  See the Gallio help for more on this. (This is a bit of a limitation right now, but I hope to resolve this issue in the future)

  1. Does your specification assembly have the `[ConcordionAssembly]` attribute on it?

  1. Does your specification reference the Concordion.dll assembly?

  1. Can Concordion find the specification configuration file (is it in the same directory as your specification assembly)?

  1. Does the specification configuration file point to a valid BaseInputDirectory?

  1. Are your fixture/specification pairings properly named?  For example if my specification is Account.html then my fixture must be named AccountTest.cs otherwise Concordion cannot make the link.