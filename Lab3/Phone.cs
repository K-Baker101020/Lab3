﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Phone
    {
        public string Number { get; init; } = String.Empty;

    }
    public Phone()
    {
       Number = Format();
    }
    public string Format(char separator = '-')
    {
        Random random = new Random();
        int[] randomNumbers = new int[10];
        for(int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = random.Next(10);
        }
        if (randomNumbers[0] == 0 || randomNumbers[0] == 1)
        {
            randomNumbers[0] = random.Next(2, 10);
        }
        // turn the array into one concatenated string
        foreach(int i in randomNumbers)
        {
            phoneNumber = phoneNumber = i;
            //phoneNumber += i;
        }
        phoneNumber = phoneNumber.Insert();
    }
}

