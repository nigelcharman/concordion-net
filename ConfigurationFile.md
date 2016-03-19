# Introduction #

The configuration file is meant to be a place where you can control/customise certain aspects of how concordion works, be it specifying runners, the base input or output directory, etc.


# Example #

```
<?xml version="1.0" encoding="utf-8" ?>
<Concordion>
  <BaseInputDirectory>C:\Dev\concordion-net\Specifications</BaseInputDirectory>
  <BaseOutputDirectory>C:\Dev\concordion-net\Results</BaseOutputDirectory>
  <SpecificationAssemblies>
    <SpecificationAssembly>Concordion.Spec, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null</SpecificationAssembly>
  </SpecificationAssemblies>
  <Runners>
    <Runner alias="runtestrunner" type="Concordion.Spec.Concordion.Command.Run.RunTestRunner, Concordion.Spec, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" />
  </Runners>
</Concordion>
```

# Element Descriptions #

## BaseInputDirectory ##

The BaseInputDirectory element tells Concordion where to look for the specifications.  If this element is not specified then Concordion attempts to look in the current working directory for the specification folders.

## BaseOutputDirectory ##

The BaseOutputDirectory element tells Concordion where to place the results of running the specifications.  If this element is not specified then Concordion places the output in the directory defined by the users TEMP environment variable.

## SpecificationAssemblies ##

This element contains one or more SpecificationAssembly elements, defining each assembly

### SpecificationAssembly ###

This element provides the ["Assembly Qualified"](http://msdn.microsoft.com/en-us/library/system.type.assemblyqualifiedname.aspx) name of an assembly that contains specifications.  Note that only classes marked with the [ConcordionTest](ConcordionTest.md) attribute will be recognised by Gallio when run.

## Runners ##

Runners are used to call and run one specification from another specification.  Another specification may be in a different testing suite (like FIT, FitNesse, Cucumber, etc.)

### Runner ###

Each runner element has two attributes that must be present to be recognised properly.  They are "alias" and "type".  The alias is used to refer to the type in the concordion:run="alias" statement.  The type is the Assembly-Qualified Name of the type that you will associate with the alias and will be used to run the called specification.  See the specification for Run for more details.