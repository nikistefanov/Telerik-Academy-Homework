namespace ConsoleWebServer.Framework
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;

    public class StaticFileHandler
    {
        private const string FileNotFoundMessage = "File not found";
        private const string FileStartingDirectory = "../../../";

        public bool CanHandle(HttpRequest request)
        {
            return request.Uri.LastIndexOf(".", StringComparison.Ordinal) > request.Uri.LastIndexOf("/", StringComparison.Ordinal);
        }

        public HttpResponse Handle(HttpRequest request)
        {
            string filePath = request.Uri;
            if (!this.FileExists(FileStartingDirectory, filePath, 3))
            {
                return new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotFound, FileNotFoundMessage);
            }

            string fileContents = File.ReadAllText(filePath);
            var response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, fileContents);
            return response;
        }

        private bool FileExists(string path, string file, int depth)
        {
            if (depth <= 0)
            {
                return File.Exists(file);
            }

            try
            {
                var filePath = Directory.GetFiles(path);
                if (filePath.Contains(file))
                {
                    return true;
                }

                var directories = Directory.GetDirectories(path);

                foreach (var directory in directories)
                {
                    if (this.FileExists(directory, file, depth - 1))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}