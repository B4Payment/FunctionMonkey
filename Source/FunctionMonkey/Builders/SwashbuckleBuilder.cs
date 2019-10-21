using FunctionMonkey.Abstractions.Builders;
using FunctionMonkey.Model;

namespace FunctionMonkey.Builders
{
    internal class SwashbuckleBuilder : ISwashbuckleBuilder
    {
        private readonly SwashbuckleConfiguration _swashbuckleConfiguration;

        public SwashbuckleBuilder(SwashbuckleConfiguration swashbuckleConfiguration)
        {
            _swashbuckleConfiguration = swashbuckleConfiguration;
        }

        public ISwashbuckleBuilder Enable(bool enabled = true)
        {
            _swashbuckleConfiguration.Enabled = enabled;
            return this;
        }

        public ISwashbuckleBuilder RoutePrefix(string routePrefix = "swagger")
        {
            _swashbuckleConfiguration.RoutePrefix = routePrefix;
            return this;
        }

        public ISwashbuckleBuilder UserInterface(bool enabled = true)
        {
            _swashbuckleConfiguration.UserInterface = enabled;
            return this;
        }
    }
}
