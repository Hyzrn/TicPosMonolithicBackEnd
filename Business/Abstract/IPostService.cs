using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPostService
    {
        IDataResult<Post> GetById(int postId);
        IDataResult<List<Post>> GetAll();
        IResult Add(AddPostDto addPostDto);
        IResult Update(UpdatePostDto post);
        IResult Delete(Post post);

    }
}
