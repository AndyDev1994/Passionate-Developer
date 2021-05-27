using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pickup : MonoBehaviour 
{
	public GameObject inventoryPanel;
	public GameObject[] inventoryIcons;

	void OnCollisionEnter(Collision collision)
	{
		 //look through children for existing icon
		 foreach(Transform child in inventoryPanel.transform)
		 {
		 	//if item already in inventory
		 	if(child.gameObject.tag == collision.gameObject.tag)
		 	{
		 		string c = child.Find("Text").GetComponent<Text>().text;
		 		int tcount = System.Int32.Parse(c) + 1;
	  			child.Find("Text").GetComponent<Text>().text = "" + tcount;
		 		return;
		 	}
		 }


		 GameObject i;
		 if(collision.gameObject.tag == "red")
		 {
		 	i = Instantiate(inventoryIcons[0]);
		 	i.transform.SetParent(inventoryPanel.transform);
		     
		}

		if(collision.gameObject.tag == "green")
		{
			i = Instantiate(inventoryIcons[1]);
			i.transform.SetParent(inventoryPanel.transform);

		}

		if(collision.gameObject.tag == "blue")
		{
			i = Instantiate(inventoryIcons[2]);
			i.transform.SetParent(inventoryPanel.transform);

		}

		if(collision.gameObject.tag == "violet")
		{
			i = Instantiate(inventoryIcons[3]);
			i.transform.SetParent(inventoryPanel.transform);

		}
		 
	}

}
