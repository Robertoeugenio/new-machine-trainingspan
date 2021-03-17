using MainPrj_CRM_E_GetCustInfo_ActivityStarted = MainPrj.CRM_E_GetCustInfo_ActivityStarted;

using MainPrj_Main_E_IntMgr_InteractionClosed = MainPrj.Main_E_IntMgr_InteractionClosed;

using MainPrj_Main_E_IntMgr_InteractionStarted = MainPrj.Main_E_IntMgr_InteractionStarted;

using MainPrj_Main_E_UpdateDisplay_ActivityStarted = MainPrj.Main_E_UpdateDisplay_ActivityStarted;

using MainPrj_frmCustInfo = MainPrj.frmCustInfo;

using MainPrj_Main_P_LoadCustInfoValues = MainPrj.Main_P_LoadCustInfoValues;

using MainPrj__GC_Main = MainPrj._GC_Main;

using System;

namespace MainPrj.Project
{
// Project-8D8E7C0E1F4164A
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D8E7C0E1F4164A")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
public sealed class MainPrj : OpenSpan.Runtime.RuntimeProject
{
	
	public MainPrj() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.MainPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public MainPrj(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.MainPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public MainPrj(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.MainPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public MainPrj(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.MainPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private MainPrj(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.MainPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void MainPrj_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D8E7C0E1F4164A");
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
			"\" Type=\"String\" Default=\"xxxxx\"/>\r\n\t\t<Value Name=\"City\" Type=\"String\" Default=\"x" +
			"xxxx\"/>\r\n\t\t<Value Name=\"State\" Type=\"String\" Default=\"xxxxx\"/>\r\n\t\t<Value Name=\"Z" +
			"ipCode\" Type=\"String\" Default=\"xxxxx\"/>\r\n\t\t<Value Name=\"NearestStore\" Type=\"Stri" +
			"ng\" Default=\"xxxxx\"/>\r\n\t\t\r\n\r\n\t</Context>\r\n\r\n\t<!--\tThe Globals section defines in" +
			"formation that is stored independent of interactions. Global values\r\n\t\tare acces" +
			"sed through the global dictionary component. Defining a global value is similar " +
			"to defining a context value:\r\n\r\n\t\t\tName - Identifies the property in automations" +
			" and in the plug-in configuration.\r\n\t\t\tType - Specifies the property\'s underlyin" +
			"g data type. Valid entries are String, Number, Boolean, and Date.\r\n\t\t\tDefault - " +
			"Specifies a default value. The property is populated with this value at system s" +
			"tart-up.\r\n\t\t\tFormat - Controls how the system displays the value. Strings can be" +
			" formatted as either numbers or dates.\r\n\t\t\t\tSeveral Numeric options are:\r\n\t\t\t\t\t\"" +
			"C\" for currency\r\n\t\t\t\t\t\"D\" for decimal\r\n\t\t\t\t\t\"P\" for percent\r\n\t\t\t\tSeveral Date op" +
			"tions are:\r\n\t\t\t\t\t\"d\" for short date (month, day, year)\r\n\t\t\t\t\t\"D\" for long date (" +
			"day of week, month, day, year)\r\n\t\t\t\t\t\"m\" or \"M\" for month format (day, month)\r\n\t" +
			"\t\t\t\t\"y\" or \"Y\" for year format (month, year)\r\n\t\t\t\t\t\"t\" for short time (time to m" +
			"inutes)\r\n\t\t\t\t\t\"T\" for long time (time to seconds)\r\n\t\t\t\t\t\"g\" for short date and t" +
			"ime (day, month, year, time to minutes)\r\n\t\t\t\t\t\"G\" for long date and time (day, m" +
			"onth, year, time to seconds)\r\n\t\t\t\t\t\"u\" for universal time\r\n\t\t\t-->\r\n\r\n\t<Globals>\r" +
			"\n\t\t<Value Name=\"AgentName\" Type=\"String\" Default=\"\"/>\r\n\t\t<Value Name=\"Conversion" +
			"Percentage\" Type=\"Number\" Format=\"P\" Default=\"0\"/>\r\n\t\t<Value Name=\"AverageHandle" +
			"Time\" Type=\"String\" Default=\"\"/>\r\n\t\t<Value Name=\"AveragePayment\" Type=\"Number\" F" +
			"ormat=\"C\" Default=\"0\"/>\r\n\t</Globals>\r\n\r\n\t<!--\tAn Activity describes a piece of w" +
			"ork that needs to done. An automation can request that an activity be performed\r" +
			"\n\t\tor perform an activity when requested. Activities are queued and run sequenti" +
			"ally. This means that only one activity\r\n\t\tis processed at a time. Any automatio" +
			"n can request that an activity be performed by calling the StartActivity method\r" +
			"\n\t\tfrom the Activity component. The activity is placed at the end of the queue a" +
			"nd will be processed when all activities in\r\n\t\tfront of it are completed. An act" +
			"ivity is completed when all automations that are listening to Activity.ActivityS" +
			"tarted\r\n\t\thave finished their execution.\r\n\r\n\t\t\tName - Provides a descriptive nam" +
			"e of an activity.  The activity component uses this name for identification.\r\n\t\t" +
			"\tValue - Specifies the parameters and properties of an activity.\r\n\t\t\tType - Spec" +
			"ifies the type of the Value, such as Boolean or String.\r\n\t\t\tRequiresInteraction " +
			"- Specifies if an interaction needs to be active for the\r\n\t\t\t\tactivity to run. T" +
			"he defaults is True.\r\n\r\n\t\t\tIn the example below, the AddPlan activity will have " +
			"a StartActivity() method with\r\n\t\t\ttwo parameters: PlanType and EffectiveDate.\r\n\t" +
			"\t\tWhen used in automations, there will also be an ActivityStarted event with Pla" +
			"nType and EffectiveDate outputs.\r\n\t\t\tAdditionally, an activity component for Add" +
			"Plan will have a PlanType property\r\n\t\t\tand an EffectiveDate property. These prop" +
			"erty values can be set or retrieved during the execution\r\n\t\t\tof the activity or " +
			"in response to the ActivityCompleted event.\r\n\r\n\t\t\t<Activity Name=\"AddPlan\" Requi" +
			"resInteraction=\"True\">\r\n\t\t\t\t<Value Name=\"PlanType\" Type=\"String\"/>\r\n\t\t\t\t<Value N" +
			"ame=\"EffectiveDate\" Type=\"Date\"/>\r\n\t\t\t</Activity>\r\n\r\n\t\t\tWhen defining an activit" +
			"y, make sure that all the data required to perform the\r\n\t\t\tactivity is available" +
			" through context values or the activity’s properties.\r\n\t\t\t-->\r\n \r\n\t<Activities>\r" +
			"\n\r\n\r\n\t    <Activity Name=\"GetCustomerInformation\">\r\n\t\t\t<Value Name=\"GetCustomerI" +
			"nformation\" Type=\"String\"/>\r\n\t\t</Activity> \r\n\t    <Activity Name=\"Update Display" +
			"\">\r\n\t\t\t<Value Name=\"Update Display\" Type=\"String\"/>\r\n\t\t</Activity>\r\n\r\n\r\n\r\n\t\t\r\n\t\t" +
			"<Activity Name=\"ValidateCaller\">\r\n\t\t\t<Value Name=\"CallerValid\" Type=\"Boolean\"/>\r" +
			"\n\t\t</Activity>\r\n\t\t<Activity Name=\"ValidateCaller\">\r\n\t\t\t<Value Name=\"CallerValid\"" +
			" Type=\"Boolean\"/>\r\n\t\t</Activity>\r\n\r\n\t\t<Activity Name=\"UnvalidateCaller\">\r\n\t\t\t<Va" +
			"lue Name=\"CallerValid\" Type=\"Boolean\"/>\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"AddPla" +
			"n\">\r\n\t\t\t<Value Name=\"PlanType\" Type=\"String\"/>\r\n\t\t\t<Value Name=\"EffectiveDate\" T" +
			"ype=\"String\"/>\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"CloseAccount\">\r\n\t\t\t<Value Name=" +
			"\"EffectiveDate\" Type=\"String\"/>\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"ProcessClaim\">" +
			"\r\n\t\t\t<Value Name=\"ClaimNum\" Type=\"String\"/>\r\n\t\t\t<Value Name=\"ClaimDate\" Type=\"St" +
			"ring\"/>\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"ProcessClaim\">\r\n\t\t</Activity>\r\n\t</Acti" +
			"vities>\r\n\r\n\t<!--  Plug-ins are HTML user interface sections in the toolbar. Agil" +
			"e Desktop includes these plug-ins:\r\n\t\t\t- 360 View - Provides access to key custo" +
			"mer information at a glance.\r\n\t\t\t- Notes - Lets you add notes and search histori" +
			"c notes.\r\n\t\t\t- Shortcuts - Provides buttons to launch an exe, go to a web site, " +
			"execute an automation,\r\n\t\t\t\tor start an activity.\r\n\t\t\t- Interaction Manager - Pr" +
			"ovides a list of all current interactions on top of the 360 View.\r\n\t\t\t- Start In" +
			"teraction - Provides a way for the Agile Desktop user to enter a string which ca" +
			"n be\r\n\t\t\t\tretrieved in an automation and used for starting an interaction.\r\n\t\t  " +
			"GENERIC PLUG-IN SETTINGS\r\n\r\n\t\t\t\tPlugin:IsActive - Indicates if the plug-in appea" +
			"rs in the toolbar.\r\n\t\t\t\tPlugin:HasExtendedView - Indicates if the plug-in can be" +
			" expanded to show more information.\r\n\t\t\t\tPlugin:EnableWithNoActiveInteraction - " +
			"Indicates if the user can interact with the plug-in when\r\n\t\t\t\t\tthere is no activ" +
			"e interaction.\r\n\t\t\t\tPlugin:CanHide - If False, the user cannot hide the plug-in " +
			"from the gear menu.\r\n\t\t\t\t-->\r\n\r\n\t<Plugins>\r\n\r\n\t\t<!--\t360 View - This plug-in dis" +
			"plays interaction context values that may be needed at a glance.\r\n\r\n\t\t\tPLUG-IN S" +
			"PECIFIC SETTINGS\r\n\r\n\t\t\t\tPlugin/Section   - Provides a logical grouping of the el" +
			"ements within the Plug-In.\r\n\t\t\t\t\t**NOTE** - <section> tag is case insensitive.\r\n" +
			"\t\t\t\tPlugin/Section:Visibility - You can choose from these options:\r\n\t\t\t\t\tPrimary" +
			" - The Section is added to the Primary view.\r\n\t\t\t\t\tExtended - The Section is add" +
			"ed to the Extended view.\r\n\t\t\t\t\tBoth - The Section is added to both the Primary a" +
			"nd Extended views.\r\n\t\t\t\tPlugin/Section:Name - Indicates the style in which the s" +
			"ection data is displayed. You can choose from these options:\r\n\t\t\t\t\tImages, Ident" +
			"ity, Ratings, Products, Custom, Balances, Eligibility, or Information.\r\n\t\t\t\t\t**N" +
			"OTE** - Item containing Image will only appear in section with Name attribute se" +
			"t to Images.\r\n\t\t\t\tPlugin/Section:Label - An optional label that can appear at th" +
			"e top of the section.\r\n\t\t\t\tPlugin/Section:InnerLabel - An optional smaller label" +
			" that ONLY appears on top of \"Information\" section. Default value is \"Contact In" +
			"formation\".\r\n\t\t\t\tPlugin/Section:Divider - A true/false value that determines if " +
			"a divider line will appear above the section.\r\n\t\t\t\tPlugin/Section:ImagePadding -" +
			" Specify the padding between images in the Images section. Default padding is 24" +
			" pixels.\r\n\t\t\t\t\t**NOTE** - ImagePadding is optional, ONLY accepts numbers, ONLY w" +
			"orks in Images section. If empty, default padding size will be used.\r\n\t\t\t\tPlugin" +
			"/Section/Item:Name - Identifies the item in the plugin\r\n\t\t\t\tPlugin/Section/Item:" +
			"Image - Specify the name of the image to be displayed.\r\n\t\t\t\t\t1) To use default i" +
			"cons, choose from the following default values\r\n\t\t\t\t\t\tCash, Check, MoneyOrder, C" +
			"redit\r\n\t\t\t\t\t2) To use custom images, follow these steps below:\r\n\t\t\t\t\t\t1. Add you" +
			"r images to the startup automation project.\r\n\t\t\t\t\t\t\tOr, put images in a local fo" +
			"lder and add  <CustomImagePath value=\"C:\\path\\to\\your\\pic\\folder\" /> to RuntimeC" +
			"onfig.xml <AgileDesktop /> section.\r\n\t\t\t\t\t\t2. Put your image name as the value o" +
			"f Image attribute. Make sure to only use (.png) images and include the file exte" +
			"nsion.\r\n\t\t\t\tPlugin/Section/Item:Tooltip - Enter a text you want to appear when m" +
			"ouse over image. Only works with image item.\r\n\t\t\t\tPlugin/Section/Item:TextWrap -" +
			" Set to true if you want the text in that Item to wrap to the next line, instead" +
			" of truncate. Default is False.\r\n\t\t\t\t\t**NOTE** - TextWrap option must be in the " +
			"Item element, and only works with items in \"Products\", \"Balances\", and \"Custom\" " +
			"Sections.\r\n\t\t\t\tPlugin/Section/Item:TextAlign - Set the text alignment in an Item" +
			", whether left or right. Only works with items in \"Custom\" Sections. Default is " +
			"Left.\r\n\t\t\t\tPlugin/Section/Item/Context:Name - Specifies the name of context valu" +
			"e (defined in the Context section) used to populate\r\n\t\t\t\t\tthis item. As the asso" +
			"ciated context property value changes, this item is automatically updated.\r\n\t\t\t\t" +
			"Plugin/Section/Item/Label - Defines the text label that appears in the toolbar. " +
			"If omitted,\r\n\t\t\t\t\tthe Name value is used.\r\n\t\t\t\tPlugin/Section/Item/Visible:Crite" +
			"ria - Specifies if an item will be displayed based on a context value, and compa" +
			"rison expression.\r\n\t\t\t\t\tFor examle, add <Visible Criteria=\"SocialInfluence gt 3\"" +
			"/> to an item, will only display the item if SocialInfluence context value is gr" +
			"eater than 3.\r\n\r\n\t\t\t\t**NOTE** - Every Item in the 360AppBar Plugin can be set up" +
			" as clickable shortcut, instructions are shown below.\r\n\t\t\t\tPlugin/Section/Item:S" +
			"hortcutType - Indicates type of shortcut. Choose from these options:\r\n\t\t\t\t\t* Act" +
			"ivity - Starts an activity.\r\n\t\t\t\t\t* Url - Goes to a web page.\r\n\t\t\t\t\t* External -" +
			" Starts an executable.\r\n\t\t\t\t\t* Automation - Starts an automation.\r\n\t\t\t\tPlugin/Se" +
			"ction/Item:ActivityName - For Activity shortcuts, enter the name of the activity" +
			" that should start when the\r\n\t\t\t\t\tItem is clicked.\r\n\t\t\t\tPlugin/Section/Item:Targ" +
			"et - Enter the destination for the shortcut. For instance, if the shortcut is a " +
			"web site, you\r\n\t\t\t\t\tenter the URL. If the shortcut launches an executable file, " +
			"enter the name of that file.\r\n\t\t\t\tPlugin/Section/Item:Project - For automation s" +
			"hortcuts, enter the name of the project that contains the automation. If the\r\n\t\t" +
			"\t\t\tproject name contains a space replace it here with an underscore. My Project " +
			"should become My_Project.\r\n\t\t\t\tPlugin/Section/Item:AutomationName - For automati" +
			"on shortcuts, enter the name of the automation that should start when the\r\n\t\t\t\t\t" +
			"Item is clicked. If the automation name contains a space replace it here with an" +
			" underscore. My Automation should become My_Automation.\r\n\t\t\t\t\tThis automation sh" +
			"ould have an entry point, and parameters can be passed into entry point if neede" +
			"d.\r\n\t\t\t\tPlugin/Section/Item:Params - For passing parameters into automation entr" +
			"y point. Only use it when Shortcut type is \"Automation\".\r\n\t\t\t\t\tSeparate multiple" +
			" parameters by comma.\r\n\t\t\t\t\tParameters will be passed in the order as they appea" +
			"r here.\r\n\t\t\t\t\t* Context. - Prefix with Context. to use context values defined in" +
			" the Context section of this document.\r\n\t\t\t\t\t* Globals. - Prefix with Globals. t" +
			"o use global values defined in the Globals section of this document.\r\n\t\t\t\t\t* Int" +
			"eraction.ActiveKey - Use this keyword to pass in the current active interaction " +
			"key.\r\n\t\t\t\t\t* \"  \" - Use double quotes to pass string literal into entry point. H" +
			"owever the value string for the whole Params attribute should be in single quote" +
			"s.\r\n\t\t\t\t\t* \'  \' - Use single quotes to pass string literal into entry point. How" +
			"ever the value string for the whole Params attribute should be in double quotes." +
			"\r\n\t\t\t\t\t\t**NOTE** - Use #apos; for apostrophe (\'), and #quot; for quote (\") insid" +
			"e string literal. Use regular HTML entities for other special characters if ther" +
			"e is a XML syntax error.\r\n\t\t\t\t\t\t**NOTE** - If no active interaction, \"Context.\" " +
			"and \"Interaction.ActiveKey\" will be passed as null value\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin N" +
			"ame=\"360AppBar\" Label=\"360 View\" IsActive=\"True\" HasExtendedView=\"True\" CanHide=" +
			"\"False\" EnableWithNoActiveInteraction=\"False\">\r\n\t\t\t<Section Name=\"Identity\" Visi" +
			"bility=\"Primary\">\r\n\t\t\t\t<Item Name=\"FullName\"  ShortcutType=\"Automation\" Project=" +
			"\"AgileDesktopExampleProject\" AutomationName=\"MyAutomation\">\r\n\t\t\t\t\t<Context Name=" +
			"\"ClientFullName\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Sectio" +
			"n Name=\"Ratings\" Visibility=\"Primary\">\r\n\t\t\t\t<Item Name=\"SocialInfluence\" Shortcu" +
			"tType=\"Automation\" Project=\"AgileDesktopExampleProject\" \r\n\t\t\t\t\tAutomationName=\"M" +
			"yAutomation\" Params=\"Context.ClientFullName, Globals.AgentName, \'It#apos;s a str" +
			"ing...\' , Interaction.ActiveKey\">\r\n\t\t\t\t\t<Context Name=\"SocialInfluence\"/>\r\n\t\t\t\t\t" +
			"<Label>Social Influence</Label>\r\n\t\t\t\t\t<MaxValue>5</MaxValue>\r\n\t\t\t\t\t<Visible Crit" +
			"eria=\"SocialInfluence eq 0\"/>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"LifetimeValue\">\r\n\t\t\t" +
			"\t\t<Context Name=\"LifetimeValue\"/>\r\n\t\t\t\t\t<Label>Lifetime Value</Label>\r\n\t\t\t\t\t<Max" +
			"Value>5</MaxValue>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Images\" Visibi" +
			"lity=\"Both\" Divider=\"True\" Label=\"Default Images Padding\"  ImagePadding=\"24\">\r\n\t" +
			"\t\t\t<Item Image=\"Cash\" Tooltip=\"Cash Default Icon\" ShortcutType=\"Activity\" Activi" +
			"tyName=\"MyActivity\"/>\r\n\t\t\t\t<Item Image=\"Check\" Tooltip=\"Check Default Icon\" Shor" +
			"tcutType=\"Url\" Target=\"http://www.pega.com\"/>\r\n\t\t\t\t<Item Image=\"MoneyOrder\"/>\r\n\t" +
			"\t\t\t<Item Image=\"Credit\">\r\n\t\t\t\t\t<Visible Criteria=\"SocialInfluence eq 0\"/>\r\n\t\t\t\t<" +
			"/Item>\r\n\t\t\t\t<Item Image=\"MyCustomImage.png\"/>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"" +
			"Images\" Visibility=\"Both\" Divider=\"True\" Label=\"Custom Images Padding\" ImagePadd" +
			"ing=\"40\">\r\n\t\t\t\t<Item Image=\"Cash\"/>\r\n\t\t\t\t<Item Image=\"Check\"/>\r\n\t\t\t\t<Item Image=" +
			"\"MoneyOrder\"/>\r\n\t\t\t\t<Item Image=\"Credit\"/>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Pro" +
			"ducts\" Visibility=\"Primary\" Label=\"Products Section Label\" Divider=\"True\">\r\n\t\t\t\t" +
			"<Item Name=\"VoicePlan\" ShortcutType=\"External\" Target=\"notepad.exe\">\r\n\t\t\t\t\t<Cont" +
			"ext Name=\"VoicePlan\"/>\r\n\t\t\t\t\t<Label>Voice Plan</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item N" +
			"ame=\"TextPlan\" TextWrap=\"False\">\r\n\t\t\t\t\t<Context Name=\"TextPlan\"/>\r\n\t\t\t\t\t<Label>T" +
			"ext Plan</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"DataPlan\" TextWrap=\"True\">\r\n\t\t\t\t\t" +
			"<Context Name=\"DataPlan\"/>\r\n\t\t\t\t\t<Label>Data Plan</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Sec" +
			"tion>\r\n\t\t\t<Section Name=\"Custom\" Visibility=\"Primary\" Label=\"Custom Section Labe" +
			"l\" Divider =\"true\">\r\n\t\t\t<Item Name=\"CustomAlignRight\" TextWrap =\"False\" TextAlig" +
			"n=\"Right\">\r\n\t\t\t\t\t<Context Name=\"Email1\"/>\r\n\t\t\t\t\t<Label>Demo Align Right</Label>\r" +
			"\n\t\t\t</Item>\r\n\t\t\t<Item Name=\"CustomAlignLeft\" TextAlign=\"Left\">\r\n\t\t\t\t\t<Context Na" +
			"me=\"Email2\"/>\r\n\t\t\t\t\t<Label>Demo Align Left</Label>\r\n\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t" +
			"\t\t<Section Name=\"Balances\" Visibility=\"Extended\" Divider=\"true\" Label=\"Balances\"" +
			">\r\n\t\t\t\t<Item Name=\"Current\">\r\n\t\t\t\t\t<Context Name=\"CurrentCharges\"/>\r\n\t\t\t\t\t<Label" +
			">Current</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Past\">\r\n\t\t\t\t\t<Context Name=\"PastD" +
			"ue\"/>\r\n\t\t\t\t\t<Label>Past</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Penalties\">\r\n\t\t\t\t\t" +
			"<Context Name=\"Penalties\"/>\r\n\t\t\t\t\t<Label>Penalties</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<It" +
			"em Name=\"Total\">\r\n\t\t\t\t\t<Context Name=\"TotalDue\"/>\r\n\t\t\t\t\t<Label>Total</Label>\r\n\t\t" +
			"\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Eligibility\" Visibility=\"Extended\">\r" +
			"\n\t\t\t\t<Item Name=\"Upgrade\">\r\n\t\t\t\t\t<Context Name=\"EligibleForUpgrade\"/>\r\n\t\t\t\t\t<Lab" +
			"el>Upgrade</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Unlimited\">\r\n\t\t\t\t\t<Context Name" +
			"=\"EligibleForUnlimited\"/>\r\n\t\t\t\t\t<Label>Unlimited</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Sect" +
			"ion>\r\n\t\t\t<Section Name=\"Information\" Visibility=\"Extended\" Divider=\"True\" InnerL" +
			"abel=\"Information Inner Label\" Label=\"Information Section Label\">\r\n\t\t\t\t<Item Nam" +
			"e=\"Phone1\">\r\n\t\t\t\t\t<Context Name=\"Phone1\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t" +
			"\t\t\t<Item Name=\"Phone2\">\r\n\t\t\t\t\t<Context Name=\"Phone2\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t" +
			"\t\t</Item>\r\n\t\t\t\t<Item Name=\"Phone3\">\r\n\t\t\t\t\t<Context Name=\"Phone3\"/>\r\n\t\t\t\t\t<Label>" +
			"</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Email1\">\r\n\t\t\t\t\t<Context Name=\"Email1\"/>\r\n" +
			"\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Email2\">\r\n\t\t\t\t\t<Context Name=" +
			"\"Email2\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Email3\">\r\n\t\t\t\t\t<C" +
			"ontext Name=\"Email3\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Addre" +
			"ss1\">\r\n\t\t\t\t\t<Context Name=\"Address1\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<" +
			"Item Name=\"Address2\">\r\n\t\t\t\t\t<Context Name=\"Address2\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t" +
			"\t\t</Item>\r\n\t\t\t\t<Item Name=\"City\">\r\n\t\t\t\t\t<Context Name=\"City\"/>\r\n\t\t\t\t\t<Label></La" +
			"bel>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"State\">\r\n\t\t\t\t\t<Context Name=\"State\"/>\r\n\t\t\t\t\t<" +
			"Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Zipcode\">\r\n\t\t\t\t\t<Context Name=\"Zipc" +
			"ode\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--\t" +
			"NOTES - This plug-in lets you add predefined notes, manually enter notes, and re" +
			"view the historical notes for\r\n\t\t\tan interaction. The name of this plug-in is No" +
			"tes. To interact with this plug-in through an automation, use the NotesControlle" +
			"r component.\r\n\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tSection/Item:Name - Specifie" +
			"s the name of the item to add to the plug-in.\r\n\t\t\t\tSection/Item:IsActive - Deter" +
			"mines whether the template appears on a menu.\r\n\t\t\t\tSection/Item:Content - Specif" +
			"ies the format of the template. To include context values, place the desired\r\n\t\t" +
			"\t\t\tcontext value name inside two braces, as shown here: {{example}}. As the asso" +
			"ciated context property value changes,\r\n\t\t\t\t\tthis item is updated on the menu an" +
			"d when added to a Note.\r\n\t\t\t\tSection/Item:Activity - Specifies that this note wi" +
			"ll be added when the activity you specify completes.\r\n\t\t\t\tConfig/TimeZone - Spec" +
			"ifies the time zone used to format dates for notes.\r\n\t\t\t\tConfig/LineBreak - Spec" +
			"ifies the line break format for notes.\r\n\t\t\t\tConfig/NoteCharacterLimit - Specifie" +
			"s max number of characters allowed per note. The Enter key will be counted as pr" +
			"ovided by Line break Setting.\r\n\t\t\t\t\t\t\t\t\t\t\tIf this element is left blank or remov" +
			"ed, no character limit will be enforced.\r\n\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"Notes\" Is" +
			"Active=\"True\" HasExtendedView=\"True\" CanHide=\"True\" EnableWithNoActiveInteractio" +
			"n=\"False\">\r\n\t\t\t<Section Name=\"NoteTemplates\">\r\n\t\t\t\t<Item Name=\"CallStarted\" IsAc" +
			"tive=\"True\">\r\n\t\t\t\t\t<Content>Call with {{ClientFullName}} started</Content>\r\n\t\t\t\t" +
			"</Item>\r\n\t\t\t\t<Item Name=\"InformDueAmount\" IsActive=\"True\">\r\n\t\t\t\t\t<Content>Inform" +
			"ed of {{TotalDue}} due amount</Content>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Hidden Not" +
			"e\" IsActive=\"False\">\r\n\t\t\t\t\t<Content>This note is hidden</Content>\r\n\t\t\t\t</Item>\r\n" +
			"\t\t\t\t<Item Name=\"Note With Activity\" IsActive=\"True\">\r\n\t\t\t\t\t<Content>Note added w" +
			"ith the validate caller activity</Content>\r\n\t\t\t\t\t<Activity>ValidateCaller</Activ" +
			"ity>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Config>\r\n\t\t\t\t<TimeZone>GMT-5</TimeZone>\r\n\t" +
			"\t\t\t<LineBreak>\\r\\n</LineBreak>\r\n\t\t\t\t<NoteCharacterLimit></NoteCharacterLimit>\r\n\t" +
			"\t\t</Config>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--\r\n\t\t\tSHORTCUTS - This plug-in provides shortcu" +
			"t buttons for calling an automation, going to a web page,\r\n\t\t\tstarting an execut" +
			"able, or starting an activity.\r\n\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tPlugin/Lab" +
			"el - Defines the heading text that appears for this section. The default is Quic" +
			"k Links.\r\n\t\t\t\tPlugin/Config/Layout - Defines the number of columns in which shor" +
			"tcuts are displayed (2 or 3).\r\n\t\t\t\tPlugin/Config/VisibleRows - Defines the initi" +
			"al number of rows to display.\r\n\t\t\t\tPlugin/Section/Name - Specifies the name of s" +
			"hortcut Section. This description does not appear in the Agile Desktop UI.\r\n\t\t\t\t" +
			"Plugin/Section/Item:Name - Enter the text you want to appear on the shortcut but" +
			"ton. This will appear on one row vertically centered.\r\n\t\t\t\tPlugin/Section/Item:R" +
			"owOneLabel - Text that appears on upper half of shortcut button. This is an alte" +
			"rnative to Name attribute.\r\n\t\t\t\tPlugin/Section/Item:RowTwoLabel - Text that appe" +
			"ars on lower half of shortcut button. This is an alternative to Name attribute.\r" +
			"\n\t\t\t\tPlugin/Section/Item:ShortcutType - Indicates type of shortcut. Choose from " +
			"these options:\r\n\t\t\t\t\t* Activity - Starts an activity.\r\n\t\t\t\t\t* Url - Goes to a we" +
			"b page.\r\n\t\t\t\t\t* External - Starts an executable.\r\n\t\t\t\t\t* Automation - Starts an " +
			"automation.\r\n\t\t\t\t\t* DropdownMenu - Shows a dropdown menu for more options.\r\n\t\t\t\t" +
			"Plugin/Section/Item:ActivityName - For Activity shortcuts, enter the name of the" +
			" activity that should start when the\r\n\t\t\t\t\tbutton is clicked.\r\n\t\t\t\tPlugin/Sectio" +
			"n/Item:Target - Enter the destination for the shortcut. For instance, if the sho" +
			"rtcut is a web site, you\r\n\t\t\t\t\tenter the URL. If the shortcut launches an execut" +
			"able file, enter the name of that file.\r\n\t\t\t\tPlugin/Section/Item:Project - For a" +
			"utomation shortcuts, enter the name of the project that contains the automation." +
			" If the\r\n\t\t\t\t\tproject name contains a space replace it here with an underscore. " +
			"My Project should become My_Project.\r\n\t\t\t\tPlugin/Section/Item:AutomationName - F" +
			"or automation shortcuts, enter the name of the automation that should start when" +
			" the\r\n\t\t\t\t\tbutton is pressed. If the automation name contains a space replace it" +
			" here with an underscore. My Automation should become My_Automation.\r\n\t\t\t\t\tThis " +
			"automation should have an entry point, and parameters can be passed into entry p" +
			"oint if needed.\r\n\t\t\t\tPlugin/Section/Item:Params - For passing parameters into au" +
			"tomation entry point. Only use it when shortcut type is \"Automation\".\r\n\t\t\t\t\tSepa" +
			"rate multiple parameters by comma.\r\n\t\t\t\t\tParameters will be passed in the order " +
			"as they appear here.\r\n\t\t\t\t\t* Context. - Prefix with Context. to use context valu" +
			"es defined in the Context section of this document.\r\n\t\t\t\t\t* Globals. - Prefix wi" +
			"th Globals. to use global values defined in the Globals section of this document" +
			".\r\n\t\t\t\t\t* Interaction.ActiveKey - Use this keyword to pass in the current active" +
			" interaction key.\r\n\t\t\t\t\t* \"  \" - Use double quotes to pass string literal into e" +
			"ntry point. However the value string for the whole Params attribute should be in" +
			" single quotes.\r\n\t\t\t\t\t* \'  \' - Use single quotes to pass string literal into ent" +
			"ry point. However the value string for the whole Params attribute should be in d" +
			"ouble quotes.\r\n\t\t\t\t\t\t**NOTE** - Use #apos; for apostrophe (\'), and #quot; for qu" +
			"ote (\") inside string literal. Use regular HTML entities for other special chara" +
			"cters if there is a XML syntax error.\r\n\t\t\t\t\t\t**NOTE** - If no active interaction" +
			", \"Context.\" and \"Interaction.ActiveKey\" will be passed as null value\r\n\t\t\t\tplugi" +
			"n/Section/Item/Enabled:Criteria - Specifies if a shortcut button will be enabled" +
			" based on the results of a logical expression.  Context values and Globals dicti" +
			"onary items can be\r\n\t\t\t\t\tused in the expression.  For example, for enabling butt" +
			"ons which lead to updating customer records have an Interaction Context value ca" +
			"lled \"ValidatedCaller\" of type Boolean and use,\r\n\t\t\t\t\t<Enabled Criteria=\"Validat" +
			"edCaller\"/> OR <Enabled Criteria=\"ValidatedCaller Eq \'True\'\"/>.  The default Cri" +
			"teria will evaluate to true and be enabled.\r\n\t\t\t\tplugin/Section/Item/Visible:Cri" +
			"teria - Specifies if a shortcut button will be visible based on the results of a" +
			" logical expression.  Context values and Globals dictionary items can be\r\n\t\t\t\t\tu" +
			"sed in the expression.  For example, for showing/hiding buttons which lead to up" +
			"dating customer records have an Interaction Context value called \"ValidatedCalle" +
			"r\" of type Boolean and use,\r\n\t\t\t\t\t<Visible Criteria=\"ValidatedCaller\"/> OR <Visi" +
			"ble Criteria=\"ValidatedCaller Eq \'True\'\"/>.  The default Criteria will evaluate " +
			"to true and be visible.\r\n\t\t\t\t\t** Note ** Care should be used when using this opt" +
			"ion as disappearing and shifting buttons can lead to a poor user experience.\r\n\t\t" +
			"\t\tPlugin/Section/Item/MenuItem - Specify a pop-up menu item inside the DropdownM" +
			"enu element.\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"Shortcuts\" IsActive=\"True\" HasExtendedV" +
			"iew=\"False\" CanHide=\"True\" EnableWithNoActiveInteraction=\"True\" Label=\"Quick Lin" +
			"ks\">\r\n\t\t\t<Config>\r\n\t\t\t\t<Layout>2</Layout>\r\n\t\t\t\t<VisibleRows>2</VisibleRows>\r\n\t\t\t" +
			"</Config>\r\n\t\t\t<Section Name=\"Links\" Visibility=\"Primary\">\r\n\t\t\t\t<Item Name=\"Valid" +
			"ate Caller\" ActivityName=\"ValidateCaller\" ShortcutType=\"Activity\"/>\r\n\t\t\t\t<Item R" +
			"owOneLabel=\"Pega\" RowTwoLabel=\"Web Site\" Target=\"http://www.pega.com/\" ShortcutT" +
			"ype=\"Url\">\r\n\t\t\t\t\t<Visible Criteria=\"SocialInfluence eq 0\" />\r\n\t\t\t\t</Item>\r\n\t\t\t\t<" +
			"Item Name=\"Send Alert\" Project=\"AgileDesktopExampleProject\" AutomationName=\"Aler" +
			"t\" ShortcutType=\"Automation\"/>\r\n\t\t\t\t<Item Name=\"Notepad\" Target=\"Notepad\" Shortc" +
			"utType=\"External\">\r\n\t\t\t\t\t<Enabled Criteria=\"SocialInfluence eq 0\" />\r\n\t\t\t\t</Item" +
			">\r\n\t\t\t\t<Item Name=\"My Dropdown\" ShortcutType=\"DropdownMenu\">\r\n\t\t\t\t\t<MenuItem Nam" +
			"e=\"Validate Caller\" ActivityName=\"ValidateCaller\" ShortcutType=\"Activity\"/>\r\n\t\t\t" +
			"\t\t<MenuItem Name=\"Send Alert\" Project=\"AgileDesktopExampleProject\" AutomationNam" +
			"e=\"Alert\" ShortcutType=\"Automation\"/>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Params Style" +
			" 1\" Project=\"AgileDesktopExampleProject\" AutomationName=\"MyAutomation\" ShortcutT" +
			"ype=\"Automation\"\r\n\t\t\t\t\tParams=\'Context.ClientFullName, Globals.AgentName, \"It#ap" +
			"os;s a string...\" , Interaction.ActiveKey\'/>\r\n\t\t\t\t<Item Name=\"Params Style 2\" Pr" +
			"oject=\"AgileDesktopExampleProject\" AutomationName=\"MyAutomation\" ShortcutType=\"A" +
			"utomation\"\r\n\t\t\t\t\tParams=\"Context.ClientFullName, Globals.AgentName, \'This #quot;" +
			" is a quote demo\' , Interaction.ActiveKey\"/>\r\n\t\t\t</Section>\r\n\t\t</Plugin>\r\n\r\n\t\t<!" +
			"--\tInteractionManager - This plug-in displays a list from which you can select t" +
			"he active interaction, close an\r\n\t\t\tinteraction, or optionally start an interact" +
			"ion.\r\n\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tSection/Item/Context Name - Enter th" +
			"e context property you want to appear in the list from which the end user  will\r" +
			"\n\t\t\t\t   select the new active interaction. For instance, if there is a context p" +
			"roperty named ClientFullName and you want your\r\n\t\t\t\t   end users to select an in" +
			"teraction based on the client\'s name, you would enter ClientFullName here.\r\n\t\t\t\t" +
			"Config/EnableStartInteraction - Enter True if you want to show a plus (+) button" +
			" to let the end user start an\r\n\t\t\t\t   interaction.\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"I" +
			"nteractionManager\" IsActive=\"False\">\r\n\t\t\t<Section Name=\"Selector\" Visibility=\"Pr" +
			"imary\">\r\n\t\t\t\t<Item Name=\"InteractionName\">\r\n\t\t\t\t\t<Context Name=\"ClientFullName\"/" +
			">\r\n\t\t\t\t\t<Label/>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Config>\r\n\t\t\t\t<EnableStartInter" +
			"action>True</EnableStartInteraction>\r\n\t\t\t</Config>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--\tStartI" +
			"nteraction - This plug-in displays a modal dialog which lets end-users enter a s" +
			"tring and start a search. The string is made available in an automation and the " +
			"automation developer can use this information to start a new interaction.\r\n\r\n\t\t\t" +
			"PLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tEnableWithNoActiveInteraction - Enter True if y" +
			"ou want to display the StartInteraction dialog when no\r\n\t\t\t\t\tinteractions exist." +
			"\r\n\t\t\t\tConfig/Label - Enter the text you want to appear on the dialog\'s heading. " +
			" This text should describe what the\r\n\t\t\t\t\tend user needs to do to start a new in" +
			"teraction. Here is an example: Enter Claim Number.\r\n\t\t\t\tConfig/Project - Enter t" +
			"he name of the OpenSpan project that contains the automation which starts a new\r" +
			"\n\t\t\t\t\tinteraction.\r\n\t\t\t\tConfig/Automation - Enter the name of the automation whi" +
			"ch starts the interaction. This automation can validate\r\n\t\t\t\t\tuser input and sta" +
			"rt an interaction by calling InteractionManager.StartInteraction(). This automat" +
			"ion should have one input parameter of type String (the text entered by the end " +
			"user), one output parameter of type String (a Message displayed if an error occu" +
			"rs), and should return a Boolean result (return False if an error message should" +
			" be displayed).\r\n\t\t\t\tConfig/DefaultErrorMessage - Enter the text of the message " +
			"you want to display if an error occurs while validating the input or starting\r\n\t" +
			"\t\t\t\tthe interaction. This will be used if the start interaction automation does " +
			"not return the error text but does return False.\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"Sta" +
			"rtInteraction\" IsActive=\"False\" EnableWithNoActiveInteraction=\"True\">\r\n\t\t\t<Confi" +
			"g>\r\n\t\t\t\t<Label>Enter Claim Number</Label>\r\n\t\t\t\t<Project>AgileDesktopExampleProje" +
			"ct</Project>\r\n\t\t\t\t<Automation>StartInteraction</Automation>\r\n\t\t\t\t<DefaultErrorMe" +
			"ssage>Unable to start interaction</DefaultErrorMessage>\r\n\t\t\t</Config>\r\n\t\t</Plugi" +
			"n>\r\n\t</Plugins>\r\n</Interaction>\r\n";
	}
	
	// Automator-8D8E89E060304E6
	public MainPrj_CRM_E_GetCustInfo_ActivityStarted CRM_E_GetCustInfo_ActivityStarted
	{
		get
		{
			return ((MainPrj_CRM_E_GetCustInfo_ActivityStarted)(this["CRM_E_GetCustInfo_ActivityStarted"]));
		}
	}
	
	// Automator-8D8E886C9690BDF
	public MainPrj_Main_E_IntMgr_InteractionClosed Main_E_IntMgr_InteractionClosed
	{
		get
		{
			return ((MainPrj_Main_E_IntMgr_InteractionClosed)(this["Main_E_IntMgr_InteractionClosed"]));
		}
	}
	
	// Automator-8D8E7D49282165B
	public MainPrj_Main_E_IntMgr_InteractionStarted Main_E_IntMgr_InteractionStarted
	{
		get
		{
			return ((MainPrj_Main_E_IntMgr_InteractionStarted)(this["Main_E_IntMgr_InteractionStarted"]));
		}
	}
	
	// Automator-8D8E92220880C0B
	public MainPrj_Main_E_UpdateDisplay_ActivityStarted Main_E_UpdateDisplay_ActivityStarted
	{
		get
		{
			return ((MainPrj_Main_E_UpdateDisplay_ActivityStarted)(this["Main_E_UpdateDisplay_ActivityStarted"]));
		}
	}
	
	// DesignForm-8D8E7C0F2493EDE
	public MainPrj_frmCustInfo frmCustInfo
	{
		get
		{
			return ((MainPrj_frmCustInfo)(this["frmCustInfo"]));
		}
	}
	
	// Automator-8D8E8980668067B
	public MainPrj_Main_P_LoadCustInfoValues Main_P_LoadCustInfoValues
	{
		get
		{
			return ((MainPrj_Main_P_LoadCustInfoValues)(this["Main_P_LoadCustInfoValues"]));
		}
	}
	
	// GlobalContainer-8D8E7CAB540ACF2
	public MainPrj__GC_Main _GC_Main
	{
		get
		{
			return ((MainPrj__GC_Main)(this["_GC_Main"]));
		}
	}
}

}

