namespace FunctionMonkey.Abstractions.Builders
{
    /// <summary>
    /// An interface to configure Swashbuckle.
    /// </summary>
    public interface ISwashbuckleBuilder
    {
        /// <summary>
        /// Enable swagger
        /// </summary>
        /// <param name="enabled">True when enabled - defaults to true</param>
        ISwashbuckleBuilder Enable(bool enabled = true);

        /// <summary>
        /// Set the route prefix to the swagger json and user interface
        /// </summary>
        /// <param name="routePrefix">The route to host on - defaults to swagger</param>
        ISwashbuckleBuilder RoutePrefix(string routePrefix = "swagger");

        /// <summary>
        /// Enable swagger user interface
        /// </summary>
        /// <param name="enabled">True when enabled - defaults to true</param>
        ISwashbuckleBuilder UserInterface(bool enabled = true);
    }
}
