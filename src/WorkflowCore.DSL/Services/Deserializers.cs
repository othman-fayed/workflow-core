using System;
using Newtonsoft.Json;
using WorkflowCore.Models.DefinitionStorage.v1;
using YamlDotNet.Serialization;

namespace WorkflowCore.Services.DefinitionStorage
{
    public static class Deserializers
    {
        private static Deserializer yamlDeserializer = new Deserializer();
		public static Func<string, DefinitionSourceV1> Json = (source) => JsonConvert.DeserializeObject<DefinitionSourceV1>(source);
        public static Func<string, DefinitionSourceV1> Yaml = (source) => yamlDeserializer.Deserialize<DefinitionSourceV1>(source);
    }
}
