﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.SharePoint.Commands;
using Microsoft.SharePoint;
using CKS.Dev.Core.Cmd.Imp.v5.Properties;
using CKS.Dev.VisualStudio.SharePoint.Commands.Info;
using CKS.Dev.VisualStudio.SharePoint.Commands.Common.ExtensionMethods;

namespace CKS.Dev.VisualStudio.SharePoint.Commands
{
  /// <summary>
  /// The style library commands.
  /// </summary>
  class StyleLibrarySharePointCommands
  {
    /// <summary>
    /// Gets additional property data for the style library.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="nodeInfo">The node info.</param>
    /// <returns></returns>
    [SharePointCommand(StyleLibrarySharePointCommandIds.GetStyleLibraryProperties)]
    private static Dictionary<string, string> GetStyleLibraryProperties(ISharePointCommandContext context,
        StyleLibraryNodeInfo nodeInfo)
    {
      return SharePointCommandServices.GetProperties(context.Site.GetCatalog(SPListTemplateType.DesignCatalog));
    }

    /// <summary>
    /// Get the default view url for the style library.
    /// </summary>
    /// <param name="context">The context</param>
    /// <returns>The default view of the style library</returns>
    [SharePointCommand(StyleLibrarySharePointCommandIds.GetStyleLibraryAllItemsUrl)]
    private static string GetStyleLibraryAllItemsUrl(ISharePointCommandContext context)
    {
      return context.Site.GetCatalog(SPListTemplateType.DesignCatalog).DefaultViewUrl;
    }
  }
}
