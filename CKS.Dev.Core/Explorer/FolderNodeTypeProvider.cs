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
  /// Represents an extension of SharePoint folder nodes in Server Explorer 
  /// </summary>
  // Enables Visual Studio to discover and load this extension.
  [Export(typeof(IExplorerNodeTypeProvider))]
  // Indicates that this class extends SharePoint folder nodes in Server Explorer.
  [ExplorerNodeType(ExplorerNodeIds.FolderNode)]
  internal class FolderNodeTypeProvider : IExplorerNodeTypeProvider
  {
    #region Methods

    /// <summary>
    /// Initializes the new node type.
    /// </summary>
    /// <param name="typeDefinition">The definition of the new node type.</param>
    public void InitializeType(IExplorerNodeTypeDefinition typeDefinition)
    {
      typeDefinition.DefaultIcon = CKSProperties.FolderNode.ToBitmap();
      typeDefinition.IsAlwaysLeaf = false;

      typeDefinition.NodeChildrenRequested += typeDefinition_NodeChildrenRequested;
    }

    /// <summary>
    /// Handles the NodeChildrenRequested event of the typeDefinition control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="ExplorerNodeEventArgs" /> instance containing the event data.</param>
    void typeDefinition_NodeChildrenRequested(object sender, ExplorerNodeEventArgs e)
    {
      FileNodeTypeProvider.CreateFilesNodes(e.Node);
    }

    #endregion
  }
}
