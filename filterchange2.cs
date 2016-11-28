using UnityEngine;
using System.Collections;

public class filterchange2 : MonoBehaviour
{
    public bool connect = false;
    public bool bonnetpermit = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v;
        v = transform.localPosition;
        filterchange ff = GameObject.Find("newfilter").GetComponent<filterchange>();
        BonnetUp bonn = GameObject.Find("Bonnet").GetComponent<BonnetUp>();
        if (ff.connect == true)
        {
            if ((transform.localPosition.x >= -10.0f && transform.localPosition.x <= -8.0f) && (transform.localPosition.y >= 1.0f && transform.localPosition.y <= 3.0f) && (transform.localPosition.z >= -100.0f && transform.localPosition.z <= -98.0f))
            {
                connect = true;
            }
            //해당 오브젝트의 포지션값을 v에 넣고
            if (connect == true)
            {
                v.x = -9.578f;//원하는 값을 입력
                v.y = 2.184f;
                v.z = -99.127f;
                transform.localPosition = v;
                transform.rotation = Quaternion.Euler(0.4816588f, 359.7331f, 0.6789147f);
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                bonnetpermit = true;
                bonn.bnu = false;
                //Destroy(this.GetComponent<BoxCollider>());
            }
        }
    }
}