using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using CKS.Dev.VisualStudio.SharePoint.Commands.Info;

namespace CKS.Dev.VisualStudio.SharePoint.Commands.Common.ExtensionMethods
{
  internal static class SPFolderCollectionExtensions
  {
    internal static List<FolderNodeInfo> ToFolderNodeInfo(this SPFolderCollection folders)
    {
      List<FolderNodeInfo> nodeInfos = new List<FolderNodeInfo>();

      foreach (SPFolder folder in folders)
      {
        FolderNodeInfo nodeInfo = new FolderNodeInfo
        {
          Name = folder.Name,
          Url = folder.Url
        };
        nodeInfos.Add(nodeInfo);
      }

      return nodeInfos;
    }
  }
}
