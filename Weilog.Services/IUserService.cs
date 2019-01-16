﻿#region using...

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Weilog.Caching;
using Weilog.Core.UI.Paged;
using Weilog.Entities;
using Weilog.Repositories;
using Weilog.Core.Domain.Entities;
using Weilog.Core.Domain.Uow;

#endregion

namespace Weilog.Services
{


    /// <summary>
    /// Weilog 内容管理系统 <see cref="User"/> 业务服务接口。
    /// </summary>
     public interface IUserService
     {
     
        #region Interface...
        
        /// <summary>
        /// 将指定的 <see cref="User"/> 实体对象插入到数据库。
        /// </summary>
        /// <param name="user">指定的 <see cref="User"/> 实体对象。</param>
        /// <param name="clearCache">是否清除缓存。</param>
        /// <returns>受影响记录数。</returns>
        int AddUser(User user, bool clearCache = true);

        /// <summary>
        /// 删除指定的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="user">指定的 <see cref="User"/> 实体对象。</param>
        /// <returns>受影响记录数。</returns>
        int DeleteUser(User user);
        
        /// <summary>
        /// 删除指定唯一编号的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="userId">指定的 <see cref="User"/> 实体对象的唯一编号。</param>
        /// <returns>受影响记录数。</returns>
        int DeleteUser(int userId);
                
        /// <summary>
        /// 更新指定的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="user">指定的 <see cref="User"/> 实体对象。</param>
        /// <param name="clearCache">是否清除缓存。</param>
        /// <returns>受影响记录数。</returns>
        int UpdateUser(User user, bool clearCache = true);
        
        /// <summary>
        /// 移除指定的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="user">指定的 <see cref="User"/> 实体对象。</param>
        /// <param name="clearCache">是否清除缓存。</param>
        /// <returns>受影响记录数。</returns>
        // int RemoveUser(User user);
        
        /// <summary>
        /// 移除指定的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="userId">指定的 <see cref="User"/> 实体对象唯一编号。</param>
        /// <param name="clearCache">是否清除缓存。</param>
        /// <returns>受影响记录数。</returns>
        // int RemoveUser(int userId);
            
        /// <summary>
        /// 查询指定编号的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="userId">指定的 <see cref="User"/> 实体对象的唯一编号。</param>
        /// <returns>返回若存在则查询的 <see cref="User"/> 实体对象，否则返回 Null。</returns>
        User GetUser(int userId);

        
        /// <summary>
        /// 获取 <see cref="User"/> 实体列表。
        /// </summary>
        /// <returns>一个 <see cref="IList{User}"/> 实体列表</returns>
        IList<User> GetUserList();

        /// <summary>
        /// 分页获取 <see cref="User"/> 实体列表。
        /// </summary>
        /// <param name="pageIndex">分页索引，默认从 0 开始。</param>
        /// <param name="pageSize">分页大小。</param>
        /// <returns>一个支持分页的 <see cref="IPagedList{User}"/> 实体列表</returns>
        IPagedList<User> GetUserPagedList(int pageIndex = 0, int pageSize = int.MaxValue);
        
        #endregion
        
    }

}