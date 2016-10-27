using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

    public GameObject logicObject;
    public GameObject Light1;
	public GameObject Light2;
	public GameObject Light3;
	public GameObject Light4;
	public GameObject Light5;
    private float RMSvalue;


	// Use this for initialization
	void Start () 
	{
		
	}

	void Update () 
	{
		AudioMeasureCS audiomeasureCS = logicObject.GetComponent<AudioMeasureCS>();
		RMSvalue = audiomeasureCS.RmsValue;

		if(RMSvalue>0.01)
		{
			Light1.GetComponent<SpriteRenderer>().color = new Color(RMSvalue,0.8f,0.2f,RMSvalue+0.8f);
		}
		else
			Light1.GetComponent<SpriteRenderer>().color = new Color(0.6f,0f,0.2f,1.0f);

		if(RMSvalue>0.03f)
		{
			Light2.GetComponent<SpriteRenderer>().color = new Color(RMSvalue,0.8f,0.2f,RMSvalue+0.8f);
		}
		else
			Light2.GetComponent<SpriteRenderer>().color = new Color(0.6f,0f,0.2f,1.0f);
	
		if(RMSvalue>0.06f)
		{
			Light3.GetComponent<SpriteRenderer>().color = new Color(RMSvalue,0.8f,0.2f,RMSvalue+0.8f);
		}
		else
			Light3.GetComponent<SpriteRenderer>().color = new Color(0.6f,0f,0.2f,1.0f);
		
		if(RMSvalue>0.09f)
		{
			Light4.GetComponent<SpriteRenderer>().color = new Color(RMSvalue,0.8f,0.2f,RMSvalue+0.8f);
		}
		else
			Light4.GetComponent<SpriteRenderer>().color = new Color(0.6f,0f,0.2f,1.0f);

		if(RMSvalue>0.12f)
		{
			Light5.GetComponent<SpriteRenderer>().color = new Color(RMSvalue,0.8f,0.2f,RMSvalue+0.8f);
		}
		else
			Light5.GetComponent<SpriteRenderer>().color = new Color(0.6f,0f,0.2f,1.0f);
	}
}
