using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CKS.Dev.VisualStudio.SharePoint.Environment
{
  public interface ICKSDevVSPackage
  {
    object GetServiceInternal(Type type);
  }
}
