﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using CKS.Dev.VisualStudio.SharePoint.Commands.Info;

namespace CKS.Dev.VisualStudio.SharePoint.Commands.Common.ExtensionMethods
{
  /// <summary>
  /// Extensions to the SPListItemCollection OM class.
  /// </summary>
  internal static class SPListItemCollectionExtensions
  {
    #region Methods

    /// <summary>
    /// Convert to a file node info object.
    /// </summary>
    /// <param name="listItems">The list item collection.</param>
    /// <returns>The file node info's.</returns>
    internal static List<FileNodeInfo> ToFileNodeInfo(this SPListItemCollection listItems)
    {
      List<FileNodeInfo> nodeInfos = new List<FileNodeInfo>();

      foreach (SPListItem listItem in listItems)
      {
        if (listItem.File != null)
        {
          FileNodeInfo nodeInfo = new FileNodeInfo();

          nodeInfo.Id = listItem.ID;
          nodeInfo.Name = listItem.File.Name;
          nodeInfo.UniqueId = listItem.UniqueId;
          nodeInfo.FileType = listItem[SPBuiltInFieldId.File_x0020_Type] as String;
          nodeInfo.ServerRelativeUrl = listItem.File.ServerRelativeUrl;
          try
          {
            nodeInfo.Title = listItem.Title;
          }
          catch (ArgumentException)
          {
            nodeInfo.Title = listItem.File.Title;
          }
          nodeInfo.IsCheckedOut = listItem.File.Level == SPFileLevel.Checkout;

          nodeInfos.Add(nodeInfo);
        }
      }

      return nodeInfos;
    }

    #endregion
  }
}
