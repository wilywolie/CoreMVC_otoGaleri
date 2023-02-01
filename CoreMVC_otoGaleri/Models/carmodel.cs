namespace CoreMVC_otoGaleri.Models
{
    public class carmodel
    {
        public int modelid { get; set; }
        public string modeladi { get; set; }
        public int modelyili { get; set; }
        public string modelimgurl { get; set; }
        public marka aracmarkasi { get; set; }
        public carmodel()
        {

        }
        public carmodel(int modelid, string modeladi, int modelyili, string modelimgurl, marka aracmarkasi)
        {
            this.modelid = modelid;
            this.modeladi = modeladi;
            this.modelyili = modelyili;
            this.modelimgurl = modelimgurl;
            this.aracmarkasi = aracmarkasi;
        }
    }
}
