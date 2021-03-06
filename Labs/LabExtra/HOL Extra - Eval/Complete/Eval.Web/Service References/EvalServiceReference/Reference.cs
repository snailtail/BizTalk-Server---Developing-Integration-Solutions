﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eval.Web.EvalServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EvalServiceReference.Eval_Orchestrations_ProcessEvals_EvalService")]
    public interface Eval_Orchestrations_ProcessEvals_EvalService {
        
        // CODEGEN: Generating message contract since the operation SubmitEval is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="SubmitEval", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Eval.Web.EvalServiceReference.SubmitEvalResponse SubmitEval(Eval.Web.EvalServiceReference.SubmitEvalRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Eval.Schemas.Evaluation")]
    public partial class Evaluation : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string trainingCourseField;
        
        private string studentField;
        
        private string ratingField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string TrainingCourse {
            get {
                return this.trainingCourseField;
            }
            set {
                this.trainingCourseField = value;
                this.RaisePropertyChanged("TrainingCourse");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Student {
            get {
                return this.studentField;
            }
            set {
                this.studentField = value;
                this.RaisePropertyChanged("Student");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Rating {
            get {
                return this.ratingField;
            }
            set {
                this.ratingField = value;
                this.RaisePropertyChanged("Rating");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Eval.Schemas.EvaluationRespnse")]
    public partial class EvaluationResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubmitEvalRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Eval.Schemas.Evaluation", Order=0)]
        public Eval.Web.EvalServiceReference.Evaluation Evaluation;
        
        public SubmitEvalRequest() {
        }
        
        public SubmitEvalRequest(Eval.Web.EvalServiceReference.Evaluation Evaluation) {
            this.Evaluation = Evaluation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubmitEvalResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Eval.Schemas.EvaluationRespnse", Order=0)]
        public Eval.Web.EvalServiceReference.EvaluationResponse EvaluationResponse;
        
        public SubmitEvalResponse() {
        }
        
        public SubmitEvalResponse(Eval.Web.EvalServiceReference.EvaluationResponse EvaluationResponse) {
            this.EvaluationResponse = EvaluationResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Eval_Orchestrations_ProcessEvals_EvalServiceChannel : Eval.Web.EvalServiceReference.Eval_Orchestrations_ProcessEvals_EvalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Eval_Orchestrations_ProcessEvals_EvalServiceClient : System.ServiceModel.ClientBase<Eval.Web.EvalServiceReference.Eval_Orchestrations_ProcessEvals_EvalService>, Eval.Web.EvalServiceReference.Eval_Orchestrations_ProcessEvals_EvalService {
        
        public Eval_Orchestrations_ProcessEvals_EvalServiceClient() {
        }
        
        public Eval_Orchestrations_ProcessEvals_EvalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Eval_Orchestrations_ProcessEvals_EvalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Eval_Orchestrations_ProcessEvals_EvalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Eval_Orchestrations_ProcessEvals_EvalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Eval.Web.EvalServiceReference.SubmitEvalResponse Eval.Web.EvalServiceReference.Eval_Orchestrations_ProcessEvals_EvalService.SubmitEval(Eval.Web.EvalServiceReference.SubmitEvalRequest request) {
            return base.Channel.SubmitEval(request);
        }
        
        public Eval.Web.EvalServiceReference.EvaluationResponse SubmitEval(Eval.Web.EvalServiceReference.Evaluation Evaluation) {
            Eval.Web.EvalServiceReference.SubmitEvalRequest inValue = new Eval.Web.EvalServiceReference.SubmitEvalRequest();
            inValue.Evaluation = Evaluation;
            Eval.Web.EvalServiceReference.SubmitEvalResponse retVal = ((Eval.Web.EvalServiceReference.Eval_Orchestrations_ProcessEvals_EvalService)(this)).SubmitEval(inValue);
            return retVal.EvaluationResponse;
        }
    }
}
