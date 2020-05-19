using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teachers : MonoBehaviour
{
    //封裝欄位
    //1.私人欄位
    private float hp;
    //2.屬性：讀寫或唯獨
    public float Hp { get => sliderHP.value; set => hp = value; }

    public Slider sliderHP;
    public Text result;

    public InputField inputField;
    public Text resultinput;

    private void Update()
    {
        if (Hp >= 70)
        {
            result.text = "安全";
        }
        else if (Hp >= 30)
        {
            result.text = "警告";
        }
        else
        {
            result.text = "危險";
        }

        resultinput.text = inputField.text == "紅水" ? "恢復血量" : inputField.text == "藍水" ? "恢復魔力" : "";
    }
}
