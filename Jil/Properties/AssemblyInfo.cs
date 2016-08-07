﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Jil")]
[assembly: AssemblyDescription("A fast JSON serializer and deserializer")]
[assembly: AssemblyProduct("Jil")]
[assembly: AssemblyCopyright("Copyright © Kevin Montrose 2013 - 2016")]

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a4bd090c-cd3e-4f8e-af53-a947b0a87316")]

[assembly: AssemblyVersion("2.14.5")]
[assembly: AssemblyFileVersion("2.14.5")]

#if !STRONG_NAME
[assembly: InternalsVisibleTo("JilTests")]
[assembly: InternalsVisibleTo("Experiments")]
[assembly: InternalsVisibleTo("JilUnionConfigLookupTypes")]
#endif
