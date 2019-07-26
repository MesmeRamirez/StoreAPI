using System;
using System.IO;
using System.Linq;

namespace ModelStoreAPI.Dto
{
    public class FileDto
    {
        public string Content { get; set; }
        public string ContentType { get; set; }
        public int Length { get; set; }
        public string Name { get; set; }

        public MemoryStream ReadAsStream() => new MemoryStream(
             Convert.FromBase64String(
                 Content
             )
         );

        public string Extension
        {
            get
            {
                return Name.Split('.').ToList().Last();
            }
        }

        public string UniqueName
        {
            get
            {
                return $"{Guid.NewGuid().ToString().ToLower()}.{Extension}";
            }
        }

    }
}
