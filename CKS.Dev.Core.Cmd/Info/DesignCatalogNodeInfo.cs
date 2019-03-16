﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CKS.Dev.VisualStudio.SharePoint.Commands.Info
{
  /// <summary>
  /// Contains basic data about the design catalog on the SharePoint site. This class is 
  /// serializable so that instances of it can be sent between the Visual Studio and 
  /// SharePoint command assemblies.
  /// </summary>
  [Serializable]
  public class DesignCatalogNodeInfo
  {
    #region Properties

    /// <summary>
    /// Gets or sets the site id guid.
    /// </summary>
    public Guid SiteId { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the image url.
    /// </summary>
    public string Url { get; set; }

    #endregion
  }
}
