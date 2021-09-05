using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserDetailManager : IUserDetailService
    {
        private IUserService _userService;
        private IUserDetailDal _userDetailDal;
        public UserDetailManager(IUserDetailDal userDetailDal, IUserService userService)
        {
            _userService = userService;
            _userDetailDal = userDetailDal;
        }
        public IResult Add(UserDetail userDetail)
        {
            IResult result = BusinessRules.Run(CheckIfUserExist(userDetail.UserId));
            if (result != null)
            {
                return result;
            }
            _userDetailDal.Add(userDetail);
            return new SuccessResult();
        }

        public IResult Delete(UserDetail userDetail)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserDetail> GetById(int userId)
        {
            return new SuccessDataResult<UserDetail>(_userDetailDal.Get(u => u.UserId == userId));
        }

        public IResult Update(UserDetail userDetail)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfUserExist(int userId)
        {
            if (_userService.GetById(userId) == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            return new SuccessResult();
        }
    }
}
