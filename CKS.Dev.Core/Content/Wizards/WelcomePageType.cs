﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CKS.Dev.VisualStudio.SharePoint.Content.Wizards
{
  /// <summary>
  /// Defines the type of welcome page that is used for a site/web template
  /// </summary>
  public enum WelcomePageType
  {
    /// <summary>
    /// A page with web part zones
    /// </summary>
    WebPartPage,
    /// <summary>
    /// A wiki page
    /// </summary>
    WikiPage,
    /// <summary>
    /// A publishing page
    /// </summary>
    PublishingPage
  }
}
