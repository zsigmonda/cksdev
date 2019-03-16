﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using System.Xml;
using System.Xml.Linq;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Publishing;
using Microsoft.SharePoint.WebPartPages;
using Microsoft.VisualStudio.SharePoint.Commands;
using CKS.Dev.VisualStudio.SharePoint.Commands.Info;

namespace CKS.Dev.VisualStudio.SharePoint.Commands
{
  /// <summary>
  /// Commands for the publishing pages
  /// </summary>
  class PublishingPageSharePointCommands
  {
    /// <summary>
    /// Exports to XML.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="pageInfo">The page info.</param>
    /// <returns></returns>
    [SharePointCommand(PublishingPageCommandIds.ExportToXml)]
    private static string ExportToXml(ISharePointCommandContext context, PublishingPageInfo pageInfo)
    {
      string pageXml = null;

      PublishingWeb publishingWeb = PublishingWeb.GetPublishingWeb(context.Web);
      PublishingPage page = publishingWeb.GetPublishingPage(pageInfo.ServerRelativeUrl);
      if (page != null)
      {
        pageXml = ExportPublishingPage(page, context.Web, context).ToString();
      }

      return pageXml;
    }

    /// <summary>
    /// Exports the publishing page.
    /// </summary>
    /// <param name="page">The page.</param>
    /// <param name="web">The web.</param>
    /// <param name="context">The context.</param>
    /// <returns></returns>
    private static XElement ExportPublishingPage(PublishingPage page, SPWeb web, ISharePointCommandContext context)
    {
      string siteCollectionUrl = web.Site.Url;

      XElement xModule = new XElement("Module",
          new XAttribute("Name", web.Title),
          new XAttribute("Url", "$Resources:osrvcore,List_Pages_UrlName;"),
          new XAttribute("Path", ""));

      XElement xFile = new XElement("File",
          new XAttribute("Url", page.Name),
          new XAttribute("Type", "GhostableInLibrary"));

      // export content
      SPListItem listItem = page.ListItem;
      foreach (SPField f in listItem.Fields)
      {
        string value = listItem[f.Id] as string;
        if (value != null)
        {
          xFile.Add(new XElement("Property",
              new XAttribute("Name", f.InternalName),
              new XAttribute("Value", value.Replace(siteCollectionUrl, "~SiteCollection"))));
        }
      }

      // export web parts
      if (HttpContext.Current == null)
      {
        HttpRequest request = new HttpRequest("", web.Url, "");
        HttpContext.Current = new HttpContext(request, new HttpResponse(new StringWriter()));
        HttpContext.Current.Items["HttpHandlerSPWeb"] = web;
      }

      using (SPLimitedWebPartManager wpMgr = web.GetLimitedWebPartManager(page.Uri.ToString(), PersonalizationScope.Shared))
      {
        foreach (System.Web.UI.WebControls.WebParts.WebPart wp in wpMgr.WebParts)
        {
          if (wp.ExportMode != WebPartExportMode.None)
          {
            try
            {
              string webPartXml = ExportToXml(wp, wpMgr);
              xFile.Add(new XElement("AllUsersWebPart",
                  new XAttribute("WebPartZoneID", wpMgr.GetZoneID(wp)),
                  new XAttribute("WebPartOrder", wp.ZoneIndex),
                  new XCData(webPartXml)));
            }
            catch (Exception ex)
            {
              context.Logger.WriteLine(String.Format("The following error has occured while exporting Web Part '{0}': {1}",
                  wp.Title,
                  ex.Message), LogCategory.Error);
            }
          }
        }
      }

      xModule.Add(xFile);

      return xModule;
    }

    /// <summary>
    /// Exports to XML.
    /// </summary>
    /// <param name="webPart">The web part.</param>
    /// <param name="wpMgr">The wp MGR.</param>
    /// <returns></returns>
    private static string ExportToXml(System.Web.UI.WebControls.WebParts.WebPart webPart, SPLimitedWebPartManager wpMgr)
    {
      StringBuilder builder = new StringBuilder();
      UTF8Encoding encoding = new UTF8Encoding(true);
      MemoryStream stream = new MemoryStream();
      StreamWriter w = new StreamWriter(stream);
      XmlTextWriter writer = new XmlTextWriter(w);
      wpMgr.ExportWebPart(webPart, writer);
      writer.Flush();
      return new string(encoding.GetChars((w.BaseStream as MemoryStream).ToArray()));
    }

    /// <summary>
    /// Gets the properties.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="pageInfo">The page info.</param>
    /// <returns></returns>
    [SharePointCommand(PublishingPageCommandIds.GetProperties)]
    private static Dictionary<string, string> GetProperties(ISharePointCommandContext context, PublishingPageInfo pageInfo)
    {
      Dictionary<string, string> pageProperties = new Dictionary<string, string>();

      PublishingWeb publishingWeb = PublishingWeb.GetPublishingWeb(context.Web);
      PublishingPage page = publishingWeb.GetPublishingPage(pageInfo.ServerRelativeUrl);
      if (page != null)
      {
        pageProperties = SharePointCommandServices.GetProperties(page);
      }

      return pageProperties;
    }
  }
}

