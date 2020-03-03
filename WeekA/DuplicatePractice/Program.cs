// int firstDuplicate(int[] a)
// {
//     int[] b = new int[a.Length+5];
//     int smallestIndex=0;
//     bool fail = true;
//     int temp = 0;
//     string tester = "";
//     smallestIndex=a.Length+1;
//     for(int i = 0; i<a.Length; i++)
//     {
//         for(int y = 0; y<a.Length; y++)
//         {
//             if(i!=y&&y>i&&a[i]==a[y]&&!tester.Contains((char)a[y]))
//             {
//                 b[temp]=y;
//                 temp++;
//                 fail = false;
//                 tester += a[y];
//             }
//         }
//     }
//     for(int i = 0; i<temp; i++)
//     {
//         if(b[i]!=0&&smallestIndex>b[i])
//         {
//             smallestIndex=b[i];
//         }
//     }
//     if(fail)
//     {
//         return -1;
//     }
//     else
//     {
//         return a[smallestIndex];
//     }
// }
