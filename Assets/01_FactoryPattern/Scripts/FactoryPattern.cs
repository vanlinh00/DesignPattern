using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FactoryPattern : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var factory = new ConcreteCreator();

        INetwork viettel = factory.Create(NetworkType.VIETTEL);

        /// tham chiếu đến đối tượng mới được tạo ra bằng cách sử dụng một interface chung.
        Debug.Log(viettel.GetNameNetWork());
        Debug.Log(viettel.GetCarrierNumber());
        Debug.Log("===========================================");
        INetwork mobiphone = factory.Create(NetworkType.MOBIFONE);

        Debug.Log(mobiphone.GetNameNetWork());
        Debug.Log(mobiphone.GetCarrierNumber());
        Debug.Log("===========================================");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
