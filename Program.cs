using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Primes
{
    public struct PrimeInfo
    {
        public int Prime;
        public uint Magic;
        public int Shift;

        public PrimeInfo(int prime, uint magic, int shift)
        {
            Prime = prime;
            Magic = magic;
            Shift = shift;
        }

        public void Deconstruct(out int prime, out uint magic, out int shift)
        {
            prime = Prime;
            magic = Magic;
            shift = Shift;
        }
    }

    class Program
    {
        public static readonly PrimeInfo[] PrimesInfo = 
        {
            new PrimeInfo(3, 0x55555556, 0),
            new PrimeInfo(7, 0x92492493, 2),
            new PrimeInfo(11, 0x2e8ba2e9, 1),
            new PrimeInfo(17, 0x78787879, 3),
            new PrimeInfo(23, 0xb21642c9, 4),
            new PrimeInfo(29, 0x8d3dcb09, 4),
            new PrimeInfo(37, 0xdd67c8a7, 5),
            new PrimeInfo(47, 0xae4c415d, 5),
            new PrimeInfo(59, 0x22b63cbf, 3),
            new PrimeInfo(71, 0xe6c2b449, 6),
            new PrimeInfo(89, 0xb81702e1, 6),
            new PrimeInfo(107, 0x4c8f8d29, 5),
            new PrimeInfo(131, 0x3e88cb3d, 5),
            new PrimeInfo(163, 0x0c907da5, 3),
            new PrimeInfo(197, 0x532ae21d, 6),
            new PrimeInfo(239, 0x891ac73b, 7),
            new PrimeInfo(293, 0xdfac1f75, 8),
            new PrimeInfo(353, 0xb9a7862b, 8),
            new PrimeInfo(431, 0x980e4157, 8),
            new PrimeInfo(521, 0x3ee4f99d, 7),
            new PrimeInfo(631, 0x33ee2623, 7),
            new PrimeInfo(761, 0x561e46a5, 8),
            new PrimeInfo(919, 0x8e9fe543, 9),
            new PrimeInfo(1103, 0x1db54401, 7),
            new PrimeInfo(1327, 0xc58bdd47, 10),
            new PrimeInfo(1597, 0xa425d4b9, 10),
            new PrimeInfo(1931, 0x10f82d9b, 7),
            new PrimeInfo(2333, 0x705d0d0f, 10),
            new PrimeInfo(2801, 0x2ecb7285, 9),
            new PrimeInfo(3371, 0x9b876783, 11),
            new PrimeInfo(4049, 0x817c5d53, 11),
            new PrimeInfo(4861, 0x35ed914d, 10),
            new PrimeInfo(5839, 0x0b394d8f, 8),
            new PrimeInfo(7013, 0x9584d635, 12),
            new PrimeInfo(8419, 0x7c8c7b75, 12),
            new PrimeInfo(10103, 0x33e4f01d, 11),
            new PrimeInfo(12143, 0x565a3073, 12),
            new PrimeInfo(14591, 0x23eeaa5d, 11),
            new PrimeInfo(17519, 0x77b510e9, 13),
            new PrimeInfo(21023, 0x63c14fe5, 13),
            new PrimeInfo(25229, 0x531fe999, 13),
            new PrimeInfo(30293, 0x8a75366b, 14),
            new PrimeInfo(36353, 0xe6c11447, 15),
            new PrimeInfo(43627, 0xc047bac3, 15),
            new PrimeInfo(52361, 0x0a035099, 11),
            new PrimeInfo(62851, 0x42bbed05, 14),
            new PrimeInfo(75431, 0x379ac159, 14),
            new PrimeInfo(90523, 0x05cab127, 11),
            new PrimeInfo(108631, 0x9a713743, 16),
            new PrimeInfo(130363, 0x80b236c9, 16),
            new PrimeInfo(156437, 0x6b3eeec1, 16),
            new PrimeInfo(187751, 0xb2b7bcf9, 17),
            new PrimeInfo(225307, 0x4a76bbc7, 16),
            new PrimeInfo(270371, 0x7c1aeabf, 17),
            new PrimeInfo(324449, 0x676b743d, 17),
            new PrimeInfo(389357, 0x2b16ec6d, 16),
            new PrimeInfo(467237, 0x8fa1117f, 18),
            new PrimeInfo(560689, 0x77b0a38f, 18),
            new PrimeInfo(672827, 0x63bddbb1, 18),
            new PrimeInfo(807403, 0x0531def9, 14),
            new PrimeInfo(968897, 0x8a86bc61, 19),
            new PrimeInfo(1162687, 0x737002ad, 19),
            new PrimeInfo(1395263, 0x180c7f9f, 17),
            new PrimeInfo(1674319, 0x140a67af, 17),
            new PrimeInfo(2009191, 0x42cd47bf, 19),
            new PrimeInfo(2411033, 0x37ab0b5f, 19),
            new PrimeInfo(2893249, 0x5cc7a9dd, 20),
            new PrimeInfo(3471899, 0x4d510d43, 20),
            new PrimeInfo(4166287, 0x080dc5ad, 17),
            new PrimeInfo(4999559, 0x035b11b9, 16),
            new PrimeInfo(5999471, 0xb2f90627, 22),
            new PrimeInfo(7199369, 0x9524d54d, 22),
            new PrimeInfo(14398753, 0x4a92658f, 22),
            new PrimeInfo(28797523, 0x4a9262ad, 23),
            new PrimeInfo(57595063, 0x9524c277, 25),
            new PrimeInfo(115190149, 0x9524c083, 26),
            new PrimeInfo(230380307, 0x4a926011, 26),
            new PrimeInfo(460760623, 0x9524bff1, 28),
            new PrimeInfo(921521257, 0x9524bfd3, 29),
            new PrimeInfo(1843042529, 0x4a925fdf, 29),
            new PrimeInfo(2146435069, 0x20040081, 28)
        };

        // To implement magic-number divide with a 32-bit magic number,
        // multiply by the magic number, take the top 64 bits, and shift that
        // by the amount given in the table.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint MagicNumberDivide(uint numerator, uint magic, int shift)
        {
            return (uint)((numerator * (ulong)magic) >> (32 + shift));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MagicNumberRemainder(int numerator, int divisor, uint magic, int shift)
        {
            Debug.Assert(numerator >= 0);
            uint product = MagicNumberDivide((uint)numerator, magic, shift);
            int result = (int)(numerator - (product * divisor));
            Debug.Assert(result == numerator % divisor);
            return result;
        }

        public static readonly int[] CurrentPrimes = {
            3, 7, 11, 17, 23, 29, 37, 47, 59, 71, 89, 107, 131, 163, 197, 239, 293, 353, 431, 521, 631, 761, 919,
            1103, 1327, 1597, 1931, 2333, 2801, 3371, 4049, 4861, 5839, 7013, 8419, 10103, 12143, 14591,
            17519, 21023, 25229, 30293, 36353, 43627, 52361, 62851, 75431, 90523, 108631, 130363, 156437,
            187751, 225307, 270371, 324449, 389357, 467237, 560689, 672827, 807403, 968897, 1162687, 1395263,
            1674319, 2009191, 2411033, 2893249, 3471899, 4166287, 4999559, 5999471, 7199369};

        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                switch (args[0])
                {
                    case "generate":
                        GeneratePrimes();
                        break;
                    case "verify":
                        VerifyPrimes();
                        break;
                    default:
                        Help();
                        break;
                }
            }
            else
            {
                Help();
            }
        }

        private static void Help()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine();
            Console.WriteLine("generate    Output prime info set");
            Console.WriteLine("verify      Verify prime info set");
        }

        private static void VerifyPrimes()
        {
            var primes = PrimesInfo;
            for(var i = 0; i < primes.Length; i++)
            {
                (int prime, uint magic, int shift) = primes[i];

                for(int n = 0; n < int.MaxValue; n++)
                {
                    var remainder = MagicNumberRemainder(n, prime, magic, shift);
                    if (remainder != n % prime)
                    {
                        Console.WriteLine($"{prime,10}: incorrect {n} {remainder} {n % prime}");
                        return;
                    }
                }

                Console.WriteLine($"{prime,10}: correct");
            }
        }

        private static void GeneratePrimes()
        {
            foreach (var prime in CurrentPrimes)
            {
                var m = magic(prime);
                Console.WriteLine($"new PrimeInfo({m.Prime}, 0x{m.Magic:x8}, {m.Shift}),");
            }

            try
            {
                var prime = ExpandPrime(CurrentPrimes[CurrentPrimes.Length - 1]);
                var i = CurrentPrimes.Length;
                while (true)
                {
                    var m = magic(prime);
                    Console.WriteLine($"new PrimeInfo({m.Prime}, 0x{m.Magic:x8}, {m.Shift}),");
                    prime = ExpandPrime(prime);
                }
            }
            catch { }
            Console.WriteLine();
            Console.WriteLine($"Max allowed: {MaxPrimeArrayLength}");
        }

        public const int HashPrime = 101;

        public static bool IsPrime(int candidate)
        {
            if ((candidate & 1) != 0)
            {
                int limit = (int)Math.Sqrt(candidate);
                for (int divisor = 3; divisor <= limit; divisor += 2)
                {
                    if ((candidate % divisor) == 0)
                        return false;
                }
                return true;
            }
            return (candidate == 2);
        }

        // This is the maximum prime smaller than Array.MaxArrayLength
        public const int MaxPrimeArrayLength = 0x7FEFFFFD;
        // Returns size of hashtable to grow to.
        public static int ExpandPrime(int oldSize)
        {
            int newSize = 2 * oldSize;

            // Allow the hashtables to grow to maximum possible size (~2G elements) before encoutering capacity overflow.
            // Note that this check works even when _items.Length overflowed thanks to the (uint) cast
            if ((uint)newSize > MaxPrimeArrayLength && MaxPrimeArrayLength > oldSize)
            {
                Debug.Assert(MaxPrimeArrayLength == GetPrime(MaxPrimeArrayLength), "Invalid MaxPrimeArrayLength");
                return MaxPrimeArrayLength;
            }

            return GetPrime(newSize);
        }

        public static int GetPrime(int min)
        {
            if (min < 0)
                throw new ArgumentException("Overflow");

            for (int i = 0; i < CurrentPrimes.Length; i++)
            {
                int prime = CurrentPrimes[i];
                if (prime >= min) return prime;
            }

            //outside of our predefined table. 
            //compute the hard way. 
            for (int i = (min | 1); i < Int32.MaxValue; i += 2)
            {
                if (IsPrime(i) && ((i - 1) % HashPrime != 0))
                    return i;
            }
            return min;
        }

        static PrimeInfo magic(int d)
        {   // Must have 2 <= d <= 2**31-1
            // or   -2**31 <= d <= -2.
            int p;
            uint ad, anc, delta, q1, r1, q2, r2, t;
            const uint two31 = 0x80000000; // 2**31.
            PrimeInfo mag = default(PrimeInfo);
            mag.Prime = d;

            ad = (uint)Math.Abs(d);
            t = two31 + ((uint)d >> 31);
            anc = t - 1 - t % ad;     // Absolute value of nc.
            p = 31;                 // Init. p.
            q1 = two31 / anc;         // Init. q1 = 2**p/|nc|.
            r1 = two31 - q1 * anc;    // Init. r1 = rem(2**p, |nc|).
            q2 = two31 / ad;          // Init. q2 = 2**p/|d|.
            r2 = two31 - q2 * ad;     // Init. r2 = rem(2**p, |d|).
            do
            {
                p = p + 1;
                q1 = 2 * q1;           // Update q1 = 2**p/|nc|.
                r1 = 2 * r1;           // Update r1 = rem(2**p, |nc|).
                if (r1 >= anc)
                {     // (Must be an unsigned
                    q1 = q1 + 1;      // comparison here).
                    r1 = r1 - anc;
                }
                q2 = 2 * q2;           // Update q2 = 2**p/|d|.
                r2 = 2 * r2;           // Update r2 = rem(2**p, |d|).
                if (r2 >= ad)
                {      // (Must be an unsigned
                    q2 = q2 + 1;      // comparison here).
                    r2 = r2 - ad;
                }
                delta = ad - r2;
            } while (q1 < delta || (q1 == delta && r1 == 0));

            mag.Magic = q2 + 1u;
            if (d < 0) mag.Magic = (uint)-mag.Magic; // Magic number and
            mag.Shift = p - 32;            // shift amount to return.
            return mag;
        }
    }
}
