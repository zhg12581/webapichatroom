using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapichatroom.ViewModel;

namespace webapichatroom.Controllers
{
    public class GetPhoneNumberController : ApiController
    {
        // private AccountContext db = new AccountContext();
        //private UnitOfWork unitOfWork = new UnitOfWork();
        [HttpPost]
        [ActionName("PostGetPhoneNumber")]
        //[Route("GetPhoneNumber")]

        private ViewModelInformation GetPhoneNumber(ViewModelPhoneNumber viewModelPhoneNumber)
        {
            ViewModelInformation viewModelInformation = new ViewModelInformation();
            viewModelInformation.Message = viewModelPhoneNumber.Code;
            return viewModelInformation;



            /*
            try
            {

                byte[] encryData = Convert.FromBase64String(encryptedData);  // strToToHexByte(text);
                RijndaelManaged rijndaelCipher = new RijndaelManaged();
                rijndaelCipher.Key = Convert.FromBase64String(Session_key); // Encoding.UTF8.GetBytes(AesKey);
                rijndaelCipher.IV = Convert.FromBase64String(IV);// Encoding.UTF8.GetBytes(AesIV);
                rijndaelCipher.Mode = CipherMode.CBC;
                rijndaelCipher.Padding = PaddingMode.PKCS7;
                ICryptoTransform transform = rijndaelCipher.CreateDecryptor();
                byte[] plainText = transform.TransformFinalBlock(encryData, 0, encryData.Length);
                string result = Encoding.Default.GetString(plainText);
                //动态解析result 成对象
                dynamic model = Newtonsoft.Json.Linq.JToken.Parse(result) as dynamic;
                return model.phoneNumber;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return "";

            }
            */

        }
    }
}
