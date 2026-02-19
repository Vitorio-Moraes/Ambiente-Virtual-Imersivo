using UnityEngine;

public class ResetBolas : MonoBehaviour
{
    [Header("Bolinhas (Arrastar os Rigidbodies aqui)")]
    public Rigidbody rbPingPong;
    public Rigidbody rbBasquete;

    [Header("Locais de Respawn (Arrastar os Empties aqui)")]
    public Transform spawnPointPingPong;
    public Transform spawnPointBasquete;

    public void ResetarTudo()
    {
        // Reseta Ping Pong
        ResetarIndividual(rbPingPong, spawnPointPingPong);

        // Reseta Basquete
        ResetarIndividual(rbBasquete, spawnPointBasquete);
    }

    private void ResetarIndividual(Rigidbody bola, Transform local)
    {
        // 1. Para a física (zera velocidade e rotação)
        bola.linearVelocity = Vector3.zero;
        bola.angularVelocity = Vector3.zero;

        // 2. Move para o local de origem
        bola.transform.position = local.position;
        bola.transform.rotation = local.rotation;
    }
}