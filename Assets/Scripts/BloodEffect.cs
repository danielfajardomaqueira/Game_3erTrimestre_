using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodEffect : MonoBehaviour
{

    public Image bloodyEffect;

    public float r;
    public float g;
    public float b;
    public float a;

    // Start is called before the first frame update
    void Start()
    {
        r = bloodyEffect.color.r;
        g = bloodyEffect.color.g;
        b = bloodyEffect.color.b;
        a = bloodyEffect.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.P))
        //{
            //a += 0.1f;
        //}

        //a -= 0.001f;
        //a = Mathf.Clamp(a, 0, 1f);
        //ChangeColor();
    }

    //private void ChangeColor()
    //{
        //Color c = new Color(r, g, b, a);
        //bloodyEffect.color = c;
    //}

    public IEnumerator Blood()
    {
        bloodyEffect.enabled = true;

        for (a=1; a>=0; a -= 0.1f)
        {
            
            
            Color c = new Color(r, g, b, a);
            bloodyEffect.color = c;
            yield return new WaitForSeconds(0.2f);
        }
    bloodyEffect.enabled = false;
    }
}
