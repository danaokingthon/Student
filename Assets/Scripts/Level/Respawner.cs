using System.Collections;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] Gem gemPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float respawnDelay;

    void OnEnable()
    {
        GameEvents.OnTargetDestroyed += RespawnGem;
    }

    void OnDisable()
    {
        GameEvents.OnTargetDestroyed -= RespawnGem;
    }

    //Recibe evento cuando destruye un objeto
    void RespawnGem(GameItem gameItem)
    {
        //Comprueba que sea gema
        if (gameItem == GameItem.Gem)
        {
            StartCoroutine(RespawnGemCoroutine());
        }
    }

    //Espera y crea nueva gema
    IEnumerator RespawnGemCoroutine()
    {
        yield return new WaitForSeconds(respawnDelay);

        Instantiate(
            gemPrefab,
            spawnPoint.position,
            spawnPoint.rotation
        );
    }
}
