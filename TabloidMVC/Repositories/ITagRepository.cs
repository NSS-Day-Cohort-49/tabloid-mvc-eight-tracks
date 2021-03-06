using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabloidMVC.Models;

namespace TabloidMVC.Repositories
{
    public interface ITagRepository
    {
        List<Tag> GetAll();
        Tag GetTagById(int id);
        List<Tag> GetTagsByPost(int postId);
        void AddTag(Tag tag);
        void Delete(int id);
        void UpdateTag(Tag tag);
    }
}
