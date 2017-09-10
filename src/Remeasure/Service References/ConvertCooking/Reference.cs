﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConvertCooking
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cookings", Namespace="http://www.webserviceX.NET/")]
    public enum Cookings : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        drop = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        dash = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        pinch = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        milliliterPerCC = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        deciliter = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        coffeeSpoon = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fluidDram = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        teaspoonUS = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        teaspoonUK = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        tablespoonUS = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        tablespoonUK = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fluidOunceUS = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fluidOunceUK = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        cupUS = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        cubicInch = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        gillUS = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        gillUK = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        pintUS = 17,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        pintUK = 18,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        quartUS = 19,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        liter = 20,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        gallonUS = 21,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        gallonUK = 22,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TwoPointFiveCan = 23,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TenCan = 24,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.webserviceX.NET/", ConfigurationName="ConvertCooking.CookingUnitSoap")]
    public interface CookingUnitSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.webserviceX.NET/ChangeCookingUnit", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ChangeCookingUnitAsync(double CookingValue, ConvertCooking.Cookings fromCookingUnit, ConvertCooking.Cookings toCookingUnit);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    public interface CookingUnitSoapChannel : ConvertCooking.CookingUnitSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    public partial class CookingUnitSoapClient : System.ServiceModel.ClientBase<ConvertCooking.CookingUnitSoap>, ConvertCooking.CookingUnitSoap
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CookingUnitSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(CookingUnitSoapClient.GetBindingForEndpoint(endpointConfiguration), CookingUnitSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CookingUnitSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CookingUnitSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CookingUnitSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CookingUnitSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CookingUnitSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<double> ChangeCookingUnitAsync(double CookingValue, ConvertCooking.Cookings fromCookingUnit, ConvertCooking.Cookings toCookingUnit)
        {
            return base.Channel.ChangeCookingUnitAsync(CookingValue, fromCookingUnit, toCookingUnit);
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
            if ((endpointConfiguration == EndpointConfiguration.CookingUnitSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.CookingUnitSoap12))
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
            if ((endpointConfiguration == EndpointConfiguration.CookingUnitSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://www.webservicex.net/ConvertCooking.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.CookingUnitSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://www.webservicex.net/ConvertCooking.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            CookingUnitSoap,
            
            CookingUnitSoap12,
        }
    }
}