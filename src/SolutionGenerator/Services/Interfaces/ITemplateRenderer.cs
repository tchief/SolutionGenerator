// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITemplateRenderer.cs" company="Orcomp development team">
//   Copyright (c) 2012 - 2013 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace SolutionGenerator.Services
{
    public interface ITemplateRenderer
    {
        #region Methods
        string Render<T>(string templateContent, T model);
        string RenderAndRenderContent<T>(string templateContent, T model);
        #endregion
    }
}