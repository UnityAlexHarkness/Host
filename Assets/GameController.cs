using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject Game1Button;
    public AssetReference Game1;

    public GameObject Game2Button;
    public AssetReference Game2;
    

    public void LoadGame1()
    {
        Game1Button.SetActive(false);
        Game2Button.SetActive(false);

        Addressables.LoadSceneAsync(Game1);
    }

    public void LoadGame2()
    {
        Game1Button.SetActive(false);
        Game2Button.SetActive(false);

        Addressables.LoadSceneAsync(Game2);
    }
}
