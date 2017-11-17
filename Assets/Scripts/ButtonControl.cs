using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ButtonControl : MonoBehaviour {


	public ButtonControl.ButtonType bt;

	public ButtonControl(){}

	private void OnMouseDown()
	{
		transform.localScale = new Vector3(250f, 250f);

	}

	private void OnMouseUp()
	{
		//transform.localScale = new Vector3(0.5f,0.5f);
		string str ;
		
		if(bt==ButtonControl.ButtonType.btPlay){
			Application.LoadLevel("LevelScreen");
			//return;
		}

		  if (bt == ButtonControl.ButtonType.btContinue)
        {
            Application.LoadLevel("mainLevel");
            //	return;
        }

		if(bt==ButtonControl.ButtonType.btLevel1){
			Application.LoadLevel("Level1");
		//	return;
		}

		using (StreamReader sr = new StreamReader("Loadlevel.txt")){
			str = sr.ReadLine();
		}

		int level = int.Parse(str);
		if(bt==ButtonControl.ButtonType.btLevel2){
			if(level > 1)
			Application.LoadLevel("Level2");
			//return;
		//	return;
		}

		if(bt==ButtonControl.ButtonType.btLevel3){
			if(level > 2)
			Application.LoadLevel("Level3");
			//return;
		//	return;
		}

		if(bt==ButtonControl.ButtonType.btLevel3){
			if(level > 3)
			Application.LoadLevel("Level4");
			//return;
		//	return;
		}
      

		if (bt == ButtonControl.ButtonType.Door)
        {
            Application.LoadLevel("Level2");
			using (StreamWriter sw = new StreamWriter("Loadlevel.txt")){
				string data = "2";
				sw.WriteLine(data);
			}
            //	return;
        }

		if (bt == ButtonControl.ButtonType.Door2)
        {
            Application.LoadLevel("Level3");
			using (StreamWriter sw = new StreamWriter("Loadlevel.txt")){
				string data = "3";
				sw.WriteLine(data);
			}
            //	return;
        }

		if (bt == ButtonControl.ButtonType.Door3)
        {
            Application.LoadLevel("Level4");
			using (StreamWriter sw = new StreamWriter("Loadlevel.txt")){
				string data = "4";
				sw.WriteLine(data);
			}
            //	return;
        }

		if (bt == ButtonControl.ButtonType.khobau)
        {
            Application.LoadLevel("winner");
			
            //	return;
        }

		if (bt == ButtonControl.ButtonType.exit)
        {
            Application.Quit();
			
            //	return;
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public enum ButtonType{
		btPlay,
		btLevel1,
		btLevel2,
		btLevel3,
		btLevel4,
        btContinue,
		Door,
		Door2,
		Door3,
		khobau,
		exit
	}
}
