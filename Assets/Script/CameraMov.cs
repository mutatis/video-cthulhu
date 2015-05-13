using UnityEngine;
using System.Collections;

public class CameraMov : MonoBehaviour {

	public float velY;
	public bool desce;
	public Transform pos;
	public int num = 0;
	public Animator anim;
	public cena1 cena;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Time.timeScale = 1;
		}
		if(desce && pos.position.y < transform.position.y && num == 0)
		{
			transform.Translate(0, velY, 0);
		}
		/*if(desce && pos.position.y > transform.position.y && num == 1)
		{
			transform.Translate(0, (velY * -1) / 4, 0);
		}*/
		else if(num == 1)
		{
			StartCoroutine("Go");
			num = 2;
		}
		if(pos.position.y > transform.position.y)
		{
			num = 1;
		}
	}

	IEnumerator Go()
	{
		yield return new WaitForSeconds(3.5f);
		cena.ok = true;
		anim.enabled = true;
	}
}
