namespace FileSize
{
    public sealed class FileSize
    {
        private readonly ulong _bits;

        private FileSize(ulong bits_) { _bits = bits_; }

        public static FileSize FromBits(ulong bits_)
        {
            return new FileSize(bits_);
        }

        public static FileSize FromBytes(ulong bytes_)
        {
            return new FileSize(bytes_ * 8);
        }

        public static FileSize FromKiloBytes(ulong kilobytes_)
        {
            return new FileSize(kilobytes_ * 1000 * 8);
        }

        public static FileSize FromMegaBytes(ulong megabytes_)
        {
            return new FileSize(megabytes_ * 1000 * 1000 * 8);
        }

        public static FileSize FromGigaBytes(ulong gygabytes_)
        {
            return new FileSize(gygabytes_ * 1000 * 1000 * 1000 * 8);
        }

        public static FileSize FromTeraBytes(ulong terabytes_)
        {
            return new FileSize(terabytes_ * 1000 * 1000 * 1000 * 1000 * 8);
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
