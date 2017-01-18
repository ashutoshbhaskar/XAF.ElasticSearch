﻿namespace BYteWare.XAF.ElasticSearch.Model
{
    using DevExpress.ExpressApp.DC;
    using DevExpress.ExpressApp.Model;
    using ElasticSearch;
    using System;

    /// <summary>
    /// Methods for the IModelListViewFilterItemElasticSearch Model Interface
    /// </summary>
    [CLSCompliant(false)]
    [DomainLogic(typeof(IModelListViewFilterItemElasticSearch))]
    public static class ModelListViewFilterItemElasticSearchLogic
    {
        /// <summary>
        /// Returns validation errors for the ElasticSearchFilter, if there are any
        /// </summary>
        /// <param name="model">IModelListViewFilterItemElasticSearch instance</param>
        /// <returns>Validation errors for the ElasticSearchFilter</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = nameof(XAF))]
        public static string Get_ElasticSearchFilterSyntax(IModelListViewFilterItemElasticSearch model)
        {
            if (model != null && !string.IsNullOrWhiteSpace(model.ElasticSearchFilter))
            {
                var modelListView = ((IModelNode)model).Parent?.Parent as IModelListView;
                if (modelListView?.ModelClass?.TypeInfo != null)
                {
                    return string.Join(Environment.NewLine, ElasticSearchClient.Instance.ValidateFilter(modelListView.ModelClass.TypeInfo, model.ElasticSearchFilter));
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// Ignores the value; needed to use a setter otherwise the field is disabled and can't be scrolled
        /// </summary>
        /// <param name="model">IModelListViewFilterItemElasticSearch instance</param>
        /// <param name="value">The value to set</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "value", Justification = nameof(XAF))]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "model", Justification = nameof(XAF))]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = nameof(XAF))]
        public static void Set_ElasticSearchFilterSyntax(IModelListViewFilterItemElasticSearch model, string value)
        {
        }
    }
}