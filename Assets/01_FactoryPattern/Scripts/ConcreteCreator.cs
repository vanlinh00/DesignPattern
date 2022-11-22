using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//3 factory class
class ConcreteCreator : NetworkFactory
{
    public override INetwork Create(NetworkType type)
    {
        switch (type)
        {
            case NetworkType.VIETTEL:
                return new Viettel();

            case NetworkType.MOBIFONE:
                return new Mobifone();
            default:
                //  throw new ArgumentException("Invalid type", "type");
                return null;

        }
    }
}