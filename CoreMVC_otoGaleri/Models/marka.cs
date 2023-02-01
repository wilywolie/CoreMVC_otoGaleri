namespace CoreMVC_otoGaleri.Models
{
    public class marka
    {
        public int markaid { get; set; }
        public string markaadi { get; set; }
        public string markaimgurl { get; set; }
        public marka()
        {

        }
        public marka(int _markaid, string _markaadi, string _markaimgurl)
        {
            this.markaid = _markaid;
            this.markaadi = _markaadi;
            this.markaimgurl = _markaimgurl;
        }   
    }
}
