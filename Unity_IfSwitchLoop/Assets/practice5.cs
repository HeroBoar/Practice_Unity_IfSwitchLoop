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
    public int why;
    public bool red;
    public GameObject cube;
    private int x = 1;
    private int y = 1;
    public void CreateCube(int length, int width)
    {
        for (int i = 0; i < length; i++)
        {
            Instantiate(cube, new Vector3(i * 2, 0, 0), Quaternion.Euler(270, 0, 0));
        }
    }

    private void Awake()
    {
        CreateCube(10,0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
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

        switch (water.text)
        {
            case "紅水":
                why = 0;
                break;
            case "藍水":
                why = 1;
                break;
        }
       
        //red = (why = 0) ? text1.text = "恢復血量" : text1.text = "恢復魔力";

    }
}
