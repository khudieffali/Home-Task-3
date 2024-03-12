#region Task1

//Task - 1 Verilmiş array-də tək ədədlərin sayını tapmaq və çap etmək. Məsələn: [1, 2, 3, 4, 5, 6, 7] => Tək ədədlərin sayı: 4

//using System.Diagnostics.Metrics;

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12, 14 };
//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine("tek ededlerin sayi: " + count);
#endregion

#region Task 2,3,4
/*----------------------------------------------------------------------------------------------------------------------*/
//eyni alqoritm
//Task - 2 Verilmiş array-də ən kiçik və ən böyük ədədlərin cəmini tapmaq. Məsələn: [3, 8, 2, 10, 5] => Cəm: 12
//Task - 3 Verilmiş array-dəki ədədlərin ən böyük və ən kiçik fərqlərini tapmaq. Məsələn: [5, 8, 15, 3, 7] => Fərq: 12
//Task - 4 Verilmiş array-dəki ədədlərin sırasını artan sıraya salmaq. Məsələn: [3, 1, 5, 4, 2] => [1, 2, 3, 4, 5]
//int[] arr = { 1,9,3,8,5,4 };
//int num;
//int count=0;

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = i + 1; j < arr.Length; j++)
//    {
//        if (arr[i] > arr[j])
//        {
//            num = arr[i];
//            arr[i] = arr[j];
//            arr[j] = num;
//        }
//    }

//}
//Task-2
//Console.WriteLine(arr[0] + arr[arr.Length - 1]);

//Task-3 
//Console.WriteLine(arr[arr.Length - 1]-arr[0]);

//Task-4
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}
/*-----------------------------------------------------------------------------------------------------------------------*/
#endregion

#region Task 5

//Task - 5 Verilmiş array-dəki tək və cüt ədədlərin cəmini ayrı-ayrı tapmaq. Məsələn: [1, 2, 3, 4, 5] => Tək ədədlərin cəmi: 9, Cüt ədədlərin

//int[] arr = { 1, 2, 3, 4, 5, 10, 13 };
//int singleNum = 0;
//int evenNum = 0;


//foreach (var item in arr)
//{
//    if (item % 2 == 0) evenNum += item;
//    else singleNum += item;
//}
//Console.WriteLine("Tek ededlerin: " + singleNum);
//Console.WriteLine("Cüt ededlerin cemi: " + evenNum);

#endregion



#region Task Lab1

//int[] arr = { 5, 8, 3, 12, 11, 10 };
//int count=0;
//int sum=0;
//int avarage;
//foreach (var item in arr)
//{
//    sum+= item;
//    count++;
//}
//avarage= sum/count;
//Console.WriteLine("Ededlerin cemi: "+sum);
//Console.WriteLine("Ededlerin ededi ortasi: "+avarage);
#endregion

#region Task Lab2

//int k=0;
//int k1=0;

//Console.WriteLine("1 ci noqtenin x ve y deyerlerini daxil edin:");
//int x= Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("2 ci noqtenin x ve y deyerlerini daxil edin:");
//int x1 = Convert.ToInt32(Console.ReadLine());
//int y1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("3 ci noqtenin x ve y deyerlerini daxil edin:");
//int x2 = Convert.ToInt32(Console.ReadLine());
//int y2 = Convert.ToInt32(Console.ReadLine());

//k =( y1 - y) / (x1 - x);
//k1 = (y2 - y1) / (x2 - x1);

//if (k == k1 )
//{
//    Console.WriteLine("Hamisi bir xettin uzerine dusur");
//}
#endregion








