using MainPrj_Main_E_IntMgr_InteractionStarted = MainPrj.Main_E_IntMgr_InteractionStarted;

using MainPrj_frmCustInfo = MainPrj.frmCustInfo;

using MainPrj_Main_E_IntMgr_InteractionClosed = MainPrj.Main_E_IntMgr_InteractionClosed;

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
			" through context values or the activity’s properties.\r\n\t\t\t-->\r\n\r\n\t<Activities>\r\n" +
			"\t\t<Activity Name=\"ValidateCaller\">\r\n\t\t\t<Value Name=\"CallerValid\" Type=\"Boolean\"/" +
			">\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"UnvalidateCaller\">\r\n\t\t\t<Value Name=\"CallerVa" +
			"lid\" Type=\"Boolean\"/>\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"AddPlan\">\r\n\t\t\t<Value Nam" +
			"e=\"PlanType\" Type=\"String\"/>\r\n\t\t\t<Value Name=\"EffectiveDate\" Type=\"String\"/>\r\n\t\t" +
			"</Activity>\r\n\t\t<Activity Name=\"CloseAccount\">\r\n\t\t\t<Value Name=\"EffectiveDate\" Ty" +
			"pe=\"String\"/>\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"ProcessClaim\">\r\n\t\t\t<Value Name=\"" +
			"ClaimNum\" Type=\"String\"/>\r\n\t\t\t<Value Name=\"ClaimDate\" Type=\"String\"/>\r\n\t\t</Activ" +
			"ity>\r\n\t\t<Activity Name=\"ProcessClaim\">\r\n\t\t</Activity>\r\n\t</Activities>\r\n\r\n\t<!--  " +
			"Plug-ins are HTML user interface sections in the toolbar. Agile Desktop includes" +
			" these plug-ins:\r\n\t\t\t- 360 View - Provides access to key customer information at" +
			" a glance.\r\n\t\t\t- Notes - Lets you add notes and search historic notes.\r\n\t\t\t- Sho" +
			"rtcuts - Provides buttons to launch an exe, go to a web site, execute an automat" +
			"ion,\r\n\t\t\t\tor start an activity.\r\n\t\t\t- Interaction Manager - Provides a list of a" +
			"ll current interactions on top of the 360 View.\r\n\t\t\t- Start Interaction - Provid" +
			"es a way for the Agile Desktop user to enter a string which can be\r\n\t\t\t\tretrieve" +
			"d in an automation and used for starting an interaction.\r\n\t\t  GENERIC PLUG-IN SE" +
			"TTINGS\r\n\r\n\t\t\t\tPlugin:IsActive - Indicates if the plug-in appears in the toolbar." +
			"\r\n\t\t\t\tPlugin:HasExtendedView - Indicates if the plug-in can be expanded to show " +
			"more information.\r\n\t\t\t\tPlugin:EnableWithNoActiveInteraction - Indicates if the u" +
			"ser can interact with the plug-in when\r\n\t\t\t\t\tthere is no active interaction.\r\n\t\t" +
			"\t\tPlugin:CanHide - If False, the user cannot hide the plug-in from the gear menu" +
			".\r\n\t\t\t\t-->\r\n\r\n\t<Plugins>\r\n\r\n\t\t<!--\t360 View - This plug-in displays interaction " +
			"context values that may be needed at a glance.\r\n\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n" +
			"\r\n\t\t\t\tPlugin/Section   - Provides a logical grouping of the elements within the " +
			"Plug-In.\r\n\t\t\t\t\t**NOTE** - <section> tag is case insensitive.\r\n\t\t\t\tPlugin/Section" +
			":Visibility - You can choose from these options:\r\n\t\t\t\t\tPrimary - The Section is " +
			"added to the Primary view.\r\n\t\t\t\t\tExtended - The Section is added to the Extended" +
			" view.\r\n\t\t\t\t\tBoth - The Section is added to both the Primary and Extended views." +
			"\r\n\t\t\t\tPlugin/Section:Name - Indicates the style in which the section data is dis" +
			"played. You can choose from these options:\r\n\t\t\t\t\tImages, Identity, Ratings, Prod" +
			"ucts, Custom, Balances, Eligibility, or Information.\r\n\t\t\t\t\t**NOTE** - Item conta" +
			"ining Image will only appear in section with Name attribute set to Images.\r\n\t\t\t\t" +
			"Plugin/Section:Label - An optional label that can appear at the top of the secti" +
			"on.\r\n\t\t\t\tPlugin/Section:InnerLabel - An optional smaller label that ONLY appears" +
			" on top of \"Information\" section. Default value is \"Contact Information\".\r\n\t\t\t\tP" +
			"lugin/Section:Divider - A true/false value that determines if a divider line wil" +
			"l appear above the section.\r\n\t\t\t\tPlugin/Section:ImagePadding - Specify the paddi" +
			"ng between images in the Images section. Default padding is 24 pixels.\r\n\t\t\t\t\t**N" +
			"OTE** - ImagePadding is optional, ONLY accepts numbers, ONLY works in Images sec" +
			"tion. If empty, default padding size will be used.\r\n\t\t\t\tPlugin/Section/Item:Name" +
			" - Identifies the item in the plugin\r\n\t\t\t\tPlugin/Section/Item:Image - Specify th" +
			"e name of the image to be displayed.\r\n\t\t\t\t\t1) To use default icons, choose from " +
			"the following default values\r\n\t\t\t\t\t\tCash, Check, MoneyOrder, Credit\r\n\t\t\t\t\t2) To " +
			"use custom images, follow these steps below:\r\n\t\t\t\t\t\t1. Add your images to the st" +
			"artup automation project.\r\n\t\t\t\t\t\t\tOr, put images in a local folder and add  <Cus" +
			"tomImagePath value=\"C:\\path\\to\\your\\pic\\folder\" /> to RuntimeConfig.xml <AgileDe" +
			"sktop /> section.\r\n\t\t\t\t\t\t2. Put your image name as the value of Image attribute." +
			" Make sure to only use (.png) images and include the file extension.\r\n\t\t\t\tPlugin" +
			"/Section/Item:Tooltip - Enter a text you want to appear when mouse over image. O" +
			"nly works with image item.\r\n\t\t\t\tPlugin/Section/Item:TextWrap - Set to true if yo" +
			"u want the text in that Item to wrap to the next line, instead of truncate. Defa" +
			"ult is False.\r\n\t\t\t\t\t**NOTE** - TextWrap option must be in the Item element, and " +
			"only works with items in \"Products\", \"Balances\", and \"Custom\" Sections.\r\n\t\t\t\tPlu" +
			"gin/Section/Item:TextAlign - Set the text alignment in an Item, whether left or " +
			"right. Only works with items in \"Custom\" Sections. Default is Left.\r\n\t\t\t\tPlugin/" +
			"Section/Item/Context:Name - Specifies the name of context value (defined in the " +
			"Context section) used to populate\r\n\t\t\t\t\tthis item. As the associated context pro" +
			"perty value changes, this item is automatically updated.\r\n\t\t\t\tPlugin/Section/Ite" +
			"m/Label - Defines the text label that appears in the toolbar. If omitted,\r\n\t\t\t\t\t" +
			"the Name value is used.\r\n\t\t\t\tPlugin/Section/Item/Visible:Criteria - Specifies if" +
			" an item will be displayed based on a context value, and comparison expression.\r" +
			"\n\t\t\t\t\tFor examle, add <Visible Criteria=\"SocialInfluence gt 3\"/> to an item, wil" +
			"l only display the item if SocialInfluence context value is greater than 3.\r\n\r\n\t" +
			"\t\t\t**NOTE** - Every Item in the 360AppBar Plugin can be set up as clickable shor" +
			"tcut, instructions are shown below.\r\n\t\t\t\tPlugin/Section/Item:ShortcutType - Indi" +
			"cates type of shortcut. Choose from these options:\r\n\t\t\t\t\t* Activity - Starts an " +
			"activity.\r\n\t\t\t\t\t* Url - Goes to a web page.\r\n\t\t\t\t\t* External - Starts an executa" +
			"ble.\r\n\t\t\t\t\t* Automation - Starts an automation.\r\n\t\t\t\tPlugin/Section/Item:Activit" +
			"yName - For Activity shortcuts, enter the name of the activity that should start" +
			" when the\r\n\t\t\t\t\tItem is clicked.\r\n\t\t\t\tPlugin/Section/Item:Target - Enter the des" +
			"tination for the shortcut. For instance, if the shortcut is a web site, you\r\n\t\t\t" +
			"\t\tenter the URL. If the shortcut launches an executable file, enter the name of " +
			"that file.\r\n\t\t\t\tPlugin/Section/Item:Project - For automation shortcuts, enter th" +
			"e name of the project that contains the automation. If the\r\n\t\t\t\t\tproject name co" +
			"ntains a space replace it here with an underscore. My Project should become My_P" +
			"roject.\r\n\t\t\t\tPlugin/Section/Item:AutomationName - For automation shortcuts, ente" +
			"r the name of the automation that should start when the\r\n\t\t\t\t\tItem is clicked. I" +
			"f the automation name contains a space replace it here with an underscore. My Au" +
			"tomation should become My_Automation.\r\n\t\t\t\t\tThis automation should have an entry" +
			" point, and parameters can be passed into entry point if needed.\r\n\t\t\t\tPlugin/Sec" +
			"tion/Item:Params - For passing parameters into automation entry point. Only use " +
			"it when Shortcut type is \"Automation\".\r\n\t\t\t\t\tSeparate multiple parameters by com" +
			"ma.\r\n\t\t\t\t\tParameters will be passed in the order as they appear here.\r\n\t\t\t\t\t* Co" +
			"ntext. - Prefix with Context. to use context values defined in the Context secti" +
			"on of this document.\r\n\t\t\t\t\t* Globals. - Prefix with Globals. to use global value" +
			"s defined in the Globals section of this document.\r\n\t\t\t\t\t* Interaction.ActiveKey" +
			" - Use this keyword to pass in the current active interaction key.\r\n\t\t\t\t\t* \"  \" " +
			"- Use double quotes to pass string literal into entry point. However the value s" +
			"tring for the whole Params attribute should be in single quotes.\r\n\t\t\t\t\t* \'  \' - " +
			"Use single quotes to pass string literal into entry point. However the value str" +
			"ing for the whole Params attribute should be in double quotes.\r\n\t\t\t\t\t\t**NOTE** -" +
			" Use #apos; for apostrophe (\'), and #quot; for quote (\") inside string literal. " +
			"Use regular HTML entities for other special characters if there is a XML syntax " +
			"error.\r\n\t\t\t\t\t\t**NOTE** - If no active interaction, \"Context.\" and \"Interaction.A" +
			"ctiveKey\" will be passed as null value\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"360AppBar\" La" +
			"bel=\"360 View\" IsActive=\"True\" HasExtendedView=\"True\" CanHide=\"False\" EnableWith" +
			"NoActiveInteraction=\"False\">\r\n\t\t\t<Section Name=\"Identity\" Visibility=\"Primary\">\r" +
			"\n\t\t\t\t<Item Name=\"FullName\"  ShortcutType=\"Automation\" Project=\"AgileDesktopExamp" +
			"leProject\" AutomationName=\"MyAutomation\">\r\n\t\t\t\t\t<Context Name=\"ClientFullName\"/>" +
			"\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Ratings\" V" +
			"isibility=\"Primary\">\r\n\t\t\t\t<Item Name=\"SocialInfluence\" ShortcutType=\"Automation\"" +
			" Project=\"AgileDesktopExampleProject\" \r\n\t\t\t\t\tAutomationName=\"MyAutomation\" Param" +
			"s=\"Context.ClientFullName, Globals.AgentName, \'It#apos;s a string...\' , Interact" +
			"ion.ActiveKey\">\r\n\t\t\t\t\t<Context Name=\"SocialInfluence\"/>\r\n\t\t\t\t\t<Label>Social Infl" +
			"uence</Label>\r\n\t\t\t\t\t<MaxValue>5</MaxValue>\r\n\t\t\t\t\t<Visible Criteria=\"SocialInflue" +
			"nce eq 0\"/>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"LifetimeValue\">\r\n\t\t\t\t\t<Context Name=\"L" +
			"ifetimeValue\"/>\r\n\t\t\t\t\t<Label>Lifetime Value</Label>\r\n\t\t\t\t\t<MaxValue>5</MaxValue>" +
			"\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Images\" Visibility=\"Both\" Divide" +
			"r=\"True\" Label=\"Default Images Padding\"  ImagePadding=\"24\">\r\n\t\t\t\t<Item Image=\"Ca" +
			"sh\" Tooltip=\"Cash Default Icon\" ShortcutType=\"Activity\" ActivityName=\"MyActivity" +
			"\"/>\r\n\t\t\t\t<Item Image=\"Check\" Tooltip=\"Check Default Icon\" ShortcutType=\"Url\" Tar" +
			"get=\"http://www.pega.com\"/>\r\n\t\t\t\t<Item Image=\"MoneyOrder\"/>\r\n\t\t\t\t<Item Image=\"Cr" +
			"edit\">\r\n\t\t\t\t\t<Visible Criteria=\"SocialInfluence eq 0\"/>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item " +
			"Image=\"MyCustomImage.png\"/>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Images\" Visibility" +
			"=\"Both\" Divider=\"True\" Label=\"Custom Images Padding\" ImagePadding=\"40\">\r\n\t\t\t\t<It" +
			"em Image=\"Cash\"/>\r\n\t\t\t\t<Item Image=\"Check\"/>\r\n\t\t\t\t<Item Image=\"MoneyOrder\"/>\r\n\t\t" +
			"\t\t<Item Image=\"Credit\"/>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"Products\" Visibility=" +
			"\"Primary\" Label=\"Products Section Label\" Divider=\"True\">\r\n\t\t\t\t<Item Name=\"VoiceP" +
			"lan\" ShortcutType=\"External\" Target=\"notepad.exe\">\r\n\t\t\t\t\t<Context Name=\"VoicePla" +
			"n\"/>\r\n\t\t\t\t\t<Label>Voice Plan</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"TextPlan\" Tex" +
			"tWrap=\"False\">\r\n\t\t\t\t\t<Context Name=\"TextPlan\"/>\r\n\t\t\t\t\t<Label>Text Plan</Label>\r\n" +
			"\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"DataPlan\" TextWrap=\"True\">\r\n\t\t\t\t\t<Context Name=\"Dat" +
			"aPlan\"/>\r\n\t\t\t\t\t<Label>Data Plan</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section" +
			" Name=\"Custom\" Visibility=\"Primary\" Label=\"Custom Section Label\" Divider =\"true\"" +
			">\r\n\t\t\t<Item Name=\"CustomAlignRight\" TextWrap =\"False\" TextAlign=\"Right\">\r\n\t\t\t\t\t<" +
			"Context Name=\"Email1\"/>\r\n\t\t\t\t\t<Label>Demo Align Right</Label>\r\n\t\t\t</Item>\r\n\t\t\t<I" +
			"tem Name=\"CustomAlignLeft\" TextAlign=\"Left\">\r\n\t\t\t\t\t<Context Name=\"Email2\"/>\r\n\t\t\t" +
			"\t\t<Label>Demo Align Left</Label>\r\n\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section Name=\"B" +
			"alances\" Visibility=\"Extended\" Divider=\"true\" Label=\"Balances\">\r\n\t\t\t\t<Item Name=" +
			"\"Current\">\r\n\t\t\t\t\t<Context Name=\"CurrentCharges\"/>\r\n\t\t\t\t\t<Label>Current</Label>\r\n" +
			"\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Past\">\r\n\t\t\t\t\t<Context Name=\"PastDue\"/>\r\n\t\t\t\t\t<Label" +
			">Past</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Penalties\">\r\n\t\t\t\t\t<Context Name=\"Pen" +
			"alties\"/>\r\n\t\t\t\t\t<Label>Penalties</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Total\">\r\n" +
			"\t\t\t\t\t<Context Name=\"TotalDue\"/>\r\n\t\t\t\t\t<Label>Total</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Se" +
			"ction>\r\n\t\t\t<Section Name=\"Eligibility\" Visibility=\"Extended\">\r\n\t\t\t\t<Item Name=\"U" +
			"pgrade\">\r\n\t\t\t\t\t<Context Name=\"EligibleForUpgrade\"/>\r\n\t\t\t\t\t<Label>Upgrade</Label>" +
			"\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Unlimited\">\r\n\t\t\t\t\t<Context Name=\"EligibleForUnlim" +
			"ited\"/>\r\n\t\t\t\t\t<Label>Unlimited</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Section " +
			"Name=\"Information\" Visibility=\"Extended\" Divider=\"True\" InnerLabel=\"Information " +
			"Inner Label\" Label=\"Information Section Label\">\r\n\t\t\t\t<Item Name=\"Phone1\">\r\n\t\t\t\t\t" +
			"<Context Name=\"Phone1\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Pho" +
			"ne2\">\r\n\t\t\t\t\t<Context Name=\"Phone2\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<It" +
			"em Name=\"Phone3\">\r\n\t\t\t\t\t<Context Name=\"Phone3\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</It" +
			"em>\r\n\t\t\t\t<Item Name=\"Email1\">\r\n\t\t\t\t\t<Context Name=\"Email1\"/>\r\n\t\t\t\t\t<Label></Labe" +
			"l>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Email2\">\r\n\t\t\t\t\t<Context Name=\"Email2\"/>\r\n\t\t\t\t\t<" +
			"Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Email3\">\r\n\t\t\t\t\t<Context Name=\"Email" +
			"3\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Address1\">\r\n\t\t\t\t\t<Conte" +
			"xt Name=\"Address1\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Address" +
			"2\">\r\n\t\t\t\t\t<Context Name=\"Address2\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<It" +
			"em Name=\"City\">\r\n\t\t\t\t\t<Context Name=\"City\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r" +
			"\n\t\t\t\t<Item Name=\"State\">\r\n\t\t\t\t\t<Context Name=\"State\"/>\r\n\t\t\t\t\t<Label></Label>\r\n\t\t" +
			"\t\t</Item>\r\n\t\t\t\t<Item Name=\"Zipcode\">\r\n\t\t\t\t\t<Context Name=\"Zipcode\"/>\r\n\t\t\t\t\t<Labe" +
			"l></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--\tNOTES - This plug-" +
			"in lets you add predefined notes, manually enter notes, and review the historica" +
			"l notes for\r\n\t\t\tan interaction. The name of this plug-in is Notes. To interact w" +
			"ith this plug-in through an automation, use the NotesController component.\r\n\r\n\t\t" +
			"\tPLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tSection/Item:Name - Specifies the name of the " +
			"item to add to the plug-in.\r\n\t\t\t\tSection/Item:IsActive - Determines whether the " +
			"template appears on a menu.\r\n\t\t\t\tSection/Item:Content - Specifies the format of " +
			"the template. To include context values, place the desired\r\n\t\t\t\t\tcontext value n" +
			"ame inside two braces, as shown here: {{example}}. As the associated context pro" +
			"perty value changes,\r\n\t\t\t\t\tthis item is updated on the menu and when added to a " +
			"Note.\r\n\t\t\t\tSection/Item:Activity - Specifies that this note will be added when t" +
			"he activity you specify completes.\r\n\t\t\t\tConfig/TimeZone - Specifies the time zon" +
			"e used to format dates for notes.\r\n\t\t\t\tConfig/LineBreak - Specifies the line bre" +
			"ak format for notes.\r\n\t\t\t\tConfig/NoteCharacterLimit - Specifies max number of ch" +
			"aracters allowed per note. The Enter key will be counted as provided by Line bre" +
			"ak Setting.\r\n\t\t\t\t\t\t\t\t\t\t\tIf this element is left blank or removed, no character l" +
			"imit will be enforced.\r\n\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"Notes\" IsActive=\"True\" HasE" +
			"xtendedView=\"True\" CanHide=\"True\" EnableWithNoActiveInteraction=\"False\">\r\n\t\t\t<Se" +
			"ction Name=\"NoteTemplates\">\r\n\t\t\t\t<Item Name=\"CallStarted\" IsActive=\"True\">\r\n\t\t\t\t" +
			"\t<Content>Call with {{ClientFullName}} started</Content>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item" +
			" Name=\"InformDueAmount\" IsActive=\"True\">\r\n\t\t\t\t\t<Content>Informed of {{TotalDue}}" +
			" due amount</Content>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Hidden Note\" IsActive=\"False" +
			"\">\r\n\t\t\t\t\t<Content>This note is hidden</Content>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"No" +
			"te With Activity\" IsActive=\"True\">\r\n\t\t\t\t\t<Content>Note added with the validate c" +
			"aller activity</Content>\r\n\t\t\t\t\t<Activity>ValidateCaller</Activity>\r\n\t\t\t\t</Item>\r" +
			"\n\t\t\t</Section>\r\n\t\t\t<Config>\r\n\t\t\t\t<TimeZone>GMT-5</TimeZone>\r\n\t\t\t\t<LineBreak>\\r\\n" +
			"</LineBreak>\r\n\t\t\t\t<NoteCharacterLimit></NoteCharacterLimit>\r\n\t\t\t</Config>\r\n\t\t</P" +
			"lugin>\r\n\r\n\t\t<!--\r\n\t\t\tSHORTCUTS - This plug-in provides shortcut buttons for call" +
			"ing an automation, going to a web page,\r\n\t\t\tstarting an executable, or starting " +
			"an activity.\r\n\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tPlugin/Label - Defines the h" +
			"eading text that appears for this section. The default is Quick Links.\r\n\t\t\t\tPlug" +
			"in/Config/Layout - Defines the number of columns in which shortcuts are displaye" +
			"d (2 or 3).\r\n\t\t\t\tPlugin/Config/VisibleRows - Defines the initial number of rows " +
			"to display.\r\n\t\t\t\tPlugin/Section/Name - Specifies the name of shortcut Section. T" +
			"his description does not appear in the Agile Desktop UI.\r\n\t\t\t\tPlugin/Section/Ite" +
			"m:Name - Enter the text you want to appear on the shortcut button. This will app" +
			"ear on one row vertically centered.\r\n\t\t\t\tPlugin/Section/Item:RowOneLabel - Text " +
			"that appears on upper half of shortcut button. This is an alternative to Name at" +
			"tribute.\r\n\t\t\t\tPlugin/Section/Item:RowTwoLabel - Text that appears on lower half " +
			"of shortcut button. This is an alternative to Name attribute.\r\n\t\t\t\tPlugin/Sectio" +
			"n/Item:ShortcutType - Indicates type of shortcut. Choose from these options:\r\n\t\t" +
			"\t\t\t* Activity - Starts an activity.\r\n\t\t\t\t\t* Url - Goes to a web page.\r\n\t\t\t\t\t* Ex" +
			"ternal - Starts an executable.\r\n\t\t\t\t\t* Automation - Starts an automation.\r\n\t\t\t\t\t" +
			"* DropdownMenu - Shows a dropdown menu for more options.\r\n\t\t\t\tPlugin/Section/Ite" +
			"m:ActivityName - For Activity shortcuts, enter the name of the activity that sho" +
			"uld start when the\r\n\t\t\t\t\tbutton is clicked.\r\n\t\t\t\tPlugin/Section/Item:Target - En" +
			"ter the destination for the shortcut. For instance, if the shortcut is a web sit" +
			"e, you\r\n\t\t\t\t\tenter the URL. If the shortcut launches an executable file, enter t" +
			"he name of that file.\r\n\t\t\t\tPlugin/Section/Item:Project - For automation shortcut" +
			"s, enter the name of the project that contains the automation. If the\r\n\t\t\t\t\tproj" +
			"ect name contains a space replace it here with an underscore. My Project should " +
			"become My_Project.\r\n\t\t\t\tPlugin/Section/Item:AutomationName - For automation shor" +
			"tcuts, enter the name of the automation that should start when the\r\n\t\t\t\t\tbutton " +
			"is pressed. If the automation name contains a space replace it here with an unde" +
			"rscore. My Automation should become My_Automation.\r\n\t\t\t\t\tThis automation should " +
			"have an entry point, and parameters can be passed into entry point if needed.\r\n\t" +
			"\t\t\tPlugin/Section/Item:Params - For passing parameters into automation entry poi" +
			"nt. Only use it when shortcut type is \"Automation\".\r\n\t\t\t\t\tSeparate multiple para" +
			"meters by comma.\r\n\t\t\t\t\tParameters will be passed in the order as they appear her" +
			"e.\r\n\t\t\t\t\t* Context. - Prefix with Context. to use context values defined in the " +
			"Context section of this document.\r\n\t\t\t\t\t* Globals. - Prefix with Globals. to use" +
			" global values defined in the Globals section of this document.\r\n\t\t\t\t\t* Interact" +
			"ion.ActiveKey - Use this keyword to pass in the current active interaction key.\r" +
			"\n\t\t\t\t\t* \"  \" - Use double quotes to pass string literal into entry point. Howeve" +
			"r the value string for the whole Params attribute should be in single quotes.\r\n\t" +
			"\t\t\t\t* \'  \' - Use single quotes to pass string literal into entry point. However " +
			"the value string for the whole Params attribute should be in double quotes.\r\n\t\t\t" +
			"\t\t\t**NOTE** - Use #apos; for apostrophe (\'), and #quot; for quote (\") inside str" +
			"ing literal. Use regular HTML entities for other special characters if there is " +
			"a XML syntax error.\r\n\t\t\t\t\t\t**NOTE** - If no active interaction, \"Context.\" and \"" +
			"Interaction.ActiveKey\" will be passed as null value\r\n\t\t\t\tplugin/Section/Item/Ena" +
			"bled:Criteria - Specifies if a shortcut button will be enabled based on the resu" +
			"lts of a logical expression.  Context values and Globals dictionary items can be" +
			"\r\n\t\t\t\t\tused in the expression.  For example, for enabling buttons which lead to " +
			"updating customer records have an Interaction Context value called \"ValidatedCal" +
			"ler\" of type Boolean and use,\r\n\t\t\t\t\t<Enabled Criteria=\"ValidatedCaller\"/> OR <En" +
			"abled Criteria=\"ValidatedCaller Eq \'True\'\"/>.  The default Criteria will evaluat" +
			"e to true and be enabled.\r\n\t\t\t\tplugin/Section/Item/Visible:Criteria - Specifies " +
			"if a shortcut button will be visible based on the results of a logical expressio" +
			"n.  Context values and Globals dictionary items can be\r\n\t\t\t\t\tused in the express" +
			"ion.  For example, for showing/hiding buttons which lead to updating customer re" +
			"cords have an Interaction Context value called \"ValidatedCaller\" of type Boolean" +
			" and use,\r\n\t\t\t\t\t<Visible Criteria=\"ValidatedCaller\"/> OR <Visible Criteria=\"Vali" +
			"datedCaller Eq \'True\'\"/>.  The default Criteria will evaluate to true and be vis" +
			"ible.\r\n\t\t\t\t\t** Note ** Care should be used when using this option as disappearin" +
			"g and shifting buttons can lead to a poor user experience.\r\n\t\t\t\tPlugin/Section/I" +
			"tem/MenuItem - Specify a pop-up menu item inside the DropdownMenu element.\r\n\t\t\t\t" +
			"-->\r\n\r\n\t\t<Plugin Name=\"Shortcuts\" IsActive=\"True\" HasExtendedView=\"False\" CanHid" +
			"e=\"True\" EnableWithNoActiveInteraction=\"True\" Label=\"Quick Links\">\r\n\t\t\t<Config>\r" +
			"\n\t\t\t\t<Layout>2</Layout>\r\n\t\t\t\t<VisibleRows>2</VisibleRows>\r\n\t\t\t</Config>\r\n\t\t\t<Sec" +
			"tion Name=\"Links\" Visibility=\"Primary\">\r\n\t\t\t\t<Item Name=\"Validate Caller\" Activi" +
			"tyName=\"ValidateCaller\" ShortcutType=\"Activity\"/>\r\n\t\t\t\t<Item RowOneLabel=\"Pega\" " +
			"RowTwoLabel=\"Web Site\" Target=\"http://www.pega.com/\" ShortcutType=\"Url\">\r\n\t\t\t\t\t<" +
			"Visible Criteria=\"SocialInfluence eq 0\" />\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Send Al" +
			"ert\" Project=\"AgileDesktopExampleProject\" AutomationName=\"Alert\" ShortcutType=\"A" +
			"utomation\"/>\r\n\t\t\t\t<Item Name=\"Notepad\" Target=\"Notepad\" ShortcutType=\"External\">" +
			"\r\n\t\t\t\t\t<Enabled Criteria=\"SocialInfluence eq 0\" />\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=" +
			"\"My Dropdown\" ShortcutType=\"DropdownMenu\">\r\n\t\t\t\t\t<MenuItem Name=\"Validate Caller" +
			"\" ActivityName=\"ValidateCaller\" ShortcutType=\"Activity\"/>\r\n\t\t\t\t\t<MenuItem Name=\"" +
			"Send Alert\" Project=\"AgileDesktopExampleProject\" AutomationName=\"Alert\" Shortcut" +
			"Type=\"Automation\"/>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item Name=\"Params Style 1\" Project=\"Agile" +
			"DesktopExampleProject\" AutomationName=\"MyAutomation\" ShortcutType=\"Automation\"\r\n" +
			"\t\t\t\t\tParams=\'Context.ClientFullName, Globals.AgentName, \"It#apos;s a string...\" " +
			", Interaction.ActiveKey\'/>\r\n\t\t\t\t<Item Name=\"Params Style 2\" Project=\"AgileDeskto" +
			"pExampleProject\" AutomationName=\"MyAutomation\" ShortcutType=\"Automation\"\r\n\t\t\t\t\tP" +
			"arams=\"Context.ClientFullName, Globals.AgentName, \'This #quot; is a quote demo\' " +
			", Interaction.ActiveKey\"/>\r\n\t\t\t</Section>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--\tInteractionMana" +
			"ger - This plug-in displays a list from which you can select the active interact" +
			"ion, close an\r\n\t\t\tinteraction, or optionally start an interaction.\r\n\r\n\t\t\tPLUG-IN" +
			" SPECIFIC SETTINGS\r\n\r\n\t\t\t\tSection/Item/Context Name - Enter the context property" +
			" you want to appear in the list from which the end user  will\r\n\t\t\t\t   select the" +
			" new active interaction. For instance, if there is a context property named Clie" +
			"ntFullName and you want your\r\n\t\t\t\t   end users to select an interaction based on" +
			" the client\'s name, you would enter ClientFullName here.\r\n\t\t\t\tConfig/EnableStart" +
			"Interaction - Enter True if you want to show a plus (+) button to let the end us" +
			"er start an\r\n\t\t\t\t   interaction.\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"InteractionManager\"" +
			" IsActive=\"False\">\r\n\t\t\t<Section Name=\"Selector\" Visibility=\"Primary\">\r\n\t\t\t\t<Item" +
			" Name=\"InteractionName\">\r\n\t\t\t\t\t<Context Name=\"ClientFullName\"/>\r\n\t\t\t\t\t<Label/>\r\n" +
			"\t\t\t\t</Item>\r\n\t\t\t</Section>\r\n\t\t\t<Config>\r\n\t\t\t\t<EnableStartInteraction>True</Enabl" +
			"eStartInteraction>\r\n\t\t\t</Config>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--\tStartInteraction - This " +
			"plug-in displays a modal dialog which lets end-users enter a string and start a " +
			"search. The string is made available in an automation and the automation develop" +
			"er can use this information to start a new interaction.\r\n\r\n\t\t\tPLUG-IN SPECIFIC S" +
			"ETTINGS\r\n\r\n\t\t\t\tEnableWithNoActiveInteraction - Enter True if you want to display" +
			" the StartInteraction dialog when no\r\n\t\t\t\t\tinteractions exist.\r\n\t\t\t\tConfig/Label" +
			" - Enter the text you want to appear on the dialog\'s heading.  This text should " +
			"describe what the\r\n\t\t\t\t\tend user needs to do to start a new interaction. Here is" +
			" an example: Enter Claim Number.\r\n\t\t\t\tConfig/Project - Enter the name of the Ope" +
			"nSpan project that contains the automation which starts a new\r\n\t\t\t\t\tinteraction." +
			"\r\n\t\t\t\tConfig/Automation - Enter the name of the automation which starts the inte" +
			"raction. This automation can validate\r\n\t\t\t\t\tuser input and start an interaction " +
			"by calling InteractionManager.StartInteraction(). This automation should have on" +
			"e input parameter of type String (the text entered by the end user), one output " +
			"parameter of type String (a Message displayed if an error occurs), and should re" +
			"turn a Boolean result (return False if an error message should be displayed).\r\n\t" +
			"\t\t\tConfig/DefaultErrorMessage - Enter the text of the message you want to displa" +
			"y if an error occurs while validating the input or starting\r\n\t\t\t\t\tthe interactio" +
			"n. This will be used if the start interaction automation does not return the err" +
			"or text but does return False.\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin Name=\"StartInteraction\" IsA" +
			"ctive=\"False\" EnableWithNoActiveInteraction=\"True\">\r\n\t\t\t<Config>\r\n\t\t\t\t<Label>Ent" +
			"er Claim Number</Label>\r\n\t\t\t\t<Project>AgileDesktopExampleProject</Project>\r\n\t\t\t\t" +
			"<Automation>StartInteraction</Automation>\r\n\t\t\t\t<DefaultErrorMessage>Unable to st" +
			"art interaction</DefaultErrorMessage>\r\n\t\t\t</Config>\r\n\t\t</Plugin>\r\n\t</Plugins>\r\n<" +
			"/Interaction>\r\n";
	}
	
	// Automator-8D8E7D49282165B
	public MainPrj_Main_E_IntMgr_InteractionStarted Main_E_IntMgr_InteractionStarted
	{
		get
		{
			return ((MainPrj_Main_E_IntMgr_InteractionStarted)(this["Main_E_IntMgr_InteractionStarted"]));
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
	
	// Automator-8D8E886C9690BDF
	public MainPrj_Main_E_IntMgr_InteractionClosed Main_E_IntMgr_InteractionClosed
	{
		get
		{
			return ((MainPrj_Main_E_IntMgr_InteractionClosed)(this["Main_E_IntMgr_InteractionClosed"]));
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

