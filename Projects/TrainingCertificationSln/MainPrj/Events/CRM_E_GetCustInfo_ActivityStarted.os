<OpenSpanDesignDocument Version="19.1.0.25" Serializer="2.0" Culture="pt-BR">
  <ComponentInfo>
    <Type Value="OpenSpan.Automation.Automator" />
    <Assembly Value="OpenSpan.Automation" />
    <AssemblyReferences>
      <Assembly Value="System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Automation, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Controls, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Interactions.Controls, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Script, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    </AssemblyReferences>
    <DynamicAssemblyReferences>
      <Assembly Value="BooleanExpression-8D8E8A0D95B9334" Type="Dynamic.BooleanExpression_8D8E8A0D95B9334.Expression" />
    </DynamicAssemblyReferences>
    <FileReferences />
    <BuildReferences />
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Automation.Automator Name="CRM_E_GetCustInfo_ActivityStarted" Id="Automator-8D8E89E060304E6">
      <AutomationDocument>
        <Name Value="" />
        <Size Value="5000, 5000" />
        <Objects>
          <ConnectionBlock>
            <DisplayName Value="Activity.ActivityStarted" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableEvent-8D8E89FA70BBC95" />
            <PartID Value="1" />
            <Left Value="40" />
            <Top Value="100" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="CRMactGetCustInfo" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableProperties-8D8E89FA70E5332" />
            <PartID Value="2" />
            <Left Value="240" />
            <Top Value="100" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="CRMlblAcctNum" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" />
            <PartID Value="7" />
            <Left Value="440" />
            <Top Value="120" />
          </ConnectionBlock>
          <ConnectionBlock>
            <Text Value="Decision" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableBoolDecision-8D8E8A1547F657B" />
            <PartID Value="8" />
            <X Value="100" />
            <Y Value="680" />
            <Width Value="100" />
            <Height Value="100" />
            <Title_X Value="142.454437" />
            <Title_Y Value="704.355469" />
            <Title_Width Value="51.2890549" />
            <Title_Height Value="15.0911436" />
            <DisplayName Value="Decision" />
            <CanEditName Value="True" />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Show" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A17961268B" />
            <PartID Value="13" />
            <Left Value="440" />
            <Top Value="220" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="messageDialog1" />
            <Fittings>
              <Result Collapsed="True" ActualText="Result" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3B77F5274" />
            <PartID Value="24" />
            <Left Value="800" />
            <Top Value="120" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="CRMlblAcctNum" />
            <UpstreamKeyedIds>
              <UpstreamKeyId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            </UpstreamKeyedIds>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3C1C85010" />
            <PartID Value="25" />
            <Left Value="800" />
            <Top Value="200" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="CRMtxtStreetAdd" />
            <UpstreamKeyedIds>
              <UpstreamKeyId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            </UpstreamKeyedIds>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3C87D3F93" />
            <PartID Value="26" />
            <Left Value="800" />
            <Top Value="280" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="CRMtxtCity" />
            <UpstreamKeyedIds>
              <UpstreamKeyId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            </UpstreamKeyedIds>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3CCE4D6E8" />
            <PartID Value="27" />
            <Left Value="800" />
            <Top Value="360" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="CRMtxtName" />
            <UpstreamKeyedIds>
              <UpstreamKeyId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            </UpstreamKeyedIds>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3D06D1D15" />
            <PartID Value="28" />
            <Left Value="800" />
            <Top Value="440" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="CRMtxtState" />
            <UpstreamKeyedIds>
              <UpstreamKeyId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            </UpstreamKeyedIds>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3D3F34DF3" />
            <PartID Value="29" />
            <Left Value="800" />
            <Top Value="520" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="CRMtxtZip" />
            <UpstreamKeyedIds>
              <UpstreamKeyId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            </UpstreamKeyedIds>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" />
            <PartID Value="30" />
            <Left Value="1060" />
            <Top Value="120" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="IntMgr" />
            <OverriddenIds />
          </ConnectionBlock>
        </Objects>
        <Links>
          <Link PartID="3" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="Raised" PortType="Event" ConnectableId="Automator-8D8E89E060304E6\ConnectableEvent-8D8E89FA70BBC95" MemberComponentId="Automator-8D8E89E060304E6\ConnectableEvent-8D8E89FA70BBC95" />
            <To PartID="2" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E89FA70E5332" MemberComponentId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E89FA70E5332" />
            <LinkPoints>
              <Point value="212, 145" />
              <Point value="222, 145" />
              <Point value="228, 145" />
              <Point value="228, 145" />
              <Point value="235, 145" />
              <Point value="245, 145" />
            </LinkPoints>
          </Link>
          <Link PartID="4" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="InteractionKey" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableEvent-8D8E89FA70BBC95" MemberComponentId="Automator-8D8E89E060304E6\ConnectableEvent-8D8E89FA70BBC95" />
            <To PartID="2" PortName="Text" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E89FA70E5332" MemberComponentId="WindowsAdapter-8D8DFE68142AF1E\Label-8D8DFF8576B26AC" />
            <LinkPoints>
              <Point value="212, 213" />
              <Point value="222, 213" />
              <Point value="228, 213" />
              <Point value="228, 179" />
              <Point value="235, 179" />
              <Point value="245, 179" />
            </LinkPoints>
          </Link>
          <Link PartID="10" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="7" PortName="Result" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" MemberComponentId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" />
            <To PartID="8" PortName="Input" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableBoolDecision-8D8E8A1547F657B" MemberComponentId="Automator-8D8E89E060304E6\ConnectableBoolDecision-8D8E8A1547F657B" />
            <LinkPoints>
              <Point value="522, 162" />
              <Point value="522, 172" />
              <Point value="522, 172" />
              <Point value="564, 172" />
              <Point value="564, 150" />
              <Point value="673, 150" />
              <Point value="683, 150" />
            </LinkPoints>
          </Link>
          <Link PartID="12" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="7" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" MemberComponentId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" />
            <To PartID="8" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E89E060304E6\ConnectableBoolDecision-8D8E8A1547F657B" MemberComponentId="Automator-8D8E89E060304E6\ConnectableBoolDecision-8D8E8A1547F657B" />
            <LinkPoints>
              <Point value="550, 143" />
              <Point value="560, 143" />
              <Point value="564, 143" />
              <Point value="564, 92" />
              <Point value="730, 92" />
              <Point value="730, 93" />
              <Point value="730, 103" />
            </LinkPoints>
          </Link>
          <Link PartID="15" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="8" PortName="SolvedFalse" PortType="Event" ConnectableId="Automator-8D8E89E060304E6\ConnectableBoolDecision-8D8E8A1547F657B" MemberComponentId="Automator-8D8E89E060304E6\ConnectableBoolDecision-8D8E8A1547F657B" />
            <To PartID="13" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A17961268B" MemberComponentId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A17961268B" />
            <LinkPoints>
              <Point value="730, 197" />
              <Point value="730, 207" />
              <Point value="730, 212" />
              <Point value="436, 212" />
              <Point value="436, 265" />
              <Point value="435, 265" />
              <Point value="445, 265" />
            </LinkPoints>
          </Link>
          <Link PartID="31" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="8" PortName="SolvedTrue" PortType="Event" ConnectableId="Automator-8D8E89E060304E6\ConnectableBoolDecision-8D8E8A1547F657B" MemberComponentId="Automator-8D8E89E060304E6\ConnectableBoolDecision-8D8E8A1547F657B" />
            <To PartID="24" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3B77F5274" MemberComponentId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3B77F5274" />
            <LinkPoints>
              <Point value="777, 150" />
              <Point value="787, 150" />
              <Point value="788, 150" />
              <Point value="788, 165" />
              <Point value="795, 165" />
              <Point value="805, 165" />
            </LinkPoints>
          </Link>
          <Link PartID="32" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="InteractionKey" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableEvent-8D8E89FA70BBC95" MemberComponentId="Automator-8D8E89E060304E6\ConnectableEvent-8D8E89FA70BBC95" />
            <To PartID="7" PortName="a" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" MemberComponentId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" />
            <LinkPoints>
              <Point value="212, 213" />
              <Point value="222, 213" />
              <Point value="230, 213" />
              <Point value="230, 81" />
              <Point value="458, 81" />
              <Point value="458, 116" />
              <Point value="459, 116" />
              <Point value="459, 113" />
              <Point value="459, 123" />
            </LinkPoints>
          </Link>
          <Link PartID="33" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="Text" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E89FA70E5332" MemberComponentId="WindowsAdapter-8D8DFE68142AF1E\Label-8D8DFF8576B26AC" />
            <To PartID="7" PortName="b" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" MemberComponentId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" />
            <LinkPoints>
              <Point value="389, 179" />
              <Point value="399, 179" />
              <Point value="409, 179" />
              <Point value="409, 97" />
              <Point value="485, 97" />
              <Point value="485, 113" />
              <Point value="485, 123" />
            </LinkPoints>
          </Link>
          <Link PartID="34" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E89FA70E5332" MemberComponentId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E89FA70E5332" />
            <To PartID="7" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" MemberComponentId="Automator-8D8E89E060304E6\ConnectableMethod-8D8E8A0D960E61A" />
            <LinkPoints>
              <Point value="389, 145" />
              <Point value="399, 145" />
              <Point value="404, 145" />
              <Point value="404, 143" />
              <Point value="433, 143" />
              <Point value="443, 143" />
            </LinkPoints>
          </Link>
          <Link PartID="35" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="24" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3B77F5274" MemberComponentId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3B77F5274" />
            <To PartID="30" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" MemberComponentId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" />
            <LinkPoints>
              <Point value="949, 165" />
              <Point value="959, 165" />
              <Point value="1007, 165" />
              <Point value="1007, 165" />
              <Point value="1055, 165" />
              <Point value="1065, 165" />
            </LinkPoints>
          </Link>
          <Link PartID="36" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="24" PortName="Text" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3B77F5274" MemberComponentId="WindowsAdapter-8D8DFE68142AF1E\Label-8D8DFF8576B26AC" />
            <To PartID="30" PortName="_SmartKey%GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A%Key%Value" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" MemberComponentId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" />
            <LinkPoints>
              <Point value="949, 182" />
              <Point value="959, 182" />
              <Point value="1007, 182" />
              <Point value="1007, 199" />
              <Point value="1055, 199" />
              <Point value="1065, 199" />
            </LinkPoints>
          </Link>
          <Link PartID="37" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="24" PortName="Text" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3B77F5274" MemberComponentId="WindowsAdapter-8D8DFE68142AF1E\Label-8D8DFF8576B26AC" />
            <To PartID="30" PortName="AcctNum" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" MemberComponentId="GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A" />
            <LinkPoints>
              <Point value="949, 182" />
              <Point value="959, 182" />
              <Point value="964, 182" />
              <Point value="964, 182" />
              <Point value="972, 182" />
              <Point value="972, 216" />
              <Point value="1055, 216" />
              <Point value="1065, 216" />
            </LinkPoints>
          </Link>
          <Link PartID="39" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="25" PortName="Text" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3C1C85010" MemberComponentId="WindowsAdapter-8D8DFE68142AF1E\TextBox-8D8DFF86B6D21D8" />
            <To PartID="30" PortName="Adress" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" MemberComponentId="GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A" />
            <LinkPoints>
              <Point value="956, 262" />
              <Point value="966, 262" />
              <Point value="972, 262" />
              <Point value="972, 233" />
              <Point value="1055, 233" />
              <Point value="1065, 233" />
            </LinkPoints>
          </Link>
          <Link PartID="40" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="26" PortName="Text" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3C87D3F93" MemberComponentId="WindowsAdapter-8D8DFE68142AF1E\TextBox-8D8DFF86EE18636" />
            <To PartID="30" PortName="City" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" MemberComponentId="GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A" />
            <LinkPoints>
              <Point value="918, 342" />
              <Point value="928, 342" />
              <Point value="932, 342" />
              <Point value="932, 344" />
              <Point value="1012, 344" />
              <Point value="1012, 250" />
              <Point value="1055, 250" />
              <Point value="1065, 250" />
            </LinkPoints>
          </Link>
          <Link PartID="41" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="27" PortName="Text" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3CCE4D6E8" MemberComponentId="WindowsAdapter-8D8DFE68142AF1E\TextBox-8D8DFF86464F285" />
            <To PartID="30" PortName="Name" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" MemberComponentId="GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A" />
            <LinkPoints>
              <Point value="931, 422" />
              <Point value="941, 422" />
              <Point value="940, 422" />
              <Point value="940, 422" />
              <Point value="1024, 422" />
              <Point value="1024, 267" />
              <Point value="1055, 267" />
              <Point value="1065, 267" />
            </LinkPoints>
          </Link>
          <Link PartID="42" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="28" PortName="Text" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3D06D1D15" MemberComponentId="WindowsAdapter-8D8DFE68142AF1E\TextBox-8D8DFF8729B15EE" />
            <To PartID="30" PortName="State" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" MemberComponentId="GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A" />
            <LinkPoints>
              <Point value="927, 502" />
              <Point value="937, 502" />
              <Point value="1035, 502" />
              <Point value="1035, 284" />
              <Point value="1055, 284" />
              <Point value="1065, 284" />
            </LinkPoints>
          </Link>
          <Link PartID="43" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="29" PortName="Text" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3D3F34DF3" MemberComponentId="WindowsAdapter-8D8DFE68142AF1E\TextBox-8D8E3BB748A756B" />
            <To PartID="30" PortName="ZipCode" PortType="Property" ConnectableId="Automator-8D8E89E060304E6\ConnectableProperties-8D8E8A3F29354DE" MemberComponentId="GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A" />
            <LinkPoints>
              <Point value="913, 582" />
              <Point value="923, 582" />
              <Point value="924, 582" />
              <Point value="924, 582" />
              <Point value="1044, 582" />
              <Point value="1044, 301" />
              <Point value="1055, 301" />
              <Point value="1065, 301" />
            </LinkPoints>
          </Link>
        </Links>
        <Comments />
        <SubGraphs />
      </AutomationDocument>
      <DocumentPosition Value="Binary">
        <Binary>AAEAAAD/////AQAAAAAAAAAMAgAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTeXN0ZW0uRHJhd2luZy5Qb2ludEYCAAAAAXgBeQAACwsCAAAAAAAAAHypE0IL</Binary>
      </DocumentPosition>
      <DocumentScale Value="0.9826307" />
      <ShowDesignCompNames Value="True" />
    </OpenSpan.Automation.Automator>
    <OpenSpan.Automation.ConnectableEvent Name="connectableEvent1" Id="ConnectableEvent-8D8E89FA70BBC95">
      <ComponentName Value="CRMactGetCustInfo" />
      <DisplayName Value="Activity.ActivityStarted" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Interactions.Controls.Activity" />
      <InstanceUniqueId Value="GlobalContainer-8D8E7CA979738F7\Activity-8D8E89AB0E0A47E" />
      <MemberDetails Value=".ActivityStarted Event" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="ActivityStarted" />
            <MemberType Value="Event" />
            <TypeName Value="System.EventHandler`1[[OpenSpan.Interactions.ActivityEventArgs, OpenSpan.Interactions, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e]]" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableEvent>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties1" Id="ConnectableProperties-8D8E89FA70E5332">
      <ComponentName Value="CRMlblAcctNum" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.Label" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\Label-8D8DFF8576B26AC" />
      <MemberDetails Value=".Text Property" />
      <Content Name="KeyInfos">
        <Items>
          <OpenSpan.Automation.KeyInfo>
            <CloneContextId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            <KeyName Value="Active" />
            <KeyType Value="Normal" />
            <SetUpstream Value="False" />
          </OpenSpan.Automation.KeyInfo>
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Text" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Script.Expression.BooleanExpression Name="booleanExpression1" Id="BooleanExpression-8D8E8A0D95B9334">
      <Expression Value="a==b" />
      <Scope Value="Local" Extended="True" />
      <Valid Value="True" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="Evaluate" aliasName="Evaluate" visibility="DefaultOn" source="" blockTypeName="" returnType="System.Boolean">
            <param name="a" aliasName="a" paramType="System.String" isIn="True" isOut="False" position="0" />
            <param name="b" aliasName="b" paramType="System.String" isIn="True" isOut="False" position="1" />
          </OpenSpan.DynamicMembers.DynamicMethodInfo>
        </Items>
      </Content>
      <Content Name="Identifiers">
        <Items>
          <OpenSpan.Script.Expression.ExpressionIdentifier>
            <DataType Value="String" />
            <ID Value="a" />
          </OpenSpan.Script.Expression.ExpressionIdentifier>
          <OpenSpan.Script.Expression.ExpressionIdentifier>
            <DataType Value="String" />
            <ID Value="b" />
          </OpenSpan.Script.Expression.ExpressionIdentifier>
        </Items>
      </Content>
    </OpenSpan.Script.Expression.BooleanExpression>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod1" Id="ConnectableMethod-8D8E8A0D960E61A">
      <ComponentName Value="booleanExpression1" />
      <DisplayName Value="Evaluate" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Script.Expression.BooleanExpression" />
      <InstanceUniqueId Value="Automator-8D8E89E060304E6\BooleanExpression-8D8E8A0D95B9334" />
      <MemberDetails Value=".Evaluate() Method" />
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
            <MemberName Value="Evaluate" />
            <MemberType Value="Method" />
            <TypeName Value="System.Boolean" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Boolean" />
                <Content Name="ParameterPrototype">
                  <Items>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="False" />
                      <ParamName Value="a" />
                      <Position Value="0" />
                      <TypeName Value="System.String" />
                    </OpenSpan.Automation.ParameterPrototype>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="False" />
                      <ParamName Value="b" />
                      <Position Value="1" />
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
    <OpenSpan.Automation.ConnectableBoolDecision Name="connectableBoolDecision1" Id="ConnectableBoolDecision-8D8E8A1547F657B">
      <ComponentName Value="connectableBoolDecision1" />
      <DisplayName Value="connectableBoolDecision1" />
      <ExceptionsHandled Value="False" />
      <Input Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.ConnectableBoolDecision" />
      <InstanceUniqueId Value="Automator-8D8E89E060304E6\ConnectableBoolDecision-8D8E8A1547F657B" />
      <MemberDetails Value="" />
    </OpenSpan.Automation.ConnectableBoolDecision>
    <OpenSpan.Controls.MessageDialog Name="messageDialog1" Id="MessageDialog-8D8E8A171A54D8E">
      <Caption Value="Information" />
      <Scope Value="Local" Extended="True" />
    </OpenSpan.Controls.MessageDialog>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod2" Id="ConnectableMethod-8D8E8A17961268B">
      <ComponentName Value="messageDialog1" />
      <DisplayName Value="Show" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Controls.MessageDialog" />
      <InstanceUniqueId Value="Automator-8D8E89E060304E6\MessageDialog-8D8E8A171A54D8E" />
      <MemberDetails Value=".Show() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="False" type="System.Windows.Forms.DialogResult" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Show" />
            <MemberType Value="Method" />
            <TypeAssemblyName Value="System.Windows.Forms" />
            <TypeName Value="System.Windows.Forms.DialogResult" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Windows.Forms.DialogResult" />
                <Content Name="ParameterPrototype">
                  <Items>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="True" />
                      <DefaultValue Value="Key/Account Number mismatch" />
                      <ParamName Value="message" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties2" Id="ConnectableProperties-8D8E8A3B77F5274">
      <ComponentName Value="CRMlblAcctNum" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.Label" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\Label-8D8DFF8576B26AC" />
      <MemberDetails Value=".Text Property" />
      <Content Name="KeyInfos">
        <Items>
          <OpenSpan.Automation.KeyInfo>
            <CloneContextId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            <KeyName Value="Active" />
            <KeyType Value="Normal" />
            <SetUpstream Value="True" />
          </OpenSpan.Automation.KeyInfo>
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Text" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties3" Id="ConnectableProperties-8D8E8A3C1C85010">
      <ComponentName Value="CRMtxtStreetAdd" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.TextBox" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\TextBox-8D8DFF86B6D21D8" />
      <MemberDetails Value=".Text Property" />
      <Content Name="KeyInfos">
        <Items>
          <OpenSpan.Automation.KeyInfo>
            <CloneContextId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            <KeyName Value="Active" />
            <KeyType Value="Normal" />
            <SetUpstream Value="True" />
          </OpenSpan.Automation.KeyInfo>
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Text" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties4" Id="ConnectableProperties-8D8E8A3C87D3F93">
      <ComponentName Value="CRMtxtCity" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.TextBox" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\TextBox-8D8DFF86EE18636" />
      <MemberDetails Value=".Text Property" />
      <Content Name="KeyInfos">
        <Items>
          <OpenSpan.Automation.KeyInfo>
            <CloneContextId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            <KeyName Value="Active" />
            <KeyType Value="Normal" />
            <SetUpstream Value="True" />
          </OpenSpan.Automation.KeyInfo>
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Text" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties5" Id="ConnectableProperties-8D8E8A3CCE4D6E8">
      <ComponentName Value="CRMtxtName" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.TextBox" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\TextBox-8D8DFF86464F285" />
      <MemberDetails Value=".Text Property" />
      <Content Name="KeyInfos">
        <Items>
          <OpenSpan.Automation.KeyInfo>
            <CloneContextId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            <KeyName Value="Active" />
            <KeyType Value="Normal" />
            <SetUpstream Value="True" />
          </OpenSpan.Automation.KeyInfo>
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Text" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties6" Id="ConnectableProperties-8D8E8A3D06D1D15">
      <ComponentName Value="CRMtxtState" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.TextBox" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\TextBox-8D8DFF8729B15EE" />
      <MemberDetails Value=".Text Property" />
      <Content Name="KeyInfos">
        <Items>
          <OpenSpan.Automation.KeyInfo>
            <CloneContextId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            <KeyName Value="Active" />
            <KeyType Value="Normal" />
            <SetUpstream Value="True" />
          </OpenSpan.Automation.KeyInfo>
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Text" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties7" Id="ConnectableProperties-8D8E8A3D3F34DF3">
      <ComponentName Value="CRMtxtZip" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.TextBox" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\TextBox-8D8E3BB748A756B" />
      <MemberDetails Value=".Text Property" />
      <Content Name="KeyInfos">
        <Items>
          <OpenSpan.Automation.KeyInfo>
            <CloneContextId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF364BBCE88" />
            <KeyName Value="Active" />
            <KeyType Value="Normal" />
            <SetUpstream Value="True" />
          </OpenSpan.Automation.KeyInfo>
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Text" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties8" Id="ConnectableProperties-8D8E8A3F29354DE">
      <ComponentName Value="IntMgr" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Interactions.Controls.InteractionManager" />
      <InstanceUniqueId Value="GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A" />
      <MemberDetails Value=" - Properties(AcctNum, Adress, City, Name, State, ZipCode)" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="_SmartKey%GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A%Key%Value" canRead="False" canWrite="True" type="System.String" aliasName="_SmartKey%GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A%Key%Value" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
        </Items>
      </Content>
      <Content Name="KeyInfos">
        <Items>
          <OpenSpan.Automation.KeyInfo>
            <CloneContextId Value="GlobalContainer-8D8E7CA979738F7\InteractionManager-8D8E7CD6FC6932A" />
            <KeyName Value="Key" />
            <KeyObjectTypeName Value="OpenSpan.Interactions.Controls.InteractionKey" />
            <KeyType Value="Smart" />
            <SetUpstream Value="False" />
          </OpenSpan.Automation.KeyInfo>
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="AcctNum" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Adress" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="City" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Name" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="State" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="ZipCode" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
  </Component>
</OpenSpanDesignDocument>