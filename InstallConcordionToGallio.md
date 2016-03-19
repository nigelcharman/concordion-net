# Requirements #

You will need the following:

  * Gallio v3.0.5.546
  * Concordion.NET v0.1.21.66

# Procedure #

## Install Gallio ##

Get Gallio v3.0.5.546 [(x86)](http://mb-unit.googlecode.com/files/GallioBundle-3.0.5.546-Setup-x86.msi) or [(x64)](http://mb-unit.googlecode.com/files/GallioBundle-3.0.5.546-Setup-x64.msi) and run the .msi file to install Gallio.  See www.gallio.org for more information on Gallio.

## Install Concordion ##

Get Concordion.NET from the [Downloads](http://code.google.com/p/concordion-net/downloads/list) page.

Unzip the file to a location on your hard drive.  This location will be referred to as CONCORDION\_NET\_HOME from now on.

<img src='http://img525.imageshack.us/img525/1140/concordionhome.jpg' alt='Image Hosted by ImageShack.us' />

## Hook up Concordion.NET and Gallio Icarus ##

Start up Gallio and start a new project to remove any old lingering assemblies, etc.

<img src='http://img185.imageshack.us/img185/8809/gallioicarusmain.jpg' alt='Image Hosted by ImageShack.us' />

Then open the Tools->Options dialog boxes to identify a plugin.  Put the path to your CONCORDION\_HOME and press Add Plugin Directory.

<img src='http://img185.imageshack.us/img185/3626/addplugin.jpg' alt='Image Hosted by ImageShack.us' />

Restart Gallio.  This will cause the plugin to take effect.

After Gallio is restarted you can add the assembly containing your specifications and you will be presented with a screen like this

<img src='http://img8.imageshack.us/img8/5111/gallioicarusmainwithspe.jpg' alt='Image Hosted by ImageShack.us' />

When you press Start Gallio will run Concordion on your specifications and produce something like the following output

<img src='http://img18.imageshack.us/img18/5111/gallioicarusmainwithspe.jpg' alt='Image Hosted by ImageShack.us' />

# Caveats #

  * The Concordion Adapter only works with v3.0.5.546 of Gallio currently.  Plans to expand this to other releases is in the works.
  * After you set the plugin directory you will have to restart Gallio for Gallio to be able to find and load the plugin properly.
  * This guide only applies to the Icarus GUI Test Runner.  Other guides for Gallio.Echo and the MSBuild and NAnt Gallio tasks will be forthcoming