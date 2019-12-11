using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore22Intro.Entities;

namespace AspNetCore22Intro.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();

        Video Get(int id);

        void Add(Video newVideo);

        int Commit();
    }
}
