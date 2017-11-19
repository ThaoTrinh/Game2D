using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonControl : MonoBehaviour {

 
	public static string str;
	public static string filepath;

	public static string GetUserPath() 
	{
		return Environment
			.GetFolderPath(
			   Environment.SpecialFolder.MyDocuments);
	}


	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	void Start () {
			string folderpath = GetUserPath() + "/Strong Girl";

		
			if (!Directory.Exists(folderpath))
			{
				Directory.CreateDirectory(folderpath);
			}

		 filepath = folderpath + "/Loadlevel.txt";
		if (!File.Exists(filepath))
		{

			using (FileStream fs = File.Create(filepath))
			{
				Byte[] info = new UTF8Encoding(true)
						 .GetBytes("1");
				fs.Write(info, 0, info.Length);
			}
		}

			using (StreamReader sr = File.OpenText(filepath))
			{
				 str = sr.ReadLine();
			
			}

	}
	public ButtonControl.ButtonType bt;

	public ButtonControl(){}

	private void OnMouseDown()
	{
		transform.localScale = new Vector3(250f, 250f);

	}
	

	private void OnMouseUp()
	{

		if(bt==ButtonControl.ButtonType.btPlay){
			ScoreManager.score = 0;
			Application.LoadLevel("LevelScreen");
		
		}

		  if (bt == ButtonControl.ButtonType.btContinue)
        {
			
            Application.LoadLevel("mainLevel");
            
        }

		if (bt == ButtonControl.ButtonType.btGuide)
        {
            Application.LoadLevel("guideScreen");
            
        }

		if(bt==ButtonControl.ButtonType.btLevel1){
			Application.LoadLevel("Level1");
	
		}

		int level = int.Parse(str);
		if(bt==ButtonControl.ButtonType.btLevel2){
			if(level > 1)
			Application.LoadLevel("Level2");
		}

		if(bt==ButtonControl.ButtonType.btLevel3){
			if(level > 2)
			Application.LoadLevel("Level3");
		}

		if(bt==ButtonControl.ButtonType.btLevel4){
			if(level > 3)
			Application.LoadLevel("Level4");
		}
      

		if (bt == ButtonControl.ButtonType.Door)
        {
            Application.LoadLevel("Level2");
			if(level<2){
				using (StreamWriter sw = new StreamWriter(filepath)){
					string data = "2";
					sw.WriteLine(data);
				}
			}
			
        }

		if (bt == ButtonControl.ButtonType.Door2)
        {
            Application.LoadLevel("Level3");
			if(level<3){
			using (StreamWriter sw = new StreamWriter(filepath)){
				string data = "3";
				sw.WriteLine(data);
			}
			}
        }

		if (bt == ButtonControl.ButtonType.Door3)
        {
            Application.LoadLevel("Level4");
			if(level<4){
			using (StreamWriter sw = new StreamWriter(filepath)){
				string data = "4";
				sw.WriteLine(data);
			}
			}
        }

		if (bt == ButtonControl.ButtonType.khobau)
        {
            Application.LoadLevel("winner");
        }

		if (bt == ButtonControl.ButtonType.exit)
        {
            Application.Quit();
        }
    }
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
		exit,
		btGuide
	}
}
