using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newOnClick : MonoBehaviour
{
    public Button CustomButton;
    // Start is called before the first frame update
    void Awake()
    {
        Button button = CustomButton.GetComponent<Button>();
        button.onClick.AddListener(CustomButton_onClick);
    }

    // Update is called once per frame
    void CustomButton_onClick()
    {
        Debug.Log("test");
    }
}
