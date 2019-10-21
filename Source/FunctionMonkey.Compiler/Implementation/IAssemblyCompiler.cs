﻿using System;
using System.Collections.Generic;
using System.Reflection;
using FunctionMonkey.Abstractions.Builders.Model;
using FunctionMonkey.Model;

namespace FunctionMonkey.Compiler.Implementation
{
    internal interface IAssemblyCompiler
    {
        void Compile(IReadOnlyCollection<AbstractFunctionDefinition> functionDefinitions,
            Type functionAppConfigurationType,
            string newAssemblyNamespace,
            IReadOnlyCollection<string> externalAssemblyLocations,
            string outputBinaryFolder,
            string assemblyName,
            SwashbuckleConfiguration swashbuckleConfiguration,
            OpenApiOutputModel openApiOutputModel,
            FunctionCompiler.TargetEnum target,
            string outputAuthoredSourceFolder = null);
    }
}
