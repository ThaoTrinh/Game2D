
/*using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadfile {

      // Use this for initialization
      public static string filepath;
      public static int savepoint;

      // on object creation
      public Loadfile()
      {
            if (readfile())
            {
                  Debug.Log("File read successfully");
            }
            else
            {
                  Debug.Log("File regenerated successfully");
            }
      }

      public string GetUserPath() 
      {
            return Environment
                  .GetFolderPath(
                     Environment.SpecialFolder.MyDocuments);
      }

      public bool readfile()
      {
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
                  return false;
            }

            using (StreamReader sr = File.OpenText(filepath))
            {
                  var str = sr.ReadLine();
                  savepoint = Int.Parse(str);
            }
            return true;
      }

      // rewrite the file on exit
      void OnApplicationQuit()
      {
            using (StreamWriter sw = new StreamWriter(Loadfile.filepath))
            {
                  string data = savepoint.ToString();
                  sw.WriteLine(data);
            }
            Debug.Log("File writeback success");
      }

      [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
      void Start ()
      {
            // empty because object is done creating
      }

      // Update is called once per frame
      void Update ()
      {
      }
}/* */
