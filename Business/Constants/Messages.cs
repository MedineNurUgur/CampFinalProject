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
        public static string ProductUpdated = "Ürün Güncellendi.";
        public static string ProductAdded= "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategotoryError = "Bir kategoride 10 dan fazla ürün olamaz.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered;
        public static string UserNotFound;
        public static string PasswordError;
        public static string SuccessfulLogin;
        public static string UserAlreadyExists;
        public static string AccessTokenCreated;
    }
}
