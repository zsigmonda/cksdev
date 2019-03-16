﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.SharePoint;

namespace CKS.Dev.VisualStudio.SharePoint.Environment.Dialogs
{
  /// <summary>
  /// Helper class to store basic information about a Project Package List Item.
  /// </summary>
  public class SharePointProjectPackageListItem
  {
    /// <summary>
    /// Gets the package.
    /// </summary>
    /// <value>
    /// The package.
    /// </value>
    public ISharePointProjectPackage Package { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SharePointProjectPackageListItem" /> class.
    /// </summary>
    /// <param name="package">The package.</param>
    /// <exception cref="System.ArgumentNullException">package</exception>
    public SharePointProjectPackageListItem(ISharePointProjectPackage package)
    {
      if (package == null)
      {
        throw new ArgumentNullException("package");
      }

      Package = package;
    }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
      return Package.Model.Name;
    }
  }
}
