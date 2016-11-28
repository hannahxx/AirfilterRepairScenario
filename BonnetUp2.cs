using UnityEngine;
using System.Collections;

public class BonnetUp2 : MonoBehaviour {
    public int cnt = 0, cnt2 = 0;
    public bool a = true;

   
	// Use this for initialization
	void Start () {
	
	}
    public void Bonnetdown()
    {
        filterchange2 permission = GameObject.Find("airfiltertop").GetComponent<filterchange2>();
        BonnetUp bon = GameObject.Find("Bonnet").GetComponent<BonnetUp>();
        if (permission.bonnetpermit)
        {
            if (cnt2 < 20)
            {
                transform.Rotate(2.0f, 0, 0);
                cnt2++;
            }
            if (cnt2 ==20&&a)
            {
               bon.transform.Translate(new Vector3(0, -0.2f, 0));
               a = false;
            }
        }
    }
    public void Bonnetup2()
    {
        if (cnt < 20)
        {
            transform.Rotate(-2.0f, 0, 0);
            cnt++;
        }
       
    }
	// Update is called once per frame
	void Update () {
	
	}
}
