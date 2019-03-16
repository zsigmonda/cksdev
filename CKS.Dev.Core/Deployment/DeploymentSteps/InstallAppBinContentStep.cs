﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKSProperties = CKS.Dev.Core.Properties.Resources;
using Microsoft.VisualStudio.SharePoint.Deployment;
using CKS.Dev.VisualStudio.SharePoint.Commands;

namespace CKS.Dev.VisualStudio.SharePoint.Deployment.DeploymentSteps
{
  /// <summary>
  /// Install the app bin content deployment step.
  /// </summary>
  [Export(typeof(IDeploymentStep))]
  [DeploymentStep(CustomDeploymentStepIds.InstallAppBinContent)]
  public class InstallAppBinContentStep
      : IDeploymentStep
  {
    /// <summary>
    /// Initializes the deployment step.
    /// </summary>
    /// <param name="stepInfo">An object that contains information about the deployment step.</param>
    public void Initialize(IDeploymentStepInfo stepInfo)
    {
      stepInfo.Name = CKSProperties.InstallAppBinContentStep_Name;
      stepInfo.StatusBarMessage = CKSProperties.InstallAppBinContentStep_StatusBarMessage;
      stepInfo.Description = CKSProperties.InstallAppBinContentStep_Description;
    }

    /// <summary>
    /// Determines whether the deployment step can be executed in the current context.
    /// </summary>
    /// <param name="context">An object that provides information you can use to determine the context in which the deployment step is executing.</param>
    /// <returns>
    /// true if the deployment step can be executed; otherwise, false.
    /// </returns>
    public bool CanExecute(IDeploymentContext context)
    {
      return true;
    }

    /// <summary>
    /// Executes the deployment step.
    /// </summary>
    /// <param name="context">An object that provides information you can use to determine the context in which the deployment step is executing.</param>
    public void Execute(IDeploymentContext context)
    {
      context.Project.SharePointConnection.ExecuteCommand(DeploymentSharePointCommandIds.CopyAppBinContent);
    }
  }
}