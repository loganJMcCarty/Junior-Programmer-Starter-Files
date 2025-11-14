using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour

{
   //enables you to access the mainmanager object from any other script.
    public static MainManager Instance;

    public Color TeamColor;

    private void Awake()
    {
       if (Instance != this);
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
[System.Serializable]
class SaveData
{
    public Color TeamColor;
}

public void SaveColor()
{
    SaveData data = new SaveData();
    data.TeamColor = TeamColor;

    string json = JsonUtility.ToJson(data);

    File.WriteAllText(Application.persistentDataPath + "/saveFile.json", json);
}
