using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Obonator.Library
{
    public class ObonPassword
    {
        public class Generator
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
        }

        public class Hasher
        {
            #region Variable
            private static byte Version = 0x01;
            private static KeyDerivationPrf Prf = KeyDerivationPrf.HMACSHA256;
            private static int IterCount = 1000;
            private static byte SaltSize = 128 / 8;
            private static byte NumBytesRequested = 256 / 8;

            public class HashSettings
            {
                /// <summary>
                /// Default value: KeyDerivationPrf.HMACSHA256
                /// </summary>
                public KeyDerivationPrf Prf { get; set; } = KeyDerivationPrf.HMACSHA256;
                /// <summary>
                /// Default value: 1000
                /// </summary>
                public int IterCount { get; set; } = 1000;
                /// <summary>
                /// Default value: 128 / 8
                /// </summary>
                public byte SaltSize { get; set; } = 128 / 8;
                /// <summary>
                /// Default value: 256 / 8
                /// </summary>
                public byte NumBytesRequested { get; set; } = 256 / 8;
            }

            /// <summary>
            /// Default Prf: KeyDerivationPrf.HMACSHA256, IterCount: 1000, SaltSize = 128 / 8, NumBytesRequested: 256 / 8
            /// </summary>
            public static void SetHashSettings(HashSettings hashSettings)
            {
                Prf = hashSettings.Prf;
                IterCount = hashSettings.IterCount;
                SaltSize = hashSettings.SaltSize;
                NumBytesRequested = hashSettings.NumBytesRequested;
            }
            #endregion

            #region V1
            /// <summary>
            /// PBKDF2 with HMAC-SHA256
            /// Format: { prf (UInt32), iter count (UInt32), salt length (UInt32), salt, subkey }
            /// (All UInt32s are stored big-endian.)
            /// </summary>
            /// <param name="password">The password to hash.</param>
            /// <param name="saltValue">Salt value to salt the password, leave empty to make it random</param>
            /// <returns>A hashed representation of the supplied <paramref name="password"/></returns>
            public static string HashPasswordV1(string password, string saltValue = null)
            {
                Version = 0x01;
                if (password == null)
                {
                    throw new ArgumentNullException(nameof(password));
                }

                byte[] salt = CreateSalt(SaltSize, saltValue);

                byte[] subkey = KeyDerivation.Pbkdf2(password, salt, Prf, IterCount, NumBytesRequested);

                var outputBytes = new byte[1 + salt.Length + subkey.Length];
                outputBytes[0] = Version; // format marker
                Buffer.BlockCopy(salt, 0, outputBytes, 1, salt.Length);
                Buffer.BlockCopy(subkey, 0, outputBytes, 1 + SaltSize, subkey.Length);
                return Convert.ToBase64String(outputBytes);
            }

            /// <summary>
            /// Make sure the settings when verify is the same when you hash it
            /// </summary>
            /// <param name="hashedPassword">The hash value for a user's stored password.</param>
            /// <param name="providedPassword">The password supplied for comparison.</param>
            /// <returns>Indicating the result of a password hash comparison.</returns>
            /// <remarks>Implementations of this method should be time consistent.</remarks>

            public static bool VerifyHashedPasswordV1(string hashedPassword, string providedPassword)
            {
                if (hashedPassword == null)
                {
                    throw new ArgumentNullException(nameof(hashedPassword));
                }
                if (providedPassword == null)
                {
                    throw new ArgumentNullException(nameof(providedPassword));
                }

                byte[] decodedHashedPassword = Convert.FromBase64String(hashedPassword);

                // read the format marker from the hashed password
                if (decodedHashedPassword.Length == 0)
                {
                    throw new Exception("Hashed password can't be decode");
                }

                try
                {
                    byte version = decodedHashedPassword[0];
                    if (version != Version)
                        return false;

                    byte[] salt = new byte[SaltSize];
                    Buffer.BlockCopy(decodedHashedPassword, 1, salt, 0, salt.Length);

                    int subkeyLength = decodedHashedPassword.Length - 1 - salt.Length;

                    byte[] expectedSubkey = new byte[subkeyLength];
                    Buffer.BlockCopy(decodedHashedPassword, 1 + salt.Length, expectedSubkey, 0, expectedSubkey.Length);

                    // Hash the incoming password and verify it
                    byte[] actualSubkey = KeyDerivation.Pbkdf2(providedPassword, salt, Prf, IterCount, subkeyLength);

                    return FixedTimeEquals(actualSubkey, expectedSubkey);
                }
                catch
                {
                    throw new Exception(@"This should never occur except in the case of a malformed payload, 
                    where we might go off the end of the array. Regardless, a malformed payload
                    implies verification failed");
                }
            }

            #endregion

            #region V2
            /// <summary>
            /// PBKDF2 with HMAC-SHA256 and Remembered Size and Iteration
            /// Format: { prf (UInt32), iter count (UInt32), salt length (UInt32), salt, subkey }
            /// (All UInt32s are stored big-endian.)
            /// </summary>
            /// <param name="password">The password to hash.</param>
            /// <param name="saltValue">Salt value to salt the password, leave empty to make it random</param>
            /// <returns>A hashed representation of the supplied <paramref name="password"/></returns>
            public static string HashPasswordV2(string password, string saltValue = null)
            { 
                Version = 0x02;
                if (password == null)
                {
                    throw new ArgumentNullException(nameof(password));
                }

                byte[] salt = CreateSalt(SaltSize, saltValue);

                byte[] subkey = KeyDerivation.Pbkdf2(password, salt, Prf, IterCount, NumBytesRequested);

                var outputBytes = new byte[13 + salt.Length + subkey.Length];
                outputBytes[0] = Version; // format marker
                WriteNetworkByteOrder(outputBytes, 1, (uint)Prf);
                WriteNetworkByteOrder(outputBytes, 5, (uint)IterCount);
                WriteNetworkByteOrder(outputBytes, 9, SaltSize);
                Buffer.BlockCopy(salt, 0, outputBytes, 13, salt.Length);
                Buffer.BlockCopy(subkey, 0, outputBytes, 13 + SaltSize, subkey.Length);
                return Convert.ToBase64String(outputBytes);
            }

            private static void WriteNetworkByteOrder(byte[] buffer, int offset, uint value)
            {
                buffer[offset + 0] = (byte)(value >> 24);
                buffer[offset + 1] = (byte)(value >> 16);
                buffer[offset + 2] = (byte)(value >> 8);
                buffer[offset + 3] = (byte)(value >> 0);
            }

            /// <summary>
            /// V2 ignore setting when verify because the hashed value had all the settings in it except iterCount
            /// </summary>
            /// <param name="hashedPassword">The hash value for a user's stored password.</param>
            /// <param name="providedPassword">The password supplied for comparison.</param>
            /// <returns>Indicating the result of a password hash comparison.</returns>
            /// <remarks>Implementations of this method should be time consistent.</remarks>
            public static bool VerifyHashedPasswordV2(string hashedPassword, string providedPassword)
            {
                if (hashedPassword == null)
                {
                    throw new ArgumentNullException(nameof(hashedPassword));
                }
                if (providedPassword == null)
                {
                    throw new ArgumentNullException(nameof(providedPassword));
                }

                byte[] decodedHashedPassword = Convert.FromBase64String(hashedPassword);

                // read the format marker from the hashed password
                if (decodedHashedPassword.Length == 0)
                {
                    throw new Exception("Hashed password can't be decode");
                }

                try
                {
                    // Read header information
                    KeyDerivationPrf prf = (KeyDerivationPrf)ReadNetworkByteOrder(decodedHashedPassword, 1);
                    int iterCount = (int)ReadNetworkByteOrder(decodedHashedPassword, 5);
                    int saltLength = (int)ReadNetworkByteOrder(decodedHashedPassword, 9);

                    byte version = decodedHashedPassword[0];
                    if (version != Version)
                        return false;

                    // Read the salt: must be >= 64 bits
                    if (saltLength < 64 / 8)
                    {
                        return false;
                    }
                    byte[] salt = new byte[saltLength];
                    Buffer.BlockCopy(decodedHashedPassword, 13, salt, 0, salt.Length);

                    // Read the subkey (the rest of the payload): must be >= 128 bits
                    int subkeyLength = decodedHashedPassword.Length - 13 - salt.Length;
                    if (subkeyLength < 64 / 8)
                    {
                        return false;
                    }
                    byte[] expectedSubkey = new byte[subkeyLength];
                    Buffer.BlockCopy(decodedHashedPassword, 13 + salt.Length, expectedSubkey, 0, expectedSubkey.Length);

                    // Hash the incoming password and verify it
                    byte[] actualSubkey = KeyDerivation.Pbkdf2(providedPassword, salt, prf, iterCount, subkeyLength);

                    return FixedTimeEquals(actualSubkey, expectedSubkey);
                }
                catch
                {
                    throw new Exception(@"This should never occur except in the case of a malformed payload, 
                    where we might go off the end of the array. Regardless, a malformed payload
                    implies verification failed");
                }
            }

            private static uint ReadNetworkByteOrder(byte[] buffer, int offset)
            {
                return ((uint)(buffer[offset + 0]) << 24)
                    | ((uint)(buffer[offset + 1]) << 16)
                    | ((uint)(buffer[offset + 2]) << 8)
                    | ((uint)(buffer[offset + 3]));
            }
            #endregion

            [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
            private static bool FixedTimeEquals(byte[] left, byte[] right)
            {
                // NoOptimization because we want this method to be exactly as non-short-circuiting as written.
                // NoInlining because the NoOptimization would get lost if the method got inlined.

                if (left.Length != right.Length)
                    return false;

                int length = left.Length;
                int accum = 0;

                for (int i = 0; i < length; i++)
                {
                    accum |= left[i] - right[i];
                }

                return accum == 0;
            }

            private static byte[] CreateSalt(byte saltSize, string saltValue = null)
            {
                byte[] salt = new byte[saltSize];
                if (saltValue == null)
                {
                    using (var generator = RandomNumberGenerator.Create())
                    {
                        generator.GetBytes(salt);
                    }
                }
                else
                {
                    byte[] saltValueBytes = System.Text.Encoding.ASCII.GetBytes(saltValue);
                    if (saltValueBytes.Length > salt.Length)
                    {
                        throw new Exception("SaltValue is bigger than SaltSize");
                    }
                    Buffer.BlockCopy(saltValueBytes, 0, salt, 0, saltValueBytes.Length);
                }
                return salt;
            }
        }

    }
}
