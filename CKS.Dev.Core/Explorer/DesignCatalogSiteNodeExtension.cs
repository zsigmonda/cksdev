﻿using CKSProperties = CKS.Dev.Core.Properties.Resources;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Explorer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKS.Dev.VisualStudio.SharePoint.Commands;
using CKS.Dev.VisualStudio.SharePoint.Commands.Info;
using CKS.Dev.VisualStudio.SharePoint.Environment.Options;
using CKS.Dev.VisualStudio.SharePoint.Explorer.Dialogs;

namespace CKS.Dev.VisualStudio.SharePoint.Explorer
{
  /// <summary>
  /// Represents an extension of SharePoint site nodes in Server Explorer for design catalog. 
  /// </summary>
  // Enables Visual Studio to discover and load this extension.
  [Export(typeof(IExplorerNodeTypeExtension))]
  // Indicates that this class extends SharePoint site nodes in Server Explorer.
  [ExplorerNodeType(ExplorerNodeTypes.SiteNode)]
  internal class DesignCatalogSiteNodeExtension : IExplorerNodeTypeExtension
  {
    #region Methods

    /// <summary>
    /// Initializes the node extension.
    /// </summary>
    /// <param name="nodeType">The node type that is being extended.</param>
    public void Initialize(IExplorerNodeType nodeType)
    {
      nodeType.NodeChildrenRequested += new EventHandler<ExplorerNodeEventArgs>(nodeType_NodeChildrenRequested);
    }

    /// <summary>
    /// Handles the NodeChildrenRequested event of the nodeType control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="ExplorerNodeEventArgs" /> instance containing the event data.</param>
    void nodeType_NodeChildrenRequested(object sender, ExplorerNodeEventArgs e)
    {
      Uri siteUrl = null;
      IExplorerNode siteNode = e.Node;
      IExplorerSiteNodeInfo siteInfo = siteNode.Annotations.GetValue<IExplorerSiteNodeInfo>();
      if (siteInfo != null && siteInfo.IsConnectionRoot)
      {
        siteUrl = siteInfo.Url;
      }

      if (EnabledExtensionsOptionsPage.GetSetting<bool>(EnabledExtensionsOptions.ViewDesignCatalog, true))
      {
        e.Node.ChildNodes.AddFolder(CKSProperties.SiteNodeExtension_DesignCatalogNodeName, CKSProperties.DesignCatalogNode.ToBitmap(), FileNodeTypeProvider.CreateFilesNodes);
      }
    }

    #endregion
  }
}
