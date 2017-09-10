﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConvertTemperature
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TemperatureUnit", Namespace="http://www.webserviceX.NET/")]
    public enum TemperatureUnit : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        degreeCelsius = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        degreeFahrenheit = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        degreeRankine = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        degreeReaumur = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        kelvin = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.webserviceX.NET/", ConfigurationName="ConvertTemperature.ConvertTemperatureSoap")]
    public interface ConvertTemperatureSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.webserviceX.NET/ConvertTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertTempAsync(double Temperature, ConvertTemperature.TemperatureUnit FromUnit, ConvertTemperature.TemperatureUnit ToUnit);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    public interface ConvertTemperatureSoapChannel : ConvertTemperature.ConvertTemperatureSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    public partial class ConvertTemperatureSoapClient : System.ServiceModel.ClientBase<ConvertTemperature.ConvertTemperatureSoap>, ConvertTemperature.ConvertTemperatureSoap
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ConvertTemperatureSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ConvertTemperatureSoapClient.GetBindingForEndpoint(endpointConfiguration), ConvertTemperatureSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ConvertTemperatureSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ConvertTemperatureSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ConvertTemperatureSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ConvertTemperatureSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ConvertTemperatureSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<double> ConvertTempAsync(double Temperature, ConvertTemperature.TemperatureUnit FromUnit, ConvertTemperature.TemperatureUnit ToUnit)
        {
            return base.Channel.ConvertTempAsync(Temperature, FromUnit, ToUnit);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ConvertTemperatureSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ConvertTemperatureSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ConvertTemperatureSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://www.webservicex.net/ConvertTemperature.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ConvertTemperatureSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://www.webservicex.net/ConvertTemperature.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ConvertTemperatureSoap,
            
            ConvertTemperatureSoap12,
        }
    }
}