﻿using POOConcepts;
try {
    var date1 = new Date();
    var date2 = new Date(1900, 12, 5);
    var date3 = new Date(2020, 2, 28);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}


