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

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="bits_"/> bits.
        /// </summary>
        /// <param name="bits_">Number of bits.</param>
        public static DataSize FromBits(ulong bits_)
        {
            return new DataSize(bits_);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="bytes_"/> bytes.
        /// </summary>
        /// <param name="bytes_">Number of bytes.</param>
        public static DataSize FromBytes(ulong bytes_)
        {
            return new DataSize(bytes_ * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="kilobytes_"/> kilobytes.
        /// </summary>
        /// <param name="kilobytes_">Number of kilobytes.</param>
        public static DataSize FromKiloBytes(ulong kilobytes_)
        {
            return new DataSize(kilobytes_ * KILO * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="megabytes_"/> megabytes.
        /// </summary>
        /// <param name="megabytes_">Number of megabytes.</param>
        public static DataSize FromMegaBytes(ulong megabytes_)
        {
            return new DataSize(megabytes_ * MEGA * BYTE);
        }
   
        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="gigabytes_"/> gigabytes.
        /// </summary>
        /// <param name="gigabytes_">Number of gigabytes.</param>
        public static DataSize FromGigaBytes(ulong gigabytes_)
        {
            return new DataSize(gigabytes_ * GIGA * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="terabytes_"/> terabytes.
        /// </summary>
        /// <param name="terabytes_">Number of terabytes.</param>
        public static DataSize FromTeraBytes(ulong terabytes_)
        {
            return new DataSize(terabytes_ * TERA * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="petabytes_"/> petabytes.
        /// </summary>
        /// <param name="petabytes_">Number of petabytes.</param>
        public static DataSize FromPetaBytes(ulong petabytes_)
        {
            return new DataSize(petabytes_ * PETA * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="exabytes_"/> exabytes.
        /// </summary>
        /// <param name="exabytes_">Number of exabytes.</param>
        public static DataSize FromExaBytes(ulong exabytes_)
        {
            return new DataSize(exabytes_ * EXA * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="kibibytes_"/> kibibytes.
        /// </summary>
        /// <param name="kibibytes_">Number of kibibytes.</param>
        public static DataSize FromKibiBytes(ulong kibibytes_)
        {
            return new DataSize(kibibytes_ * KIBI * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="mebibytes_"/> mebibytes.
        /// </summary>
        /// <param name="mebibytes_">Number of mebibytes.</param>
        public static DataSize FromMebiBytes(ulong mebibytes_)
        {
            return new DataSize(mebibytes_ * MEBI * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="gibibytes_"/> gibibyes.
        /// </summary>
        /// <param name="gibibytes_">Number of gibibytes.</param>
        public static DataSize FromGibiBytes(ulong gibibytes_)
        {
            return new DataSize(gibibytes_ * GIBI * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="tebibytes_"/> tebibyes.
        /// </summary>
        /// <param name="tebibytes_">Number of tebibytes.</param>
        public static DataSize FromTebiBytes(ulong tebibytes_)
        {
            return new DataSize(tebibytes_ * TEBI * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="pebibytes_"/> pebibyes.
        /// </summary>
        /// <param name="pebibytes_">Number of pebibytes.</param>
        public static DataSize FromPebiBytes(ulong pebibytes_)
        {
            return new DataSize(pebibytes_ * PEBI * BYTE);
        }

        /// <summary>
        /// Initializes a DataSize instance representing <paramref name="exbibytes_"/> exbibytes.
        /// </summary>
        /// <param name="exbibytes_">Number of exbibytes.</param>
        public static DataSize FromExbiBytes(ulong exbibytes_)
        {
            return new DataSize(exbibytes_ * EXBI * BYTE);
        }

        /// <summary>
        /// Double representing DataSize in number of bits.
        /// </summary>
        public double Bits
        {
            get
            {
                return _bits;
            }
        }

        /// <summary>
        /// Double representing DataSize in number of bytes.
        /// </summary>
        public double Bytes
        {
            get
            {
                return _bits / (double)BYTE;
            }
        }

        /// <summary>
        /// Double representing DataSize in number of kilobytes.
        /// </summary>
        public double KiloBytes
        {
            get
            {
                return _bits / ((double)KILO * BYTE);
            }
        }

        /// <summary>
        /// Double representing DataSize in number of megabytes.
        /// </summary>
        public double MegaBytes
        {
            get
            {
                return _bits / ((double)MEGA * BYTE);
            }
        }

        /// <summary>
        /// Double representing DataSize in number of gigabytes.
        /// </summary>
        public double GigaBytes
        {
            get
            {
                return _bits / ((double)GIGA * BYTE);
            }
        }

        /// <summary>
        /// Double representing DataSize in number of terabytes.
        /// </summary>
        public double TeraBytes
        {
            get
            {
                return _bits / ((double)TERA * BYTE);
            }
        }

        /// <summary>
        /// Double representing DataSize in number of petabytes.
        /// </summary>
        public double PetaBytes
        {
            get
            {
                return _bits / ((double)PETA * BYTE);
            }
        }

        /// <summary>
        /// Double representing DataSize in number of exabytes.
        /// </summary>
        public double ExaBytes
        {
            get
            {
                return _bits / ((double)EXA * BYTE);
            }
        }

        /// <summary>
        /// Double representing DataSize in number of kibibytes.
        /// </summary>  
        public double KibiBytes
        {
            get
            {
                return _bits / ((double)KIBI * BYTE);
            }
        }
        
        /// <summary>
        /// Double representing DataSize in number of mebibytes.
        /// </summary>
        public double MebiBytes
        {
            get
            {
                return _bits / ((double)MEBI * BYTE);
            }
        }
       
        /// <summary>
        /// Double representing DataSize in number of gibibytes.
        /// </summary>
        public double GibiBytes
        {
            get
            {
                return _bits / ((double)GIBI * BYTE);
            }
        }
        
        /// <summary>
        /// Double representing DataSize in number of tebibytes.
        /// </summary>
        public double TebiBytes
        {
            get
            {
                return _bits / ((double)TEBI * BYTE);
            }
        }
        
        /// <summary>
        /// Double representing DataSize in number of pebibytes.
        /// </summary>
        public double PebiBytes
        {
            get
            {
                return _bits / ((double)PEBI * BYTE);
            }
        }

        /// <summary>
        /// Double representing DataSize in number of exbibytes.
        /// </summary>
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
            if (ds == null) { throw new System.ArgumentException(); }
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

        public static DataSize operator +(DataSize a, DataSize b)
        {
            return new DataSize(a._bits + b._bits);
        }

        public static DataSize operator -(DataSize a, DataSize b)
        {
            return new DataSize(a._bits - b._bits);
        }

        public static DataSize operator *(DataSize a, ulong b)
        {
            return new DataSize(a._bits * b);
        }
    }
}
