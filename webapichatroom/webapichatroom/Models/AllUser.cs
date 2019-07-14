﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapichatroom.Models
{
    public class AllUser
    {
        public int ID { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        public string UserAccount { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassword { get; set; }

        /// 记住密码的选择，1表示记忆，0表示不记忆
        /// </summary>
        public string RememberPassword { get; set; }
        /// <summary>
        /// 用户头像编号
        /// </summary>
        public string HeadImageNumber { get; set; }
        /// <summary>
        /// 用户状态(0代表不在线，1代表在线)
        /// </summary>
        public int UserState { get; set; }
        /// <summary>
        /// 用户权限(0代表无任何权限，1代表管理员权限，2代表群主权限)
        /// </summary>
        public string UserPermission { get; set; }
    }
}