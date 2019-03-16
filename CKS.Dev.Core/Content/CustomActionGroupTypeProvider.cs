﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;
using CKSProperties = CKS.Dev.Core.Properties.Resources;

namespace CKS.Dev.VisualStudio.SharePoint.Content
{
  /// <summary>
  /// CustomActionGroup item provider.
  /// </summary>
  // Enables Visual Studio to discover and load this extension.
  [Export(typeof(ISharePointProjectItemTypeProvider))]
  // Specifies the ID for this new project item type. This string must match the value of the 
  // Type attribute of the ProjectItem element in the .spdata file for the project item.
  [SharePointProjectItemType(ProjectItemIds.CustomActionGroup)]
  // Specifies the icon to display with this project item in Solution Explorer.
  [SharePointProjectItemIcon("CKS.Dev12.VisualStudio.SharePoint.Resources.SolutionExplorerIcons.CustomActionGroup_SolutionExplorer.ico")]
  partial class CustomActionGroupTypeProvider : ISharePointProjectItemTypeProvider
  {
    #region Methods

    /// <summary>
    /// Called by projects to initialize an instance of a SharePoint project item type.
    /// </summary>
    /// <param name="typeDefinition">A project item type definition to initialize.</param>
    public void InitializeType(ISharePointProjectItemTypeDefinition typeDefinition)
    {
      typeDefinition.Name = CKSProperties.CustomActionGroupTypeProvider_TypeDefinitionName;
      typeDefinition.SupportedDeploymentScopes = SupportedDeploymentScopes.Farm | SupportedDeploymentScopes.WebApplication | SupportedDeploymentScopes.Site | SupportedDeploymentScopes.Web;
      typeDefinition.SupportedTrustLevels = SupportedTrustLevels.FullTrust;
      typeDefinition.SupportedAssemblyDeploymentTargets = SupportedAssemblyDeploymentTargets.All;
    }

    #endregion
  }
}
