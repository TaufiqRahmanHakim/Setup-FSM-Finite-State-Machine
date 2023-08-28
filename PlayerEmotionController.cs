public class PlayerEmotionController : MonoBehaviour
{
    private IEmotionState currentState;

    private void Start()
    {
        currentState = new NormalState(); // State awal
        currentState.EnterState();
    }

    private void Update()
    {
        // Logika untuk mengganti state berdasarkan input atau kondisi tertentu
    }
}