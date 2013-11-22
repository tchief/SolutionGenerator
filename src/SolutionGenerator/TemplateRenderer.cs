namespace SolutionGenerator
{
    using System.IO;
    using System.Text.RegularExpressions;

    public class TemplateRenderer
    {
        public static string Render<T>(string templateContent, T model)
        {
            string text = File.ReadAllText(templateContent);

            return Regex.Replace(text, @"\{.*?\}", match =>
                {
                    string replace = match.Value.Replace("{", string.Empty).Replace("}", string.Empty);
                    return model.GetType().GetProperty(replace).GetValue(model).ToString();
                });
        }
    }
}