using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AntrenmanTakip.Persistence.Services
{
    public static class InfService
    {
        public static string Sure(View_Antrenmanlar antrenman)
        {
            var dakika = antrenman.AntrenmanSuresi / 60;
            var saniye = antrenman.AntrenmanSuresi % 60;
            string systemLanguage = DbService.GetApplicationLanguage();
            if(systemLanguage == "Turkish")
                return $"{dakika} Dakika {saniye} saniye";
            return $"{dakika} Minute {saniye} second";
        }

        public static string ConvertToEnglish(string text)
        {
            string englishMevki = string.Empty;
            switch (text)
            {
                case "Defans":
                    englishMevki = "Defense";
                    break;
                case "Orta Saha":
                    englishMevki = "Midfielder";
                    break;
                case "Forvet":
                    englishMevki = "Forward";
                    break;
                case "Kaleci":
                    englishMevki = "Goalkeeper";
                    break;
            }
            return englishMevki;
        }
        public static void Exit()
        {
            Application.ExitThread(); 
        }
        public static string GetCurrentDirectory()
        {
            string currentDirectory = Environment.CurrentDirectory;
            currentDirectory = currentDirectory.Substring(0, currentDirectory.IndexOf("\\bin"));
            string path = Path.Combine(currentDirectory + @"\Resources");
            return path;
        }
        public static void ShowMessage(string turkishText,string englishText)
        {
            var systemLanguage = DbService.GetApplicationLanguage();
            if (systemLanguage == "English")
                MessageBox.Show(englishText);
            else if (systemLanguage == "Turkish")
                MessageBox.Show(turkishText);
        }
        public static DialogResult ShowMessage(string turkishText, string englishText, MessageBoxButtons buttonType = MessageBoxButtons.OK)
        {
            var systemLanguage = DbService.GetApplicationLanguage();
            if (systemLanguage == "English")
                return MessageBox.Show(englishText, "", buttonType);
            else if (systemLanguage == "Turkish")
               return  MessageBox.Show(turkishText, "", buttonType);
            return DialogResult.No;
        }

        public static void OpenExcelFile()
        {
            // Excel uygulamasını başlat
            Excel.Application excelApp = new Excel.Application();

            // Yeni bir çalışma kitabı oluştur
            Excel.Workbook workbook = excelApp.Workbooks.Add();

            // Aktif sayfa üzerinde çalışmak için bir çalışma sayfası al
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Sayfa adını değiştirebilirsiniz
            worksheet.Name = "Asil";

            // Excel uygulamasını göster
            excelApp.Visible = true;

            // Excel uygulamasını kapatın
            // excelApp.Quit();
        }
    }
}
