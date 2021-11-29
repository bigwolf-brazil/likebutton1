using BlazorApp.Entities;

namespace BlazorApp.Repository
{
    public class PostRepository : Repository<Post>
    {
        public PostRepository() : this(new BlogEntities()) { }
        public PostRepository(DbContext context) : base(context)
        {
        }

        public Post GetById(int id)
        {
            return First(e => e.Id == id);
        }
    }
}