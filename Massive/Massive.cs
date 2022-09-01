int Max(int arg1, int arg2, int arg3) {
    int result_max = arg1;
    if(arg2 > result_max) result_max = arg2;
    if(arg3 > result_max) result_max = arg3;
    return result_max;
}

int [] array = {0,21,13,41,15,61,17,81,19};
/*
int a1 = 15;
int b1 = 21;
int c1 = 39;

int a2 = 12;
int b2 = 23;
int c2 = 33;

int a3 = 13;
int b3 = 10000;
int c3 = 33;
*/
int max1 = Max(array[0], array[1], array[2]);
int max2 = Max(array[3], array[4], array[5]);
int max3 = Max(array[6], array[7], array[8]);
int Abs_Max =Max(max1, max2, max3);
/*int Abs_Max =Max(Max(array[0], array[1], array[2]), 
                   Max(array[3], array[4], array[5]), 
                   Max(array[6], array[7], array[8]));*/

Console.WriteLine(Abs_Max);
