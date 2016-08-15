using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;
using Metamodel.Assembly;
using Metamodel.Repo;
using Metamodel.DeepPCM.System0;
using Metamodel.DeepPCM.Resourceenvironment;
using Metamodel.Identifier;

namespace EventDeploymentCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri("http://github.com/ghmanager/EventDeployment");
            var eventTesterL3 = CreateEventDeployment(uri);
            var model = new Model()
            {
                ModelUri = uri
            };
            model.RootElements.Add(eventTesterL3);
            var unit = MetaFacade.CreateCode(eventTesterL3, "Metamodel");
            MetaFacade.GenerateCode(unit, new Microsoft.CSharp.CSharpCodeProvider(), @"..\..\..\EventDeployment\EventDeployment", true);
            using (var fs = File.Create(@"..\..\..\EventDeployment.nmf"))
            {
                MetaRepository.Instance.Serializer.Serialize(eventTesterL3, fs);
            }
        }

        public static INamespace CreateEventDeployment(Uri uri)
        {
            var resourceContainer = new ResourceContainer() { Id = "ApplicationServer" };
            var middlewareServer = new ResourceContainer() { Id = "ApplicationServer" };
            var computeEnvironment = new ResourceEnvironment();
            computeEnvironment.ResourceContainer_ResourceEnvironment.Add(resourceContainer);
            computeEnvironment.ResourceContainer_ResourceEnvironment.Add(middlewareServer);
            var deployment = new EventSystemArchitecture() { Name = "Deployment" };
            deployment.Environment = computeEnvironment;
            deployment.Sender = resourceContainer;
            deployment.Receiver = resourceContainer;
            deployment.ChannelReceiver = resourceContainer;
            deployment.ChannelReceiver2 = resourceContainer;

            var eventTesterL3 = new Namespace()
            {
                Name = "Deployment",
                Uri = uri,
                Prefix = "mediaStore"
            };
            eventTesterL3.Types.Add(deployment);
            return eventTesterL3;
        }
    }
}
