using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }
        [ValidationAspect(typeof(AddPostValidator))]
        public IResult Add(AddPostDto addPostDto)
        {
            var post = new Post
            {
                ActivityId = addPostDto.ActivityId,
                Code = addPostDto.Code,
                Date = addPostDto.Date,
                Description = addPostDto.Description,
                Status = addPostDto.Status,
                UserId = addPostDto.UserId
            };
            _postDal.Add(post);
            return new SuccessResult(Messages.PostAdded);
        }

        public IResult Delete(Post post)
        {
            _postDal.Delete(post);
            return new SuccessResult(Messages.PostDeleted);
        }

        public IDataResult<List<Post>> GetAll()
        {
            return new SuccessDataResult<List<Post>>(_postDal.GetList().ToList());
        }

        public IDataResult<Post> GetById(int postId)
        {
            return new SuccessDataResult<Post>(_postDal.Get(p => p.Id == postId));
        }
        [ValidationAspect(typeof(UpdatePostValidator), Priority = 1)]
        public IResult Update(UpdatePostDto updatePostDto)
        {
            var post = new Post
            {
                Id = updatePostDto.Id,
                ActivityId = updatePostDto.ActivityId,
                Code = updatePostDto.Code,
                Date = updatePostDto.Date,
                Description = updatePostDto.Description,
                Status = updatePostDto.Status
            };
            _postDal.Update(post);
            return new SuccessResult(Messages.PostUpdated);
        }
    }
}
