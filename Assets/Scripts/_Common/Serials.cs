using UnityEngine;

public class Serials
{
  [System.Serializable]
  public class Player : System.Object
  {
    public string name;
    // public ??? runs;
  }

  [System.Serializable]
  public class SourcesAccount : System.Object
  {
    public string question;
    public string discovered;
  }

  [System.Serializable]
  public class SourcesCommon : System.Object
  {
    public int account;
    public string scene;
    public string lang;
  }

  [System.Serializable]
  public class LangsHeader : System.Object
  {
    public string settings;
    public string exit;
  }
}
