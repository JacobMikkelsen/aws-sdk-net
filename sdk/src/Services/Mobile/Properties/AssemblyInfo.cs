using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.Mobile")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - AWS Mobile. AWS Mobile Hub is an integrated experience designed to help developers build, test, configure and release cloud-based applications for mobile devices using Amazon Web Services. AWS Mobile Hub provides a console and API for developers, allowing them to quickly select desired features and integrate them into mobile applications. Features include NoSQL Database, Cloud Logic, Messaging and Analytics. With AWS Mobile Hub, you pay only for the underlying services that Mobile Hub provisions based on the features you choose in the Mobile Hub console.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - AWS Mobile. AWS Mobile Hub is an integrated experience designed to help developers build, test, configure and release cloud-based applications for mobile devices using Amazon Web Services. AWS Mobile Hub provides a console and API for developers, allowing them to quickly select desired features and integrate them into mobile applications. Features include NoSQL Database, Cloud Logic, Messaging and Analytics. With AWS Mobile Hub, you pay only for the underlying services that Mobile Hub provisions based on the features you choose in the Mobile Hub console.")]
#elif NETSTANDARD13
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 1.3) - AWS Mobile. AWS Mobile Hub is an integrated experience designed to help developers build, test, configure and release cloud-based applications for mobile devices using Amazon Web Services. AWS Mobile Hub provides a console and API for developers, allowing them to quickly select desired features and integrate them into mobile applications. Features include NoSQL Database, Cloud Logic, Messaging and Analytics. With AWS Mobile Hub, you pay only for the underlying services that Mobile Hub provisions based on the features you choose in the Mobile Hub console.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - AWS Mobile. AWS Mobile Hub is an integrated experience designed to help developers build, test, configure and release cloud-based applications for mobile devices using Amazon Web Services. AWS Mobile Hub provides a console and API for developers, allowing them to quickly select desired features and integrate them into mobile applications. Features include NoSQL Database, Cloud Logic, Messaging and Analytics. With AWS Mobile Hub, you pay only for the underlying services that Mobile Hub provisions based on the features you choose in the Mobile Hub console.")]
#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - AWS Mobile. AWS Mobile Hub is an integrated experience designed to help developers build, test, configure and release cloud-based applications for mobile devices using Amazon Web Services. AWS Mobile Hub provides a console and API for developers, allowing them to quickly select desired features and integrate them into mobile applications. Features include NoSQL Database, Cloud Logic, Messaging and Analytics. With AWS Mobile Hub, you pay only for the underlying services that Mobile Hub provisions based on the features you choose in the Mobile Hub console.")]
#else
#error Unknown platform constant - unable to set correct AssemblyDescription
#endif

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("Amazon Web Services SDK for .NET")]
[assembly: AssemblyCompany("Amazon.com, Inc")]
[assembly: AssemblyCopyright("Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

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
[assembly: AssemblyVersion("3.3")]
[assembly: AssemblyFileVersion("3.5.0.48")]

[assembly: System.CLSCompliant(true)]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif