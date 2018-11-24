namespace DTO
{
    public class ChiTietThietBiPhong
    {
        private string maphong;
        private string mathietbi;
        private int soluong;

        public string Maphong
        {
            get
            {
                return maphong;
            }
            set
            {
                maphong = value;
            }
        }

        public string Mathietbi
        {
            get
            {
                return mathietbi;
            }
            set
            {
                mathietbi = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }
            set
            {
                soluong = value;
            }
        }
    }
}