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
    /// Weilog 内容管理系统 Category 数据仓储接口。
    /// </summary>
    public interface ICategoryRepository
    {

        #region Interface...

        /// <summary>
        /// 将指定的 <see cref="Category"/> 实体对象插入到数据库。
        /// </summary>
        /// <param name="entity">指定的 <see cref="Category"/> 实体对象。</param>
        void AddCategory(Category entity);

        /// <summary>
        /// 删除指定的 <see cref="Category"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="Category"/> 实体对象。</param>
        void DeleteCategory(Category entity);
        
        /// <summary>
        /// 删除指定唯一编号的 <see cref="Category"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="Category"/> 实体对象的唯一编号。</param>
        void DeleteCategory(int id);
                
        /// <summary>
        /// 更新指定的 <see cref="Category"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="Category"/> 实体对象。</param>
        void UpdateCategory(Category entity);
        
        /// <summary>
        /// 移除指定的 <see cref="Category"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="Category"/> 实体对象。</param>
        //  void RemoveCategory(Category entity);
        
        /// <summary>
        /// 移除指定的 <see cref="Category"/> 实体对象。
        /// </summary>
        /// <param name="id">指定的 <see cref="Category"/> 实体对象唯一编号。</param>
        //  void RemoveCategory(int id);
            
        /// <summary>
        /// 查询指定编号的 <see cref="Category"/> 实体对象。
        /// </summary>
        /// <param name="id">指定的 <see cref="Category"/> 实体对象编号。</param>
        /// <returns>返回若存在则查询的 <see cref="Category"/> 实体对象，否则返回 Null。</returns>
        Category GetCategory(int id);
        
        /// <summary>
        /// 获取 <see cref="IList{Category}"/> 的数据集合。
        /// </summary>
        IList<Category> GetCategoryList();
        
        /// <summary>
        /// 获取 <see cref="IQueryable{Category}"/> 的数据集合。
        /// </summary>
        IQueryable<Category> Queryable();
        
        #endregion
        
    }
}

