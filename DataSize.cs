namespace DataSize
{
    public sealed class DataSize : System.IComparable
    {
        private const ulong BYTE = 8ul;

        private const ulong KILO = 1000ul;
        private const ulong MEGA = KILO * 1000ul;
        private const ulong GIGA = MEGA * 1000ul;
        private const ulong TERA = GIGA * 1000ul;
        private const ulong PETA = TERA * 1000ul;
        private const ulong EXA = PETA * 1000ul;

        private const ulong KIBI = 1024ul;
        private const ulong MEBI = KIBI * 1024ul;
        private const ulong GIBI = MEBI * 1024ul;
        private const ulong TEBI = GIBI * 1024ul;
        private const ulong PEBI = TEBI * 1024ul;
        private const ulong EXBI = PEBI * 1024ul;

        private readonly ulong _bits;

        private DataSize(ulong bits_) { _bits = bits_; }

        public static DataSize FromBits(ulong bits_)
        {
            return new DataSize(bits_);
        }

        public static DataSize FromBytes(ulong bytes_)
        {
            return new DataSize(bytes_ * BYTE);
        }

        public static DataSize FromKiloBytes(ulong kilobytes_)
        {
            return new DataSize(kilobytes_ * KILO * BYTE);
        }

        public static DataSize FromMegaBytes(ulong megabytes_)
        {
            return new DataSize(megabytes_ * MEGA * BYTE);
        }

        public static DataSize FromGigaBytes(ulong gygabytes_)
        {
            return new DataSize(gygabytes_ * GIGA * BYTE);
        }

        public static DataSize FromTeraBytes(ulong terabytes_)
        {
            return new DataSize(terabytes_ * TERA * BYTE);
        }

        public static DataSize FromPetaBytes(ulong petabytes_)
        {
            return new DataSize(petabytes_ * PETA * BYTE);
        }

        public static DataSize FromExaBytes(ulong exabytes_)
        {
            return new DataSize(exabytes_ * EXA * BYTE);
        }

        public static DataSize FromKibiBytes(ulong kibibytes_)
        {
            return new DataSize(kibibytes_ * KIBI * BYTE);
        }

        public static DataSize FromMebiBytes(ulong mebibytes_)
        {
            return new DataSize(mebibytes_ * MEBI * BYTE);
        }

        public static DataSize FromGibiBytes(ulong gibibytes_)
        {
            return new DataSize(gibibytes_ * GIBI * BYTE);
        }

        public static DataSize FromTebiBytes(ulong pebibytes_)
        {
            return new DataSize(pebibytes_ * TEBI * BYTE);
        }

        public static DataSize FromPebiBytes(ulong pebibytes_)
        {
            return new DataSize(pebibytes_ * PEBI * BYTE);
        }

        public static DataSize FromExbiBytes(ulong exbibytes_)
        {
            return new DataSize(exbibytes_ * EXBI * BYTE);
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
                return _bits / (double)BYTE;
            }
        }

        public double KiloBytes
        {
            get
            {
                return _bits / ((double)KILO * BYTE);
            }
        }

        public double MegaBytes
        {
            get
            {
                return _bits / ((double)MEGA * BYTE);
            }
        }

        public double GigaBytes
        {
            get
            {
                return _bits / ((double)GIGA * BYTE);
            }
        }
        
        public double TeraBytes
        {
            get
            {
                return _bits / ((double)TERA * BYTE);
            }
        }

        public double PetaBytes
        {
            get
            {
                return _bits / ((double)PETA * BYTE);
            }
        }

        public double ExaBytes
        {
            get
            {
                return _bits / ((double)EXA * BYTE);
            }
        }

        public double KibiBytes
        {
            get
            {
                return _bits / ((double)KIBI * BYTE);
            }
        }

        public double MebiBytes
        {
            get
            {
                return _bits / ((double)MEBI * BYTE);
            }
        }

        public double GibiBytes
        {
            get
            {
                return _bits / ((double)GIBI * BYTE);
            }
        }

        public double TebiBytes
        {
            get
            {
                return _bits / ((double)TEBI * BYTE);
            }
        }

        public double PebiBytes
        {
            get
            {
                return _bits / ((double)PEBI * BYTE);
            }
        }

        public double ExbiBytes
        {
            get
            {
                return _bits / ((double)EXBI * BYTE);
            }
        }

        public override bool Equals(object obj)
        {
            var ds = obj as DataSize;
            if (ds == null) { throw new ArgumentException(); }
            return this == null || ds == null ? false : _bits == ds._bits;
        }

        public override int GetHashCode()
        {
            return _bits.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} bit", _bits);
        }

        public int CompareTo(object obj)
        {
            var ds = obj as DataSize;
            return _bits.CompareTo(ds._bits);
        }

        public static bool operator ==(DataSize a, DataSize b)
        {
            return a.CompareTo(b) == 0;
        }

        public static bool operator !=(DataSize a, DataSize b)
        {
            return a.CompareTo(b) != 0;
        }

        public static bool operator >(DataSize a, DataSize b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator >=(DataSize a, DataSize b)
        {
            return a.CompareTo(b) >= 0;
        }

        public static bool operator <(DataSize a, DataSize b)
        {
            return a.CompareTo(b) < 0;
        }

        public static bool operator <=(DataSize a, DataSize b)
        {
            return a.CompareTo(b) <= 0;
        }
    }
}
