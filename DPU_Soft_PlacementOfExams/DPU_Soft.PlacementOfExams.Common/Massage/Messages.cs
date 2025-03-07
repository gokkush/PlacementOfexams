﻿
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace DPU_Soft.PlacementOfExams.Common.Massage
{
    
    public static class Messages
    { 
        public static void ALCCalistir(string mesaj, string baslik)
        {
            DevExpress.XtraBars.Alerter.AlertControl _alert = new DevExpress.XtraBars.Alerter.AlertControl();
            _alert.Show(Form.ActiveForm, mesaj, baslik);
        }
        public static void HataMesaji(string hataMesaji)
        {
           // AnaMessage.Mesaj("Hata", hataMesaji);
            XtraMessageBox.Show(hataMesaji,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
          
        }

        public static void UyariMesaji(string uyariMesaji)
        {
            // AnaMessage.Mesaj("Hata", hataMesaji);
            XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult SilMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçili {kartAdi} silinecektir. Onaylıyor musunuz?", "silme Onayı");
        }

        public static void KartSecmemeHataMesaj()
        {
            UyariMesaji("Lütfen bir kart seçiniz.");
        }
        public static void KartKalmadiHataMesaj()
        {
            UyariMesaji("Eklenebilecek Kayıt Kalmadığından Form Açılamadı.");
        }
        public static DialogResult KapanisMesaj()
        {
            return EvetSeciliEvetHayirIptal("Değişiklikler Kaydedilmesini İstiyor musunuz?", "Çıkış İşlemi");
        }

        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayir("Değişiklikler Kaydedilmesini İstiyor musunuz?", "Kayıt İşlemi");
        }
        public static void MukerrerKayitHataMesaj(string alanAdi)
        {
            HataMesaji($"Girmiş olduğunuz {alanAdi} daha önce kullanılmıştır.");
        }

        public static void HataliVeriMesaj(string alanAdi)
        {
            HataMesaji($"{alanAdi} Alanına Geçerli Değer Girmelisiniz.");
        }

        public static DialogResult TabloExportMesaj(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili Tablo, {dosyaFormati} olarak Dışarı aktarılacaktır. Onaylıyor musunuz?", "Aktarım Onayı");
        }

        public static DialogResult EmailgonderimOnayi()
        {
            return HayirSeciliEvetHayir($"Kullanıcı Şifresi sıfırlanarak, Kullanıcı Bilgilerini İçeren Yeni Bir Mail Gönderilecektir. Onaylıyor musunuz?", "Şifre Sıfırla Onayı");
        }

        public static DialogResult RaporuTasarimaGonder()
        {
            return HayirSeciliEvetHayir("Rapor Tasarım Görünümünde Açılacaktır. Onaylıyor musunuz?","Onay");
        }
    }
}
