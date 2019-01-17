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
    /// Weilog 内容管理系统 RoleMenu 数据仓储接口。
    /// </summary>
    public interface IRoleMenuRepository
    {

        #region Interface...

        /// <summary>
        /// 将指定的 <see cref="RoleMenu"/> 实体对象插入到数据库。
        /// </summary>
        /// <param name="entity">指定的 <see cref="RoleMenu"/> 实体对象。</param>
        void AddRoleMenu(RoleMenu entity);

        /// <summary>
        /// 删除指定的 <see cref="RoleMenu"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="RoleMenu"/> 实体对象。</param>
        void DeleteRoleMenu(RoleMenu entity);
        
        /// <summary>
        /// 删除指定唯一编号的 <see cref="RoleMenu"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="RoleMenu"/> 实体对象的唯一编号。</param>
        void DeleteRoleMenu(int id);
                
        /// <summary>
        /// 更新指定的 <see cref="RoleMenu"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="RoleMenu"/> 实体对象。</param>
        void UpdateRoleMenu(RoleMenu entity);
        
        /// <summary>
        /// 移除指定的 <see cref="RoleMenu"/> 实体对象。
        /// </summary>
        /// <param name="entity">指定的 <see cref="RoleMenu"/> 实体对象。</param>
        //  void RemoveRoleMenu(RoleMenu entity);
        
        /// <summary>
        /// 移除指定的 <see cref="RoleMenu"/> 实体对象。
        /// </summary>
        /// <param name="id">指定的 <see cref="RoleMenu"/> 实体对象唯一编号。</param>
        //  void RemoveRoleMenu(int id);
            
        /// <summary>
        /// 查询指定编号的 <see cref="RoleMenu"/> 实体对象。
        /// </summary>
        /// <param name="id">指定的 <see cref="RoleMenu"/> 实体对象编号。</param>
        /// <returns>返回若存在则查询的 <see cref="RoleMenu"/> 实体对象，否则返回 Null。</returns>
        RoleMenu GetRoleMenu(int id);
        
        /// <summary>
        /// 获取 <see cref="IList{RoleMenu}"/> 的数据集合。
        /// </summary>
        IList<RoleMenu> GetRoleMenuList();
        
        /// <summary>
        /// 获取 <see cref="IQueryable{RoleMenu}"/> 的数据集合。
        /// </summary>
        IQueryable<RoleMenu> Queryable();
        
        #endregion
        
    }
}

