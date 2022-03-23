using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç başarılı bir şekilde sisteme eklenmiştir.";
        public static string CarNameInvalid = "Girilen araç ismi 2  karakterden daha uzun olmalıdır.";
        public static string CarUpdated = "Araç bilgileri başarılı bir şekilde güncellenmiştir.";
        public static string CarDeleted = "Araç bilgileri sistemden silinmiştir.";
        public static string CarsListed = "Araçlar Listelenmiştir.";

        public static string BrandAdded = "Araç markası başarılı bir şekilde sisteme eklenmiştir";
        public static string BrandUpdate = "Araç markası başarılı bir şekilde güncellenmiştir";
        public static string BrandDeleted = "Araç markası sistemden silinmiştir.";

        public static string ColorAdded = "Yeni araç rengi sisteme eklenöiştir.";
        public static string ColorUpdate = "Araç rengi güncellenmiştir.";
        public static string ColorDeleted = "Araç rengi sistemden silinmiştir";
        public static string ColorListed = "Renkler listelenmiştir.";

        public static string MainteanceTime = "Sistem şu an bakımdadır.";
        public static string AuthorizationDenied = "Bu işlem için yetkiniz bulunmamaktadır.";
        public static string UserNotFound = "Böyle bir kullanıcı bulunamadı!";
        public static string PasswordError = "Hatalı şifre girişi!";
        public static string SuccessfulLogin = "Giriş başarıyla gerçekleştirildi!";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated;
        public static string UserRegistered = "Kayıt başarıyla gerçekleştirildi!";
        public static string UserAdded;
    }
}
