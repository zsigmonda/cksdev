﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.SharePoint;
using CKS.Dev.VisualStudio.SharePoint;
using CKS.Dev.VisualStudio.SharePoint.Environment.Dialogs;

namespace CKS.Dev.Core.VisualStudio.SharePoint.Environment.Dialogs 
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FeaturesViewerForm : Form 
    {
        private List<ISharePointProjectFeature> allFeatures;

        /// <summary>
        /// Gets the selected feature.
        /// </summary>
        /// <value>The selected feature.</value>
        public ISharePointProjectFeature SelectedFeature 
        {
            get 
            {
                ISharePointProjectFeature selectedFeature = null;

                SharePointProjectFeatureListItem selectedFeatureItem = lbFeatures.SelectedItem as SharePointProjectFeatureListItem;
                if (selectedFeatureItem != null) 
                {
                    selectedFeature = selectedFeatureItem.Feature;
                }

                return selectedFeature;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesViewerForm"/> class.
        /// </summary>
        /// <param name="spi">The spi.</param>
        public FeaturesViewerForm(ISharePointProjectItem spi)
        {
            if (spi == null) 
            {
                throw new ArgumentNullException("spi");
            }

            InitializeComponent();
            LoadProjects(spi.Project);
            LoadFeatures(spi);
            FilterFeaturesList();
        }

        /// <summary>
        /// Filters the features list.
        /// </summary>
        private void FilterFeaturesList() 
        {
            var features = from ISharePointProjectFeature f
                           in allFeatures
                           select new SharePointProjectFeatureListItem(f);

            if (cbProject.SelectedIndex > 0) 
            {
                features = from SharePointProjectFeatureListItem featureItem
                           in features
                           where featureItem.Feature.Project.Id == ((SharePointProjectListItem)cbProject.SelectedItem).Project.Id
                           select featureItem;
            }

            if (!String.IsNullOrEmpty(tbFilter.Text))
            {
                features = from SharePointProjectFeatureListItem featureItem
                           in features
                           where featureItem.Feature.Model.Title.Contains(tbFilter.Text, StringComparison.InvariantCultureIgnoreCase) ||
                           featureItem.Feature.Name.Contains(tbFilter.Text, StringComparison.InvariantCultureIgnoreCase)
                           select featureItem;
            }

            lbFeatures.DataSource = features.OrderBy(f => f.Feature.Model.Title).ToList();
        }

        /// <summary>
        /// Loads the projects.
        /// </summary>
        /// <param name="project">The project.</param>
        private void LoadProjects(ISharePointProject project) 
        {
            List<SharePointProjectListItem> projects = (from ISharePointProject p
                                                       in project.ProjectService.Projects
                                                        select new SharePointProjectListItem(p)).OrderBy(pr => pr.Project.Name).ToList();

            cbProject.Items.Add("");

            foreach (var p in projects) 
            {
                cbProject.Items.Add(p);
            }
        }

        /// <summary>
        /// Loads the features.
        /// </summary>
        /// <param name="spi">The spi.</param>
        private void LoadFeatures(ISharePointProjectItem spi)
        {
            allFeatures = new List<ISharePointProjectFeature>();

            foreach (var p in spi.Project.ProjectService.Projects) 
            {
                foreach (var f in p.Features)
                {
                    if (f.Model != null &&
                        FeatureSupportsSpiScope(f.Model.Scope, spi.ProjectItemType.SupportedDeploymentScopes))
                    {
                        allFeatures.Add(f);
                    }
                }
            }
        }

        /// <summary>
        /// Features the supports spi scope.
        /// </summary>
        /// <param name="featureScope">The feature scope.</param>
        /// <param name="supportedDeploymentScopes">The supported deployment scopes.</param>
        /// <returns></returns>
        private static bool FeatureSupportsSpiScope(Microsoft.VisualStudio.SharePoint.Features.FeatureScope featureScope,
            SupportedDeploymentScopes supportedDeploymentScopes) 
        {
            bool featureSupportsSpiScope = false;

            switch (featureScope)
            {
                case Microsoft.VisualStudio.SharePoint.Features.FeatureScope.Farm:
                    featureSupportsSpiScope = (supportedDeploymentScopes & SupportedDeploymentScopes.Farm) == SupportedDeploymentScopes.Farm;
                    break;
                case Microsoft.VisualStudio.SharePoint.Features.FeatureScope.Site:
                    featureSupportsSpiScope = (supportedDeploymentScopes & SupportedDeploymentScopes.Site) == SupportedDeploymentScopes.Site;
                    break;
                case Microsoft.VisualStudio.SharePoint.Features.FeatureScope.Web:
                    featureSupportsSpiScope = (supportedDeploymentScopes & SupportedDeploymentScopes.Web) == SupportedDeploymentScopes.Web;
                    break;
                case Microsoft.VisualStudio.SharePoint.Features.FeatureScope.WebApplication:
                    featureSupportsSpiScope = (supportedDeploymentScopes & SupportedDeploymentScopes.WebApplication) == SupportedDeploymentScopes.WebApplication;
                    break;
            }

            return featureSupportsSpiScope;
        }

        /// <summary>
        /// Handles the TextChanged event of the Filter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Filter_TextChanged(object sender, EventArgs e)
        {
            FilterFeaturesList();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Project control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Project_SelectedIndexChanged(object sender, EventArgs e) 
        {
            FilterFeaturesList();
        }
    }
}
