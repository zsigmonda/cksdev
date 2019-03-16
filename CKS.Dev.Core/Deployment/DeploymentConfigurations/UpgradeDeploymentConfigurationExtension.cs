﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKSProperties = CKS.Dev.Core.Properties.Resources;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Deployment;
using CKS.Dev.VisualStudio.SharePoint.Deployment.DeploymentSteps;

namespace CKS.Dev.VisualStudio.SharePoint.Deployment.DeploymentConfigurations
{
  /// <summary>
  /// Deployment configuration for upgrade.
  /// </summary>
  [Export(typeof(ISharePointProjectExtension))]
  internal class UpgradeDeploymentConfigurationExtension : ISharePointProjectExtension
  {
    /// <summary>
    /// Initializes the SharePoint project extension.
    /// </summary>
    /// <param name="projectService">An instance of SharePoint project service.</param>
    public void Initialize(ISharePointProjectService projectService)
    {
      projectService.ProjectInitialized += ProjectInitialized;
    }

    /// <summary>
    /// Creates the new deployment configuration.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="Microsoft.VisualStudio.SharePoint.SharePointProjectEventArgs"/> instance containing the event data.</param>
    private void ProjectInitialized(object sender, SharePointProjectEventArgs e)
    {
      //Add the new configuration.
      if (!e.Project.DeploymentConfigurations.ContainsKey(CKSProperties.UpgradeDeploymentConfigurationExtension_Name))
      {
        string[] deploymentSteps = new string[]
        {
                    DeploymentStepIds.PreDeploymentCommand,
                    DeploymentStepIds.RecycleApplicationPool,
                    CustomDeploymentStepIds.UpgradeSolution,
                    DeploymentStepIds.PostDeploymentCommand
        };

        string[] retractionSteps = new string[]
        {
                    DeploymentStepIds.RecycleApplicationPool,
                    DeploymentStepIds.RetractSolution
        };

        IDeploymentConfiguration configuration = e.Project.DeploymentConfigurations.Add(
            CKSProperties.UpgradeDeploymentConfigurationExtension_Name, deploymentSteps, retractionSteps);
        configuration.Description = CKSProperties.UpgradeDeploymentConfigurationExtension_Description;
      }
    }
  }
}
