# Primes
Prime generators

generate
```
C:\GitHub\Primes>dotnet run -c Release generate
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
new PrimeInfo(2146435069, 0x20040081, 28),

Max allowed: 2146435069
```
verify
```
C:\GitHub\Primes>dotnet run -c Release verify
         3: correct
         7: correct
        11: correct
        17: correct
        23: correct
        29: correct
        37: correct
        47: correct
        59: correct
        71: correct
        89: correct
       107: correct
       131: correct
       163: correct
       197: correct
       239: correct
       293: correct
       353: correct
       431: correct
       521: correct
       631: correct
       761: correct
       919: correct
      1103: correct
      1327: correct
      1597: correct
      1931: correct
      2333: correct
      2801: correct
      3371: correct
      4049: correct
      4861: correct
      5839: correct
      7013: correct
      8419: correct
     10103: correct
     12143: correct
     14591: correct
     17519: correct
     21023: correct
     25229: correct
     30293: correct
     36353: correct
     43627: correct
     52361: correct
     62851: correct
     75431: correct
     90523: correct
    108631: correct
    130363: correct
    156437: correct
    187751: correct
    225307: correct
    270371: correct
    324449: correct
    389357: correct
    467237: correct
    560689: correct
    672827: correct
    807403: correct
    968897: correct
   1162687: correct
   1395263: correct
   1674319: correct
   2009191: correct
   2411033: correct
   2893249: correct
   3471899: correct
   4166287: correct
   4999559: correct
   5999471: correct
   7199369: correct
  14398753: correct
  28797523: correct
  57595063: correct
 115190149: correct
 230380307: correct
 460760623: correct
 921521257: correct
1843042529: correct
2146435069: correct

```