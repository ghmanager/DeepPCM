using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeepPCM.Deeppcm;
using DeepPCM.Deeppcm.Repository;
using DeepPCM.Deeppcm.Seff;
using DeepPCM.Deeppcm.System0;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;

namespace MediaStoreRepositoryCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri("http://github.com/georghinkel/mediaStore/Repository");
            var mediaStoreL1 = CreateMediaStoreRepository(uri);
            var model = new Model()
            {
                ModelUri = uri
            };
            model.RootElements.Add(mediaStoreL1);
            var unit = MetaFacade.CreateCode(mediaStoreL1, "GereratedCode.DeepPCMInstance");
            MetaFacade.GenerateCode(unit, new Microsoft.CSharp.CSharpCodeProvider(), @"..\..\..\MediaStoreRepository\MediaStoreRepository", true);
            using (var fs = File.Create(@"..\..\..\MediaStoreRepository.nmf"))
            {
                MetaRepository.Instance.Serializer.Serialize(mediaStoreL1, fs);
            }
        }

        public static INamespace CreateMediaStoreRepository(Uri uri)
        {
            var mediaStoreL1 = new Repository() { Name = "Repository", Uri = uri, Prefix = "repo" };
            var iAudioStore = new OperationInterface()
            {
                Name = "AudioStoreInterface"
            };
            mediaStoreL1.Interfaces__Repository.Add(iAudioStore);
            var iEncoder = new OperationInterface()
            {
                Name = "EncoderInterface"
            };
            mediaStoreL1.Interfaces__Repository.Add(iEncoder);
            var iAudioDB = new OperationInterface()
            {
                Name = "AudioDBInterface"
            };
            mediaStoreL1.Interfaces__Repository.Add(iAudioDB);

            var iUserManagement = new OperationInterface()
            {
                Name = "UserManagementInterface"
            };
            mediaStoreL1.Interfaces__Repository.Add(iUserManagement);

            var iUserDB = new OperationInterface()
            {
                Name = "UserDBInterface"
            };
            mediaStoreL1.Interfaces__Repository.Add(iUserDB);

            var iCommand = new OperationInterface()
            {
                Name = "CommandInterface"
            };
            mediaStoreL1.Interfaces__Repository.Add(iCommand);

            var iConnection = new OperationInterface()
            {
                Name = "ConnectionInterface"
            };
            mediaStoreL1.Interfaces__Repository.Add(iConnection);

            var iDataReaderInterface = new OperationInterface()
            {
                Name = "DataReaderInterface"
            };
            mediaStoreL1.Interfaces__Repository.Add(iDataReaderInterface);

            var http = new OperationInterface()
            {
                Name = "HTTP"
            };
            mediaStoreL1.Interfaces__Repository.Add(http);

            var webBrowser = new BasicComponent()
            {
                Name = "WebBrowser"
            };
            webBrowser.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "backend",
                OperationInterface = http
            });
            mediaStoreL1.Components__Repository.Add(webBrowser);

            var webForm = new BasicComponent()
            {
                Name = "WebForm"
            };
            webForm.ProvidedInterfaces.Add(http);
            webForm.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "application",
                OperationInterface = iAudioStore
            });
            mediaStoreL1.Components__Repository.Add(webForm);

            var audioStore = new BasicComponent()
            {
                Name = "AudioStore"
            };
            audioStore.ProvidedInterfaces.Add(iAudioStore);
            audioStore.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "audioDB",
                OperationInterface = iAudioDB
            });
            audioStore.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "userManagement",
                OperationInterface = iUserManagement
            });
            mediaStoreL1.Components__Repository.Add(audioStore);

            var encodingAdapter = new BasicComponent()
            {
                Name = "EncodingAdapter"
            };
            encodingAdapter.ProvidedInterfaces.Add(iAudioDB);
            encodingAdapter.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "encoder",
                OperationInterface = iEncoder
            });
            encodingAdapter.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "database",
                OperationInterface = iAudioDB
            });
            mediaStoreL1.Components__Repository.Add(encodingAdapter);

            var oggEncoder = new BasicComponent()
            {
                Name = "OggEncoder"
            };
            oggEncoder.ProvidedInterfaces.Add(iEncoder);
            mediaStoreL1.Components__Repository.Add(oggEncoder);

            var userMgmt = new BasicComponent()
            {
                Name = "UserManagement"
            };
            userMgmt.ProvidedInterfaces.Add(iUserManagement);
            userMgmt.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "database",
                OperationInterface = iUserDB
            });
            mediaStoreL1.Components__Repository.Add(userMgmt);

            var dbadapter = new BasicComponent()
            {
                Name = "DBAdapter"
            };
            dbadapter.ProvidedInterfaces.Add(iUserDB);
            dbadapter.ProvidedInterfaces.Add(iAudioDB);
            dbadapter.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "command",
                OperationInterface = iCommand
            });
            dbadapter.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "connection",
                OperationInterface = iConnection
            });
            dbadapter.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "dataReader",
                OperationInterface = iDataReaderInterface
            });
            mediaStoreL1.Components__Repository.Add(dbadapter);

            var database = new BasicComponent()
            {
                Name = "MySqlClient"
            };
            database.ProvidedInterfaces.Add(iCommand);
            database.ProvidedInterfaces.Add(iConnection);
            database.ProvidedInterfaces.Add(iDataReaderInterface);
            mediaStoreL1.Components__Repository.Add(database);

            var encrypt = new OperationSignature() { Name = "Encrypt" };
            var decrypt = new OperationSignature() { Name = "Decrypt" };
            iEncoder.Signatures__OperationInterface.Add(encrypt);
            iEncoder.Signatures__OperationInterface.Add(decrypt);

            var upload = new OperationSignature() { Name = "Upload" };
            var download = new OperationSignature() { Name = "Download" };
            iAudioStore.Signatures__OperationInterface.Add(upload);
            iEncoder.Signatures__OperationInterface.Add(download);   

            oggEncoder.ServiceEffectSpecifications__BasicComponent.Add(new ResourceDemandingSEFF()
            {
                Name = "Encrypt",
                DescribedService__SEFF = encrypt
            });
            oggEncoder.ServiceEffectSpecifications__BasicComponent.Add(new ResourceDemandingSEFF()
            {
                Name = "Decrypt",
                DescribedService__SEFF = decrypt
            });

            audioStore.ServiceEffectSpecifications__BasicComponent.Add(new ResourceDemandingSEFF()
            {
                Name = "Upload",
                DescribedService__SEFF = upload
            });
            audioStore.ServiceEffectSpecifications__BasicComponent.Add(new ResourceDemandingSEFF()
            {
                Name = "Download",
                DescribedService__SEFF = download
            });

            var mediaStoreSystem = new System0()
            {
                Name = "MediaStoreSystem"
            };
            mediaStoreSystem.RequiredInterfaces.Add(new RequiredOperationInterface()
            {
                Name = "Frontend",
                OperationInterface = http
            });

            return mediaStoreL1;
        }
    }
}
