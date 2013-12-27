// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateRenderer.cs" company="Orcomp development team">
//   Copyright (c) 2012 - 2013 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace SolutionGenerator.Services
{
    using System.IO;
    using System.Text.RegularExpressions;

    public class TemplateRenderer : ITemplateRenderer
    {
        #region Constants
        private const string TemplateRegex = @"[^{]({[^{].*?})";
        #endregion

        #region ITemplateRenderer Members
        public string Render<T>(string templateContent, T model)
        {
            string text = File.ReadAllText(templateContent);

            return Regex.Replace(text, TemplateRegex, match =>
            {
                var indexOfFirst = match.Value.IndexOf('{');
                var prefix = indexOfFirst > 0 ? match.Value.Substring(0, 1) : string.Empty;
                var value = match.Value.Substring(indexOfFirst);
                string replace = value.Replace("{", string.Empty).Replace("}", string.Empty);
                return prefix + model.GetType().GetProperty(replace).GetValue(model).ToString();
            }).Replace("{{", "{").Replace("}}", "}");
        }

        public string RenderAndRenderContent<T>(string templateContent, T model)
        {
            string text = File.ReadAllText(templateContent);

            MatchEvaluator matchEvaluator = match =>
            {
                var indexOfFirst = match.Value.IndexOf('{');
                var prefix = indexOfFirst > 0 ? match.Value.Substring(0, 1) : string.Empty;
                var value = match.Value.Substring(indexOfFirst);
                string replace = value.Replace("{", string.Empty).Replace("}", string.Empty);
                return prefix + model.GetType().GetProperty(replace).GetValue(model).ToString();
            };

            string resolvedTemplate = Regex.Replace(text, TemplateRegex, matchEvaluator);
            return Regex.Replace(resolvedTemplate, TemplateRegex, matchEvaluator).Replace("{{", "{").Replace("}}", "}");
        }
        #endregion
    }
}