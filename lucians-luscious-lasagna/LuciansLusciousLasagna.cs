class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    // returns how many minutes the lasagna should be in the oven.
    // According to the cooking book, the expected oven time in minutes is 40
    public int ExpectedMinutesInOven()
    {
        return 40;
        
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    //  returns how many minutes the lasagna still has to remain in the oven,
    //  based on the expected oven time in minutes from the previous task
    public int RemainingMinutesInOven(int minutesInOven)
    {
        int ExpectedMinutesInOven() - minutesInOven; 
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    // returns how many minutes you spent preparing the lasagna
    // assuming each layer takes you 2 minutes to prepare
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    // return how many minutes you've worked on cooking the lasagna,
    // which is the sum of the preparation time in minutes,
    // and the time in minutes the lasagna has spent in the oven at the moment.
    public int ElapsedTimeInMinutes(int layersAdded, int minutesInOver)
    {
        return PreparationTimeInMinutes(layersAdded) + minutesInOver; 
    }
}
