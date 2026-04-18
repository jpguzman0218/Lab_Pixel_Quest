using UnityEngine;
using UnityEngine.SceneManagement; 

public class EPICWIN : MonoBehaviour
{
  public string startScene; 
   public void Loadlevel() {
        SceneManager.LoadScene(startScene);
    }


    public void QuitGame() {
        Application.Quit(); 
    }
}
