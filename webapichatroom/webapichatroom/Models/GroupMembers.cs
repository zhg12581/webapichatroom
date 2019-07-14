using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapichatroom.Models
{
    public class GroupMembers
    {
        public int ID { get; set; }
        /// <summary>
        /// 群账号
        /// </summary>
        public string GroupNumber { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string UserAccount { get; set; }
        /// <summary>
        /// 用户权限(0代表无任何权限，1代表管理员权限，2代表群主权限)
        /// </summary>
        public string UserPermission { get; set; }
    }
}