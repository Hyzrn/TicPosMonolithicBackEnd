using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordWrong = "Şifre yanlış girildi.";
        public static string LoginSuccessfull = "Login işlemi başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut.";
        public static string RegisterSuccessfull = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu.";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string ProductNameAlreadyExist = "Ürün ismi zaten mevcut";
        public static string PostAdded = "Gönderi başarıyla kaydedildi";
        public static string PostUpdated = "Gönderi başarıyla güncellendi";
        public static string PostDeleted = "Gönderi başarıyla silindi";
    }
}
