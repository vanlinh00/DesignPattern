using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 2 SubClass
class Mobifone : INetwork
{
    public string CheckAccountMoney()
    {
        return "*101#";
    }

    public string GetCarrierNumber()
    {
        return "090, 093, 0120, 0121, 0122, 0126, 0128, 089";
    }

    public string GetNameNetWork()
    {
        return "MOBIFONE";
    }
}