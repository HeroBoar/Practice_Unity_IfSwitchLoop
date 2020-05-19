using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.UI;

public class practice5 : MonoBehaviour
{
    public Slider slider;
    public float hp;
    public Text text,text1;
    public InputField water;
    public GameObject cube;
    private int x = 1;
    private int y = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < (i + 1); j++)
            {
                Vector3 pos = new Vector3(i * 2, j * 2, 25);
                Instantiate(cube, pos, Quaternion.identity);
            }            
        }
    }

    // Update is called once per frame
    void Update()
    {
        hp = slider.value;
        if (hp >= 70)
        {
            //print("安全");
            text.text = "安全";
        }
        else if (hp >= 30)
        {
            text.text = "警告";
        }
        else
        {
            text.text = "危險";
        }

        text1.text = water.text == "紅水" ? "恢復血量" : water.text == "藍水" ? "恢復魔力" : "";

    }
}
