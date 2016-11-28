using UnityEngine;
using System.Collections;

public class RotateBonnetHook : MonoBehaviour {

	public int cnt;
	public bool connectHand;
	private Vector3 bonnetHookVector;
	private Quaternion bonnetHookQuaternion;
	private Rotate bonnetRotate;



	void Start () {
		bonnetHookVector = new Vector3(8006.2f, -13301.95f, 23068.6f);
		bonnetHookQuaternion = new Quaternion(0.0f, 0.0f, 290.0f,0.0f);
		bonnetHookRotate = new Rotate(0, -70.0f);
		cnt = 0;
		connectHand = false;
	}

	void Update () {
		Vector3 v = transform.position;
		Quaternion q = transform.rotation;

		if (connectHand)
		{
			if (cnt == 0)
			{
				v = bonnetHookVector;
				q = bonnetHookQuaternion;
				cnt++;

				this.GetComponent<Rigidbody>().isKinematic = false;
				GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
				BonnetUp bu = GameObject.Find("Bonnet").GetComponent<BonnetUp>();
				bu.Bonnetup();
				GameObject boxcoll = GameObject.Find("HandController");
				BoxCollider bc = boxcoll.GetComponent<BoxCollider>();
				bc.gameObject.SetActive(false);
			}
		}
	}  
	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "hand")
		{
			connectHand = true;       
		}
	}
}








