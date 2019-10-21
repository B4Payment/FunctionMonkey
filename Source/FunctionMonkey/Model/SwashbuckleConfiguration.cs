namespace FunctionMonkey.Model
{
    public class SwashbuckleConfiguration
    {
        public bool Enabled { get; set; } = true;

        public string RoutePrefix { get; set; } = "swagger";

        public bool UserInterface { get; set; } = true;
    }
}
