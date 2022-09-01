
int [] array = {0,1,2,3,4,5,5,5,5,6,7,8};

int find = int.Parse(Console.ReadLine());

int i = 0;

while(i < array.Length){
    if(array[i]==find){
        Console.WriteLine(i);
        break;
    }
   
    
    i++;
}