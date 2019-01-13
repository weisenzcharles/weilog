﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weilog.Entities;

namespace Weilog.Data.Mapping
{
    public class UserMap: EntityTypeConfiguration<User>
    {
        /// <summary>
        /// 初始化 <seealso cref="UserMap"/> 类的新实例。
        /// </summary>
        public UserMap()
        {
            ToTable("User");
            HasKey(bp => bp.Id);
            Property(bp => bp.Username).IsRequired();
            Property(bp => bp.Password).IsRequired();
            Property(bp => bp.Nicename).IsRequired();
            Property(bp => bp.Email).IsRequired();
            Property(bp => bp.Status).IsRequired();
            Property(bp => bp.Deleted).IsRequired();
            Property(bp => bp.CreatedTime).IsRequired();
        }
    }
}
