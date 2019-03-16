﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CKS.Dev.VisualStudio.SharePoint.Commands.Info
{
  /// <summary>
  /// Feature scopes.
  /// </summary>
  public enum DeploymentFeatureScope
  {
    /// <summary>
    /// Farm
    /// </summary>
    Farm = 0,
    /// <summary>
    /// Web Application
    /// </summary>
    WebApplication = 1,
    /// <summary>
    /// Site Collection
    /// </summary>
    Site = 2,
    /// <summary>
    /// Web
    /// </summary>
    Web = 3
  }
}
