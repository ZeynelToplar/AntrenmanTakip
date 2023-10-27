using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AntrenmanTakip.Persistence.Services
{
    public static class DbService
    {
        static DbAntrenmanTakipEntities Context = new DbAntrenmanTakipEntities();
        public static object GetFootballer(int id)
        {
            var sporcu = (from s in Context.Sporcular join m in Context.Mevkiler on s.MevkiId equals m.Id where s.Id == id select new 
            {
               Adi = s.Adi,
               Soyadi = s.Soyadi,
               Yas = s.Yas,
               Boy = s.Boy,
               Kilo = s.Kilo,
               Mevkiler = m
            }).First();
            return sporcu;
        }
        public static List<Sporcular> GetAllFootballer()
        {
            List<Sporcular> sporcular = (from s in Context.Sporcular
                                         join m in Context.Mevkiler on s.MevkiId equals m.Id
                                         select new Sporcular
                                         {
                                             Adi = s.Adi,
                                             Soyadi = s.Soyadi,
                                             Yas = s.Yas,
                                             Boy = s.Boy,
                                             Kilo = s.Kilo,
                                             Mevkiler = m
                                         }).ToList();
            return sporcular;
        }
        public static List<View_Antrenmanlar> GetPractices(int id, int topKonumId)
        {
            return Context.View_Antrenmanlar.Where(s => s.Id == id && s.TopKonumId == topKonumId).OrderBy(a => a.AntrenmanTurleri).ThenBy(a => a.AntrenmanSayisi).ToList();
        }
        public static List<View_Antrenmanlar> GetFilteredValueOnlyDate(int id, int topKonumId, DateTimePicker pickerBaslangic, DateTimePicker pickerBitis)
        {
            return Context.View_Antrenmanlar.Where(a => a.Id == id && a.TopKonumId == topKonumId && a.Tarih >= pickerBaslangic.Value && a.Tarih <= pickerBitis.Value).OrderBy(a => a.AntrenmanTurleri).ThenBy(a => a.AntrenmanSayisi).ToList();
        }
        public static List<View_Antrenmanlar> GetFilteredValue(int id, int topKonumId, int aranacakDeger, DateTimePicker pickerBaslangic, DateTimePicker pickerBitis)
        {
            return Context.View_Antrenmanlar.Where(a => a.AntrenmanId == aranacakDeger && a.TopKonumId == topKonumId && a.Id == id && a.Tarih >= pickerBaslangic.Value && a.Tarih <= pickerBitis.Value).OrderBy(a => a.AntrenmanTurleri).ThenBy(a => a.AntrenmanSayisi).ToList();
        }
        public static List<View_Antrenmanlar> GetSearchedValue(int id, int topKonumId, string aranacakDeger)
        {
            return Context.View_Antrenmanlar.Where(a => a.AntrenmanTurleri.Contains(aranacakDeger) && a.TopKonumId == topKonumId && a.Id == id).OrderBy(a => a.AntrenmanTurleri).ThenBy(a => a.AntrenmanSayisi).ToList();
        }
        public static Kullanicilar GetUser(int id)
        {
            return Context.Kullanicilar.Find(id);
        }
        public static string GetApplicationLanguage()
        {
            var language = Context.Diller.FirstOrDefault(d => d.Selected == true);
            return language.Language;
        }
    }
}
