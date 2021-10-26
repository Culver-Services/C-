DateTime.Now Property
Definition
Namespace:
System
Assembly:
System.Runtime.dll
Gets a DateTime object that is set to the current date and time on this computer, expressed as the local time.

C#


public static DateTime Now { get; }
Property Value
DateTime
An object whose value is the current local date and time.

Examples
The following example uses the Now and UtcNow properties to retrieve the current local date and time and the current universal coordinated (UTC) date and time. It then uses the formatting conventions of a number of cultures to display the strings, along with the values of the their Kind properties.

C#


using System;
using System.Globalization;

public class Example
{
   public static void Main()
   {
      DateTime localDate = DateTime.Now;
      DateTime utcDate = DateTime.UtcNow;
      String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" } ;

      foreach (var cultureName in cultureNames) {
         var culture = new CultureInfo(cultureName);
         Console.WriteLine("{0}:", culture.NativeName);
         Console.WriteLine("   Local date and time: {0}, {1:G}",
                           localDate.ToString(culture), localDate.Kind);
         Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                           utcDate.ToString(culture), utcDate.Kind);
      }
   }
}
// The example displays the following output:
//       English (United States):
//          Local date and time: 6/19/2015 10:35:50 AM, Local
//          UTC date and time: 6/19/2015 5:35:50 PM, Utc
//
//       English (United Kingdom):
//          Local date and time: 19/06/2015 10:35:50, Local
//          UTC date and time: 19/06/2015 17:35:50, Utc
//
//       français (France):
//          Local date and time: 19/06/2015 10:35:50, Local
//          UTC date and time: 19/06/2015 17:35:50, Utc
//
//       Deutsch (Deutschland):
//          Local date and time: 19.06.2015 10:35:50, Local
//          UTC date and time: 19.06.2015 17:35:50, Utc
//
//       русский (Россия):
//          Local date and time: 19.06.2015 10:35:50, Local
//          UTC date and time: 19.06.2015 17:35:50, Utc
Remarks
The Now property returns a DateTime value that represents the current date and time on the local computer. Note that there is a difference between a DateTime value, which represents the number of ticks that have elapsed since midnight of January 1, 0001, and the string representation of that DateTime value, which expresses a date and time value in a culture-specific-specific format. For information on formatting date and time values, see the ToString method. The following example displays the short date and time string in a number of culture-specific formats.

C#


using System;
using System.Globalization;

public class Example
{
   public static void Main()
   {
      DateTime localDate = DateTime.Now;
      String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };

      foreach (var cultureName in cultureNames) {
         var culture = new CultureInfo(cultureName);
         Console.WriteLine("{0}: {1}", cultureName,
                           localDate.ToString(culture));
      }
   }
}
// The example displays the following output:
//       en-US: 6/19/2015 10:03:06 AM
//       en-GB: 19/06/2015 10:03:06
//       fr-FR: 19/06/2015 10:03:06
//       de-DE: 19.06.2015 10:03:06
//       ru-RU: 19.06.2015 10:03:06
The resolution of this property depends on the system timer, which depends on the underlying operating system. It tends to be between 0.5 and 15 milliseconds. As a result, repeated calls to the Now property in a short time interval, such as in a loop, may return the same value.

The Now property is frequently used to measure performance. However, because of its low resolution, it is not suitable for use as a benchmarking tool. A better alternative is to use the Stopwatch class.

Starting with the .NET Framework version 2.0, the return value is a DateTime whose Kind property returns DateTimeKind.Local.

 Note

You can also use the DateTimeOffset.Now property to retrieve the current local date and time. It allows a local time to be expressed unambiguously as a single point in time, which in turn makes that time value portable across computers.