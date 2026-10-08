// Displays the required welcome message to the user.
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Asks the user to enter the package weight.
Console.WriteLine("Please enter the package weight:");

// Reads the package weight and converts the input from text to a decimal number.
decimal weight = Convert.ToDecimal(Console.ReadLine());

// Checks whether the package weight is greater than 50.
if (weight > 50)
{
    // Displays the required error message when the package is too heavy.
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

    // Stops the program because the package cannot be shipped.
    return;
}

// Asks the user to enter the package width.
Console.WriteLine("Please enter the package width:");

// Reads the package width and converts the input to a decimal number.
decimal width = Convert.ToDecimal(Console.ReadLine());

// Asks the user to enter the package height.
Console.WriteLine("Please enter the package height:");

// Reads the package height and converts the input to a decimal number.
decimal height = Convert.ToDecimal(Console.ReadLine());

// Asks the user to enter the package length.
Console.WriteLine("Please enter the package length:");

// Reads the package length and converts the input to a decimal number.
decimal length = Convert.ToDecimal(Console.ReadLine());

// Adds the width, height, and length together to find the total package dimensions.
decimal totalDimensions = width + height + length;

// Checks whether the total dimensions are greater than 50.
if (totalDimensions > 50)
{
    // Displays the required error message when the package is too large.
    Console.WriteLine("Package too big to be shipped via Package Express.");

    // Stops the program because the package cannot be shipped.
    return;
}

// Multiplies the height, width, and length to calculate the package volume.
decimal volume = height * width * length;

// Multiplies the package volume by the package weight.
decimal shippingTotal = volume * weight;

// Divides the shipping calculation by 100 to determine the shipping quote.
decimal shippingQuote = shippingTotal / 100;

// Displays the shipping quote with a dollar sign and exactly two decimal places.
Console.WriteLine($"Your estimated total for shipping this package is: ${shippingQuote:F2}");

// Displays the required thank-you message.
Console.WriteLine("Thank you!");
