using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject currentWorld;
    public Material newSkybox;

    public void ChangeWorld(GameObject newWorld)
    {
        newSkybox = newWorld.GetComponent<Renderer>().material;
        RenderSettings.skybox = newSkybox;
        DynamicGI.UpdateEnvironment();
        currentWorld.SetActive(false);
        currentWorld = newWorld;
        newWorld.SetActive(true);
    }
}