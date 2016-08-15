using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Metamodel.DeepPCM;
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Core;
using Metamodel.DeepPCM.Core.Composition;
using Metamodel.DeepPCM.Seff;
using Metamodel.DeepPCM.Seff.Seff_performance;
using Metamodel.DeepPCM.System0;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Resourcetype;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;
using Metamodel.Stoex;
using Metamodel.Identifier;

namespace EventRepositoryCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri("http://github.com/ghmanager/EventRepo");
            var eventTesterL1 = CreateEventRepository(uri);
            var model = new Model()
            {
                ModelUri = uri
            };
            model.RootElements.Add(eventTesterL1);
            var unit = MetaFacade.CreateCode(eventTesterL1, "Metamodel");
            MetaFacade.GenerateCode(unit, new Microsoft.CSharp.CSharpCodeProvider(), @"..\..\..\EventRepository\EventRepository", true);
            using (var fs = File.Create(@"..\..\..\EventRepository.nmf"))
            {
                MetaRepository.Instance.Serializer.Serialize(eventTesterL1, fs);
            }
        }

        public static INamespace CreateEventRepository(Uri uri)
        {
            var eventRepo = new Repository() { Name = "Repo", Uri = uri, Prefix = "repo" };
            var sender = new BasicComponent()
            {
                Name = "Sender"
            };
            var basicReceiver = new BasicComponent()
            {
                Name = "Receiver"
            };
            var channelReceiver = new BasicComponent()
            {
                Name = "ChannelReceiver"
            };
            var eventInterface = new OperationInterface()
            {
                Name = "EventInterface"
            };
            var dosth = new OperationSignature() { Id = "DoSth" };
            sender.ProvidedInterfaces.Add(eventInterface);
            eventRepo.Interfaces__Repository.Add(eventInterface);
            var eventGroup = new EventGroup() { Name = "EventGroup" };
            var eventType1 = new EventType() { Id = "EventType1" };
            var event1 = new Metamodel.DeepPCM.Repository.Parameter();
            event1.DataType__Parameter = new PrimitiveDataType();
            eventType1.Parameter__EventType = event1;
            eventGroup.EventTypes__EventGroup.Add(eventType1);
            sender.ProvidedInterfaces.Add(eventGroup);
            eventRepo.Interfaces__Repository.Add(eventGroup);
            var eventGroupChannel = new EventGroup()
            {
                Name = "EventGroupChannel"
            };
            var eventType2 = new EventType() { Id = "EventType2" };
            var event2 = new Metamodel.DeepPCM.Repository.Parameter();
            event2.DataType__Parameter = new PrimitiveDataType();
            eventType2.Parameter__EventType = event2;
            eventGroupChannel.EventTypes__EventGroup.Add(eventType2);
            sender.ProvidedInterfaces.Add(eventGroupChannel);
            eventRepo.Interfaces__Repository.Add(eventGroupChannel);


            var senderSeff = new ResourceDemandingSEFF()
            {
                Id = "SenderSEFF",
                DescribedService__SEFF = dosth
            };
            var senderStartAction = new StartAction() { Id = "senderStartAction" };
            senderSeff.Steps_Behaviour.Add(senderStartAction);
            var senderStopAction = new StopAction() { Id = "senderStopAction" };
            senderSeff.Steps_Behaviour.Add(senderStopAction);

            var emitEvent = new EmitEventAction() { Id = "emitEvent" };
            emitEvent.EventGroup__EmitEventAction = eventGroup;
            emitEvent.Predecessor_AbstractAction = senderStartAction;
            emitEvent.Successor_AbstractAction = senderStopAction;
            emitEvent.EventType__EmitEventAction = eventType1;
            var variable = new VariableUsage();
            variable.VariableCharacterisation_VariableUsage.Add(new VariableCharacterisation()
            {
                Type = VariableCharacterisationType.VALUE,
                Specification_VariableCharacterisation = new PCMRandomVariable()
                {
                    Specification = "true"
                }
            });
            variable.NamedReference__VariableUsage = new VariableReference();
            variable.NamedReference__VariableUsage.ReferenceName = "event";
            emitEvent.InputVariableUsages__CallAction.Add(variable);
            senderStopAction.Predecessor_AbstractAction = emitEvent;
            senderSeff.Steps_Behaviour.Add(emitEvent);

            var action1 = new InternalAction() { Id = "action1" };
            action1.Predecessor_AbstractAction = senderStartAction;
            action1.Successor_AbstractAction = emitEvent;
            var resourceDemand = new ParametricResourceDemand();
            resourceDemand.Specification_ParametericResourceDemand = new PCMRandomVariable()
            {
                Specification = "1"
            };
            action1.ResourceDemand_Action.Add(resourceDemand);
            senderStartAction.Successor_AbstractAction = action1;
            senderSeff.Steps_Behaviour.Add(action1);

            var emitEvent2 = new EmitEventAction() { Id = "emitEvent2" };
            emitEvent2.EventGroup__EmitEventAction = eventGroup;
            emitEvent2.Predecessor_AbstractAction = emitEvent;
            emitEvent2.Successor_AbstractAction = senderStopAction;
            emitEvent2.EventType__EmitEventAction = eventType2;
            var variable2 = new VariableUsage();
            variable2.VariableCharacterisation_VariableUsage.Add(new VariableCharacterisation()
            {
                Type = VariableCharacterisationType.VALUE,
                Specification_VariableCharacterisation = new PCMRandomVariable()
                {
                    Specification = "BoolPMF[(true;0.5)(false;0.5)]"
                }
            });
            variable2.NamedReference__VariableUsage = new VariableReference();
            variable2.NamedReference__VariableUsage.ReferenceName = "event";
            emitEvent2.InputVariableUsages__CallAction.Add(variable2);
            senderSeff.Steps_Behaviour.Add(emitEvent2);
            sender.ServiceEffectSpecifications__BasicComponent.Add(senderSeff);
            eventRepo.Components__Repository.Add(sender);


            basicReceiver.RequiredInterfaces.Add(new EventGroupSubscriber()
            {
                Name = "BasicSubscriber",
                EventGroup = eventGroup
            });
            var basicReceiverSeff = new ResourceDemandingSEFF()
            {
                Id = "BasicReceiverSeff",
                DescribedService__SEFF = eventType1
            };
            var basicReceiverStartAction = new StartAction() { Id = "basicReceiverStartAction" };
            basicReceiverSeff.Steps_Behaviour.Add(basicReceiverStartAction);
            var basicReceiverStopAction = new StopAction() { Id = "basicReceiverStopAction" };
            basicReceiverSeff.Steps_Behaviour.Add(basicReceiverStopAction);
            var action2 = new InternalAction() { Id = "action2" };
            action2.Predecessor_AbstractAction = basicReceiverStartAction;
            action2.Successor_AbstractAction = basicReceiverStopAction;
            var resourceDemand2 = new ParametricResourceDemand();
            resourceDemand2.Specification_ParametericResourceDemand = new PCMRandomVariable()
            {
                Specification = "event.VALUE ? 2 : 10"
            };
            action2.ResourceDemand_Action.Add(resourceDemand2);
            basicReceiverStartAction.Successor_AbstractAction = action2;
            basicReceiverStopAction.Predecessor_AbstractAction = action2;
            basicReceiverSeff.Steps_Behaviour.Add(action2);
            basicReceiver.ServiceEffectSpecifications__BasicComponent.Add(basicReceiverSeff);
            eventRepo.Components__Repository.Add(basicReceiver);


            channelReceiver.RequiredInterfaces.Add(new EventGroupSubscriber()
            {
                Name = "ChannelSubscriber",
                EventGroup = eventGroupChannel
            });
            var channelReceiverSeff = new ResourceDemandingSEFF()
            {
                Id = "ChannelReceiverSeff",
                DescribedService__SEFF = eventType2
            };
            var channelReceiverStartAction = new StartAction() { Id = "channelReceiverStartAction" };
            channelReceiverSeff.Steps_Behaviour.Add(channelReceiverStartAction);
            var channelReceiverStopAction = new StopAction() { Id = "channelReceiverStopAction" };
            channelReceiverSeff.Steps_Behaviour.Add(channelReceiverStopAction);
            var action3 = new InternalAction() { Id = "action3" };
            action3.Predecessor_AbstractAction = channelReceiverStartAction;
            action3.Successor_AbstractAction = channelReceiverStopAction;
            var resourceDemand3 = new ParametricResourceDemand();
            resourceDemand3.Specification_ParametericResourceDemand = new PCMRandomVariable()
            {
                Specification = "1"
            };
            action3.ResourceDemand_Action.Add(resourceDemand3);
            channelReceiverStartAction.Successor_AbstractAction = action3;
            channelReceiverStopAction.Predecessor_AbstractAction = action3;
            channelReceiverSeff.Steps_Behaviour.Add(action3);
            channelReceiver.ServiceEffectSpecifications__BasicComponent.Add(channelReceiverSeff);
            eventRepo.Components__Repository.Add(channelReceiver);
            var system1 = new SystemSpecification() { Id = "System1", Name = "System1" };
            //system1.ProvidedInterfaces.Add(eventInterface);
            eventRepo.SystemSpecifications.Add(system1);
            var channel = new EventChannel() { Name = "ExampleChannel" };
            channel.EventGroup__EventChannel = eventGroupChannel;
            eventRepo.EventChannel__Repository.Add(channel);
            return eventRepo;
        }
    }
}