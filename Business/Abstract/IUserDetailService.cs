using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserDetailService
    {
        IDataResult<UserDetail> GetById(int userId);
        IResult Add(UserDetail userDetail);
        IResult Update(UserDetail userDetail);
        IResult Delete(UserDetail userDetail);

    }
}
