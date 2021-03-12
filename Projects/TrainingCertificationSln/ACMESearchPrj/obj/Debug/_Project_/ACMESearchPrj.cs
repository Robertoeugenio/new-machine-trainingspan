using ACMESearchPrj_ACMESystem = ACMESearchPrj.ACMESystem;

using ACMESearchPrj_frmTest = ACMESearchPrj.frmTest;

using ACMESearchPrj_ACME_P_NavToHome = ACMESearchPrj.ACME_P_NavToHome;

using ACMESearchPrj_ACME_P_SignIn = ACMESearchPrj.ACME_P_SignIn;

using System;

namespace ACMESearchPrj.Project
{
// Project-8D8DDA64745E957
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D8DDA64745E957")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class ACMESearchPrj : OpenSpan.Runtime.RuntimeProject
{
	
	public ACMESearchPrj() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.ACMESearchPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public ACMESearchPrj(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.ACMESearchPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public ACMESearchPrj(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.ACMESearchPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public ACMESearchPrj(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.ACMESearchPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private ACMESearchPrj(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.ACMESearchPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void ACMESearchPrj_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D8DDA64745E957");
		this.mVersion = new System.Version("19.1.75.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("19.1.0.25");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// UniversalWebAdapter-8D8DE50B28552EF
	public ACMESearchPrj_ACMESystem ACMESystem
	{
		get
		{
			return ((ACMESearchPrj_ACMESystem)(this["ACMESystem"]));
		}
	}
	
	// DesignForm-8D8E46A4FF4EC54
	public ACMESearchPrj_frmTest frmTest
	{
		get
		{
			return ((ACMESearchPrj_frmTest)(this["frmTest"]));
		}
	}
	
	// Automator-8D8E561DC276930
	public ACMESearchPrj_ACME_P_NavToHome ACME_P_NavToHome
	{
		get
		{
			return ((ACMESearchPrj_ACME_P_NavToHome)(this["ACME_P_NavToHome"]));
		}
	}
	
	// Automator-8D8E55BD1146088
	public ACMESearchPrj_ACME_P_SignIn ACME_P_SignIn
	{
		get
		{
			return ((ACMESearchPrj_ACME_P_SignIn)(this["ACME_P_SignIn"]));
		}
	}
}

}

