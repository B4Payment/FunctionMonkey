﻿using FunctionMonkey.Abstractions.Builders;

namespace FunctionMonkey.Compiler.Core.Implementation.OpenApi
{
    public class OpenApiDocumentFilterContext : IOpenApiDocumentFilterContext
    {
        public string DocumentRoute { get; set; }
    }
}
