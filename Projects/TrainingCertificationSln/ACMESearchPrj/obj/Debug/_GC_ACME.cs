using System;

namespace ACMESearchPrj
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// GlobalContainer-8D8E585B0F4A024
[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D8E585B0F4A024")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class _GC_ACME : OpenSpan.Automation.GlobalContainer
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D8E585B0F4A024\\AsoManager-8D8E585CAA10B70")]
	public OpenSpan.ApplicationFramework.AssistedSignOn.AsoManager asoManager1;
	
	public _GC_ACME()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(_GC_ACME));
		this.asoManager1 = new OpenSpan.ApplicationFramework.AssistedSignOn.AsoManager();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D8E585B0F4A024");
		// 
		// Set component Ids
		// 
		this.SetId(this.asoManager1, new OpenSpan.Design.ComponentIdentity("AsoManager-8D8E585CAA10B70"));
		// 
		// _GC_ACME
		// 
		ComponentInfo.CodeDomData = _resources_.GetString("__GC_ACME_1_");
		this.IsStartStoppable = false;
		this.Name = "_GC_ACME";
		// 
		// asoManager1
		// 
		this.asoManager1.Enable = false;
		this.asoManager1.QueueActivity = false;
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.asoManager1);
	}
	
	private System.Collections.Generic.List<System.ComponentModel.IComponent> mComponents;
	
	public System.Collections.Generic.List<System.ComponentModel.IComponent> Components
	{
		get
		{
			return this.mComponents;
		}
	}
	
	/// <summary>
	/// Start design component.
	/// </summary>
	public override void Start()
	{
		base.Start();
	}
	
	/// <summary>
	/// Stop design component.
	/// </summary>
	public override void Stop()
	{
		base.Stop();
	}
	
	internal OpenSpan.ApplicationFramework.AssistedSignOn.AsoManager Create_asoManager1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.ApplicationFramework.AssistedSignOn.AsoManager asoManager1 = new OpenSpan.ApplicationFramework.AssistedSignOn.AsoManager();
		this.SetId(asoManager1, new OpenSpan.Design.ComponentIdentity("AsoManager-8D8E585CAA10B70"));
		asoManager1.Enable = false;
		asoManager1.QueueActivity = false;
		// 
		// Result
		// 
		return asoManager1;
	}
}

}

