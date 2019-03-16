﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CKS.Dev.VisualStudio.SharePoint.Commands
{
  /// <summary>
  /// SharePoint Command Ids for list event receivers.
  /// </summary>
  public static class ListEventReceiversCommandIds
  {
    #region Constants

    /// <summary>
    /// Gets properties of List Event Receiver.
    /// </summary>
    public const string GetListEventReceiverProperties = "ListEventReceivers.GetListEventReceiverProperties";

    /// <summary>
    /// Get Event Receivers associated with the List.
    /// </summary>
    public const string GetListEventReceivers = "ListEventReceivers.GetListEventReceivers";

    #endregion
  }
}
