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
  /// ASHX Handler item provider.
  /// </summary>
  // Enables Visual Studio to discover and load this extension.
  [Export(typeof(ISharePointProjectItemTypeProvider))]
  // Specifies the ID for this new project item type. This string must match the value of the 
  // Type attribute of the ProjectItem element in the .spdata file for the project item.
  [SharePointProjectItemType(ProjectItemIds.AshxHandler)]
  // Specifies the icon to display with this project item in Solution Explorer.
  [SharePointProjectItemIcon("CKS.Dev12.VisualStudio.SharePoint.Resources.SolutionExplorerIcons.AshxHandler_SolutionExplorer.ico")]
  partial class AshxHandlerTypeProvider : ISharePointProjectItemTypeProvider
  {
    #region Methods

    /// <summary>
    /// Called by projects to initialize an instance of a SharePoint project item type.
    /// </summary>
    /// <param name="typeDefinition">A project item type definition to initialize.</param>
    public void InitializeType(ISharePointProjectItemTypeDefinition typeDefinition)
    {
      typeDefinition.Name = CKSProperties.AshxHandlerTypeProvider_TypeDefinitionName;
      typeDefinition.SupportedDeploymentScopes = SupportedDeploymentScopes.Farm | SupportedDeploymentScopes.WebApplication;
      typeDefinition.SupportedTrustLevels = SupportedTrustLevels.FullTrust;
      typeDefinition.SupportedAssemblyDeploymentTargets = SupportedAssemblyDeploymentTargets.All;
    }

    //TODO: go through every type provider and match http://msdn.microsoft.com/en-us/library/ms454835.aspx

    #endregion
  }
}