﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GatoRPCEncode.ECCI {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ECCI_B77519_B72097_Gato", ConfigurationName="ECCI.ECCI_B77519_B72097_GatoPort")]
    public interface ECCI_B77519_B72097_GatoPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#jugar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void jugar(int casilla);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#jugar", ReplyAction="*")]
        System.Threading.Tasks.Task jugarAsync(int casilla);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#juegaMaquina", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        int juegaMaquina();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#juegaMaquina", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<int> juegaMaquinaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#checkWin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool checkWin(int casilla, string simbolo);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#checkWin", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> checkWinAsync(int casilla, string simbolo);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#checkCasillas", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void checkCasillas(int casilla);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#checkCasillas", ReplyAction="*")]
        System.Threading.Tasks.Task checkCasillasAsync(int casilla);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#getCasillasRestantes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        int getCasillasRestantes();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#getCasillasRestantes", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<int> getCasillasRestantesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#setJugador", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void setJugador(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#setJugador", ReplyAction="*")]
        System.Threading.Tasks.Task setJugadorAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#getBoard", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getBoard();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_B77519_B72097_Gato#Gato#getBoard", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getBoardAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ECCI_B77519_B72097_GatoPortChannel : GatoRPCEncode.ECCI.ECCI_B77519_B72097_GatoPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ECCI_B77519_B72097_GatoPortClient : System.ServiceModel.ClientBase<GatoRPCEncode.ECCI.ECCI_B77519_B72097_GatoPort>, GatoRPCEncode.ECCI.ECCI_B77519_B72097_GatoPort {
        
        public ECCI_B77519_B72097_GatoPortClient() {
        }
        
        public ECCI_B77519_B72097_GatoPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ECCI_B77519_B72097_GatoPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_B77519_B72097_GatoPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_B77519_B72097_GatoPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void jugar(int casilla) {
            base.Channel.jugar(casilla);
        }
        
        public System.Threading.Tasks.Task jugarAsync(int casilla) {
            return base.Channel.jugarAsync(casilla);
        }
        
        public int juegaMaquina() {
            return base.Channel.juegaMaquina();
        }
        
        public System.Threading.Tasks.Task<int> juegaMaquinaAsync() {
            return base.Channel.juegaMaquinaAsync();
        }
        
        public bool checkWin(int casilla, string simbolo) {
            return base.Channel.checkWin(casilla, simbolo);
        }
        
        public System.Threading.Tasks.Task<bool> checkWinAsync(int casilla, string simbolo) {
            return base.Channel.checkWinAsync(casilla, simbolo);
        }
        
        public void checkCasillas(int casilla) {
            base.Channel.checkCasillas(casilla);
        }
        
        public System.Threading.Tasks.Task checkCasillasAsync(int casilla) {
            return base.Channel.checkCasillasAsync(casilla);
        }
        
        public int getCasillasRestantes() {
            return base.Channel.getCasillasRestantes();
        }
        
        public System.Threading.Tasks.Task<int> getCasillasRestantesAsync() {
            return base.Channel.getCasillasRestantesAsync();
        }
        
        public void setJugador(string nombre) {
            base.Channel.setJugador(nombre);
        }
        
        public System.Threading.Tasks.Task setJugadorAsync(string nombre) {
            return base.Channel.setJugadorAsync(nombre);
        }
        
        public string getBoard() {
            return base.Channel.getBoard();
        }
        
        public System.Threading.Tasks.Task<string> getBoardAsync() {
            return base.Channel.getBoardAsync();
        }
    }
}
