﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CKS.Dev.VisualStudio.SharePoint.Commands.Info
{
  /// <summary>
  /// Publishing Page Info
  /// </summary>
  public class PublishingPageInfo
  {
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the server relative URL.
    /// </summary>
    /// <value>
    /// The server relative URL.
    /// </value>
    public string ServerRelativeUrl { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>
    /// The title.
    /// </value>
    public string Title { get; set; }
  }
}
