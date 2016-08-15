using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Transformations;
using NMF.Utilities;
using Metamodel.DeepPCM.Repository;
using Metamodel.Identifier;

namespace Transformation
{
    public static class Transformation
    {
        private static ModelRepository repository = new ModelRepository();
        private static DeepPCM2PCMTransformation deepPCM2PCM = new DeepPCM2PCMTransformation();

/*        static Transformation()
        {
            using (var ecoreModel = typeof(ModelRepository).Assembly.GetManifestResourceStream("Transformation.DeepPCM.nmeta"))
            {
                repository.Serializer.Deserialize(ecoreModel, new Uri("http://github.com/ghmanager/DeepPCM/1.0", UriKind.Absolute), repository, true);
            }
        }*/

        public static IModelRepository Repository
        {
            get
            {
                return repository;
            }
        }

        public static Repository LoadRepositoryFromFile(string path)
        {
            var fileInfo = new FileInfo(path);
            return LoadRepositoryFromUri(new Uri(fileInfo.FullName));
        }

        public static Repository LoadRepositoryFromUri(Uri uri)
        {
            var tempRepository = new ModelRepository(repository);
            var modelElement = tempRepository.Resolve(uri);

            var package = modelElement as Repository;
            if (package != null) return package;

            return modelElement.Model.RootElements.OfType<Repository>().FirstOrDefault();
        }

        public static INamespace Transform2PCM(Repository repo)
        {
            var model = new Model();
            var rootRepository = TransformationEngine.Transform<Repository, INamespace>(repo, deepPCM2PCM);
            model.RootElements.Add(rootRepository);
            Uri modelUri;
            if (Uri.TryCreate(repo.AbsoluteUri.ToString(), UriKind.Absolute, out modelUri))
            {
                model.ModelUri = modelUri;
            }
            return rootRepository;
        }

        public static IEnumerable<INamespace> Transform2PCM(IEnumerable<Repository> repos)
        {
            var model = new Model();
            var rootRepositories = TransformationEngine.TransformMany<IRepository, INamespace>(repos, deepPCM2PCM);
            model.RootElements.AddRange(rootRepositories);
            Uri modelUri;
            if (repos.Count() > 0 && Uri.TryCreate(repos.First().AbsoluteUri.ToString(), UriKind.Absolute, out modelUri))
            {
                model.ModelUri = modelUri;
            }
            return rootRepositories;
        }

    }
}
