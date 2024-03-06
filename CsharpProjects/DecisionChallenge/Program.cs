Random random = new Random();

int daysUntilExpiration = random.Next(12);

int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days./n Renew now and save {discountPercentage}%!")
    }
    else if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your subscription will expire in within a day./n Renew now and save {discountPercentage}%!")
    }
    else if (daysUntilExpiration == 0)
    {
        Console.WriteLine($"Your subscription expired")
    }
    Console.WriteLine($"Your subscription will expire soon. Renew now!")
}