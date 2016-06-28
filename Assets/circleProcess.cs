using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class circleProcess : MonoBehaviour {
	
	[SerializeField]
	float speed;
	
	[SerializeField]
	Transform process;
	
	[SerializeField]
	Transform indicator;
	
	public int targetProcess{ get; set;}
	private float currentAmout = 0;
	
	// Use this for initialization
	void Start () {
		targetProcess = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (currentAmout < targetProcess) {
			Debug.Log("currentAmount:" + currentAmout.ToString());
			
			currentAmout += speed;
			if(currentAmout > targetProcess)
				currentAmout = targetProcess;
			indicator.GetComponent<Text>().text = ((int)currentAmout).ToString() + "%";
			process.GetComponent<Image>().fillAmount = currentAmout/100.0f;
		}
		
	}
	
	
	public void SetTargetProcess(int target)
	{
		if(target >= 0 && target <= 100)
			targetProcess = target;
	}

}
