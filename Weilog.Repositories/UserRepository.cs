﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weilog.Entities;
using Weilog.Core.Domain.Repositories;

namespace Weilog.Repositories
{
    /// <summary>
    /// Weilog 内容管理系统 User 数据仓储类，无法继承此类。
    /// </summary>
    public sealed class UserRepository : IUserRepository
    {

        #region Fields...

        private readonly IRepositoryAsync<User> _repository;

        #endregion

        #region Constructors...


        /// <summary>
        /// 初始化 <see cref="UserRepository"/> 类的新实例。
        /// </summary>
        public UserRepository(IRepositoryAsync<User> userRepository)
        {
            _repository = userRepository;
        }

        #endregion

        #region Methods...

        /// <summary>
        /// 将指定的 <see cref="User"/> 实体对象插入到数据库。
        /// </summary>
        /// <param name="entity">指定的 <see cref="User"/> 实体对象。</param>
        public void AddUser(User entity)
        {
            _repository.Insert(entity);
        }

        /// <summary>
        /// 删除指定的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="User"/> 实体对象。</param>
        public void DeleteUser(User entity)
        {
            _repository.Delete(entity);
        }

        /// <summary>
        /// 删除指定唯一编号的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="User"/> 实体对象的唯一编号。</param>
        public void DeleteUser(int id)
        {
            _repository.Delete(id);
        }

        /// <summary>
        /// 更新指定的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="User"/> 实体对象。</param>
        public void UpdateUser(User entity)
        {
            _repository.Update(entity);
        }

        /// <summary>
        /// 移除指定的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="User"/> 实体对象。</param>
        // public void RemoveUser(User entity)
        // {
        //     _repository.Delete(entity);
        // }

        /// <summary>
        /// 移除指定的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="id">指定的 <see cref="User"/> 实体对象唯一编号。</param>
        // public void RemoveUser(int id)
        // {
        //     _repository.Delete(id);
        // }

        /// <summary>
        /// 查询指定编号的 <see cref="User"/> 实体对象。
        /// </summary>
        /// <param name="id">指定的 <see cref="User"/> 实体对象编号。</param>
        /// <returns>返回若存在则查询的 <see cref="User"/> 实体对象，否则返回 Null。</returns>
        public User GetUser(int id)
        {
            return _repository.Get(id);
        }

        /// <summary>
        /// 获取 <see cref="IList{User}"/> 的数据集合。
        /// </summary>
        public IList<User> GetUserList()
        {
            return _repository.Queryable().ToList();
        }

        /// <summary>
        /// 获取 <see cref="IQueryable{User}"/> 的数据集合。
        /// </summary>
        public IQueryable<User> Queryable()
        {
            return _repository.Queryable().OrderBy(entity => entity.Id);
        }

        #endregion
    }
}


