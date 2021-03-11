<OpenSpanDesignDocument Version="19.1.0.25" Serializer="2.0" Culture="pt-BR">
  <ComponentInfo>
    <Type Value="OpenSpan.Automation.Automator" />
    <Assembly Value="OpenSpan.Automation" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Web.WebBase, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Automation, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences />
    <BuildReferences />
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Automation.Automator Name="ACME_P_SignIn" Id="Automator-8D8E3A60CCCDFB3">
      <AutomationDocument>
        <Name Value="" />
        <Size Value="5000, 5000" />
        <Objects>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\EntryPoint-8D8E3A6459FAE48" />
            <Left Value="20" />
            <Top Value="220" />
            <PartID Value="1" />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\LabelHost-8D8E3A648E8573A" />
            <Left Value="340" />
            <Top Value="60" />
            <PartID Value="2" />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\LabelHost-8D8E3A65AD9AC93" />
            <Left Value="20" />
            <Top Value="60" />
            <PartID Value="3" />
          </ConnectionBlock>
          <ConnectionBlock type="OpenSpan.Automation.Design.ConnectionBlocks.MultiExitPointBlock">
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\ExitPoint-8D8E3A6680813BA" />
            <Left Value="500" />
            <Top Value="60" />
            <PartID Value="4" />
            <Title Value="Failed" />
            <EventName Value="" />
          </ConnectionBlock>
          <ConnectionBlock type="OpenSpan.Automation.Design.ConnectionBlocks.MultiExitPointBlock">
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\ExitPoint-8D8E3A67DB65305" />
            <Left Value="180" />
            <Top Value="60" />
            <PartID Value="5" />
            <Title Value="Sucess" />
            <EventName Value="" />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AA3471BD1D" />
            <PartID Value="7" />
            <Left Value="560" />
            <Top Value="220" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value=" ACMEtxtPassword" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AE806F983C" />
            <PartID Value="8" />
            <Left Value="360" />
            <Top Value="220" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEtxtUserName" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AEA2A75D53" />
            <PartID Value="9" />
            <Left Value="160" />
            <Top Value="220" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value=" ACMEtxtPassword" />
            <Fittings>
              <IsCreated Collapsed="False" ActualText="IsCreated" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="WaitForCreate" />
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E3B1127E0B14" />
            <PartID Value="12" />
            <Left Value="620" />
            <Top Value="320" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEwpHome" />
            <Fittings>
              <Result Collapsed="False" ActualText="Result" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\JumpHost-8D8E3B135DDEBE4" />
            <PartID Value="13" />
            <Left Value="200" />
            <Top Value="360" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\JumpHost-8D8E3B1389818B0" />
            <PartID Value="14" />
            <Left Value="960" />
            <Top Value="300" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\JumpHost-8D8E3B17DF8BD5C" />
            <PartID Value="15" />
            <Left Value="840" />
            <Top Value="380" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="PerformClick" />
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E3D89A9209C3" />
            <PartID Value="16" />
            <Left Value="780" />
            <Top Value="220" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEbtnSignln" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="RaiseEvent" />
            <ConnectableUniqueId Value="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E471B352FDE2" />
            <PartID Value="29" />
            <Left Value="680" />
            <Top Value="140" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value=" ACMEtxtPassword" />
            <OverriddenIds />
          </ConnectionBlock>
        </Objects>
        <Links>
          <Link PartID="18" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3A60CCCDFB3\LabelHost-8D8E3A648E8573A" MemberComponentId="Automator-8D8E3A60CCCDFB3\LabelHost-8D8E3A648E8573A" />
            <To PartID="4" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\ExitPoint-8D8E3A6680813BA" MemberComponentId="Automator-8D8E3A60CCCDFB3\ExitPoint-8D8E3A6680813BA" />
            <LinkPoints>
              <Point value="436, 78" />
              <Point value="446, 78" />
              <Point value="469, 78" />
              <Point value="469, 78" />
              <Point value="492, 78" />
              <Point value="502, 78" />
            </LinkPoints>
          </Link>
          <Link PartID="19" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="_param1" PortType="Property" ConnectableId="Automator-8D8E3A60CCCDFB3\LabelHost-8D8E3A648E8573A" MemberComponentId="EMPTY" />
            <To PartID="4" PortName="param1" PortType="Property" ConnectableId="Automator-8D8E3A60CCCDFB3\ExitPoint-8D8E3A6680813BA" MemberComponentId="EMPTY" />
            <LinkPoints>
              <Point value="436, 105" />
              <Point value="446, 105" />
              <Point value="469, 105" />
              <Point value="469, 105" />
              <Point value="492, 105" />
              <Point value="502, 105" />
            </LinkPoints>
          </Link>
          <Link PartID="20" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="3" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3A60CCCDFB3\LabelHost-8D8E3A65AD9AC93" MemberComponentId="Automator-8D8E3A60CCCDFB3\LabelHost-8D8E3A65AD9AC93" />
            <To PartID="5" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\ExitPoint-8D8E3A67DB65305" MemberComponentId="Automator-8D8E3A60CCCDFB3\ExitPoint-8D8E3A67DB65305" />
            <LinkPoints>
              <Point value="126, 78" />
              <Point value="136, 78" />
              <Point value="154, 78" />
              <Point value="154, 78" />
              <Point value="172, 78" />
              <Point value="182, 78" />
            </LinkPoints>
          </Link>
          <Link PartID="21" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3A60CCCDFB3\EntryPoint-8D8E3A6459FAE48" MemberComponentId="Automator-8D8E3A60CCCDFB3\EntryPoint-8D8E3A6459FAE48" />
            <To PartID="9" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AEA2A75D53" MemberComponentId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AEA2A75D53" />
            <LinkPoints>
              <Point value="131, 238" />
              <Point value="141, 238" />
              <Point value="148, 238" />
              <Point value="148, 249" />
              <Point value="155, 249" />
              <Point value="165, 249" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="22" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="9" ParentMemberName="IsCreated" DecisionValue="True" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AEA2A75D53" />
            <To PartID="8" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AE806F983C" MemberComponentId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AE806F983C" />
            <LinkPoints>
              <Point value="327, 280" />
              <Point value="337, 280" />
              <Point value="340, 280" />
              <Point value="340, 249" />
              <Point value="355, 249" />
              <Point value="365, 249" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="23" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="8" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AE806F983C" MemberComponentId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AE806F983C" />
            <To PartID="7" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AA3471BD1D" MemberComponentId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AA3471BD1D" />
            <LinkPoints>
              <Point value="528, 249" />
              <Point value="538, 249" />
              <Point value="547, 249" />
              <Point value="547, 249" />
              <Point value="555, 249" />
              <Point value="565, 249" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="25" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="9" ParentMemberName="IsCreated" DecisionValue="False" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AEA2A75D53" />
            <To PartID="13" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\JumpHost-8D8E3B135DDEBE4" MemberComponentId="Automator-8D8E3A60CCCDFB3\JumpHost-8D8E3B135DDEBE4" />
            <LinkPoints>
              <Point value="327, 295" />
              <Point value="337, 295" />
              <Point value="340, 295" />
              <Point value="340, 316" />
              <Point value="196, 316" />
              <Point value="196, 377" />
              <Point value="193, 377" />
              <Point value="203, 377" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="26" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="16" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E3D89A9209C3" MemberComponentId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E3D89A9209C3" />
            <To PartID="12" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E3B1127E0B14" MemberComponentId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E3B1127E0B14" />
            <LinkPoints>
              <Point value="926, 249" />
              <Point value="936, 249" />
              <Point value="940, 249" />
              <Point value="940, 284" />
              <Point value="612, 284" />
              <Point value="612, 349" />
              <Point value="615, 349" />
              <Point value="625, 349" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="27" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="12" ParentMemberName="Result" DecisionValue="True" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E3B1127E0B14" />
            <To PartID="14" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\JumpHost-8D8E3B1389818B0" MemberComponentId="Automator-8D8E3A60CCCDFB3\JumpHost-8D8E3B1389818B0" />
            <LinkPoints>
              <Point value="762, 380" />
              <Point value="772, 380" />
              <Point value="772, 380" />
              <Point value="772, 317" />
              <Point value="953, 317" />
              <Point value="963, 317" />
            </LinkPoints>
          </DecisionEventLink>
          <DecisionEventLink PartID="28" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="12" ParentMemberName="Result" DecisionValue="False" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E3B1127E0B14" />
            <To PartID="15" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\JumpHost-8D8E3B17DF8BD5C" MemberComponentId="Automator-8D8E3A60CCCDFB3\JumpHost-8D8E3B17DF8BD5C" />
            <LinkPoints>
              <Point value="762, 395" />
              <Point value="772, 395" />
              <Point value="772, 397" />
              <Point value="772, 397" />
              <Point value="833, 397" />
              <Point value="843, 397" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="30" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="7" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AA3471BD1D" MemberComponentId="Automator-8D8E3A60CCCDFB3\ConnectableProperties-8D8E3AA3471BD1D" />
            <To PartID="29" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E471B352FDE2" MemberComponentId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E471B352FDE2" />
            <LinkPoints>
              <Point value="727, 249" />
              <Point value="737, 249" />
              <Point value="737, 209" />
              <Point value="675, 209" />
              <Point value="675, 169" />
              <Point value="685, 169" />
            </LinkPoints>
          </Link>
          <Link PartID="31" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="29" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E471B352FDE2" MemberComponentId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E471B352FDE2" />
            <To PartID="16" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E3D89A9209C3" MemberComponentId="Automator-8D8E3A60CCCDFB3\ConnectableMethod-8D8E3D89A9209C3" />
            <LinkPoints>
              <Point value="847, 169" />
              <Point value="857, 169" />
              <Point value="857, 209" />
              <Point value="775, 209" />
              <Point value="775, 249" />
              <Point value="785, 249" />
            </LinkPoints>
          </Link>
        </Links>
        <Comments />
        <SubGraphs />
      </AutomationDocument>
      <DocumentPosition Value="Binary">
        <Binary>AAEAAAD/////AQAAAAAAAAAMAgAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTeXN0ZW0uRHJhd2luZy5Qb2ludEYCAAAAAXgBeQAACwsCAAAAAAAAAAAA4EIL</Binary>
      </DocumentPosition>
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="_EntryPointExecute" aliasName="Execute" visibility="DefaultOn" source="" blockTypeName="OpenSpan.Automation.Design.ConnectionBlocks.EntryPointExecuteBlock" returnType="System.Void">
            <param name="param1" aliasName="msg" paramType="System.String" isIn="False" isOut="True" position="0" />
          </OpenSpan.DynamicMembers.DynamicMethodInfo>
        </Items>
      </Content>
    </OpenSpan.Automation.Automator>
    <OpenSpan.Automation.EntryPoint Name="entryPoint1" Id="EntryPoint-8D8E3A6459FAE48">
      <AliasName Value="Execute" />
      <ComponentName Value="Execute" />
      <DisplayName Value="Execute" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D8E3A60CCCDFB3\EntryPoint-8D8E3A6459FAE48" />
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
    <OpenSpan.Automation.LabelHost Name="labelHost1" Id="LabelHost-8D8E3A648E8573A">
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
    <OpenSpan.Automation.LabelHost Name="labelHost2" Id="LabelHost-8D8E3A65AD9AC93">
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
    <OpenSpan.Automation.ExitPoint Name="exitPoint1" Id="ExitPoint-8D8E3A6680813BA">
      <ComponentName Value="Execute" />
      <DisplayName Value="Failed" />
      <EntryPoint Value="ComponentReference" Name="entryPoint1" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D8E3A60CCCDFB3\EntryPoint-8D8E3A6459FAE48" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.Void" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="param1" canRead="True" canWrite="True" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.ExitPoint>
    <OpenSpan.Automation.ExitPoint Name="exitPoint2" Id="ExitPoint-8D8E3A67DB65305">
      <ComponentName Value="Execute" />
      <DisplayName Value="Sucess" />
      <EntryPoint Value="ComponentReference" Name="entryPoint1" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D8E3A60CCCDFB3\EntryPoint-8D8E3A6459FAE48" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="param1" canRead="True" canWrite="True" type="System.String" aliasName="param1" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.Void" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.ExitPoint>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties2" Id="ConnectableProperties-8D8E3AA3471BD1D">
      <ComponentName Value=" ACMEtxtPassword" />
      <DefaultValues Value="Text=1234" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.WebBase.Controls.TextBox" />
      <InstanceUniqueId Value="UniversalWebAdapter-8D8DE50B28552EF\TextBox-8D8E248B7E2F760" />
      <MemberDetails Value=".Text Property" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties3" Id="ConnectableProperties-8D8E3AE806F983C">
      <ComponentName Value="ACMEtxtUserName" />
      <DefaultValues Value="Text=1234" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.WebBase.Controls.TextBox" />
      <InstanceUniqueId Value="UniversalWebAdapter-8D8DE50B28552EF\TextBox-8D8E248A5BC358E" />
      <MemberDetails Value=".Text Property" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties4" Id="ConnectableProperties-8D8E3AEA2A75D53">
      <ComponentName Value=" ACMEtxtPassword" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.WebBase.Controls.TextBox" />
      <InstanceUniqueId Value="UniversalWebAdapter-8D8DE50B28552EF\TextBox-8D8E248B7E2F760" />
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
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod1" Id="ConnectableMethod-8D8E3B1127E0B14">
      <ComponentName Value="ACMEwpHome" />
      <DisplayName Value="WaitForCreate" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.WebBase.Controls.WebPage" />
      <InstanceUniqueId Value="UniversalWebAdapter-8D8DE50B28552EF\WebPage-8D8E2499572E967" />
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
    <OpenSpan.Automation.JumpHost Name="jumpHost1" Id="JumpHost-8D8E3B135DDEBE4">
      <ComponentName Value="labelHost1" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D8E3A60CCCDFB3\LabelHost-8D8E3A648E8573A" />
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
                      <DefaultValue Value="The Login form is not available." />
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
    <OpenSpan.Automation.JumpHost Name="jumpHost2" Id="JumpHost-8D8E3B1389818B0">
      <ComponentName Value="labelHost2" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D8E3A60CCCDFB3\LabelHost-8D8E3A65AD9AC93" />
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
    <OpenSpan.Automation.JumpHost Name="jumpHost3" Id="JumpHost-8D8E3B17DF8BD5C">
      <ComponentName Value="labelHost1" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D8E3A60CCCDFB3\LabelHost-8D8E3A648E8573A" />
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
                      <DefaultValue Value="ACME Home is not available. " />
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
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod2" Id="ConnectableMethod-8D8E3D89A9209C3">
      <ComponentName Value="ACMEbtnSignln" />
      <DisplayName Value="PerformClick" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.WebBase.Controls.Button" />
      <InstanceUniqueId Value="UniversalWebAdapter-8D8DE50B28552EF\Button-8D8E248BC54D22E" />
      <MemberDetails Value=".PerformClick() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="PerformClick" />
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
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod3" Id="ConnectableMethod-8D8E471B352FDE2">
      <ComponentName Value=" ACMEtxtPassword" />
      <DisplayName Value="RaiseEvent" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.WebBase.Controls.TextBox" />
      <InstanceUniqueId Value="UniversalWebAdapter-8D8DE50B28552EF\TextBox-8D8E248B7E2F760" />
      <MemberDetails Value=".RaiseEvent() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="RaiseEvent" />
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
                      <DefaultValue Value="keyup" />
                      <ParamName Value="evt" />
                      <Position Value="0" />
                      <TypeAssemblyName Value="OpenSpan.Adapters.Web.WebBase" />
                      <TypeName Value="OpenSpan.Adapters.Web.WebBase.HtmlEvent" />
                    </OpenSpan.Automation.ParameterPrototype>
                  </Items>
                </Content>
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableMethod>
  </Component>
</OpenSpanDesignDocument>