using System.Text.Json;

namespace Solid_Principles
{
    public class Solid_D
    {
        public async void Main()
        {
            string origin = @"https://fake_url.com";
            string dbPath = @"C:\Example\Path\db.json";

            IInfo info = new InfoByRequest(origin);

            Monitor monitor = new Monitor(origin, info);
            await monitor.Show();

            FileDB fileDB = new FileDB(dbPath, origin, info);
            await fileDB.Save();
        }

        public class Monitor
        {
            private string _origin;
            private IInfo _info;
            public Monitor(string origin, IInfo info)
            {
                _origin = origin;
                _info = info;
            }
            public async Task Show()
            {
                var posts = await _info.Get();
                foreach (var post in posts)
                {
                    Console.WriteLine(post.title);
                }
            }
        }
        public class FileDB
        {
            private string _origin;
            private IInfo _info;
            private string _path;
            public FileDB(string path, string origin, IInfo info)
            {
                _path = path;
                _origin = origin;
                _info = info;
            }
            public async Task Save()
            {
                var posts = await _info.Get();
                string json = JsonSerializer.Serialize(posts);
                await File.WriteAllTextAsync(_path, json);
            }
        }
        public class InfoByRequest : IInfo
        {
            private string _url;
            public InfoByRequest(string url)
            {
                _url = url;
            }
            public async Task<IEnumerable<Post>> Get()
            {
                HttpClient httpClient = new();
                var response = await httpClient.GetAsync(_url);
                var stream = await response.Content.ReadAsStreamAsync();
                List<Post> posts =
                    await JsonSerializer.DeserializeAsync<List<Post>>(stream);
                return posts;
            }
        }
        public class InfoByFile : IInfo
        {
            private string _path;
            public InfoByFile(string path)
            {
                _path = path;
            }
            public async Task<IEnumerable<Post>> Get()
            {
                var contentStream = new FileStream(_path, FileMode.Open, FileAccess.Read);
                IEnumerable<Post> posts =
                    await JsonSerializer.DeserializeAsync<IEnumerable<Post>>(contentStream);
                return posts;
            }
        }
        public class Post
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public bool completed { get; set; }
        }
        public interface IInfo
        {
            public Task<IEnumerable<Post>> Get();
        }
    }
}
