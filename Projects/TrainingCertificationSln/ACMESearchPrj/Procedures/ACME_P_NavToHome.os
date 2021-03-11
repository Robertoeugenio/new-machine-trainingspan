<OpenSpanDesignDocument Version="19.1.0.25" Serializer="2.0" Culture="pt-BR">
  <ComponentInfo>
    <Type Value="OpenSpan.Automation.Automator" />
    <Assembly Value="OpenSpan.Automation" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Web.Universal, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Web.WebBase, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Automation, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences />
    <BuildReferences />
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Automation.Automator Name="ACME_P_NavToHome" Id="Automator-8D8E3237CB3C098">
      <AutomationDocument>
        <Name Value="" />
        <Size Value="5010, 5000" />
        <Objects>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E39D66B7901B" />
            <PartID Value="2" />
            <Left Value="200" />
            <Top Value="120" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEwpHome" />
            <Fittings>
              <IsCreated Collapsed="False" ActualText="IsCreated" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8653D366" />
            <Left Value="580" />
            <Top Value="40" />
            <PartID Value="3" />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8C349E78" />
            <Left Value="860" />
            <Top Value="40" />
            <PartID Value="4" />
          </ConnectionBlock>
          <ConnectionBlock type="OpenSpan.Automation.Design.ConnectionBlocks.MultiExitPointBlock">
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\ExitPoint-8D8E39DB48499EE" />
            <Left Value="1000" />
            <Top Value="40" />
            <PartID Value="6" />
            <Title Value="Failed" />
            <EventName Value="" />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\EntryPoint-8D8E39CC8011547" />
            <Left Value="60" />
            <Top Value="120" />
            <PartID Value="1" />
          </ConnectionBlock>
          <ConnectionBlock type="OpenSpan.Automation.Design.ConnectionBlocks.MultiExitPointBlock">
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\ExitPoint-8D8E39EBE6A0EC6" />
            <Left Value="720" />
            <Top Value="40" />
            <PartID Value="8" />
            <Title Value="Sucess" />
            <EventName Value="" />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\JumpHost-8D8E3A09A3AA53B" />
            <PartID Value="14" />
            <Left Value="380" />
            <Top Value="140" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E3A144C19D61" />
            <PartID Value="17" />
            <Left Value="460" />
            <Top Value="200" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMESystem" />
            <Fittings>
              <IsRunning Collapsed="False" ActualText="IsRunning" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="WaitForCreate" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3A4CA28DCE0" />
            <PartID Value="19" />
            <Left Value="220" />
            <Top Value="320" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEwpSignIn" />
            <Fittings>
              <Result Collapsed="False" ActualText="Result" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\LabelHost-8D8E3A4E95E6AC7" />
            <Left Value="80" />
            <Top Value="340" />
            <PartID Value="20" />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\JumpHost-8D8E3A4F91C8108" />
            <PartID Value="21" />
            <Left Value="640" />
            <Top Value="200" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Start" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3A56BA7732B" />
            <PartID Value="26" />
            <Left Value="640" />
            <Top Value="260" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMESystem" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\JumpHost-8D8E3A58731B0B0" />
            <PartID Value="28" />
            <Left Value="800" />
            <Top Value="260" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock type="OpenSpan.Automation.Design.ConnectionBlocks.EntryPointExecuteBlock">
            <DisplayName Value="Execute" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3DA63A16CE5" />
            <PartID Value="31" />
            <Left Value="420" />
            <Top Value="320" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACME_P_SignIn" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA7ACBCFDB" />
            <PartID Value="32" />
            <Left Value="640" />
            <Top Value="320" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA8F87BF51" />
            <PartID Value="33" />
            <Left Value="640" />
            <Top Value="380" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA95E1D2D2" />
            <PartID Value="34" />
            <Left Value="360" />
            <Top Value="460" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Control.Click" />
            <ConnectableUniqueId Value="Automator-8D8E3237CB3C098\ConnectableEvent-8D8E46C93C34244" />
            <PartID Value="42" />
            <Left Value="60" />
            <Top Value="240" />
            <Collapsed Value="True" />
            <WillExecute Value="True" />
            <InstanceName Value="btnTest" />
            <OverriddenIds />
          </ConnectionBlock>
        </Objects>
        <Links>
          <Link PartID="11" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="3" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8653D366" MemberComponentId="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8653D366" />
            <To PartID="8" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\ExitPoint-8D8E39EBE6A0EC6" MemberComponentId="Automator-8D8E3237CB3C098\ExitPoint-8D8E39EBE6A0EC6" />
            <LinkPoints>
              <Point value="686, 58" />
              <Point value="696, 58" />
              <Point value="704, 58" />
              <Point value="704, 58" />
              <Point value="712, 58" />
              <Point value="722, 58" />
            </LinkPoints>
          </Link>
          <Link PartID="12" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="4" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8C349E78" MemberComponentId="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8C349E78" />
            <To PartID="6" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\ExitPoint-8D8E39DB48499EE" MemberComponentId="Automator-8D8E3237CB3C098\ExitPoint-8D8E39DB48499EE" />
            <LinkPoints>
              <Point value="956, 58" />
              <Point value="966, 58" />
              <Point value="966, 58" />
              <Point value="966, 58" />
              <Point value="992, 58" />
              <Point value="1002, 58" />
            </LinkPoints>
          </Link>
          <Link PartID="13" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="4" PortName="_param1" PortType="Property" ConnectableId="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8C349E78" MemberComponentId="EMPTY" />
            <To PartID="6" PortName="param1" PortType="Property" ConnectableId="Automator-8D8E3237CB3C098\ExitPoint-8D8E39DB48499EE" MemberComponentId="EMPTY" />
            <LinkPoints>
              <Point value="956, 85" />
              <Point value="966, 85" />
              <Point value="966, 85" />
              <Point value="966, 85" />
              <Point value="992, 85" />
              <Point value="1002, 85" />
            </LinkPoints>
          </Link>
          <Link PartID="15" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3237CB3C098\EntryPoint-8D8E39CC8011547" MemberComponentId="Automator-8D8E3237CB3C098\EntryPoint-8D8E39CC8011547" />
            <To PartID="2" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E39D66B7901B" MemberComponentId="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E39D66B7901B" />
            <LinkPoints>
              <Point value="171, 138" />
              <Point value="181, 138" />
              <Point value="181, 138" />
              <Point value="181, 149" />
              <Point value="195, 149" />
              <Point value="205, 149" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="23" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" ParentMemberName="IsCreated" DecisionValue="True" ConnectableId="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E39D66B7901B" />
            <To PartID="14" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\JumpHost-8D8E3A09A3AA53B" MemberComponentId="Automator-8D8E3237CB3C098\JumpHost-8D8E3A09A3AA53B" />
            <LinkPoints>
              <Point value="342, 180" />
              <Point value="352, 180" />
              <Point value="348, 180" />
              <Point value="348, 180" />
              <Point value="356, 180" />
              <Point value="356, 157" />
              <Point value="373, 157" />
              <Point value="383, 157" />
            </LinkPoints>
          </DecisionEventLink>
          <DecisionEventLink PartID="24" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" ParentMemberName="IsCreated" DecisionValue="False" ConnectableId="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E39D66B7901B" />
            <To PartID="17" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E3A144C19D61" MemberComponentId="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E3A144C19D61" />
            <LinkPoints>
              <Point value="342, 195" />
              <Point value="352, 195" />
              <Point value="348, 195" />
              <Point value="348, 195" />
              <Point value="356, 195" />
              <Point value="356, 229" />
              <Point value="455, 229" />
              <Point value="465, 229" />
            </LinkPoints>
          </DecisionEventLink>
          <DecisionEventLink PartID="25" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="17" ParentMemberName="IsRunning" DecisionValue="True" ConnectableId="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E3A144C19D61" />
            <To PartID="21" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\JumpHost-8D8E3A4F91C8108" MemberComponentId="Automator-8D8E3237CB3C098\JumpHost-8D8E3A4F91C8108" />
            <LinkPoints>
              <Point value="594, 260" />
              <Point value="604, 260" />
              <Point value="604, 260" />
              <Point value="604, 217" />
              <Point value="633, 217" />
              <Point value="643, 217" />
            </LinkPoints>
          </DecisionEventLink>
          <DecisionEventLink PartID="27" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="17" ParentMemberName="IsRunning" DecisionValue="False" ConnectableId="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E3A144C19D61" />
            <To PartID="26" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3A56BA7732B" MemberComponentId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3A56BA7732B" />
            <LinkPoints>
              <Point value="594, 275" />
              <Point value="604, 275" />
              <Point value="604, 275" />
              <Point value="604, 289" />
              <Point value="635, 289" />
              <Point value="645, 289" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="29" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="26" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3A56BA7732B" MemberComponentId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3A56BA7732B" />
            <To PartID="28" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\JumpHost-8D8E3A58731B0B0" MemberComponentId="Automator-8D8E3237CB3C098\JumpHost-8D8E3A58731B0B0" />
            <LinkPoints>
              <Point value="774, 289" />
              <Point value="784, 289" />
              <Point value="780, 289" />
              <Point value="780, 289" />
              <Point value="788, 289" />
              <Point value="788, 277" />
              <Point value="793, 277" />
              <Point value="803, 277" />
            </LinkPoints>
          </Link>
          <Link PartID="30" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="20" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3237CB3C098\LabelHost-8D8E3A4E95E6AC7" MemberComponentId="Automator-8D8E3237CB3C098\LabelHost-8D8E3A4E95E6AC7" />
            <To PartID="19" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3A4CA28DCE0" MemberComponentId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3A4CA28DCE0" />
            <LinkPoints>
              <Point value="179, 358" />
              <Point value="189, 358" />
              <Point value="192, 358" />
              <Point value="192, 349" />
              <Point value="215, 349" />
              <Point value="225, 349" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="36" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="19" ParentMemberName="Result" DecisionValue="True" ConnectableId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3A4CA28DCE0" />
            <To PartID="31" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3DA63A16CE5" MemberComponentId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3DA63A16CE5" />
            <LinkPoints>
              <Point value="365, 380" />
              <Point value="375, 380" />
              <Point value="372, 380" />
              <Point value="372, 380" />
              <Point value="380, 380" />
              <Point value="380, 349" />
              <Point value="415, 349" />
              <Point value="425, 349" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="37" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="31" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3DA63A16CE5" MemberComponentId="Automator-8D8E3A60CCCDFB3\ExitPoint-8D8E3A6680813BA" />
            <To PartID="32" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA7ACBCFDB" MemberComponentId="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA7ACBCFDB" />
            <LinkPoints>
              <Point value="571, 366" />
              <Point value="581, 366" />
              <Point value="580, 366" />
              <Point value="580, 366" />
              <Point value="588, 366" />
              <Point value="588, 337" />
              <Point value="633, 337" />
              <Point value="643, 337" />
            </LinkPoints>
          </Link>
          <Link PartID="38" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="31" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3DA63A16CE5" MemberComponentId="Automator-8D8E3A60CCCDFB3\ExitPoint-8D8E3A67DB65305" />
            <To PartID="33" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA8F87BF51" MemberComponentId="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA8F87BF51" />
            <LinkPoints>
              <Point value="571, 383" />
              <Point value="581, 383" />
              <Point value="580, 383" />
              <Point value="580, 383" />
              <Point value="588, 383" />
              <Point value="588, 397" />
              <Point value="633, 397" />
              <Point value="643, 397" />
            </LinkPoints>
          </Link>
          <Link PartID="39" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="31" PortName="param1" PortType="Property" ConnectableId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3DA63A16CE5" MemberComponentId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3DA63A16CE5" />
            <To PartID="33" PortName="_param1" PortType="Property" ConnectableId="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA8F87BF51" MemberComponentId="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA8F87BF51" />
            <LinkPoints>
              <Point value="571, 400" />
              <Point value="581, 400" />
              <Point value="588, 400" />
              <Point value="588, 426" />
              <Point value="635, 426" />
              <Point value="645, 426" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="40" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="19" ParentMemberName="Result" DecisionValue="False" ConnectableId="Automator-8D8E3237CB3C098\ConnectableMethod-8D8E3A4CA28DCE0" />
            <To PartID="34" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA95E1D2D2" MemberComponentId="Automator-8D8E3237CB3C098\JumpHost-8D8E3DA95E1D2D2" />
            <LinkPoints>
              <Point value="365, 395" />
              <Point value="375, 395" />
              <Point value="372, 395" />
              <Point value="372, 395" />
              <Point value="380, 395" />
              <Point value="380, 412" />
              <Point value="356, 412" />
              <Point value="356, 477" />
              <Point value="353, 477" />
              <Point value="363, 477" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="43" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="42" PortName="Raised" PortType="Event" ConnectableId="Automator-8D8E3237CB3C098\ConnectableEvent-8D8E46C93C34244" MemberComponentId="Automator-8D8E3237CB3C098\EMPTY" />
            <To PartID="2" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E39D66B7901B" MemberComponentId="Automator-8D8E3237CB3C098\ConnectableProperties-8D8E39D66B7901B" />
            <LinkPoints>
              <Point value="154, 269" />
              <Point value="164, 269" />
              <Point value="180, 269" />
              <Point value="180, 149" />
              <Point value="195, 149" />
              <Point value="205, 149" />
            </LinkPoints>
          </Link>
        </Links>
        <Comments />
        <SubGraphs />
      </AutomationDocument>
      <DocumentPosition Value="Binary">
        <Binary>AAEAAAD/////AQAAAAAAAAAMAgAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTeXN0ZW0uRHJhd2luZy5Qb2ludEYCAAAAAXgBeQAACwsCAAAAAAAAAAAAoEIL</Binary>
      </DocumentPosition>
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="_EntryPointExecute" aliasName="Execute" visibility="DefaultOn" source="" blockTypeName="OpenSpan.Automation.Design.ConnectionBlocks.EntryPointExecuteBlock" returnType="System.Void">
            <param name="param1" aliasName="msg" paramType="System.String" isIn="False" isOut="True" position="0" />
          </OpenSpan.DynamicMembers.DynamicMethodInfo>
        </Items>
      </Content>
    </OpenSpan.Automation.Automator>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties1" Id="ConnectableProperties-8D8E39D66B7901B">
      <ComponentName Value="ACMEwpHome" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.WebBase.Controls.WebPage" />
      <InstanceUniqueId Value="UniversalWebAdapter-8D8DE50B28552EF\WebPage-8D8E2499572E967" />
      <MemberDetails Value=".IsCreated Property" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="IsCreated" />
            <MemberType Value="Property" />
            <TypeName Value="System.Boolean" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.LabelHost Name="labelHost1" Id="LabelHost-8D8E39D8653D366">
      <ComponentName Value="OpenSpan.Automation.EntryPoint" />
      <DisplayName Value="Sucess" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="EMPTY" />
      <LabelName Value="Sucess" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="GoToLabel" aliasName="GoToLabel" visibility="AlwaysHidden" source="" blockTypeName="" returnType="System.Void" />
        </Items>
      </Content>
    </OpenSpan.Automation.LabelHost>
    <OpenSpan.Automation.LabelHost Name="labelHost2" Id="LabelHost-8D8E39D8C349E78">
      <ComponentName Value="OpenSpan.Automation.EntryPoint" />
      <DisplayName Value="Failed" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="EMPTY" />
      <LabelName Value="Failed" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="GoToLabel" aliasName="GoToLabel" visibility="AlwaysHidden" source="" blockTypeName="" returnType="System.Void">
            <param name="_param1" aliasName="msg" paramType="System.String" isIn="True" isOut="False" position="0" />
          </OpenSpan.DynamicMembers.DynamicMethodInfo>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="_param1" canRead="True" canWrite="True" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.LabelHost>
    <OpenSpan.Automation.ExitPoint Name="exitPoint2" Id="ExitPoint-8D8E39DB48499EE">
      <ComponentName Value="Execute" />
      <DisplayName Value="Failed" />
      <EntryPoint Value="ComponentReference" Name="entryPoint1" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D8E3237CB3C098\EntryPoint-8D8E39CC8011547" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.Void" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="param1" canRead="True" canWrite="True" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.ExitPoint>
    <OpenSpan.Automation.EntryPoint Name="entryPoint1" Id="EntryPoint-8D8E39CC8011547">
      <AliasName Value="Execute" />
      <ComponentName Value="Execute" />
      <DisplayName Value="Execute" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D8E3237CB3C098\EntryPoint-8D8E39CC8011547" />
      <MemberDetails Value="" />
      <MethodName Value="_EntryPointExecute" />
      <Removing Value="False" />
      <UseAlias Value="True" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.Void" aliasName="Result" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="param1" canRead="True" canWrite="False" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.EntryPoint>
    <OpenSpan.Automation.ExitPoint Name="exitPoint1" Id="ExitPoint-8D8E39EBE6A0EC6">
      <ComponentName Value="Execute" />
      <DisplayName Value="Sucess" />
      <EntryPoint Value="ComponentReference" Name="entryPoint1" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D8E3237CB3C098\EntryPoint-8D8E39CC8011547" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="param1" canRead="True" canWrite="True" type="System.String" aliasName="param1" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.Void" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.ExitPoint>
    <OpenSpan.Automation.JumpHost Name="jumpHost1" Id="JumpHost-8D8E3A09A3AA53B">
      <ComponentName Value="labelHost1" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8653D366" />
      <MemberDetails Value=" - Sucess" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties2" Id="ConnectableProperties-8D8E3A144C19D61">
      <ComponentName Value="ACMESystem" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Universal.UniversalWebAdapter" />
      <InstanceUniqueId Value="UniversalWebAdapter-8D8DE50B28552EF" />
      <MemberDetails Value=".IsRunning Property" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="IsRunning" />
            <MemberType Value="Property" />
            <TypeName Value="System.Boolean" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod1" Id="ConnectableMethod-8D8E3A4CA28DCE0">
      <ComponentName Value="ACMEwpSignIn" />
      <DisplayName Value="WaitForCreate" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.WebBase.Controls.WebPage" />
      <InstanceUniqueId Value="UniversalWebAdapter-8D8DE50B28552EF\WebPage-8D8E248A5F8C9E4" />
      <MemberDetails Value=".WaitForCreate() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="False" type="System.Boolean" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="WaitForCreate" />
            <MemberType Value="Method" />
            <TypeName Value="System.Boolean" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Boolean" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableMethod>
    <OpenSpan.Automation.LabelHost Name="labelHost3" Id="LabelHost-8D8E3A4E95E6AC7">
      <ComponentName Value="OpenSpan.Automation.EntryPoint" />
      <DisplayName Value="Signin" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="EMPTY" />
      <LabelName Value="Signin" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="GoToLabel" aliasName="GoToLabel" visibility="AlwaysHidden" source="" blockTypeName="" returnType="System.Void" />
        </Items>
      </Content>
    </OpenSpan.Automation.LabelHost>
    <OpenSpan.Automation.JumpHost Name="jumpHost2" Id="JumpHost-8D8E3A4F91C8108">
      <ComponentName Value="labelHost3" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D8E3237CB3C098\LabelHost-8D8E3A4E95E6AC7" />
      <MemberDetails Value=" - Signin" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod2" Id="ConnectableMethod-8D8E3A56BA7732B">
      <ComponentName Value="ACMESystem" />
      <DisplayName Value="Start" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Universal.UniversalWebAdapter" />
      <InstanceUniqueId Value="UniversalWebAdapter-8D8DE50B28552EF" />
      <MemberDetails Value=".Start() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Start" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableMethod>
    <OpenSpan.Automation.JumpHost Name="jumpHost3" Id="JumpHost-8D8E3A58731B0B0">
      <ComponentName Value="labelHost3" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D8E3237CB3C098\LabelHost-8D8E3A4E95E6AC7" />
      <MemberDetails Value=" - Signin" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod3" Id="ConnectableMethod-8D8E3DA63A16CE5">
      <ComponentName Value="ACME_P_SignIn" />
      <DisplayName Value="Execute" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.Automator" />
      <InstanceUniqueId Value="Automator-8D8E3A60CCCDFB3" />
      <MemberDetails Value=".Execute() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="_EntryPointExecute" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
                <Content Name="ParameterPrototype">
                  <Items>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="True" />
                      <CanWrite Value="False" />
                      <DefaultSet Value="False" />
                      <ParamName Value="param1" />
                      <Position Value="0" />
                      <TypeName Value="System.String" />
                    </OpenSpan.Automation.ParameterPrototype>
                  </Items>
                </Content>
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableMethod>
    <OpenSpan.Automation.JumpHost Name="jumpHost4" Id="JumpHost-8D8E3DA7ACBCFDB">
      <ComponentName Value="labelHost1" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8653D366" />
      <MemberDetails Value=" - Sucess" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
    <OpenSpan.Automation.JumpHost Name="jumpHost5" Id="JumpHost-8D8E3DA8F87BF51">
      <ComponentName Value="labelHost2" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8C349E78" />
      <MemberDetails Value=" - Failed" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
                <Content Name="ParameterPrototype">
                  <Items>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="False" />
                      <ParamName Value="_param1" />
                      <Position Value="0" />
                      <TypeName Value="System.String" />
                    </OpenSpan.Automation.ParameterPrototype>
                  </Items>
                </Content>
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
    <OpenSpan.Automation.JumpHost Name="jumpHost6" Id="JumpHost-8D8E3DA95E1D2D2">
      <ComponentName Value="labelHost2" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D8E3237CB3C098\LabelHost-8D8E39D8C349E78" />
      <MemberDetails Value=" - Failed" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
                <Content Name="ParameterPrototype">
                  <Items>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="True" />
                      <DefaultValue Value="Unable to find page Sign In&#xD;&#xA;" />
                      <ParamName Value="_param1" />
                      <Position Value="0" />
                      <TypeName Value="System.String" />
                    </OpenSpan.Automation.ParameterPrototype>
                  </Items>
                </Content>
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
    <OpenSpan.Automation.ConnectableEvent Name="connectableEvent1" Id="ConnectableEvent-8D8E46C93C34244">
      <ComponentName Value="btnTest" />
      <DisplayName Value="Control.Click" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="System.Windows.Forms.Button" />
      <InstanceUniqueId Value="DesignForm-8D8E46A4FF4EC54\Button-8D8E46AABF1A888" />
      <MemberDetails Value=".Click Event" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Click" />
            <MemberType Value="Event" />
            <TypeName Value="System.EventHandler" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableEvent>
  </Component>
</OpenSpanDesignDocument>