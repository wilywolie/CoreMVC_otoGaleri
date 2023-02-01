using CoreMVC_otoGaleri.Models;

namespace CoreMVC_otoGaleri.Data
{
    public class dataList
    {
        public List<marka> markalar = new List<marka>();
        public List<carmodel> modeller = new List<carmodel>();
        public dataList()
        {
            markalar.Add(new marka(1, "bmw", "bmw.png"));
            markalar.Add(new marka(2, "audi", "audi.png"));
            markalar.Add(new marka(3, "mercedes", "mercedes.png"));
            modeller.Add(new carmodel(1, "A3", 2000, "2022-bmw-i7222946722.jpeg", markalar.Where(m => m.markaid == 2).FirstOrDefault()));
            modeller.Add(new carmodel(2, "A5", 2000, "audi-q7-0-1223436761.jpeg", markalar.Where(m => m.markaid == 2).FirstOrDefault()));
            modeller.Add(new carmodel(3, "E200", 2023, "lthmb_9850391031lc224901135.jpg", markalar.Where(m => m.markaid == 3).FirstOrDefault()));
        }
    }
}
