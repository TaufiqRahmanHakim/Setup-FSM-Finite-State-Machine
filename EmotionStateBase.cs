public abstract class EmotionStateBase : IEmotionState
{
    public virtual void EnterState()
    {
        Debug.Log("Entering emotion state: " + GetType().Name);
    }

    public virtual void UpdateState()
    {
        Debug.Log("Updating emotion state: " + GetType().Name);
    }

    public virtual void ExitState()
    {
        Debug.Log("Exiting emotion state: " + GetType().Name);
    }
}