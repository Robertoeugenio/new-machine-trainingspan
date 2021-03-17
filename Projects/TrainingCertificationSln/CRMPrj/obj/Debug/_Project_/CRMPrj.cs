using CRMPrj_ACMESearch = CRMPrj.ACMESearch;

using CRMPrj_CRM = CRMPrj.CRM;

using CRMPrj_CRM_E_IntMgr_InteractionStarted = CRMPrj.CRM_E_IntMgr_InteractionStarted;

using CRMPrj_CRM_E_CRMChild_Closing = CRMPrj.CRM_E_CRMChild_Closing;

using CRMPrj_CRM_E_CRMChild_Created = CRMPrj.CRM_E_CRMChild_Created;

using CRMPrj_CRM_E_CRMfrmLogin_Created = CRMPrj.CRM_E_CRMfrmLogin_Created;

using CRMPrj__GC_CRM = CRMPrj._GC_CRM;

using System;

namespace CRMPrj.Project
{
// Project-8D8DDA51F9DEA2F
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D8DDA51F9DEA2F")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class CRMPrj : OpenSpan.Runtime.RuntimeProject
{
	
	public CRMPrj() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CRMPrj(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CRMPrj(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CRMPrj(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private CRMPrj(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void CRMPrj_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D8DDA51F9DEA2F");
		this.mVersion = new System.Version("19.1.75.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("19.1.0.25");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
		this.mInteractionConfigXml = "<Interaction Name=\"Call\" xmlns:json=\'http://james.newtonking.com/projects/json\'>\r" +
			"\n\r\n\t<!--\tThe Context section defines what information is stored about an interac" +
			"tion. Property values are set and\r\n\t\tretrieved via the InteractionManager compon" +
			"ent. Defining a context includes defining these values:\r\n\r\n\t\t\tName - Identifies " +
			"the property in automations and in the plug-in configuration.\r\n\t\t\tType - Specifi" +
			"es the property\'s underlying data type. Valid entries are String, Number, Boolea" +
			"n, and Date.\r\n\t\t\tDefault - Specifies a default value. The property is populated " +
			"with this value when an\r\n\t\t\t   interaction is created.\r\n\t\t\tFormat - Controls how" +
			" the system displays the value. Strings can be formatted as either numbers or da" +
			"tes.\r\n\t\t\t\tSeveral Numeric options are:\r\n\t\t\t\t\t\"C\" for currency\r\n\t\t\t\t\t\"D\" for deci" +
			"mal\r\n\t\t\t\t\t\"P\" for percent\r\n\t\t\t\tSeveral Date options are:\r\n\t\t\t\t\t\"d\" for short dat" +
			"e (month, day, year)\r\n\t\t\t\t\t\"D\" for long date (day of week, month, day, year)\r\n\t\t" +
			"\t\t\t\"m\" or \"M\" for month format (day, month)\r\n\t\t\t\t\t\"y\" or \"Y\" for year format (mo" +
			"nth, year)\r\n\t\t\t\t\t\"t\" for short time (time to minutes)\r\n\t\t\t\t\t\"T\" for long time (t" +
			"ime to seconds)\r\n\t\t\t\t\t\"g\" for short date and time (day, month, year, time to min" +
			"utes)\r\n\t\t\t\t\t\"G\" for long date and time (day, month, year, time to seconds)\r\n\t\t\t\t" +
			"\t\"u\" for universal time\r\n\t\t\t-->\r\n\r\n\t<Context>\r\n\t\t<Value Name=\"AcctNum\" Type=\"Str" +
			"ing\" Default=\"10000\"/>\r\n\t\t<Value Name=\"Name\" Type=\"String\" Default=\"[No Active C" +
			"all]\"/>\r\n\t\t<Value Name=\"Adress\" Type=\"String\" Default=\"xxxxx\"/>\r\n\t\t<Value Name=\"" +
			"City\" Type=\"String\" Default=\"xxxxx\"/>\r\n\t\t<Value Name=\"State\" Type=\"String\" Defau" +
			"lt=\"xxxxx\"/>\r\n\t\t<Value Name=\"ZipCode\" Type=\"String\" Default=\"xxxxx\"/>\r\n\t\t<Value " +
			"Name=\"NearestStore\" Type=\"String\" Default=\"xxxxx\"/>\r\n\t\r\n\t\t\r\n\r\n\t</Context>\r\n\r\n\t<!" +
			"--\tThe Globals section defines information that is stored independent of interac" +
			"tions. Global values\r\n\t\tare accessed through the global dictionary component. De" +
			"fining a global value is similar to defining a context value:\r\n\r\n\t\t\tName - Ident" +
			"ifies the property in automations and in the plug-in configuration.\r\n\t\t\tType - S" +
			"pecifies the property\'s underlying data type. Valid entries are String, Number, " +
			"Boolean, and Date.\r\n\t\t\tDefault - Specifies a default value. The property is popu" +
			"lated with this value at system start-up.\r\n\t\t\tFormat - Controls how the system d" +
			"isplays the value. Strings can be formatted as either numbers or dates.\r\n\t\t\t\tSev" +
			"eral Numeric options are:\r\n\t\t\t\t\t\"C\" for currency\r\n\t\t\t\t\t\"D\" for decimal\r\n\t\t\t\t\t\"P\"" +
			" for percent\r\n\t\t\t\tSeveral Date options are:\r\n\t\t\t\t\t\"d\" for short date (month, day" +
			", year)\r\n\t\t\t\t\t\"D\" for long date (day of week, month, day, year)\r\n\t\t\t\t\t\"m\" or \"M\"" +
			" for month format (day, month)\r\n\t\t\t\t\t\"y\" or \"Y\" for year format (month, year)\r\n\t" +
			"\t\t\t\t\"t\" for short time (time to minutes)\r\n\t\t\t\t\t\"T\" for long time (time to second" +
			"s)\r\n\t\t\t\t\t\"g\" for short date and time (day, month, year, time to minutes)\r\n\t\t\t\t\t\"" +
			"G\" for long date and time (day, month, year, time to seconds)\r\n\t\t\t\t\t\"u\" for univ" +
			"ersal time\r\n\t\t\t-->\r\n\r\n\t<Globals>\r\n\t\t<Value Name=\"AgentName\" Type=\"String\" Defaul" +
			"t=\"\"/>\r\n\t\t<Value Name=\"ConversionPercentage\" Type=\"Number\" Format=\"P\" Default=\"0" +
			"\"/>\r\n\t\t<Value Name=\"AverageHandleTime\" Type=\"String\" Default=\"\"/>\r\n\t\t<Value Name" +
			"=\"AveragePayment\" Type=\"Number\" Format=\"C\" Default=\"0\"/>\r\n\t</Globals>\r\n\r\n\t<!--\tA" +
			"n Activity describes a piece of work that needs to done. An automation can reque" +
			"st that an activity be performed\r\n\t\tor perform an activity when requested. Activ" +
			"ities are queued and run sequentially. This means that only one activity\r\n\t\tis p" +
			"rocessed at a time. Any automation can request that an activity be performed by " +
			"calling the StartActivity method\r\n\t\tfrom the Activity component. The activity is" +
			" placed at the end of the queue and will be processed when all activities in\r\n\t\t" +
			"front of it are completed. An activity is completed when all automations that ar" +
			"e listening to Activity.ActivityStarted\r\n\t\thave finished their execution.\r\n\r\n\t\t\t" +
			"Name - Provides a descriptive name of an activity.  The activity component uses " +
			"this name for identification.\r\n\t\t\tValue - Specifies the parameters and propertie" +
			"s of an activity.\r\n\t\t\tType - Specifies the type of the Value, such as Boolean or" +
			" String.\r\n\t\t\tRequiresInteraction - Specifies if an interaction needs to be activ" +
			"e for the\r\n\t\t\t\tactivity to run. The defaults is True.\r\n\r\n\t\t\tIn the example below" +
			", the AddPlan activity will have a StartActivity() method with\r\n\t\t\ttwo parameter" +
			"s: PlanType and EffectiveDate.\r\n\t\t\tWhen used in automations, there will also be " +
			"an ActivityStarted event with PlanType and EffectiveDate outputs.\r\n\t\t\tAdditional" +
			"ly, an activity component for AddPlan will have a PlanType property\r\n\t\t\tand an E" +
			"ffectiveDate property. These property values can be set or retrieved during the " +
			"execution\r\n\t\t\tof the activity or in response to the ActivityCompleted event.\r\n\r\n" +
			"\t\t\t<Activity Name=\"AddPlan\" RequiresInteraction=\"True\">\r\n\t\t\t\t<Value Name=\"PlanTy" +
			"pe\" Type=\"String\"/>\r\n\t\t\t\t<Value Name=\"EffectiveDate\" Type=\"Date\"/>\r\n\t\t\t</Activit" +
			"y>\r\n\r\n\t\t\tWhen defining an activity, make sure that all the data required to perf" +
			"orm the\r\n\t\t\tactivity is available through context values or the activity’s prope" +
			"rties.\r\n\t\t\t-->\r\n \r\n\t<Activities>\r\n\r\n\r\n\t    <Activity Name=\"GetCustomerInformatio" +
			"n\">\r\n\t\t\t<Value Name=\"GetCustomerInformation\" Type=\"String\"/>\r\n\t\t</Activity> \r\n\t " +
			"   <Activity Name=\"Update Display\">\r\n\t\t\t<Value Name=\"Update Display\" Type=\"Strin" +
			"g\"/>\r\n\t\t</Activity>\r\n\r\n\r\n\r\n\t\t\r\n\t\t<Activity Name=\"ValidateCaller\">\r\n\t\t\t<Value Nam" +
			"e=\"CallerValid\" Type=\"Boolean\"/>\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"ValidateCalle" +
			"r\">\r\n\t\t\t<Value Name=\"CallerValid\" Type=\"Boolean\"/>\r\n\t\t</Activity>\r\n\r\n\t\t<Activity" +
			" Name=\"UnvalidateCaller\">\r\n\t\t\t<Value Name=\"CallerValid\" Type=\"Boolean\"/>\r\n\t\t</Ac" +
			"tivity>\r\n\t\t<Activity Name=\"AddPlan\">\r\n\t\t\t<Value Name=\"PlanType\" Type=\"String\"/>\r" +
			"\n\t\t\t<Value Name=\"EffectiveDate\" Type=\"String\"/>\r\n\t\t</Activity>\r\n\t\t<Activity Name" +
			"=\"CloseAccount\">\r\n\t\t\t<Value Name=\"EffectiveDate\" Type=\"String\"/>\r\n\t\t</Activity>\r" +
			"\n\t\t<Activity Name=\"ProcessClaim\">\r\n\t\t\t<Value Name=\"ClaimNum\" Type=\"String\"/>\r\n\t\t" +
			"\t<Value Name=\"ClaimDate\" Type=\"String\"/>\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"Proce" +
			"ssClaim\">\r\n\t\t</Activity>\r\n\t</Activities>\r\n\r\n\t<!--  Plug-ins are HTML user interf" +
			"ace sections in the toolbar. Agile Desktop includes these plug-ins:\r\n\t\t\t- 360 Vi" +
			"ew - Provides access to key customer information at a glance.\r\n\t\t\t- Notes - Lets" +
			" you add notes and search historic notes.\r\n\t\t\t- Shortcuts - Provides buttons to " +
			"launch an exe, go to a web site, execute an automation,\r\n\t\t\t\tor start an activit" +
			"y.\r\n\t\t\t- Interaction Manager - Provides a list of all current interactions on to" +
			"p of the 360 View.\r\n\t\t\t- Start Interaction - Provides a way for the Agile Deskto" +
			"p user to enter a string which can be\r\n\t\t\t\tretrieved in an automation and used f" +
			"or starting an interaction.\r\n\t\t  GENERIC PLUG-IN SETTINGS\r\n\r\n\t\t\t\tPlugin:IsActive" +
			" - Indicates if the plug-in appears in the toolbar.\r\n\t\t\t\tPlugin:HasExtendedView " +
			"- Indicates if the plug-in can be expanded to show more information.\r\n\t\t\t\tPlugin" +
			":EnableWithNoActiveInteraction - Indicates if the user can interact with the plu" +
			"g-in when\r\n\t\t\t\t\tthere is no active interaction.\r\n\t\t\t\tPlugin:CanHide - If False, " +
			"the user cannot hide the plug-in from the gear menu.\r\n\t\t\t\t-->\r\n\r\n\t<Plugins>\r\n\r\n\t" +
			"\t<!--\t360 View - This plug-in displays interaction context values that may be ne" +
			"eded at a glance.\r\n\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tPlugin/Section   - Prov" +
			"ides a logical grouping of the elements within the Plug-In.\r\n\t\t\t\t\t**NOTE** - <se" +
			"ction> tag is case insensitive.\r\n\t\t\t\tPlugin/Section:Visibility - You can choose " +
			"from these options:\r\n\t\t\t\t\tPrimary - The Section is added to the Primary view.\r\n\t" +
			"\t\t\t\tExtended - The Section is added to the Extended view.\r\n\t\t\t\t\tBoth - The Secti" +
			"on is added to both the Primary and Extended views.\r\n\t\t\t\tPlugin/Section:Name - I" +
			"ndicates the style in which the section data is displayed. You can choose from t" +
			"hese options:\r\n\t\t\t\t\tImages, Identity, Ratings, Products, Custom, Balances, Eligi" +
			"bility, or Information.\r\n\t\t\t\t\t**NOTE** - Item containing Image will only appear " +
			"in section with Name attribute set to Images.\r\n\t\t\t\tPlugin/Section:Label - An opt" +
			"ional label that can appear at the top of the section.\r\n\t\t\t\tPlugin/Section:Inner" +
			"Label - An optional smaller label that ONLY appears on top of \"Information\" sect" +
			"ion. Default value is \"Contact Information\".\r\n\t\t\t\tPlugin/Section:Divider - A tru" +
			"e/false value that determines if a divider line will appear above the section.\r\n" +
			"\t\t\t\tPlugin/Section:ImagePadding - Specify the padding between images in the Imag" +
			"es section. Default padding is 24 pixels.\r\n\t\t\t\t\t**NOTE** - ImagePadding is optio" +
			"nal, ONLY accepts numbers, ONLY works in Images section. If empty, default paddi" +
			"ng size will be used.\r\n\t\t\t\tPlugin/Section/Item:Name - Identifies the item in the" +
			" plugin\r\n\t\t\t\tPlugin/Section/Item:Image - Specify the name of the image to be dis" +
			"played.\r\n\t\t\t\t\t1) To use default icons, choose from the following default values\r" +
			"\n\t\t\t\t\t\tCash, Check, MoneyOrder, Credit\r\n\t\t\t\t\t2) To use custom images, follow the" +
			"se steps below:\r\n\t\t\t\t\t\t1. Add your images to the startup automation project.\r\n\t\t" +
			"\t\t\t\t\tOr, put images in a local folder and add  <CustomImagePath value=\"C:\\path\\t" +
			"o\\your\\pic\\folder\" /> to RuntimeConfig.xml <AgileDesktop /> section.\r\n\t\t\t\t\t\t2. P" +
			"ut your image name as the value of Image attribute. Make sure to only use (.png)" +
			" images and include the file extension.\r\n\t\t\t\tPlugin/Section/Item:Tooltip - Enter" +
			" a text you want to appear when mouse over image. Only works with image item.\r\n\t" +
			"\t\t\tPlugin/Section/Item:TextWrap - Set to true if you want the text in that Item " +
			"to wrap to the next line, instead of truncate. Default is False.\r\n\t\t\t\t\t**NOTE** " +
			"- TextWrap option must be in the Item element, and only works with items in \"Pro" +
			"ducts\", \"Balances\", and \"Custom\" Sections.\r\n\t\t\t\tPlugin/Section/Item:TextAlign - " +
			"Set the text alignment in an Item, whether left or right. Only works with items " +
			"in \"Custom\" Sections. Default is Left.\r\n\t\t\t\tPlugin/Section/Item/Context:Name - S" +
			"pecifies the name of context value (defined in the Context section) used to popu" +
			"late\r\n\t\t\t\t\tthis item. As the associated context property value changes, this ite" +
			"m is automatically updated.\r\n\t\t\t\tPlugin/Section/Item/Label - Defines the text la" +
			"bel that appears in the toolbar. If omitted,\r\n\t\t\t\t\tthe Name value is used.\r\n\t\t\t\t" +
			"Plugin/Section/Item/Visible:Criteria - Specifies if an item will be displayed ba" +
			"sed on a context value, and comparison expression.\r\n\t\t\t\t\tFor examle, add <Visibl" +
			"e Criteria=\"SocialInfluence gt 3\"/> to an item, will only display the item if So" +
			"cialInfluence context value is greater than 3.\r\n\r\n\t\t\t\t**NOTE** - Every Item in t" +
			"he 360AppBar Plugin can be set up as clickable shortcut, instructions are shown " +
			"below.\r\n\t\t\t\tPlugin/Section/Item:ShortcutType - Indicates type of shortcut. Choos" +
			"e from these options:\r\n\t\t\t\t\t* Activity - Starts an activity.\r\n\t\t\t\t\t* Url - Goes " +
			"to a web page.\r\n\t\t\t\t\t* External - Starts an executable.\r\n\t\t\t\t\t* Automation - Sta" +
			"rts an automation.\r\n\t\t\t\tPlugin/Section/Item:ActivityName - For Activity shortcut" +
			"s, enter the name of the activity that should start when the\r\n\t\t\t\t\tItem is click" +
			"ed.\r\n\t\t\t\tPlugin/Section/Item:Target - Enter the destination for the shortcut. Fo" +
			"r instance, if the shortcut is a web site, you\r\n\t\t\t\t\tenter the URL. If the short" +
			"cut launches an executable file, enter the name of that file.\r\n\t\t\t\tPlugin/Sectio" +
			"n/Item:Project - For automation shortcuts, enter the name of the project that co" +
			"ntains the automation. If the\r\n\t\t\t\t\tproject name contains a space replace it her" +
			"e with an underscore. My Project should become My_Project.\r\n\t\t\t\tPlugin/Section/I" +
			"tem:AutomationName - For automation shortcuts, enter the name of the automation " +
			"that should start when the\r\n\t\t\t\t\tItem is clicked. If the automation name contain" +
			"s a space replace it here with an underscore. My Automation should become My_Aut" +
			"omation.\r\n\t\t\t\t\tThis automation should have an entry point, and parameters can be" +
			" passed into entry point if needed.\r\n\t\t\t\tPlugin/Section/Item:Params - For passin" +
			"g parameters into automation entry point. Only use it when Shortcut type is \"Aut" +
			"omation\".\r\n\t\t\t\t\tSeparate multiple parameters by comma.\r\n\t\t\t\t\tParameters will be " +
			"passed in the order as they appear here.\r\n\t\t\t\t\t* Context. - Prefix with Context." +
			" to use context values defined in the Context section of this document.\r\n\t\t\t\t\t* " +
			"Globals. - Prefix with Globals. to use global values defined in the Globals sect" +
			"ion of this document.\r\n\t\t\t\t\t* Interaction.ActiveKey - Use this keyword to pass i" +
			"n the current active interaction key.\r\n\t\t\t\t\t* \"  \" - Use double quotes to pass s" +
			"tring literal into entry point. However the value string for the whole Params at" +
			"tribute should be in single quotes.\r\n\t\t\t\t\t* \'  \' - Use single quotes to pass str" +
			"ing literal into entry point. However the value string for the whole Params attr" +
			"ibute should be in double quotes.\r\n\t\t\t\t\t\t**NOTE** - Use #apos; for apostrophe (\'" +
			"), and #quot; for quote (\") inside string literal. Use regular HTML entities for" +
			" other special characters if there is a XML syntax error.\r\n\t\t\t\t\t\t**NOTE** - If n" +
			"o active interaction, \"Context.\" and \"Interaction.ActiveKey\" will be passed as n" +
			"ull value\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"360AppBar\" Label=\"360 View\" IsActive=\"True" +
			"\" HasExtendedView=\"True\" CanHide=\"False\" EnableWithNoActiveInteraction=\"False\">\r" +
			"\n\t\t\t<Section Name=\"Identity\" Visibility=\"Primary\">\r\n\t\t\t\t<Item Name=\"FullName\"  S" +
			"hortcutType=\"Automation\" Project=\"AgileDesktopExampleProject\" AutomationName=\"My" +
			"Automation\">\r\n\t\t\t\t\t<Context Name=\"ClientFullName\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t<" +
			"/Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Ratings\" Visibility=\"Primary\">\r\n\t\t\t\t<It" +
			"em Name=\"SocialInfluence\" ShortcutType=\"Automation\" Project=\"AgileDesktopExample" +
			"Project\" \r\n\t\t\t\t\tAutomationName=\"MyAutomation\" Params=\"Context.ClientFullName, Gl" +
			"obals.AgentName, \'It#apos;s a string...\' , Interaction.ActiveKey\">\r\n\t\t\t\t\t<Contex" +
			"t Name=\"SocialInfluence\"/>\r\n\t\t\t\t\t<Label>Social Influence</Label>\r\n\t\t\t\t\t<MaxValue" +
			">5</MaxValue>\r\n\t\t\t\t\t<Visible Criteria=\"SocialInfluence eq 0\"/>\r\n\t\t\t\t</Item>\r\n\t\t\t" +
			"\t<Item Name=\"LifetimeValue\">\r\n\t\t\t\t\t<Context Name=\"LifetimeValue\"/>\r\n\t\t\t\t\t<Label>" +
			"Lifetime Value</Label>\r\n\t\t\t\t\t<MaxValue>5</MaxValue>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r" +
			"\n\t\t\t<Section Name=\"Images\" Visibility=\"Both\" Divider=\"True\" Label=\"Default Image" +
			"s Padding\"  ImagePadding=\"24\">\r\n\t\t\t\t<Item Image=\"Cash\" Tooltip=\"Cash Default Ico" +
			"n\" ShortcutType=\"Activity\" ActivityName=\"MyActivity\"/>\r\n\t\t\t\t<Item Image=\"Check\" " +
			"Tooltip=\"Check Default Icon\" ShortcutType=\"Url\" Target=\"http://www.pega.com\"/>\r\n" +
			"\t\t\t\t<Item Image=\"MoneyOrder\"/>\r\n\t\t\t\t<Item Image=\"Credit\">\r\n\t\t\t\t\t<Visible Criteri" +
			"a=\"SocialInfluence eq 0\"/>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Image=\"MyCustomImage.png\"/>\r\n" +
			"\t\t\t</Section>\r\n\t\t\t<Section Name=\"Images\" Visibility=\"Both\" Divider=\"True\" Label=" +
			"\"Custom Images Padding\" ImagePadding=\"40\">\r\n\t\t\t\t<Item Image=\"Cash\"/>\r\n\t\t\t\t<Item " +
			"Image=\"Check\"/>\r\n\t\t\t\t<Item Image=\"MoneyOrder\"/>\r\n\t\t\t\t<Item Image=\"Credit\"/>\r\n\t\t\t" +
			"</Section>\r\n\t\t\t<Section Name=\"Products\" Visibility=\"Primary\" Label=\"Products Sec" +
			"tion Label\" Divider=\"True\">\r\n\t\t\t\t<Item Name=\"VoicePlan\" ShortcutType=\"External\" " +
			"Target=\"notepad.exe\">\r\n\t\t\t\t\t<Context Name=\"VoicePlan\"/>\r\n\t\t\t\t\t<Label>Voice Plan<" +
			"/Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"TextPlan\" TextWrap=\"False\">\r\n\t\t\t\t\t<Context" +
			" Name=\"TextPlan\"/>\r\n\t\t\t\t\t<Label>Text Plan</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"" +
			"DataPlan\" TextWrap=\"True\">\r\n\t\t\t\t\t<Context Name=\"DataPlan\"/>\r\n\t\t\t\t\t<Label>Data Pl" +
			"an</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Custom\" Visibility=\"Pr" +
			"imary\" Label=\"Custom Section Label\" Divider =\"true\">\r\n\t\t\t<Item Name=\"CustomAlign" +
			"Right\" TextWrap =\"False\" TextAlign=\"Right\">\r\n\t\t\t\t\t<Context Name=\"Email1\"/>\r\n\t\t\t\t" +
			"\t<Label>Demo Align Right</Label>\r\n\t\t\t</Item>\r\n\t\t\t<Item Name=\"CustomAlignLeft\" Te" +
			"xtAlign=\"Left\">\r\n\t\t\t\t\t<Context Name=\"Email2\"/>\r\n\t\t\t\t\t<Label>Demo Align Left</Lab" +
			"el>\r\n\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Balances\" Visibility=\"Extended" +
			"\" Divider=\"true\" Label=\"Balances\">\r\n\t\t\t\t<Item Name=\"Current\">\r\n\t\t\t\t\t<Context Nam" +
			"e=\"CurrentCharges\"/>\r\n\t\t\t\t\t<Label>Current</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"" +
			"Past\">\r\n\t\t\t\t\t<Context Name=\"PastDue\"/>\r\n\t\t\t\t\t<Label>Past</Label>\r\n\t\t\t\t</Item>\r\n\t" +
			"\t\t\t<Item Name=\"Penalties\">\r\n\t\t\t\t\t<Context Name=\"Penalties\"/>\r\n\t\t\t\t\t<Label>Penalt" +
			"ies</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Total\">\r\n\t\t\t\t\t<Context Name=\"TotalDue\"" +
			"/>\r\n\t\t\t\t\t<Label>Total</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Eli" +
			"gibility\" Visibility=\"Extended\">\r\n\t\t\t\t<Item Name=\"Upgrade\">\r\n\t\t\t\t\t<Context Name=" +
			"\"EligibleForUpgrade\"/>\r\n\t\t\t\t\t<Label>Upgrade</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name" +
			"=\"Unlimited\">\r\n\t\t\t\t\t<Context Name=\"EligibleForUnlimited\"/>\r\n\t\t\t\t\t<Label>Unlimite" +
			"d</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Information\" Visibility" +
			"=\"Extended\" Divider=\"True\" InnerLabel=\"Information Inner Label\" Label=\"Informati" +
			"on Section Label\">\r\n\t\t\t\t<Item Name=\"Phone1\">\r\n\t\t\t\t\t<Context Name=\"Phone1\"/>\r\n\t\t\t" +
			"\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Phone2\">\r\n\t\t\t\t\t<Context Name=\"Ph" +
			"one2\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Phone3\">\r\n\t\t\t\t\t<Cont" +
			"ext Name=\"Phone3\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Email1\">" +
			"\r\n\t\t\t\t\t<Context Name=\"Email1\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Na" +
			"me=\"Email2\">\r\n\t\t\t\t\t<Context Name=\"Email2\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n" +
			"\t\t\t\t<Item Name=\"Email3\">\r\n\t\t\t\t\t<Context Name=\"Email3\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t" +
			"\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Address1\">\r\n\t\t\t\t\t<Context Name=\"Address1\"/>\r\n\t\t\t\t\t<L" +
			"abel></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Address2\">\r\n\t\t\t\t\t<Context Name=\"Addr" +
			"ess2\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"City\">\r\n\t\t\t\t\t<Contex" +
			"t Name=\"City\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"State\">\r\n\t\t\t" +
			"\t\t<Context Name=\"State\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Zi" +
			"pcode\">\r\n\t\t\t\t\t<Context Name=\"Zipcode\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t<" +
			"/Section>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--\tNOTES - This plug-in lets you add predefined no" +
			"tes, manually enter notes, and review the historical notes for\r\n\t\t\tan interactio" +
			"n. The name of this plug-in is Notes. To interact with this plug-in through an a" +
			"utomation, use the NotesController component.\r\n\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n\r" +
			"\n\t\t\t\tSection/Item:Name - Specifies the name of the item to add to the plug-in.\r\n" +
			"\t\t\t\tSection/Item:IsActive - Determines whether the template appears on a menu.\r\n" +
			"\t\t\t\tSection/Item:Content - Specifies the format of the template. To include cont" +
			"ext values, place the desired\r\n\t\t\t\t\tcontext value name inside two braces, as sho" +
			"wn here: {{example}}. As the associated context property value changes,\r\n\t\t\t\t\tth" +
			"is item is updated on the menu and when added to a Note.\r\n\t\t\t\tSection/Item:Activ" +
			"ity - Specifies that this note will be added when the activity you specify compl" +
			"etes.\r\n\t\t\t\tConfig/TimeZone - Specifies the time zone used to format dates for no" +
			"tes.\r\n\t\t\t\tConfig/LineBreak - Specifies the line break format for notes.\r\n\t\t\t\tCon" +
			"fig/NoteCharacterLimit - Specifies max number of characters allowed per note. Th" +
			"e Enter key will be counted as provided by Line break Setting.\r\n\t\t\t\t\t\t\t\t\t\t\tIf th" +
			"is element is left blank or removed, no character limit will be enforced.\r\n\r\n\t\t\t" +
			"\t-->\r\n\r\n\t\t<Plugin Name=\"Notes\" IsActive=\"True\" HasExtendedView=\"True\" CanHide=\"T" +
			"rue\" EnableWithNoActiveInteraction=\"False\">\r\n\t\t\t<Section Name=\"NoteTemplates\">\r\n" +
			"\t\t\t\t<Item Name=\"CallStarted\" IsActive=\"True\">\r\n\t\t\t\t\t<Content>Call with {{ClientF" +
			"ullName}} started</Content>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"InformDueAmount\" IsAct" +
			"ive=\"True\">\r\n\t\t\t\t\t<Content>Informed of {{TotalDue}} due amount</Content>\r\n\t\t\t\t</" +
			"Item>\r\n\t\t\t\t<Item Name=\"Hidden Note\" IsActive=\"False\">\r\n\t\t\t\t\t<Content>This note i" +
			"s hidden</Content>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Note With Activity\" IsActive=\"T" +
			"rue\">\r\n\t\t\t\t\t<Content>Note added with the validate caller activity</Content>\r\n\t\t\t" +
			"\t\t<Activity>ValidateCaller</Activity>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Config>\r\n" +
			"\t\t\t\t<TimeZone>GMT-5</TimeZone>\r\n\t\t\t\t<LineBreak>\\r\\n</LineBreak>\r\n\t\t\t\t<NoteCharac" +
			"terLimit></NoteCharacterLimit>\r\n\t\t\t</Config>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--\r\n\t\t\tSHORTCUT" +
			"S - This plug-in provides shortcut buttons for calling an automation, going to a" +
			" web page,\r\n\t\t\tstarting an executable, or starting an activity.\r\n\r\n\t\t\tPLUG-IN SP" +
			"ECIFIC SETTINGS\r\n\r\n\t\t\t\tPlugin/Label - Defines the heading text that appears for " +
			"this section. The default is Quick Links.\r\n\t\t\t\tPlugin/Config/Layout - Defines th" +
			"e number of columns in which shortcuts are displayed (2 or 3).\r\n\t\t\t\tPlugin/Confi" +
			"g/VisibleRows - Defines the initial number of rows to display.\r\n\t\t\t\tPlugin/Secti" +
			"on/Name - Specifies the name of shortcut Section. This description does not appe" +
			"ar in the Agile Desktop UI.\r\n\t\t\t\tPlugin/Section/Item:Name - Enter the text you w" +
			"ant to appear on the shortcut button. This will appear on one row vertically cen" +
			"tered.\r\n\t\t\t\tPlugin/Section/Item:RowOneLabel - Text that appears on upper half of" +
			" shortcut button. This is an alternative to Name attribute.\r\n\t\t\t\tPlugin/Section/" +
			"Item:RowTwoLabel - Text that appears on lower half of shortcut button. This is a" +
			"n alternative to Name attribute.\r\n\t\t\t\tPlugin/Section/Item:ShortcutType - Indicat" +
			"es type of shortcut. Choose from these options:\r\n\t\t\t\t\t* Activity - Starts an act" +
			"ivity.\r\n\t\t\t\t\t* Url - Goes to a web page.\r\n\t\t\t\t\t* External - Starts an executable" +
			".\r\n\t\t\t\t\t* Automation - Starts an automation.\r\n\t\t\t\t\t* DropdownMenu - Shows a drop" +
			"down menu for more options.\r\n\t\t\t\tPlugin/Section/Item:ActivityName - For Activity" +
			" shortcuts, enter the name of the activity that should start when the\r\n\t\t\t\t\tbutt" +
			"on is clicked.\r\n\t\t\t\tPlugin/Section/Item:Target - Enter the destination for the s" +
			"hortcut. For instance, if the shortcut is a web site, you\r\n\t\t\t\t\tenter the URL. I" +
			"f the shortcut launches an executable file, enter the name of that file.\r\n\t\t\t\tPl" +
			"ugin/Section/Item:Project - For automation shortcuts, enter the name of the proj" +
			"ect that contains the automation. If the\r\n\t\t\t\t\tproject name contains a space rep" +
			"lace it here with an underscore. My Project should become My_Project.\r\n\t\t\t\tPlugi" +
			"n/Section/Item:AutomationName - For automation shortcuts, enter the name of the " +
			"automation that should start when the\r\n\t\t\t\t\tbutton is pressed. If the automation" +
			" name contains a space replace it here with an underscore. My Automation should " +
			"become My_Automation.\r\n\t\t\t\t\tThis automation should have an entry point, and para" +
			"meters can be passed into entry point if needed.\r\n\t\t\t\tPlugin/Section/Item:Params" +
			" - For passing parameters into automation entry point. Only use it when shortcut" +
			" type is \"Automation\".\r\n\t\t\t\t\tSeparate multiple parameters by comma.\r\n\t\t\t\t\tParame" +
			"ters will be passed in the order as they appear here.\r\n\t\t\t\t\t* Context. - Prefix " +
			"with Context. to use context values defined in the Context section of this docum" +
			"ent.\r\n\t\t\t\t\t* Globals. - Prefix with Globals. to use global values defined in the" +
			" Globals section of this document.\r\n\t\t\t\t\t* Interaction.ActiveKey - Use this keyw" +
			"ord to pass in the current active interaction key.\r\n\t\t\t\t\t* \"  \" - Use double quo" +
			"tes to pass string literal into entry point. However the value string for the wh" +
			"ole Params attribute should be in single quotes.\r\n\t\t\t\t\t* \'  \' - Use single quote" +
			"s to pass string literal into entry point. However the value string for the whol" +
			"e Params attribute should be in double quotes.\r\n\t\t\t\t\t\t**NOTE** - Use #apos; for " +
			"apostrophe (\'), and #quot; for quote (\") inside string literal. Use regular HTML" +
			" entities for other special characters if there is a XML syntax error.\r\n\t\t\t\t\t\t**" +
			"NOTE** - If no active interaction, \"Context.\" and \"Interaction.ActiveKey\" will b" +
			"e passed as null value\r\n\t\t\t\tplugin/Section/Item/Enabled:Criteria - Specifies if " +
			"a shortcut button will be enabled based on the results of a logical expression. " +
			" Context values and Globals dictionary items can be\r\n\t\t\t\t\tused in the expression" +
			".  For example, for enabling buttons which lead to updating customer records hav" +
			"e an Interaction Context value called \"ValidatedCaller\" of type Boolean and use," +
			"\r\n\t\t\t\t\t<Enabled Criteria=\"ValidatedCaller\"/> OR <Enabled Criteria=\"ValidatedCall" +
			"er Eq \'True\'\"/>.  The default Criteria will evaluate to true and be enabled.\r\n\t\t" +
			"\t\tplugin/Section/Item/Visible:Criteria - Specifies if a shortcut button will be " +
			"visible based on the results of a logical expression.  Context values and Global" +
			"s dictionary items can be\r\n\t\t\t\t\tused in the expression.  For example, for showin" +
			"g/hiding buttons which lead to updating customer records have an Interaction Con" +
			"text value called \"ValidatedCaller\" of type Boolean and use,\r\n\t\t\t\t\t<Visible Crit" +
			"eria=\"ValidatedCaller\"/> OR <Visible Criteria=\"ValidatedCaller Eq \'True\'\"/>.  Th" +
			"e default Criteria will evaluate to true and be visible.\r\n\t\t\t\t\t** Note ** Care s" +
			"hould be used when using this option as disappearing and shifting buttons can le" +
			"ad to a poor user experience.\r\n\t\t\t\tPlugin/Section/Item/MenuItem - Specify a pop-" +
			"up menu item inside the DropdownMenu element.\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"Shortc" +
			"uts\" IsActive=\"True\" HasExtendedView=\"False\" CanHide=\"True\" EnableWithNoActiveIn" +
			"teraction=\"True\" Label=\"Quick Links\">\r\n\t\t\t<Config>\r\n\t\t\t\t<Layout>2</Layout>\r\n\t\t\t\t" +
			"<VisibleRows>2</VisibleRows>\r\n\t\t\t</Config>\r\n\t\t\t<Section Name=\"Links\" Visibility=" +
			"\"Primary\">\r\n\t\t\t\t<Item Name=\"Validate Caller\" ActivityName=\"ValidateCaller\" Short" +
			"cutType=\"Activity\"/>\r\n\t\t\t\t<Item RowOneLabel=\"Pega\" RowTwoLabel=\"Web Site\" Target" +
			"=\"http://www.pega.com/\" ShortcutType=\"Url\">\r\n\t\t\t\t\t<Visible Criteria=\"SocialInflu" +
			"ence eq 0\" />\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Send Alert\" Project=\"AgileDesktopExa" +
			"mpleProject\" AutomationName=\"Alert\" ShortcutType=\"Automation\"/>\r\n\t\t\t\t<Item Name=" +
			"\"Notepad\" Target=\"Notepad\" ShortcutType=\"External\">\r\n\t\t\t\t\t<Enabled Criteria=\"Soc" +
			"ialInfluence eq 0\" />\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"My Dropdown\" ShortcutType=\"D" +
			"ropdownMenu\">\r\n\t\t\t\t\t<MenuItem Name=\"Validate Caller\" ActivityName=\"ValidateCalle" +
			"r\" ShortcutType=\"Activity\"/>\r\n\t\t\t\t\t<MenuItem Name=\"Send Alert\" Project=\"AgileDes" +
			"ktopExampleProject\" AutomationName=\"Alert\" ShortcutType=\"Automation\"/>\r\n\t\t\t\t</It" +
			"em>\r\n\t\t\t\t<Item Name=\"Params Style 1\" Project=\"AgileDesktopExampleProject\" Automa" +
			"tionName=\"MyAutomation\" ShortcutType=\"Automation\"\r\n\t\t\t\t\tParams=\'Context.ClientFu" +
			"llName, Globals.AgentName, \"It#apos;s a string...\" , Interaction.ActiveKey\'/>\r\n\t" +
			"\t\t\t<Item Name=\"Params Style 2\" Project=\"AgileDesktopExampleProject\" AutomationNa" +
			"me=\"MyAutomation\" ShortcutType=\"Automation\"\r\n\t\t\t\t\tParams=\"Context.ClientFullName" +
			", Globals.AgentName, \'This #quot; is a quote demo\' , Interaction.ActiveKey\"/>\r\n\t" +
			"\t\t</Section>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--\tInteractionManager - This plug-in displays a" +
			" list from which you can select the active interaction, close an\r\n\t\t\tinteraction" +
			", or optionally start an interaction.\r\n\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tSec" +
			"tion/Item/Context Name - Enter the context property you want to appear in the li" +
			"st from which the end user  will\r\n\t\t\t\t   select the new active interaction. For " +
			"instance, if there is a context property named ClientFullName and you want your\r" +
			"\n\t\t\t\t   end users to select an interaction based on the client\'s name, you would" +
			" enter ClientFullName here.\r\n\t\t\t\tConfig/EnableStartInteraction - Enter True if y" +
			"ou want to show a plus (+) button to let the end user start an\r\n\t\t\t\t   interacti" +
			"on.\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"InteractionManager\" IsActive=\"False\">\r\n\t\t\t<Secti" +
			"on Name=\"Selector\" Visibility=\"Primary\">\r\n\t\t\t\t<Item Name=\"InteractionName\">\r\n\t\t\t" +
			"\t\t<Context Name=\"ClientFullName\"/>\r\n\t\t\t\t\t<Label/>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t" +
			"\t\t<Config>\r\n\t\t\t\t<EnableStartInteraction>True</EnableStartInteraction>\r\n\t\t\t</Conf" +
			"ig>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--\tStartInteraction - This plug-in displays a modal dial" +
			"og which lets end-users enter a string and start a search. The string is made av" +
			"ailable in an automation and the automation developer can use this information t" +
			"o start a new interaction.\r\n\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tEnableWithNoAc" +
			"tiveInteraction - Enter True if you want to display the StartInteraction dialog " +
			"when no\r\n\t\t\t\t\tinteractions exist.\r\n\t\t\t\tConfig/Label - Enter the text you want to" +
			" appear on the dialog\'s heading.  This text should describe what the\r\n\t\t\t\t\tend u" +
			"ser needs to do to start a new interaction. Here is an example: Enter Claim Numb" +
			"er.\r\n\t\t\t\tConfig/Project - Enter the name of the OpenSpan project that contains t" +
			"he automation which starts a new\r\n\t\t\t\t\tinteraction.\r\n\t\t\t\tConfig/Automation - Ent" +
			"er the name of the automation which starts the interaction. This automation can " +
			"validate\r\n\t\t\t\t\tuser input and start an interaction by calling InteractionManager" +
			".StartInteraction(). This automation should have one input parameter of type Str" +
			"ing (the text entered by the end user), one output parameter of type String (a M" +
			"essage displayed if an error occurs), and should return a Boolean result (return" +
			" False if an error message should be displayed).\r\n\t\t\t\tConfig/DefaultErrorMessage" +
			" - Enter the text of the message you want to display if an error occurs while va" +
			"lidating the input or starting\r\n\t\t\t\t\tthe interaction. This will be used if the s" +
			"tart interaction automation does not return the error text but does return False" +
			".\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"StartInteraction\" IsActive=\"False\" EnableWithNoAct" +
			"iveInteraction=\"True\">\r\n\t\t\t<Config>\r\n\t\t\t\t<Label>Enter Claim Number</Label>\r\n\t\t\t\t" +
			"<Project>AgileDesktopExampleProject</Project>\r\n\t\t\t\t<Automation>StartInteraction<" +
			"/Automation>\r\n\t\t\t\t<DefaultErrorMessage>Unable to start interaction</DefaultError" +
			"Message>\r\n\t\t\t</Config>\r\n\t\t</Plugin>\r\n\t</Plugins>\r\n</Interaction>\r\n";
	}
	
	// WebAdapter-8D8DE2BB139348E
	public CRMPrj_ACMESearch ACMESearch
	{
		get
		{
			return ((CRMPrj_ACMESearch)(this["ACMESearch"]));
		}
	}
	
	// WindowsAdapter-8D8DFE68142AF1E
	public CRMPrj_CRM CRM
	{
		get
		{
			return ((CRMPrj_CRM)(this["CRM"]));
		}
	}
	
	// Automator-8D8E89D29ADB8C1
	public CRMPrj_CRM_E_IntMgr_InteractionStarted CRM_E_IntMgr_InteractionStarted
	{
		get
		{
			return ((CRMPrj_CRM_E_IntMgr_InteractionStarted)(this["CRM_E_IntMgr_InteractionStarted"]));
		}
	}
	
	// Automator-8D8E885DE61584A
	public CRMPrj_CRM_E_CRMChild_Closing CRM_E_CRMChild_Closing
	{
		get
		{
			return ((CRMPrj_CRM_E_CRMChild_Closing)(this["CRM_E_CRMChild_Closing"]));
		}
	}
	
	// Automator-8D8E884D37F8321
	public CRMPrj_CRM_E_CRMChild_Created CRM_E_CRMChild_Created
	{
		get
		{
			return ((CRMPrj_CRM_E_CRMChild_Created)(this["CRM_E_CRMChild_Created"]));
		}
	}
	
	// Automator-8D8E30F1807D26C
	public CRMPrj_CRM_E_CRMfrmLogin_Created CRM_E_CRMfrmLogin_Created
	{
		get
		{
			return ((CRMPrj_CRM_E_CRMfrmLogin_Created)(this["CRM_E_CRMfrmLogin_Created"]));
		}
	}
	
	// GlobalContainer-8D8E7CA979738F7
	public CRMPrj__GC_CRM _GC_CRM
	{
		get
		{
			return ((CRMPrj__GC_CRM)(this["_GC_CRM"]));
		}
	}
}

}

