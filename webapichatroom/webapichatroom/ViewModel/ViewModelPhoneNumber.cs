using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapichatroom.ViewModel
{
    public class ViewModelPhoneNumber
    {
        public string Code { get; set; }

        public string EncryptedData { get; set; }

        public string Iv { get; set; }
    }
}