public class Clock : PickUp
{
    public bool AddTime;
    public int Time = 5;

    public override void Picked()
    {
        int sign = AddTime ? 1 : -1;
        GameManager.Instance.AddTime(Time * sign);
        Destroy(gameObject);
    }
 
    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
}
