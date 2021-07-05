using System;
using System.Collections.Generic;

namespace ConvertCase
    {
    public static class QuoteGenerator
        {

        private static List<string> jokes = new()
            {


            @"“The purpose of our lives is to be happy.” — Dalai Lama" ,

            @"“The whole secret of a successful life is to find out what is one’s destiny to do, and then do it.”– Henry Ford",
            @"“The unexamined life is not worth living.” — Socrates",
            @"“If you want to live a happy life, tie it to a goal, not to people or things.”– Albert Einstein",

@"“Many of life’s failures are people who did not realize how close they were to success when they gave up.”– Thomas A. Edison"

            };
       
     
        /// <summary>
        /// Generates a Joke
        /// </summary>
        /// <returns><seealso cref="String"/></returns>
       public static string GetJoke()
            {

            var random = new Random(0);
            return jokes[random.Next(0, 4)];
                                
            }
        }
    }
