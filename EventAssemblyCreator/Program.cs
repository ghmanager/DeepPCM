using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metamodel.DeepPCM.System0;
using Metamodel.Repo;
using Metamodel.Identifier;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;

namespace EventAssemblyCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri("http://github.com/ghmanager/EventSystem");
            var mediaStoreL2 = CreateMediaStoreAssembly(uri);
            var model = new Model()
            {
                ModelUri = uri
            };
            model.RootElements.Add(mediaStoreL2);

            var unit = MetaFacade.CreateCode(mediaStoreL2, "Metamodel");
            MetaFacade.GenerateCode(unit, new Microsoft.CSharp.CSharpCodeProvider(), @"..\..\..\EventAssembly\EventAssembly", true);
            using (var fs = File.OpenWrite(@"..\..\..\EventAssembly.nmf"))
            {
                MetaRepository.Instance.Serializer.Serialize(mediaStoreL2, fs);
            }
        }

        public static INamespace CreateMediaStoreAssembly(Uri uri)
        {
            var system = new System1()
            {
                Name = "EventSystemArchitecture"
            };
            var sender = new Sender()
            {
                Name = "Sender"
            };
            var normalReceiver = new Receiver()
            {
                Name = "Receiver"
            };
            var channelReceiver1 = new ChannelReceiver()
            {
                Name = "ChannelReceiver"
            };
            var channelReceiver2 = new ChannelReceiver()
            {
                Name = "ChannelReceiver2"
            };
            system.AssemblyContexts__ComposedStructure.Add(sender);
            system.AssemblyContexts__ComposedStructure.Add(normalReceiver);
            system.AssemblyContexts__ComposedStructure.Add(channelReceiver1);
            system.AssemblyContexts__ComposedStructure.Add(channelReceiver2);

            normalReceiver.BasicSubscriber = sender;
            var channel = new ExampleChannel() { Name = "Channel" };
            channel.EventPublisher.Add(sender);
            channel.EventSubscriber.Add(channelReceiver1);
            channel.EventSubscriber.Add(channelReceiver2);
            system.EventChannelArchitecture__ComposedStructure.Add(channel);
            var mediaStoreL2 = new Namespace()
            {
                Name = "Assembly",
                Uri = uri,
                Prefix = "mediaStore"
            };
            mediaStoreL2.Types.Add(system);
            return mediaStoreL2;
        }
    }
}
