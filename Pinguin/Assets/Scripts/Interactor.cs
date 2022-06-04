public class Interactor
{
    public virtual void OnCreate() { }  // Когда все репо и интерактры созданы.
    public virtual void Initialize() { } // Когда все репо и интеракторы сделали OnCreate().
    public virtual void OnStart() { } // Когда все репо и интеракторы Initialize().
}


