using System;

namespace CRMPrj
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// Automator-8D8E30F1807D26C
[OpenSpan.Design.ComponentIdentityAttribute("Automator-8D8E30F1807D26C")]
[System.ComponentModel.ToolboxItemAttribute(false)]
[OpenSpan.Runtime.RuntimeReferenceAttribute("System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619" +
	"34e089")]
public sealed class CRM_E_CRMfrmLogin_Created : OpenSpan.Automation.Automator
{
	
	private OpenSpan.Automation.ConnectableEvent connectableEvent1;
	
	private OpenSpan.Automation.ConnectableMethod connectableMethod2;
	
	private OpenSpan.Automation.ConnectableMethod connectableMethod3;
	
	private OpenSpan.Automation.ConnectableMethod connectableMethod1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("Automator-8D8E30F1807D26C\\MessageDialog-8D8E31AB9AC907D")]
	public OpenSpan.Controls.MessageDialog messageDialog1;
	
	private OpenSpan.Automation.ConnectableMethod connectableMethod4;
	
	[OpenSpan.Design.ComponentIdentityAttribute("Automator-8D8E30F1807D26C\\DiagnosticsLog-8D8E3EB41AC4BB4")]
	public OpenSpan.Controls.DiagnosticsLog diagnosticsLog1;
	
	private OpenSpan.Automation.ConnectableMethod connectableMethod5;
	
	[OpenSpan.Design.ComponentIdentityAttribute("Automator-8D8E30F1807D26C\\MessageDialog-8D8E52B72208536")]
	public OpenSpan.Controls.MessageDialog messageDialog2;
	
	public CRM_E_CRMfrmLogin_Created()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(CRM_E_CRMfrmLogin_Created));
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo1 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.Automation.MemberPrototype memberprototype2 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype3 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype4 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo2 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.Automation.MemberPrototype memberprototype5 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.ParameterPrototype parameterprototype1 = new OpenSpan.Automation.ParameterPrototype();
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo3 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.Automation.MemberPrototype memberprototype6 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.ParameterPrototype parameterprototype2 = new OpenSpan.Automation.ParameterPrototype();
		this.connectableEvent1 = new OpenSpan.Automation.ConnectableEvent();
		this.connectableMethod2 = new OpenSpan.Automation.ConnectableMethod();
		this.connectableMethod3 = new OpenSpan.Automation.ConnectableMethod();
		this.connectableMethod1 = new OpenSpan.Automation.ConnectableMethod();
		this.messageDialog1 = new OpenSpan.Controls.MessageDialog();
		this.connectableMethod4 = new OpenSpan.Automation.ConnectableMethod();
		this.diagnosticsLog1 = new OpenSpan.Controls.DiagnosticsLog();
		this.connectableMethod5 = new OpenSpan.Automation.ConnectableMethod();
		this.messageDialog2 = new OpenSpan.Controls.MessageDialog();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("Automator-8D8E30F1807D26C");
		// 
		// Set component Ids
		// 
		this.SetId(this.connectableEvent1, new OpenSpan.Design.ComponentIdentity("ConnectableEvent-8D8E310FA2B3435"));
		this.SetId(this.connectableMethod2, new OpenSpan.Design.ComponentIdentity("ConnectableMethod-8D8E311FBC3F15F"));
		this.SetId(this.connectableMethod3, new OpenSpan.Design.ComponentIdentity("ConnectableMethod-8D8E312358752BD"));
		this.SetId(this.connectableMethod1, new OpenSpan.Design.ComponentIdentity("ConnectableMethod-8D8E31199B54194"));
		this.SetId(this.messageDialog1, new OpenSpan.Design.ComponentIdentity("MessageDialog-8D8E31AB9AC907D"));
		this.SetId(this.connectableMethod4, new OpenSpan.Design.ComponentIdentity("ConnectableMethod-8D8E31ABC10C37E"));
		this.SetId(this.diagnosticsLog1, new OpenSpan.Design.ComponentIdentity("DiagnosticsLog-8D8E3EB41AC4BB4"));
		this.SetId(this.connectableMethod5, new OpenSpan.Design.ComponentIdentity("ConnectableMethod-8D8E3EB41B51E8E"));
		this.SetId(this.messageDialog2, new OpenSpan.Design.ComponentIdentity("MessageDialog-8D8E52B72208536"));
		// 
		// CRM_E_CRMfrmLogin_Created
		// 
		ComponentInfo.CodeDomData = _resources_.GetString("_CRM_E_CRMfrmLogin_Created_1_");
		this.DocumentScale = 0.7350919F;
		this.IsStartStoppable = false;
		this.LogData = true;
		this.LogEvents = true;
		this.LogFile = "";
		this.LogToFile = false;
		this.Name = "CRM_E_CRMfrmLogin_Created";
		this.ShowDesignCompNames = true;
		this.SuppressErrors = false;
		// 
		// connectableEvent1
		// 
		this.connectableEvent1.DisplayName = "null";
		this.connectableEvent1.ExceptionsHandled = false;
		this.connectableEvent1.InstanceTypeName = "OpenSpan.Adapters.Controls.Form";
		this.connectableEvent1.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D8DFE68142AF1E\\Form-8D8DFF16A0ECEEE");
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "Created";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Event;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = "System.EventHandler";
		this.connectableEvent1.MemberPrototypes.Add(memberprototype1);
		// 
		// connectableMethod2
		// 
		this.connectableMethod2.DisplayName = "<WaitForCreate>";
		dynamicpropertyinfo1.IsSerializable = true;
		dynamicpropertyinfo1.NoInputConvesion = false;
		dynamicpropertyinfo1.Source = "";
		dynamicpropertyinfo1.ValidateConnectionCallback = null;
		dynamicpropertyinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo1.CodeDomData = _resources_.GetString("_CRM_E_CRMfrmLogin_Created_2_");
		this.connectableMethod2.DynamicMembers.Add(dynamicpropertyinfo1);
		this.connectableMethod2.ExceptionsHandled = false;
		this.connectableMethod2.InstanceTypeName = "OpenSpan.Adapters.Controls.Button";
		this.connectableMethod2.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D8DFE68142AF1E\\Button-8D8DFF36D5B3441");
		memberprototype2.DefaultValue = null;
		memberprototype2.MemberName = "WaitForCreate";
		memberprototype2.MemberType = System.Reflection.MemberTypes.Method;
		memberprototype2.Signature.ReturnType = "System.Boolean";
		memberprototype2.TypeName = "System.Boolean";
		this.connectableMethod2.MemberPrototypes.Add(memberprototype2);
		this.connectableMethod2.ParamsLength = 0;
		this.connectableMethod2.SerializedParamsDefaultValues = "";
		// 
		// connectableMethod3
		// 
		this.connectableMethod3.DisplayName = "<PerformClick>";
		this.connectableMethod3.ExceptionsHandled = false;
		this.connectableMethod3.InstanceTypeName = "OpenSpan.Adapters.Controls.Button";
		this.connectableMethod3.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D8DFE68142AF1E\\Button-8D8DFF36D5B3441");
		memberprototype3.DefaultValue = null;
		memberprototype3.MemberName = "PerformClick";
		memberprototype3.MemberType = System.Reflection.MemberTypes.Method;
		memberprototype3.Signature.ReturnType = "System.Void";
		memberprototype3.TypeName = "System.Void";
		this.connectableMethod3.MemberPrototypes.Add(memberprototype3);
		this.connectableMethod3.ParamsLength = 0;
		this.connectableMethod3.SerializedParamsDefaultValues = "";
		// 
		// connectableMethod1
		// 
		this.connectableMethod1.DisplayName = "<PerformClick>";
		this.connectableMethod1.ExceptionsHandled = false;
		this.connectableMethod1.InstanceTypeName = "OpenSpan.Adapters.Controls.Button";
		this.connectableMethod1.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D8DFE68142AF1E\\Button-8D8DFF16A0C389F");
		memberprototype4.DefaultValue = null;
		memberprototype4.MemberName = "PerformClick";
		memberprototype4.MemberType = System.Reflection.MemberTypes.Method;
		memberprototype4.Signature.ReturnType = "System.Void";
		memberprototype4.TypeName = "System.Void";
		this.connectableMethod1.MemberPrototypes.Add(memberprototype4);
		this.connectableMethod1.ParamsLength = 0;
		this.connectableMethod1.SerializedParamsDefaultValues = "";
		// 
		// messageDialog1
		// 
		this.messageDialog1.Caption = "Information";
		this.messageDialog1.Message = "The user 1 button is not avaliable";
		this.SetScope(this.messageDialog1, OpenSpan.Design.ConnectableScope.Local);
		// 
		// connectableMethod4
		// 
		this.connectableMethod4.DisplayName = "<Show>";
		dynamicpropertyinfo2.IsSerializable = true;
		dynamicpropertyinfo2.NoInputConvesion = false;
		dynamicpropertyinfo2.Source = "";
		dynamicpropertyinfo2.ValidateConnectionCallback = null;
		dynamicpropertyinfo2.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo2.CodeDomData = _resources_.GetString("_CRM_E_CRMfrmLogin_Created_3_");
		this.connectableMethod4.DynamicMembers.Add(dynamicpropertyinfo2);
		this.connectableMethod4.ExceptionsHandled = false;
		this.connectableMethod4.InstanceTypeName = "OpenSpan.Controls.MessageDialog";
		this.connectableMethod4.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("Automator-8D8E30F1807D26C\\MessageDialog-8D8E31AB9AC907D");
		memberprototype5.DefaultValue = null;
		memberprototype5.MemberName = "Show";
		memberprototype5.MemberType = System.Reflection.MemberTypes.Method;
		parameterprototype1.CanRead = false;
		parameterprototype1.CanWrite = true;
		parameterprototype1.DefaultSet = true;
		parameterprototype1.DefaultValue = "The user 1 button is not avaliable.\r\n";
		parameterprototype1.ParamName = "message";
		parameterprototype1.Position = 0;
		parameterprototype1.TypeName = "System.String";
		memberprototype5.Signature.ParameterPrototype.Add(parameterprototype1);
		memberprototype5.Signature.ReturnType = "System.Windows.Forms.DialogResult";
		memberprototype5.TypeAssemblyName = "System.Windows.Forms";
		memberprototype5.TypeName = "System.Windows.Forms.DialogResult";
		this.connectableMethod4.MemberPrototypes.Add(memberprototype5);
		this.connectableMethod4.ParamsLength = 0;
		this.connectableMethod4.SerializedParamsDefaultValues = "";
		// 
		// diagnosticsLog1
		// 
		this.SetScope(this.diagnosticsLog1, OpenSpan.Design.ConnectableScope.Local);
		// 
		// connectableMethod5
		// 
		this.connectableMethod5.DisplayName = "<Log>";
		dynamicpropertyinfo3.IsSerializable = true;
		dynamicpropertyinfo3.NoInputConvesion = false;
		dynamicpropertyinfo3.Source = "";
		dynamicpropertyinfo3.ValidateConnectionCallback = null;
		dynamicpropertyinfo3.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo3.CodeDomData = _resources_.GetString("_CRM_E_CRMfrmLogin_Created_4_");
		this.connectableMethod5.DynamicMembers.Add(dynamicpropertyinfo3);
		this.connectableMethod5.ExceptionsHandled = false;
		this.connectableMethod5.InstanceTypeName = "OpenSpan.Controls.DiagnosticsLog";
		this.connectableMethod5.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("Automator-8D8E30F1807D26C\\DiagnosticsLog-8D8E3EB41AC4BB4");
		memberprototype6.DefaultValue = null;
		memberprototype6.MemberName = "Log";
		memberprototype6.MemberType = System.Reflection.MemberTypes.Method;
		parameterprototype2.CanRead = false;
		parameterprototype2.CanWrite = true;
		parameterprototype2.DefaultSet = true;
		parameterprototype2.DefaultValue = "First Name Last Name";
		parameterprototype2.ParamName = "message";
		parameterprototype2.Position = 0;
		parameterprototype2.TypeName = "System.String";
		memberprototype6.Signature.ParameterPrototype.Add(parameterprototype2);
		memberprototype6.Signature.ReturnType = "System.String";
		memberprototype6.TypeName = "System.String";
		this.connectableMethod5.MemberPrototypes.Add(memberprototype6);
		this.connectableMethod5.ParamsLength = 0;
		this.connectableMethod5.SerializedParamsDefaultValues = "";
		// 
		// messageDialog2
		// 
		this.messageDialog2.Caption = "Information";
		this.messageDialog2.Message = null;
		this.SetScope(this.messageDialog2, OpenSpan.Design.ConnectableScope.Local);
		// 
		// Initialize CodeDom data
		// 
		this.CodeDomData = _resources_.GetString("_CRM_E_CRMfrmLogin_Created_5_");
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.connectableEvent1);
		this.Components.Add(this.connectableMethod2);
		this.Components.Add(this.connectableMethod3);
		this.Components.Add(this.connectableMethod1);
		this.Components.Add(this.messageDialog1);
		this.Components.Add(this.connectableMethod4);
		this.Components.Add(this.diagnosticsLog1);
		this.Components.Add(this.connectableMethod5);
		this.Components.Add(this.messageDialog2);
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
	
	internal OpenSpan.Automation.ConnectableEvent Create_connectableEvent1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableEvent connectableEvent1 = new OpenSpan.Automation.ConnectableEvent();
		this.SetId(connectableEvent1, new OpenSpan.Design.ComponentIdentity("ConnectableEvent-8D8E310FA2B3435"));
		connectableEvent1.DisplayName = "null";
		connectableEvent1.ExceptionsHandled = false;
		connectableEvent1.InstanceTypeName = "OpenSpan.Adapters.Controls.Form";
		connectableEvent1.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D8DFE68142AF1E\\Form-8D8DFF16A0ECEEE");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "Created";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Event;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = "System.EventHandler";
		connectableEvent1.MemberPrototypes.Add(memberprototype1);
		// 
		// Result
		// 
		return connectableEvent1;
	}
	
	internal OpenSpan.Automation.ConnectableMethod Create_connectableMethod2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(CRM_E_CRMfrmLogin_Created));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableMethod connectableMethod2 = new OpenSpan.Automation.ConnectableMethod();
		this.SetId(connectableMethod2, new OpenSpan.Design.ComponentIdentity("ConnectableMethod-8D8E311FBC3F15F"));
		connectableMethod2.DisplayName = "<WaitForCreate>";
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo1 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo1.IsSerializable = true;
		dynamicpropertyinfo1.NoInputConvesion = false;
		dynamicpropertyinfo1.Source = "";
		dynamicpropertyinfo1.ValidateConnectionCallback = null;
		dynamicpropertyinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo1.CodeDomData = _resources_.GetString("_CRM_E_CRMfrmLogin_Created_2_");
		connectableMethod2.DynamicMembers.Add(dynamicpropertyinfo1);
		connectableMethod2.ExceptionsHandled = false;
		connectableMethod2.InstanceTypeName = "OpenSpan.Adapters.Controls.Button";
		connectableMethod2.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D8DFE68142AF1E\\Button-8D8DFF36D5B3441");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "WaitForCreate";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Method;
		memberprototype1.Signature.ReturnType = "System.Boolean";
		memberprototype1.TypeName = "System.Boolean";
		connectableMethod2.MemberPrototypes.Add(memberprototype1);
		connectableMethod2.ParamsLength = 0;
		connectableMethod2.SerializedParamsDefaultValues = "";
		// 
		// Result
		// 
		return connectableMethod2;
	}
	
	internal OpenSpan.Automation.ConnectableMethod Create_connectableMethod3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableMethod connectableMethod3 = new OpenSpan.Automation.ConnectableMethod();
		this.SetId(connectableMethod3, new OpenSpan.Design.ComponentIdentity("ConnectableMethod-8D8E312358752BD"));
		connectableMethod3.DisplayName = "<PerformClick>";
		connectableMethod3.ExceptionsHandled = false;
		connectableMethod3.InstanceTypeName = "OpenSpan.Adapters.Controls.Button";
		connectableMethod3.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D8DFE68142AF1E\\Button-8D8DFF36D5B3441");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "PerformClick";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Method;
		memberprototype1.Signature.ReturnType = "System.Void";
		memberprototype1.TypeName = "System.Void";
		connectableMethod3.MemberPrototypes.Add(memberprototype1);
		connectableMethod3.ParamsLength = 0;
		connectableMethod3.SerializedParamsDefaultValues = "";
		// 
		// Result
		// 
		return connectableMethod3;
	}
	
	internal OpenSpan.Automation.ConnectableMethod Create_connectableMethod1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableMethod connectableMethod1 = new OpenSpan.Automation.ConnectableMethod();
		this.SetId(connectableMethod1, new OpenSpan.Design.ComponentIdentity("ConnectableMethod-8D8E31199B54194"));
		connectableMethod1.DisplayName = "<PerformClick>";
		connectableMethod1.ExceptionsHandled = false;
		connectableMethod1.InstanceTypeName = "OpenSpan.Adapters.Controls.Button";
		connectableMethod1.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D8DFE68142AF1E\\Button-8D8DFF16A0C389F");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "PerformClick";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Method;
		memberprototype1.Signature.ReturnType = "System.Void";
		memberprototype1.TypeName = "System.Void";
		connectableMethod1.MemberPrototypes.Add(memberprototype1);
		connectableMethod1.ParamsLength = 0;
		connectableMethod1.SerializedParamsDefaultValues = "";
		// 
		// Result
		// 
		return connectableMethod1;
	}
	
	internal OpenSpan.Controls.MessageDialog Create_messageDialog1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Controls.MessageDialog messageDialog1 = new OpenSpan.Controls.MessageDialog();
		this.SetId(messageDialog1, new OpenSpan.Design.ComponentIdentity("MessageDialog-8D8E31AB9AC907D"));
		this.SetScope(messageDialog1, OpenSpan.Design.ConnectableScope.Local);
		messageDialog1.Caption = "Information";
		messageDialog1.Message = "The user 1 button is not avaliable";
		// 
		// Result
		// 
		return messageDialog1;
	}
	
	internal OpenSpan.Automation.ConnectableMethod Create_connectableMethod4(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(CRM_E_CRMfrmLogin_Created));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableMethod connectableMethod4 = new OpenSpan.Automation.ConnectableMethod();
		this.SetId(connectableMethod4, new OpenSpan.Design.ComponentIdentity("ConnectableMethod-8D8E31ABC10C37E"));
		connectableMethod4.DisplayName = "<Show>";
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo1 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo1.IsSerializable = true;
		dynamicpropertyinfo1.NoInputConvesion = false;
		dynamicpropertyinfo1.Source = "";
		dynamicpropertyinfo1.ValidateConnectionCallback = null;
		dynamicpropertyinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo1.CodeDomData = _resources_.GetString("_CRM_E_CRMfrmLogin_Created_3_");
		connectableMethod4.DynamicMembers.Add(dynamicpropertyinfo1);
		connectableMethod4.ExceptionsHandled = false;
		connectableMethod4.InstanceTypeName = "OpenSpan.Controls.MessageDialog";
		connectableMethod4.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("Automator-8D8E30F1807D26C\\MessageDialog-8D8E31AB9AC907D");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "Show";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Method;
		OpenSpan.Automation.ParameterPrototype parameterprototype1 = new OpenSpan.Automation.ParameterPrototype();
		parameterprototype1.CanRead = false;
		parameterprototype1.CanWrite = true;
		parameterprototype1.DefaultSet = true;
		parameterprototype1.DefaultValue = "The user 1 button is not avaliable.\r\n";
		parameterprototype1.ParamName = "message";
		parameterprototype1.Position = 0;
		parameterprototype1.TypeName = "System.String";
		memberprototype1.Signature.ParameterPrototype.Add(parameterprototype1);
		memberprototype1.Signature.ReturnType = "System.Windows.Forms.DialogResult";
		memberprototype1.TypeAssemblyName = "System.Windows.Forms";
		memberprototype1.TypeName = "System.Windows.Forms.DialogResult";
		connectableMethod4.MemberPrototypes.Add(memberprototype1);
		connectableMethod4.ParamsLength = 0;
		connectableMethod4.SerializedParamsDefaultValues = "";
		// 
		// Result
		// 
		return connectableMethod4;
	}
	
	internal OpenSpan.Controls.DiagnosticsLog Create_diagnosticsLog1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Controls.DiagnosticsLog diagnosticsLog1 = new OpenSpan.Controls.DiagnosticsLog();
		this.SetId(diagnosticsLog1, new OpenSpan.Design.ComponentIdentity("DiagnosticsLog-8D8E3EB41AC4BB4"));
		this.SetScope(diagnosticsLog1, OpenSpan.Design.ConnectableScope.Local);
		// 
		// Result
		// 
		return diagnosticsLog1;
	}
	
	internal OpenSpan.Automation.ConnectableMethod Create_connectableMethod5(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(CRM_E_CRMfrmLogin_Created));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableMethod connectableMethod5 = new OpenSpan.Automation.ConnectableMethod();
		this.SetId(connectableMethod5, new OpenSpan.Design.ComponentIdentity("ConnectableMethod-8D8E3EB41B51E8E"));
		connectableMethod5.DisplayName = "<Log>";
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo1 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo1.IsSerializable = true;
		dynamicpropertyinfo1.NoInputConvesion = false;
		dynamicpropertyinfo1.Source = "";
		dynamicpropertyinfo1.ValidateConnectionCallback = null;
		dynamicpropertyinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo1.CodeDomData = _resources_.GetString("_CRM_E_CRMfrmLogin_Created_4_");
		connectableMethod5.DynamicMembers.Add(dynamicpropertyinfo1);
		connectableMethod5.ExceptionsHandled = false;
		connectableMethod5.InstanceTypeName = "OpenSpan.Controls.DiagnosticsLog";
		connectableMethod5.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("Automator-8D8E30F1807D26C\\DiagnosticsLog-8D8E3EB41AC4BB4");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "Log";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Method;
		OpenSpan.Automation.ParameterPrototype parameterprototype1 = new OpenSpan.Automation.ParameterPrototype();
		parameterprototype1.CanRead = false;
		parameterprototype1.CanWrite = true;
		parameterprototype1.DefaultSet = true;
		parameterprototype1.DefaultValue = "First Name Last Name";
		parameterprototype1.ParamName = "message";
		parameterprototype1.Position = 0;
		parameterprototype1.TypeName = "System.String";
		memberprototype1.Signature.ParameterPrototype.Add(parameterprototype1);
		memberprototype1.Signature.ReturnType = "System.String";
		memberprototype1.TypeName = "System.String";
		connectableMethod5.MemberPrototypes.Add(memberprototype1);
		connectableMethod5.ParamsLength = 0;
		connectableMethod5.SerializedParamsDefaultValues = "";
		// 
		// Result
		// 
		return connectableMethod5;
	}
	
	internal OpenSpan.Controls.MessageDialog Create_messageDialog2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Controls.MessageDialog messageDialog2 = new OpenSpan.Controls.MessageDialog();
		this.SetId(messageDialog2, new OpenSpan.Design.ComponentIdentity("MessageDialog-8D8E52B72208536"));
		this.SetScope(messageDialog2, OpenSpan.Design.ConnectableScope.Local);
		messageDialog2.Caption = "Information";
		messageDialog2.Message = null;
		// 
		// Result
		// 
		return messageDialog2;
	}
}

}

