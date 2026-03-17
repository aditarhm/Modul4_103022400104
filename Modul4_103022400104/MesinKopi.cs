using System;

class MesinKopi
{
    enum State
    {
        OFF,
        STANDBY,
        BREWING,
        MAINTENANCE
    }

    private State currentState;

    public MesinKopi()
    {
        currentState = State.OFF;
    }

    public void PowerOn()
    {
        if (currentState == State.OFF)
        {
            currentState = State.STANDBY;
            Console.WriteLine("Mesin Off berubah menjadi Standby");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void PowerOff()
    {
        if (currentState == State.STANDBY)
        {
            currentState = State.OFF;
            Console.WriteLine("Mesin Standby berubah menjadi Off");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void StartBrew()
    {
        if (currentState == State.STANDBY)
        {
            currentState = State.BREWING;
            Console.WriteLine("Mesin Standby berubah menjadi Brewing");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void FinishBrew()
    {
        if (currentState == State.BREWING)
        {
            currentState = State.STANDBY;
            Console.WriteLine("Mesin Brewing berubah menjadi Standby");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void StartMaintenance()
    {
        if (currentState == State.STANDBY)
        {
            currentState = State.MAINTENANCE;
            Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void FinishMaintenance()
    {
        if (currentState == State.MAINTENANCE)
        {
            currentState = State.STANDBY;
            Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }
}