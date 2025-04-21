class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length -1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        bool birdsInDay = false;

        foreach (var birds in birdsPerDay)
        {
            if (birds == 0)
            {
                birdsInDay =  true;
            }
        }
        return birdsInDay;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        //validate that we do not have more than seven days in a week
        if (numberOfDays > 7)
            return -1;

        int numberOfBirds = 0;

        for (int dayCount = 0; dayCount < numberOfDays; dayCount++)
        {
            numberOfBirds += birdsPerDay[dayCount];
        }
        return numberOfBirds;
    }

    public int BusyDays()
    {
        int busyDays = 0;

        foreach (int day in birdsPerDay) 
        {
            if(day >= 5)
                busyDays++;
        }
        return busyDays;
    }
}
