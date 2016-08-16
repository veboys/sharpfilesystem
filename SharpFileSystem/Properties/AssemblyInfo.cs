using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SharpFileSystem")]
// NuGet automatically substitutes this as $description$ in the .nuspec
[assembly: AssemblyDescription("A virtual file system for .NET written in C#")]
[assembly: AssemblyConfiguration("")]
// NuGet automatically substitutes this as $author$ in the .nuspec
[assembly: AssemblyCompany("Bob van der Linden")]
[assembly: AssemblyProduct("SharpFileSystem")]
[assembly: AssemblyCopyright("Copyright ©  2010")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("4b8cb295-69c1-40db-a9a8-03a2549b8f3d")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]

// Never change this. It forces people to change assembly references and mostly just problems.
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// This is substituted as $version$ in the .nuspec. It lets you use free-form text,
// meaning you can put semver (MAJOR.MINOR.PATCH) (3 parts rather than 4) in there.
// This is also helpful because it shows up as “Product version” in Windows Explorer’s
// Properties window.
[assembly: AssemblyInformationalVersion("1.0.0")]
