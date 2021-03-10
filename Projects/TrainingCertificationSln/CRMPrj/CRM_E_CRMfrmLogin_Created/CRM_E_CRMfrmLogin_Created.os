<OpenSpanDesignDocument Version="19.1.0.25" Serializer="2.0" Culture="pt-BR">
  <ComponentInfo>
    <Type Value="OpenSpan.Automation.Automator" />
    <Assembly Value="OpenSpan.Automation" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Automation, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Controls, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences />
    <BuildReferences />
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Automation.Automator Name="CRM_E_CRMfrmLogin_Created" Id="Automator-8D8E30F1807D26C">
      <AutomationDocument>
        <Name Value="" />
        <Size Value="5000, 5000" />
        <Objects>
          <ConnectionBlock>
            <DisplayName Value="ControlBase.Created" />
            <ConnectableUniqueId Value="Automator-8D8E30F1807D26C\ConnectableEvent-8D8E310FA2B3435" />
            <PartID Value="1" />
            <Left Value="40" />
            <Top Value="120" />
            <Collapsed Value="True" />
            <WillExecute Value="True" />
            <InstanceName Value="frmLogin" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="WaitForCreate" />
            <ConnectableUniqueId Value="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E311FBC3F15F" />
            <PartID Value="3" />
            <Left Value="380" />
            <Top Value="120" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="CRMbtnUser1" />
            <Fittings>
              <Result Collapsed="False" ActualText="Result" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="PerformClick" />
            <ConnectableUniqueId Value="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E312358752BD" />
            <PartID Value="4" />
            <Left Value="560" />
            <Top Value="120" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="CRMbtnUser1" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="PerformClick" />
            <ConnectableUniqueId Value="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E31199B54194" />
            <PartID Value="2" />
            <Left Value="220" />
            <Top Value="120" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="btnLogin" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Show" />
            <ConnectableUniqueId Value="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E31ABC10C37E" />
            <PartID Value="8" />
            <Left Value="460" />
            <Top Value="240" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="messageDialog1" />
            <Fittings>
              <Result Collapsed="False" ActualText="Result" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
        </Objects>
        <Links>
          <DecisionEventLink PartID="7" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="3" ParentMemberName="Result" DecisionValue="True" ConnectableId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E311FBC3F15F" />
            <To PartID="4" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E312358752BD" MemberComponentId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E312358752BD" />
            <LinkPoints>
              <Point value="515, 180" />
              <Point value="525, 180" />
              <Point value="524, 180" />
              <Point value="524, 180" />
              <Point value="532, 180" />
              <Point value="532, 149" />
              <Point value="555, 149" />
              <Point value="565, 149" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="5" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="Raised" PortType="Event" ConnectableId="Automator-8D8E30F1807D26C\ConnectableEvent-8D8E310FA2B3435" MemberComponentId="Automator-8D8E30F1807D26C\ConnectableEvent-8D8E310FA2B3435" />
            <To PartID="2" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E31199B54194" MemberComponentId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E31199B54194" />
            <LinkPoints>
              <Point value="142, 149" />
              <Point value="152, 149" />
              <Point value="184, 149" />
              <Point value="184, 149" />
              <Point value="215, 149" />
              <Point value="225, 149" />
            </LinkPoints>
          </Link>
          <Link PartID="6" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="Complete" PortType="Event" ConnectableId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E31199B54194" MemberComponentId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E31199B54194" />
            <To PartID="3" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E311FBC3F15F" MemberComponentId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E311FBC3F15F" />
            <LinkPoints>
              <Point value="344, 149" />
              <Point value="354, 149" />
              <Point value="365, 149" />
              <Point value="365, 149" />
              <Point value="375, 149" />
              <Point value="385, 149" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="9" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="3" ParentMemberName="Result" DecisionValue="False" ConnectableId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E311FBC3F15F" />
            <To PartID="8" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E31ABC10C37E" MemberComponentId="Automator-8D8E30F1807D26C\ConnectableMethod-8D8E31ABC10C37E" />
            <LinkPoints>
              <Point value="515, 195" />
              <Point value="525, 195" />
              <Point value="525, 232" />
              <Point value="455, 232" />
              <Point value="455, 269" />
              <Point value="465, 269" />
            </LinkPoints>
          </DecisionEventLink>
        </Links>
        <Comments />
        <SubGraphs />
      </AutomationDocument>
      <DocumentPosition Value="Binary">
        <Binary>AAEAAAD/////AQAAAAAAAAAMAgAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTeXN0ZW0uRHJhd2luZy5Qb2ludEYCAAAAAXgBeQAACwsCAAAAAAAAAAAAoEIL</Binary>
      </DocumentPosition>
    </OpenSpan.Automation.Automator>
    <OpenSpan.Automation.ConnectableEvent Name="connectableEvent1" Id="ConnectableEvent-8D8E310FA2B3435">
      <ComponentName Value="frmLogin" />
      <DisplayName Value="ControlBase.Created" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.Form" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\Form-8D8DFF16A0ECEEE" />
      <MemberDetails Value=".Created Event" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Created" />
            <MemberType Value="Event" />
            <TypeName Value="System.EventHandler" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableEvent>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod2" Id="ConnectableMethod-8D8E311FBC3F15F">
      <ComponentName Value="CRMbtnUser1" />
      <DisplayName Value="WaitForCreate" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.Button" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\Button-8D8DFF36D5B3441" />
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
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod3" Id="ConnectableMethod-8D8E312358752BD">
      <ComponentName Value="CRMbtnUser1" />
      <DisplayName Value="PerformClick" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.Button" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\Button-8D8DFF36D5B3441" />
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
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod1" Id="ConnectableMethod-8D8E31199B54194">
      <ComponentName Value="btnLogin" />
      <DisplayName Value="PerformClick" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Controls.Button" />
      <InstanceUniqueId Value="WindowsAdapter-8D8DFE68142AF1E\Button-8D8DFF16A0C389F" />
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
    <OpenSpan.Controls.MessageDialog Name="messageDialog1" Id="MessageDialog-8D8E31AB9AC907D">
      <Caption Value="Information" />
      <Message Value="The user 1 button is not avaliable" />
      <Scope Value="Local" Extended="True" />
    </OpenSpan.Controls.MessageDialog>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod4" Id="ConnectableMethod-8D8E31ABC10C37E">
      <ComponentName Value="messageDialog1" />
      <DisplayName Value="Show" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Controls.MessageDialog" />
      <InstanceUniqueId Value="Automator-8D8E30F1807D26C\MessageDialog-8D8E31AB9AC907D" />
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
                      <DefaultValue Value="The user 1 button is not avaliable.&#xD;&#xA;" />
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
  </Component>
</OpenSpanDesignDocument>