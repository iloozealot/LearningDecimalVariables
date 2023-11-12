//stores out to 28 digits before rounding that's why decimal is used for money

decimal bankAccountBalance;

bankAccountBalance = 2.34; //this doesn't work because 2.34 is a double type
bankAccountBalance = 2.34M;// by putting the capital M at the end it indicates that the number in front of it is a decimal


Console.WriteLine(bankAccountBalance);
