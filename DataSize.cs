namespace DataSize
{
    public sealed class DataSize
    {
        private readonly ulong _bits;

        private DataSize(ulong bits_) { _bits = bits_; }

        public static DataSize FromBits(ulong bits_)
        {
            return new DataSize(bits_);
        }

        public static DataSize FromBytes(ulong bytes_)
        {
            return new DataSize(bytes_ * 8);
        }

        public static DataSize FromKiloBytes(ulong kilobytes_)
        {
            return new DataSize(kilobytes_ * 1000 * 8);
        }

        public static DataSize FromMegaBytes(ulong megabytes_)
        {
            return new DataSize(megabytes_ * 1000 * 1000 * 8);
        }

        public static DataSize FromGigaBytes(ulong gygabytes_)
        {
            return new DataSize(gygabytes_ * 1000 * 1000 * 1000 * 8);
        }

        public static DataSize FromTeraBytes(ulong terabytes_)
        {
            return new DataSize(terabytes_ * 1000 * 1000 * 1000 * 1000 * 8);
        }

        public double Bits
        {
            get
            {
                return _bits;
            }
        }

        public double Bytes
        {
            get
            {
                return _bits / 8d;
            }
        }

        public double KiloBytes
        {
            get
            {
                return _bits / (1000d * 8d);
            }
        }

        public double MegaBytes
        {
            get
            {
                return _bits / (1000d * 1000d * 8d);
            }
        }

        public double GigaBytes
        {
            get
            {
                return _bits / (1000d * 1000d * 1000d * 8d);
            }
        }
        
        public double TeraBytes
        {
            get
            {
                return _bits / (1000d * 1000d * 1000d * 1000d * 8d);
            }
        }
    }
}
