using Models;
using System.Threading.Tasks;

namespace DBRepository
{
    public interface IBlogRepository
    {
        Task<Page<Post>> GetPosts(int index, int pageSize, string tag = null);
    }
}