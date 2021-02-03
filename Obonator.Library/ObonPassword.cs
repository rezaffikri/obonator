using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Obonator.Library
{
    public class ObonPassword
    {
        const int MAXIMUM_IDENTICAL_CONSECUTIVE_CHARS = 2;
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERS = "0123456789";
        const string SPECIALS = @"!@£$%^&*()#€";
        const string AMBIGOUS = "{}[]/\'\"`~,;:.<>";
        const string SPACES = " ";


        /// <summary>
        /// Generates a random password based on the rules passed in the parameters
        /// </summary>
        /// <param name="passwordLength">Length of password required. Should be between 8 and 128</param>
        /// <param name="useLowercase">Bool to say if lowercase are required</param>
        /// <param name="useUppercase">Bool to say if uppercase are required</param>
        /// <param name="useNumbers">Bool to say if numerics are required</param>
        /// <param name="useSpecials">Bool to say if special characters are required</param>
        /// <param name="useAmbiguous">Bool to say if ambigous character are required</param>
        /// <param name="addSpaces">Bool to say if spaces are required</param>
        /// <returns></returns>
        public static string GenerateRandomPasswordVer1(int passwordLength, bool useLowercase, bool useUppercase, bool useNumbers,
            bool useSpecials, bool useAmbiguous, bool addSpaces)
        {
            char[] password = new char[passwordLength];
            string charSet = ""; // Initialise to blank

            // Build up the character set to choose from
            if (useLowercase) charSet += LOWER_CASE;

            if (useUppercase) charSet += UPPER_CASE;

            if (useNumbers) charSet += NUMBERS;

            if (useSpecials) charSet += SPECIALS;

            if (useAmbiguous) charSet += AMBIGOUS;

            if (addSpaces) charSet += SPACES;

            // Because we cannot use the default randomizer, which is based on the current time 
            // (it will produce the same "random" number within a second), we will use a random number 
            // generator to seed the randomizer. Use a 4-byte array to fill it with random bytes and convert
            // it then to an integer value.
            var randomBytes = new byte[4];

            // Generate 4 random bytes.
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);

            // Convert 4 bytes into a 32-bit integer value.
            var seed = (randomBytes[0] & 0x7f) << 24 |
                       randomBytes[1] << 16 |
                       randomBytes[2] << 8 |
                       randomBytes[3];

            // Now, this is real randomization.
            var random = new System.Random(seed);


            for (int characterPosition = 0; characterPosition < passwordLength; characterPosition++)
            {
                password[characterPosition] = charSet[random.Next(charSet.Length - 1)];
                bool moreThanTwoIdenticalInARow =
                    characterPosition > MAXIMUM_IDENTICAL_CONSECUTIVE_CHARS
                    && password[characterPosition] == password[characterPosition - 1]
                    && password[characterPosition - 1] == password[characterPosition - 2];

                if (moreThanTwoIdenticalInARow)
                {
                    characterPosition--;
                }
            }

            return string.Join(null, password);
        }

        /// <summary>
        /// Generates a random password based on the rules passed in the parameters
        /// </summary>
        /// <param name="passwordLength">Length of password required. Should be between 8 and 128</param>
        /// <param name="useLowercase">Bool to say if lowercase are required</param>
        /// <param name="useUppercase">Bool to say if uppercase are required</param>
        /// <param name="useNumbers">Bool to say if numerics are required</param>
        /// <param name="useSpecials">Bool to say if special characters are required</param>
        /// <param name="useAmbiguous">Bool to say if ambigous character are required</param>
        /// <param name="addSpaces">Bool to say if spaces are required</param>
        /// <returns></returns>
        public static string GenerateRandomPasswordVer2(int passwordLength, bool useLowercase, bool useUppercase, bool useNumbers,
            bool useSpecials, bool useAmbiguous, bool addSpaces)
        {
            try
            {
                if (passwordLength <= 0)
                {
                    return null;
                }

                int charGroupsSize = 0;
                if (useLowercase) charGroupsSize++;

                if (useUppercase) charGroupsSize++;

                if (useNumbers) charGroupsSize++;

                if (useSpecials) charGroupsSize++;

                if (useAmbiguous) charGroupsSize++;

                if (addSpaces) charGroupsSize++;

                if (charGroupsSize == 0)
                {
                    return "";
                }

                // Create a local array containing supported password characters grouped by types. 
                // You can remove character groups from this array, but doing so will weaken the password strength.  
                var charGroups = new char[charGroupsSize][];

                charGroupsSize = 0;
                if (useLowercase)
                {
                    charGroups[charGroupsSize] = LOWER_CASE.ToCharArray();
                    charGroupsSize++;
                }

                if (useUppercase)
                {
                    charGroups[charGroupsSize] = UPPER_CASE.ToCharArray();
                    charGroupsSize++;
                }

                if (useNumbers)
                {
                    charGroups[charGroupsSize] = NUMBERS.ToCharArray();
                    charGroupsSize++;
                }

                if (useSpecials)
                {
                    charGroups[charGroupsSize] = SPECIALS.ToCharArray();
                    charGroupsSize++;
                }

                if (useAmbiguous)
                {
                    charGroups[charGroupsSize] = AMBIGOUS.ToCharArray();
                    charGroupsSize++;
                }

                if (addSpaces)
                {
                    charGroups[charGroupsSize] = SPACES.ToCharArray();
                    charGroupsSize++;
                }

                // Use this array to track the number of unused characters in each character group.
                var charsLeftInGroup = new int[charGroups.Length];

                // Initially, all characters in each group are not used.
                for (var i = 0; i < charsLeftInGroup.Length; i++)
                {
                    charsLeftInGroup[i] = charGroups[i].Length;
                }

                // Use this array to track (iterate through) unused character groups.
                var leftGroupsOrder = new int[charGroups.Length];

                // Initially, all character groups are not used.
                for (int i = 0; i < leftGroupsOrder.Length; i++)
                {
                    leftGroupsOrder[i] = i;
                }

                // Because we cannot use the default randomizer, which is based on the current time 
                // (it will produce the same "random" number within a second), we will use a random number 
                // generator to seed the randomizer. Use a 4-byte array to fill it with random bytes and convert
                // it then to an integer value.
                var randomBytes = new byte[4];

                // Generate 4 random bytes.
                var rng = new RNGCryptoServiceProvider();
                rng.GetBytes(randomBytes);

                // Convert 4 bytes into a 32-bit integer value.
                var seed = (randomBytes[0] & 0x7f) << 24 |
                           randomBytes[1] << 16 |
                           randomBytes[2] << 8 |
                           randomBytes[3];

                // Now, this is real randomization.
                var random = new System.Random(seed);

                // This array will hold password characters.
                // Allocate appropriate memory for the password.
                var password = new char[passwordLength];

                // some indexes
                var lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

                // Generate password characters one at a time.
                for (var i = 0; i < password.Length; i++)
                {
                    // If only one character group remained unprocessed, process it; otherwise, 
                    // pick a random character group from the unprocessed group list. To allow a 
                    // special character to appear in the first position, increment the second 
                    // parameter of the Next function call by one, i.e. lastLeftGroupsOrderIdx + 1.
                    var nextLeftGroupsOrderIdx = lastLeftGroupsOrderIdx == 0 ? 0 : random.Next(0, lastLeftGroupsOrderIdx);

                    // Get the actual index of the character group, from which we will pick the next character.
                    var nextGroupIdx = leftGroupsOrder[nextLeftGroupsOrderIdx];
                    var lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;

                    // If only one unprocessed character is left, pick it; otherwise, get a 
                    // random character from the unused character list.
                    var nextCharIdx = lastCharIdx == 0 ? 0 : random.Next(0, lastCharIdx + 1);

                    // Add this character to the password.
                    password[i] = charGroups[nextGroupIdx][nextCharIdx];

                    // If we processed the last character in this group, start over.
                    if (lastCharIdx == 0)
                    {
                        charsLeftInGroup[nextGroupIdx] = charGroups[nextGroupIdx].Length;
                    }
                    else
                    {
                        if (lastCharIdx != nextCharIdx)
                        {
                            var temp = charGroups[nextGroupIdx][lastCharIdx];
                            charGroups[nextGroupIdx][lastCharIdx] = charGroups[nextGroupIdx][nextCharIdx];
                            charGroups[nextGroupIdx][nextCharIdx] = temp;
                        }
                        charsLeftInGroup[nextGroupIdx]--;
                    }

                    // If we processed the last group, start all over.
                    if (lastLeftGroupsOrderIdx == 0)
                    {
                        lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
                    }
                    else
                    {
                        // Swap processed group with the last unprocessed group so that we don't pick it until we process all groups.
                        if (lastLeftGroupsOrderIdx != nextLeftGroupsOrderIdx)
                        {
                            var temp = leftGroupsOrder[lastLeftGroupsOrderIdx];
                            leftGroupsOrder[lastLeftGroupsOrderIdx] = leftGroupsOrder[nextLeftGroupsOrderIdx];
                            leftGroupsOrder[nextLeftGroupsOrderIdx] = temp;
                        }

                        // Decrement the number of unprocessed groups.
                        lastLeftGroupsOrderIdx--;
                    }
                }
                // Convert password characters into a string and return the result.
                return new string(password);
            }
            catch (System.Exception ex)
            {

                return "";
            }
        }
    }
}
