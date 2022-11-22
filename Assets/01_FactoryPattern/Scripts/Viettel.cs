using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2 Sub class 
class Viettel : INetwork
{
    public string CheckAccountMoney()
    {
        return "*101#";
    }

    public string GetCarrierNumber()
    {
        return "086, 096, 097, 098, 032, 033, 034, 035, 036, 037, 038, 039";
    }

    public string GetNameNetWork()
    {
        return "VIETTEL";
    }

}