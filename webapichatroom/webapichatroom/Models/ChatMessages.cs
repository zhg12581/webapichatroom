﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapichatroom.Models
{
    public class ChatMessages
    {
        public int ID { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string UserAccount { get; set; }
        /// <summary>
        /// 用户发送的消息
        /// </summary>
        public string Message { get; set; }
    }
}