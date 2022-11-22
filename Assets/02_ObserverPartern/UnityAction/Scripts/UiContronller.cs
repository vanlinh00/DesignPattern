using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiContronller : MonoBehaviour
{
    [SerializeField] Button _testButton;
    private void Awake()
    {
        _testButton.onClick.AddListener(ClickBtn);
    }
    public void ClickBtn()
    {
        EventManager.OnButtonClick();
    }


}
