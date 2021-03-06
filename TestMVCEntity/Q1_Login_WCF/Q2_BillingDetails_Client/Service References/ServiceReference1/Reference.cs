﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Q2_BillingDetails_Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Interface1")]
    public interface Interface1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Interface1/Accept_BillDetails", ReplyAction="http://tempuri.org/Interface1/Accept_BillDetailsResponse")]
        void Accept_BillDetails(int billID, string bill_Date, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Interface1/Accept_BillDetails", ReplyAction="http://tempuri.org/Interface1/Accept_BillDetailsResponse")]
        System.Threading.Tasks.Task Accept_BillDetailsAsync(int billID, string bill_Date, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Interface1/Accept_CustomerDetails", ReplyAction="http://tempuri.org/Interface1/Accept_CustomerDetailsResponse")]
        void Accept_CustomerDetails(int customerID, string customer_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Interface1/Accept_CustomerDetails", ReplyAction="http://tempuri.org/Interface1/Accept_CustomerDetailsResponse")]
        System.Threading.Tasks.Task Accept_CustomerDetailsAsync(int customerID, string customer_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Interface1/Accept_ProductDetails", ReplyAction="http://tempuri.org/Interface1/Accept_ProductDetailsResponse")]
        void Accept_ProductDetails(int productID, string productName, int qtyInStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Interface1/Accept_ProductDetails", ReplyAction="http://tempuri.org/Interface1/Accept_ProductDetailsResponse")]
        System.Threading.Tasks.Task Accept_ProductDetailsAsync(int productID, string productName, int qtyInStock);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Interface1Channel : Q2_BillingDetails_Client.ServiceReference1.Interface1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Interface1Client : System.ServiceModel.ClientBase<Q2_BillingDetails_Client.ServiceReference1.Interface1>, Q2_BillingDetails_Client.ServiceReference1.Interface1 {
        
        public Interface1Client() {
        }
        
        public Interface1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Interface1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Interface1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Interface1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Accept_BillDetails(int billID, string bill_Date, int amount) {
            base.Channel.Accept_BillDetails(billID, bill_Date, amount);
        }
        
        public System.Threading.Tasks.Task Accept_BillDetailsAsync(int billID, string bill_Date, int amount) {
            return base.Channel.Accept_BillDetailsAsync(billID, bill_Date, amount);
        }
        
        public void Accept_CustomerDetails(int customerID, string customer_Name) {
            base.Channel.Accept_CustomerDetails(customerID, customer_Name);
        }
        
        public System.Threading.Tasks.Task Accept_CustomerDetailsAsync(int customerID, string customer_Name) {
            return base.Channel.Accept_CustomerDetailsAsync(customerID, customer_Name);
        }
        
        public void Accept_ProductDetails(int productID, string productName, int qtyInStock) {
            base.Channel.Accept_ProductDetails(productID, productName, qtyInStock);
        }
        
        public System.Threading.Tasks.Task Accept_ProductDetailsAsync(int productID, string productName, int qtyInStock) {
            return base.Channel.Accept_ProductDetailsAsync(productID, productName, qtyInStock);
        }
    }
}
